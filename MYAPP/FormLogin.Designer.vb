<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelUserId = New System.Windows.Forms.Label()
        Me.TextBoxUserId = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelUserId = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelPassword = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxRemember = New System.Windows.Forms.CheckBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUserId.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPassword.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.TextBoxPassword.Location = New System.Drawing.Point(37, 7)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxPassword.TabIndex = 10
        Me.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'LabelUserId
        '
        Me.LabelUserId.AutoSize = True
        Me.LabelUserId.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserId.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserId.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LabelUserId.Location = New System.Drawing.Point(27, 78)
        Me.LabelUserId.Name = "LabelUserId"
        Me.LabelUserId.Size = New System.Drawing.Size(40, 16)
        Me.LabelUserId.TabIndex = 9
        Me.LabelUserId.Text = "User Id"
        '
        'TextBoxUserId
        '
        Me.TextBoxUserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxUserId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUserId.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserId.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.TextBoxUserId.Location = New System.Drawing.Point(37, 8)
        Me.TextBoxUserId.Name = "TextBoxUserId"
        Me.TextBoxUserId.Size = New System.Drawing.Size(250, 25)
        Me.TextBoxUserId.TabIndex = 9
        Me.TextBoxUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LabelPassword.Location = New System.Drawing.Point(28, 138)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(51, 16)
        Me.LabelPassword.TabIndex = 8
        Me.LabelPassword.Text = "Password"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonLogin.BackColor = System.Drawing.Color.DarkCyan
        Me.ButtonLogin.FlatAppearance.BorderSize = 0
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonLogin.Location = New System.Drawing.Point(202, 227)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(161, 35)
        Me.ButtonLogin.TabIndex = 11
        Me.ButtonLogin.Text = "Sign In"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(36, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "User Login"
        '
        'PanelUserId
        '
        Me.PanelUserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelUserId.Controls.Add(Me.PictureBox1)
        Me.PanelUserId.Controls.Add(Me.TextBoxUserId)
        Me.PanelUserId.Location = New System.Drawing.Point(31, 96)
        Me.PanelUserId.Name = "PanelUserId"
        Me.PanelUserId.Size = New System.Drawing.Size(332, 39)
        Me.PanelUserId.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.MYAPPVB.My.Resources.Resources.username
        Me.PictureBox1.Location = New System.Drawing.Point(294, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(7)
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PanelPassword
        '
        Me.PanelPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelPassword.Controls.Add(Me.PictureBox2)
        Me.PanelPassword.Controls.Add(Me.TextBoxPassword)
        Me.PanelPassword.Location = New System.Drawing.Point(30, 156)
        Me.PanelPassword.Name = "PanelPassword"
        Me.PanelPassword.Size = New System.Drawing.Size(332, 39)
        Me.PanelPassword.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.MYAPPVB.My.Resources.Resources.key
        Me.PictureBox2.Location = New System.Drawing.Point(294, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(7)
        Me.PictureBox2.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'CheckBoxRemember
        '
        Me.CheckBoxRemember.AutoSize = True
        Me.CheckBoxRemember.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRemember.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBoxRemember.Location = New System.Drawing.Point(31, 237)
        Me.CheckBoxRemember.Name = "CheckBoxRemember"
        Me.CheckBoxRemember.Size = New System.Drawing.Size(119, 20)
        Me.CheckBoxRemember.TabIndex = 16
        Me.CheckBoxRemember.Text = "Remember Password"
        Me.CheckBoxRemember.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Image = Global.MYAPPVB.My.Resources.Resources.close
        Me.ButtonClose.Location = New System.Drawing.Point(0, -1)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(36, 36)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(82, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Created By zainu.developer@gmail.com"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.CheckBoxRemember)
        Me.Controls.Add(Me.PanelPassword)
        Me.Controls.Add(Me.PanelUserId)
        Me.Controls.Add(Me.LabelUserId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Login"
        Me.Text = "FormLogin"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.ControlLight
        Me.PanelUserId.ResumeLayout(False)
        Me.PanelUserId.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPassword.ResumeLayout(False)
        Me.PanelPassword.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelUserId As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelUserId As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelPassword As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CheckBoxRemember As CheckBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Label1 As Label
End Class
