Public Class Toggle
    Public Value As Boolean = False
    Private Sub Toggle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tool.SmoothBorder(Panel1, 18)
        Tool.SmoothBorder(Panel2, 18)
        Tool.SmoothBorder(Panel3, 28)

        Panel3.Left = 0
        Panel2.Width = Panel3.Left + Panel3.Width / 2
    End Sub

    Private Sub Toggle_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick, Panel2.MouseClick, Panel3.MouseClick
        If Value = False Then
            Value = True
            While Panel3.Left < Width - Panel3.Width
                Panel3.Left += 1
                Panel2.Width = Panel3.Left + Panel3.Width / 2
                Threading.Thread.Sleep(3)
            End While
        Else
            Value = False
            While Panel3.Left > 0
                Panel3.Left -= 1
                Panel2.Width = Panel3.Left + Panel3.Width / 2
                Threading.Thread.Sleep(3)
            End While
        End If
    End Sub
End Class