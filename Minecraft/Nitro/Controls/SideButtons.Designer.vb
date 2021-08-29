<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideButtons
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Highlight = New System.Windows.Forms.Panel()
        Me.Image = New System.Windows.Forms.PictureBox()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlight
        '
        Me.Highlight.Location = New System.Drawing.Point(0, 2)
        Me.Highlight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Highlight.Name = "Highlight"
        Me.Highlight.Size = New System.Drawing.Size(8, 60)
        Me.Highlight.TabIndex = 3
        '
        'Image
        '
        Me.Image.Location = New System.Drawing.Point(19, 7)
        Me.Image.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(50, 50)
        Me.Image.TabIndex = 2
        Me.Image.TabStop = False
        '
        'SideButtons
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Highlight)
        Me.Controls.Add(Me.Image)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Name = "SideButtons"
        Me.Size = New System.Drawing.Size(80, 64)
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Highlight As Panel
    Friend WithEvents Image As PictureBox
End Class
