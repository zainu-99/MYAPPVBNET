<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxProfile = New System.Windows.Forms.GroupBox()
        Me.PanelGender = New System.Windows.Forms.Panel()
        Me.RadioButtonPemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.RadioButtonNonActive = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActive = New System.Windows.Forms.RadioButton()
        Me.ButtonOpenGaleri = New System.Windows.Forms.Button()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.TextBoxNohp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxUserId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxChangePassword = New System.Windows.Forms.GroupBox()
        Me.TextBoxConfirmPasssword = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxOldPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonUpdateBio = New System.Windows.Forms.Button()
        Me.ButtonUpdatePassword = New System.Windows.Forms.Button()
        Me.GroupBoxProfile.SuspendLayout()
        Me.PanelGender.SuspendLayout()
        Me.PanelStatus.SuspendLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxChangePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxProfile
        '
        Me.GroupBoxProfile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxProfile.Controls.Add(Me.PanelGender)
        Me.GroupBoxProfile.Controls.Add(Me.PanelStatus)
        Me.GroupBoxProfile.Controls.Add(Me.ButtonOpenGaleri)
        Me.GroupBoxProfile.Controls.Add(Me.PictureBoxProfile)
        Me.GroupBoxProfile.Controls.Add(Me.TextBoxNohp)
        Me.GroupBoxProfile.Controls.Add(Me.Label9)
        Me.GroupBoxProfile.Controls.Add(Me.Label8)
        Me.GroupBoxProfile.Controls.Add(Me.TextBoxAddress)
        Me.GroupBoxProfile.Controls.Add(Me.Label7)
        Me.GroupBoxProfile.Controls.Add(Me.Label6)
        Me.GroupBoxProfile.Controls.Add(Me.TextBoxName)
        Me.GroupBoxProfile.Controls.Add(Me.Label5)
        Me.GroupBoxProfile.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxProfile.Controls.Add(Me.Label4)
        Me.GroupBoxProfile.Controls.Add(Me.TextBoxUserId)
        Me.GroupBoxProfile.Controls.Add(Me.Label3)
        Me.GroupBoxProfile.Enabled = False
        Me.GroupBoxProfile.Location = New System.Drawing.Point(56, 115)
        Me.GroupBoxProfile.Name = "GroupBoxProfile"
        Me.GroupBoxProfile.Size = New System.Drawing.Size(783, 162)
        Me.GroupBoxProfile.TabIndex = 7
        Me.GroupBoxProfile.TabStop = False
        Me.GroupBoxProfile.Text = "Profile"
        '
        'PanelGender
        '
        Me.PanelGender.Controls.Add(Me.RadioButtonPemale)
        Me.PanelGender.Controls.Add(Me.RadioButtonMale)
        Me.PanelGender.Location = New System.Drawing.Point(403, 50)
        Me.PanelGender.Name = "PanelGender"
        Me.PanelGender.Size = New System.Drawing.Size(197, 23)
        Me.PanelGender.TabIndex = 22
        '
        'RadioButtonPemale
        '
        Me.RadioButtonPemale.AutoSize = True
        Me.RadioButtonPemale.Location = New System.Drawing.Point(78, 3)
        Me.RadioButtonPemale.Name = "RadioButtonPemale"
        Me.RadioButtonPemale.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonPemale.TabIndex = 8
        Me.RadioButtonPemale.TabStop = True
        Me.RadioButtonPemale.Text = "Female"
        Me.RadioButtonPemale.UseVisualStyleBackColor = True
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(8, 3)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonMale.TabIndex = 7
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'PanelStatus
        '
        Me.PanelStatus.Controls.Add(Me.RadioButtonNonActive)
        Me.PanelStatus.Controls.Add(Me.RadioButtonActive)
        Me.PanelStatus.Location = New System.Drawing.Point(87, 83)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(197, 23)
        Me.PanelStatus.TabIndex = 19
        '
        'RadioButtonNonActive
        '
        Me.RadioButtonNonActive.AutoSize = True
        Me.RadioButtonNonActive.Location = New System.Drawing.Point(78, 3)
        Me.RadioButtonNonActive.Name = "RadioButtonNonActive"
        Me.RadioButtonNonActive.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonNonActive.TabIndex = 4
        Me.RadioButtonNonActive.TabStop = True
        Me.RadioButtonNonActive.Text = "Disable"
        Me.RadioButtonNonActive.UseVisualStyleBackColor = True
        '
        'RadioButtonActive
        '
        Me.RadioButtonActive.AutoSize = True
        Me.RadioButtonActive.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonActive.Name = "RadioButtonActive"
        Me.RadioButtonActive.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonActive.TabIndex = 3
        Me.RadioButtonActive.TabStop = True
        Me.RadioButtonActive.Text = "Active"
        Me.RadioButtonActive.UseVisualStyleBackColor = True
        '
        'ButtonOpenGaleri
        '
        Me.ButtonOpenGaleri.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonOpenGaleri.FlatAppearance.BorderSize = 0
        Me.ButtonOpenGaleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenGaleri.ForeColor = System.Drawing.Color.White
        Me.ButtonOpenGaleri.Location = New System.Drawing.Point(620, 115)
        Me.ButtonOpenGaleri.Name = "ButtonOpenGaleri"
        Me.ButtonOpenGaleri.Size = New System.Drawing.Size(98, 29)
        Me.ButtonOpenGaleri.TabIndex = 18
        Me.ButtonOpenGaleri.Text = "Open Galeri"
        Me.ButtonOpenGaleri.UseVisualStyleBackColor = False
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.Image = Global.MYAPPVB.My.Resources.Resources.user
        Me.PictureBoxProfile.Location = New System.Drawing.Point(620, 20)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(98, 92)
        Me.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProfile.TabIndex = 17
        Me.PictureBoxProfile.TabStop = False
        '
        'TextBoxNohp
        '
        Me.TextBoxNohp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNohp.Location = New System.Drawing.Point(403, 83)
        Me.TextBoxNohp.Name = "TextBoxNohp"
        Me.TextBoxNohp.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxNohp.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Gender"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(87, 116)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxAddress.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Status"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(87, 52)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxName.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(403, 19)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxEmail.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(325, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email"
        '
        'TextBoxUserId
        '
        Me.TextBoxUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserId.Location = New System.Drawing.Point(87, 21)
        Me.TextBoxUserId.Name = "TextBoxUserId"
        Me.TextBoxUserId.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxUserId.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "User Id"
        '
        'GroupBoxChangePassword
        '
        Me.GroupBoxChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxChangePassword.Controls.Add(Me.TextBoxConfirmPasssword)
        Me.GroupBoxChangePassword.Controls.Add(Me.TextBoxNewPassword)
        Me.GroupBoxChangePassword.Controls.Add(Me.TextBoxOldPassword)
        Me.GroupBoxChangePassword.Controls.Add(Me.Label10)
        Me.GroupBoxChangePassword.Controls.Add(Me.Label2)
        Me.GroupBoxChangePassword.Controls.Add(Me.Label1)
        Me.GroupBoxChangePassword.Location = New System.Drawing.Point(56, 332)
        Me.GroupBoxChangePassword.Name = "GroupBoxChangePassword"
        Me.GroupBoxChangePassword.Size = New System.Drawing.Size(783, 156)
        Me.GroupBoxChangePassword.TabIndex = 8
        Me.GroupBoxChangePassword.TabStop = False
        Me.GroupBoxChangePassword.Text = "Change Password"
        '
        'TextBoxConfirmPasssword
        '
        Me.TextBoxConfirmPasssword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConfirmPasssword.Location = New System.Drawing.Point(230, 85)
        Me.TextBoxConfirmPasssword.Name = "TextBoxConfirmPasssword"
        Me.TextBoxConfirmPasssword.Size = New System.Drawing.Size(330, 27)
        Me.TextBoxConfirmPasssword.TabIndex = 5
        Me.TextBoxConfirmPasssword.UseSystemPasswordChar = True
        '
        'TextBoxNewPassword
        '
        Me.TextBoxNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNewPassword.Location = New System.Drawing.Point(230, 52)
        Me.TextBoxNewPassword.Name = "TextBoxNewPassword"
        Me.TextBoxNewPassword.Size = New System.Drawing.Size(330, 27)
        Me.TextBoxNewPassword.TabIndex = 4
        Me.TextBoxNewPassword.Tag = "Akun"
        Me.TextBoxNewPassword.UseSystemPasswordChar = True
        '
        'TextBoxOldPassword
        '
        Me.TextBoxOldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOldPassword.Location = New System.Drawing.Point(230, 19)
        Me.TextBoxOldPassword.Name = "TextBoxOldPassword"
        Me.TextBoxOldPassword.Size = New System.Drawing.Size(330, 27)
        Me.TextBoxOldPassword.TabIndex = 3
        Me.TextBoxOldPassword.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(99, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password"
        '
        'ButtonUpdateBio
        '
        Me.ButtonUpdateBio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonUpdateBio.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonUpdateBio.FlatAppearance.BorderSize = 0
        Me.ButtonUpdateBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdateBio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateBio.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdateBio.Location = New System.Drawing.Point(764, 283)
        Me.ButtonUpdateBio.Name = "ButtonUpdateBio"
        Me.ButtonUpdateBio.Size = New System.Drawing.Size(75, 32)
        Me.ButtonUpdateBio.TabIndex = 9
        Me.ButtonUpdateBio.Text = "Edit"
        Me.ButtonUpdateBio.UseVisualStyleBackColor = False
        '
        'ButtonUpdatePassword
        '
        Me.ButtonUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonUpdatePassword.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonUpdatePassword.FlatAppearance.BorderSize = 0
        Me.ButtonUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdatePassword.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdatePassword.Location = New System.Drawing.Point(764, 494)
        Me.ButtonUpdatePassword.Name = "ButtonUpdatePassword"
        Me.ButtonUpdatePassword.Size = New System.Drawing.Size(75, 32)
        Me.ButtonUpdatePassword.TabIndex = 10
        Me.ButtonUpdatePassword.Text = "Update"
        Me.ButtonUpdatePassword.UseVisualStyleBackColor = False
        '
        'FormAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(953, 591)
        Me.Controls.Add(Me.ButtonUpdatePassword)
        Me.Controls.Add(Me.ButtonUpdateBio)
        Me.Controls.Add(Me.GroupBoxChangePassword)
        Me.Controls.Add(Me.GroupBoxProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAccount"
        Me.Tag = "Akun"
        Me.Text = "FormAccount"
        Me.GroupBoxProfile.ResumeLayout(False)
        Me.GroupBoxProfile.PerformLayout()
        Me.PanelGender.ResumeLayout(False)
        Me.PanelGender.PerformLayout()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxChangePassword.ResumeLayout(False)
        Me.GroupBoxChangePassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxProfile As GroupBox
    Friend WithEvents PanelGender As Panel
    Friend WithEvents RadioButtonPemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents RadioButtonNonActive As RadioButton
    Friend WithEvents RadioButtonActive As RadioButton
    Friend WithEvents ButtonOpenGaleri As Button
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents TextBoxNohp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxChangePassword As GroupBox
    Friend WithEvents ButtonUpdateBio As Button
    Friend WithEvents ButtonUpdatePassword As Button
    Friend WithEvents TextBoxConfirmPasssword As TextBox
    Friend WithEvents TextBoxNewPassword As TextBox
    Friend WithEvents TextBoxOldPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
