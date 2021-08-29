<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinBox = New System.Windows.Forms.PictureBox()
        Me.CloseBox = New System.Windows.Forms.PictureBox()
        Me.SideLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.SideButtons1 = New Nitro.SideButtons()
        Me.SideButtons2 = New Nitro.SideButtons()
        Me.SideButtons3 = New Nitro.SideButtons()
        Me.Generator1 = New Nitro.Generator()
        Me.MainPanel.SuspendLayout()
        CType(Me.MinBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideLayoutPanel.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.Generator1)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Controls.Add(Me.MinBox)
        Me.MainPanel.Controls.Add(Me.CloseBox)
        Me.MainPanel.Location = New System.Drawing.Point(80, 10)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(810, 530)
        Me.MainPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Minecraft Dot Generator"
        '
        'MinBox
        '
        Me.MinBox.Image = Global.Nitro.My.Resources.Resources.Min
        Me.MinBox.Location = New System.Drawing.Point(765, 3)
        Me.MinBox.Name = "MinBox"
        Me.MinBox.Size = New System.Drawing.Size(18, 18)
        Me.MinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MinBox.TabIndex = 1
        Me.MinBox.TabStop = False
        '
        'CloseBox
        '
        Me.CloseBox.Image = Global.Nitro.My.Resources.Resources.close
        Me.CloseBox.Location = New System.Drawing.Point(789, 3)
        Me.CloseBox.Name = "CloseBox"
        Me.CloseBox.Size = New System.Drawing.Size(18, 18)
        Me.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBox.TabIndex = 0
        Me.CloseBox.TabStop = False
        '
        'SideLayoutPanel
        '
        Me.SideLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.SideLayoutPanel.Controls.Add(Me.SideButtons1)
        Me.SideLayoutPanel.Controls.Add(Me.SideButtons2)
        Me.SideLayoutPanel.Controls.Add(Me.SideButtons3)
        Me.SideLayoutPanel.ForeColor = System.Drawing.Color.White
        Me.SideLayoutPanel.Location = New System.Drawing.Point(0, 60)
        Me.SideLayoutPanel.Name = "SideLayoutPanel"
        Me.SideLayoutPanel.Size = New System.Drawing.Size(80, 490)
        Me.SideLayoutPanel.TabIndex = 1
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BottomPanel.Location = New System.Drawing.Point(0, 546)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(80, 4)
        Me.BottomPanel.TabIndex = 0
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.LOGO.Location = New System.Drawing.Point(0, 0)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(80, 60)
        Me.LOGO.TabIndex = 2
        Me.LOGO.TabStop = False
        '
        'SideButtons1
        '
        Me.SideButtons1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SideButtons1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SideButtons1.Location = New System.Drawing.Point(0, 10)
        Me.SideButtons1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 5)
        Me.SideButtons1.Name = "SideButtons1"
        Me.SideButtons1.SelectControl = False
        Me.SideButtons1.Size = New System.Drawing.Size(80, 64)
        Me.SideButtons1.TabIndex = 0
        '
        'SideButtons2
        '
        Me.SideButtons2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SideButtons2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SideButtons2.Location = New System.Drawing.Point(0, 84)
        Me.SideButtons2.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.SideButtons2.Name = "SideButtons2"
        Me.SideButtons2.SelectControl = False
        Me.SideButtons2.Size = New System.Drawing.Size(80, 64)
        Me.SideButtons2.TabIndex = 1
        '
        'SideButtons3
        '
        Me.SideButtons3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SideButtons3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SideButtons3.Location = New System.Drawing.Point(0, 403)
        Me.SideButtons3.Margin = New System.Windows.Forms.Padding(0, 250, 0, 5)
        Me.SideButtons3.Name = "SideButtons3"
        Me.SideButtons3.SelectControl = False
        Me.SideButtons3.Size = New System.Drawing.Size(80, 64)
        Me.SideButtons3.TabIndex = 2
        '
        'Generator1
        '
        Me.Generator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Generator1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Generator1.ForeColor = System.Drawing.Color.White
        Me.Generator1.Location = New System.Drawing.Point(20, 45)
        Me.Generator1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Generator1.Name = "Generator1"
        Me.Generator1.Size = New System.Drawing.Size(790, 485)
        Me.Generator1.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(890, 550)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.SideLayoutPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Minecraft Dot Generator"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.MinBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideLayoutPanel.ResumeLayout(False)
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents SideLayoutPanel As FlowLayoutPanel
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents MinBox As PictureBox
    Friend WithEvents CloseBox As PictureBox
    Friend WithEvents SideButtons1 As SideButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents SideButtons2 As SideButtons
    Friend WithEvents SideButtons3 As SideButtons
    Friend WithEvents Generator1 As Generator
End Class
