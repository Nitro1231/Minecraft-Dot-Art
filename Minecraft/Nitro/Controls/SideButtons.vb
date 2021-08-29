Public Class SideButtons
    Dim MouseHoverColor As Color = Color.FromArgb(50, 50, 50)
    Dim SelectColor As Color = Color.FromArgb(22, 160, 133)
    Dim DefaultColor As Color = Color.FromArgb(40, 40, 40)

    Dim Selected As Boolean = False

    Public index As Integer = 0

    Public Event ClickEvent(ByVal sender As Object, ByVal e As EventArgs)

    Sub New()
        InitializeComponent()
        BackColor = DefaultColor
        Image.BackColor = DefaultColor
    End Sub

    Public Property SelectControl As Boolean
        Get
            Return Selected
        End Get
        Set(value As Boolean)
            If (value = True) Then
                BackColor = MouseHoverColor
                Image.BackColor = MouseHoverColor
                Highlight.BackColor = SelectColor
            Else
                BackColor = DefaultColor
                Image.BackColor = DefaultColor
                Highlight.BackColor = DefaultColor
            End If
            Selected = value
        End Set
    End Property

    Private Sub _MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Image.MouseMove, Highlight.MouseMove
        If Not SelectControl Then
            BackColor = MouseHoverColor
            Image.BackColor = MouseHoverColor
            Highlight.BackColor = MouseHoverColor
        End If
        Tool.MoveForm(Main.Handle)
    End Sub

    Private Sub _MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, Image.MouseLeave, Highlight.MouseMove
        If Not SelectControl Then
            BackColor = DefaultColor
            Image.BackColor = DefaultColor
            Highlight.BackColor = DefaultColor
        End If
    End Sub

    Private Sub _Click(sender As Object, e As EventArgs) Handles Me.Click, Image.Click
        RaiseEvent ClickEvent(Me, e)
    End Sub
End Class
