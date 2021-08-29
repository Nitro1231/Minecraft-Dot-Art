Public Class Generator
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    Dim ConcreteCode(15, 1) As String
    Dim TerracottaCode(16, 1) As String
    Dim maxX As Integer = 40
    Dim maxY As Integer = 40

    Private Sub Generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConcreteLines() As String = My.Resources.Concrete.Split(vbNewLine)
        Dim TerracottaLines() As String = My.Resources.Terracotta.Split(vbNewLine)
        For i As Integer = 0 To 15
            ConcreteCode(i, 0) = ConcreteLines(i).Split(" ")(0).Trim
            ConcreteCode(i, 1) = ConcreteLines(i).Split(" ")(1)
        Next
        For i As Integer = 0 To 16
            TerracottaCode(i, 0) = TerracottaLines(i).Split(" ")(0).Trim
            TerracottaCode(i, 1) = TerracottaLines(i).Split(" ")(1)
        Next
    End Sub

    Private Sub ImgOpen_Click(sender As Object, e As EventArgs) Handles ImgOpen.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = IO.Path.GetFullPath(open.FileName)
            Dim OIMG = New Bitmap(open.FileName)
            'ImgBox.Image = OIMG
            ImgBox.Image = New Bitmap(OIMG, New Size(maxX, maxY))
            FileTextBox.Text = open.FileName
        End If
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        Dim ImgColor As Color
        Dim ListColor As Color
        Dim ImgBit As New Bitmap(ImgBox.Image)
        Dim MinNum(0, 1)
        Dim NowNum As Integer

        For i As Integer = 0 To maxX - 1
            For l As Integer = 0 To maxY - 1
                MinNum(0, 0) = 1000
                ImgColor = ImgBit.GetPixel(i, l)


                If ImgColor.A = 0 Then
                Else
                    For c As Integer = 0 To 15
                        ListColor = ColorTranslator.FromHtml(ConcreteCode(c, 1))
                        NowNum = Math.Abs(Convert.ToInt32(ImgColor.R) - Convert.ToInt32(ListColor.R)) + Math.Abs(Convert.ToInt32(ImgColor.G) - Convert.ToInt32(ListColor.G)) + Math.Abs(Convert.ToInt32(ImgColor.B) - Convert.ToInt32(ListColor.B))
                        If NowNum < MinNum(0, 0) Then
                            MinNum(0, 0) = NowNum
                            MinNum(0, 1) = ConcreteCode(c, 0)
                        End If
                    Next

                    For t As Integer = 0 To 16
                        ListColor = ColorTranslator.FromHtml(TerracottaCode(t, 1))
                        NowNum = Math.Abs(Convert.ToInt32(ImgColor.R) - Convert.ToInt32(ListColor.R)) + Math.Abs(Convert.ToInt32(ImgColor.G) - Convert.ToInt32(ListColor.G)) + Math.Abs(Convert.ToInt32(ImgColor.B) - Convert.ToInt32(ListColor.B))
                        If NowNum < MinNum(0, 0) Then
                            MinNum(0, 0) = NowNum
                            MinNum(0, 1) = TerracottaCode(t, 0)
                        End If
                    Next

                    OutputBox.Text += $"/setblock {50018 + i - 20} {100 - l} 52 minecraft:{MinNum(0, 1)} replace" & vbNewLine
                End If
            Next
        Next
    End Sub

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Private Declare Function MapVirtualKey Lib "user32" Alias "MapVirtualKeyA" (ByVal wCode As Integer, ByVal wMapType As Integer) As Integer
    Public Const KEYEVENTF_KEYUP As Short = &H2S
    Private Sub PressKey(ByVal VK As Byte, ByVal Scan As Byte)
        keybd_event(VK, Scan, 0, 0)
        keybd_event(VK, Scan, KEYEVENTF_KEYUP, 0)
    End Sub
    Public Sub Key_Press(ByRef Key As Keys)
        Dim ScanKey As Short
        ScanKey = MapVirtualKey(Key, 0)
        PressKey(Key, ScanKey)
    End Sub
    Public Sub Key_Down(ByRef Key As Keys)
        Dim ScanKey As Short
        ScanKey = MapVirtualKey(Key, 0)
        keybd_event(Key, ScanKey, 0, 0)
    End Sub
    Public Sub Key_Up(ByRef Key As Keys)
        Dim ScanKey As Short
        ScanKey = MapVirtualKey(Key, 0)
        keybd_event(Key, ScanKey, KEYEVENTF_KEYUP, 0)
    End Sub

    Public Sub Delay(Optional ByRef dTime As Single = 1)
        Dim sTime As Single
        sTime = Microsoft.VisualBasic.Timer()
        Do
            Application.DoEvents()
            If sTime > Microsoft.VisualBasic.Timer() Then sTime = sTime - 86400
        Loop While dTime + sTime > Microsoft.VisualBasic.Timer()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Threading.Thread.Sleep(5000)
        Breakout = False
        Esc.Enabled = True
        For Each l In OutputBox.Lines
            Key_Press(Keys.T)
            Threading.Thread.Sleep(100)
            SendKeys.SendWait(l)
            Key_Press(Keys.Enter)
            Threading.Thread.Sleep(100)

            If Breakout Then
                Exit For
            End If
        Next
        Esc.Enabled = False
        Breakout = False
    End Sub
    Private Const VK_ESCAPE = &H1B

    Dim Breakout As Boolean = False

    Private Sub Esc_Tick(sender As Object, e As EventArgs) Handles Esc.Tick
        If GetAsyncKeyState(VK_ESCAPE) Then
            Breakout = True
        End If
    End Sub
End Class
