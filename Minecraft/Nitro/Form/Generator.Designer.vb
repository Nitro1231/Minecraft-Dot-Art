<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Generator
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ImgOpen = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImgBox = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.OutputBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundToggle = New Nitro.Toggle()
        Me.Esc = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImgOpen
        '
        Me.ImgOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImgOpen.Location = New System.Drawing.Point(7, 359)
        Me.ImgOpen.Name = "ImgOpen"
        Me.ImgOpen.Size = New System.Drawing.Size(210, 35)
        Me.ImgOpen.TabIndex = 20
        Me.ImgOpen.Text = "Open"
        Me.ImgOpen.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel5.Controls.Add(Me.FileTextBox)
        Me.Panel5.Location = New System.Drawing.Point(7, 325)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 28)
        Me.Panel5.TabIndex = 19
        '
        'FileTextBox
        '
        Me.FileTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileTextBox.ForeColor = System.Drawing.Color.White
        Me.FileTextBox.Location = New System.Drawing.Point(5, 6)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(200, 16)
        Me.FileTextBox.TabIndex = 12
        '
        'GenerateButton
        '
        Me.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateButton.Location = New System.Drawing.Point(7, 400)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(210, 45)
        Me.GenerateButton.TabIndex = 17
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(7, 269)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 50)
        Me.Panel3.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BackgroundToggle)
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 40)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Transparent Background "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Image"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ImgBox)
        Me.Panel1.Location = New System.Drawing.Point(7, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 210)
        Me.Panel1.TabIndex = 14
        '
        'ImgBox
        '
        Me.ImgBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ImgBox.Location = New System.Drawing.Point(5, 5)
        Me.ImgBox.Name = "ImgBox"
        Me.ImgBox.Size = New System.Drawing.Size(200, 200)
        Me.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgBox.TabIndex = 3
        Me.ImgBox.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel4.Controls.Add(Me.OutputBox)
        Me.Panel4.Location = New System.Drawing.Point(277, 80)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(500, 327)
        Me.Panel4.TabIndex = 18
        '
        'OutputBox
        '
        Me.OutputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputBox.ForeColor = System.Drawing.Color.White
        Me.OutputBox.Location = New System.Drawing.Point(5, 5)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(490, 317)
        Me.OutputBox.TabIndex = 10
        Me.OutputBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 36)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundToggle
        '
        Me.BackgroundToggle.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundToggle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BackgroundToggle.Location = New System.Drawing.Point(3, 5)
        Me.BackgroundToggle.Name = "BackgroundToggle"
        Me.BackgroundToggle.Size = New System.Drawing.Size(50, 30)
        Me.BackgroundToggle.TabIndex = 2
        '
        'Esc
        '
        '
        'Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ImgOpen)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Generator"
        Me.Size = New System.Drawing.Size(790, 485)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImgOpen As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FileTextBox As TextBox
    Friend WithEvents GenerateButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundToggle As Toggle
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgBox As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OutputBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Esc As Timer
End Class
