Public Class CircleProgressBar
    Public Val As Integer = 0
    Public ThicknessA As Integer = 5
    Public ThicknessB As Integer = 5
    Private Sub DrawProgress(g As Graphics, rect As Rectangle, percentage As Single)
        Dim progressAngle = CSng(360 / 100 * percentage)
        Dim remainderAngle = 360 - progressAngle
        Dim Colors As Color

        If Val <= 50 Then
            Colors = Color.FromArgb(46, 204, 113)
        ElseIf Val <= 85 Then
            Colors = Color.FromArgb(241, 196, 15)
        Else
            Colors = Color.FromArgb(231, 76, 60)
        End If

        Using progressPen As New Pen(Colors, ThicknessA), remainderPen As New Pen(Color.FromArgb(20, 20, 20), ThicknessB)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.DrawArc(progressPen, rect, -90, progressAngle)
            g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle)
        End Using

        Using fnt As New Font(Font.FontFamily, 14)
            Dim text As String = percentage.ToString + "%"
            Dim textSize = g.MeasureString(text, fnt)
            Dim textPoint As New Point(CInt(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), CInt(rect.Top + (rect.Height / 2) - (textSize.Height / 2)))
            g.DrawString(text, fnt, Brushes.White, textPoint)
        End Using
    End Sub
    Private Sub CircleProgressBar_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawProgress(e.Graphics, New Rectangle(5, 5, Width - 10, Height - 10), Val)
    End Sub

    Private Sub CircleProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
    End Sub
End Class