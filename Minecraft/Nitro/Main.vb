Imports System.Drawing.Drawing2D

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw, True)
        SideButtons1.SelectControl = True
        'SideButtons1.Image.Image = My.Resources.
        SideButtons1.index = 1
        'SideButtons2.Image.Image = My.Resources.
        SideButtons2.index = 2
        'SideButtons3.Image.Image = My.Resources.
        SideButtons3.index = 3
    End Sub

    Private Sub SideButtons_ClickEvent(sender As Object, e As EventArgs) Handles SideButtons1.ClickEvent, SideButtons2.ClickEvent, SideButtons3.ClickEvent
        For Each control As SideButtons In SideLayoutPanel.Controls '모든 버튼 원상태로 되돌림
            control.SelectControl = False
        Next

        Dim button As SideButtons = sender '클릭한 버튼만 색을 바꿈
        button.SelectControl = True
        AllPanelHide() '모든 패널 숨기기

        If button.index = 1 Then
            '.Visible = True
        ElseIf button.index = 2 Then
            '.Visible = True
        ElseIf button.index = 3 Then
            '.Visible = True
        End If
    End Sub

    Private Sub AllPanelHide()
        '.Visible = False
        '.Visible = False
        '.Visible = False
        '.Visible = False
    End Sub

    Private Sub CloseBox_Click(sender As Object, e As EventArgs) Handles CloseBox.Click
        End
    End Sub

    Private Sub MinBox_Click(sender As Object, e As EventArgs) Handles MinBox.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mouse_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, SideLayoutPanel.MouseMove, MainPanel.MouseMove, LOGO.MouseMove, BottomPanel.MouseMove, Generator1.MouseMove '+ form controls
        Tool.MoveForm(Handle)
    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint
        Dim rectFToFill As New RectangleF(0, 0, 20, 530)
        Using shadowBrush As LinearGradientBrush = New LinearGradientBrush(rectFToFill, Color.FromArgb(255, Color.FromArgb(15, 15, 15)), Color.FromArgb(1, Color.FromArgb(35, 35, 35)), 360)
            e.Graphics.FillRectangle(shadowBrush, rectFToFill)
        End Using
    End Sub

    Private Sub Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = SmoothingMode.HighSpeed
    End Sub
End Class