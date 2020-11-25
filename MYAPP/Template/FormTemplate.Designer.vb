<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTemplate
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadioButtonPemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNonAktif = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAktif = New System.Windows.Forms.RadioButton()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.ButtonOpenGaleri = New System.Windows.Forms.Button()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.MenuStripAction = New System.Windows.Forms.MenuStrip()
        Me.ButtonAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxNohp = New System.Windows.Forms.TextBox()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelGender = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxUserId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.PanelStatus.SuspendLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripAction.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGender.SuspendLayout()
        Me.GroupBoxInputData.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButtonPemale
        '
        Me.RadioButtonPemale.AutoSize = True
        Me.RadioButtonPemale.Location = New System.Drawing.Point(78, 3)
        Me.RadioButtonPemale.Name = "RadioButtonPemale"
        Me.RadioButtonPemale.Size = New System.Drawing.Size(79, 17)
        Me.RadioButtonPemale.TabIndex = 8
        Me.RadioButtonPemale.TabStop = True
        Me.RadioButtonPemale.Text = "Perempuan"
        Me.RadioButtonPemale.UseVisualStyleBackColor = True
        '
        'RadioButtonNonAktif
        '
        Me.RadioButtonNonAktif.AutoSize = True
        Me.RadioButtonNonAktif.Location = New System.Drawing.Point(78, 3)
        Me.RadioButtonNonAktif.Name = "RadioButtonNonAktif"
        Me.RadioButtonNonAktif.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonNonAktif.TabIndex = 4
        Me.RadioButtonNonAktif.TabStop = True
        Me.RadioButtonNonAktif.Text = "Non Aktif"
        Me.RadioButtonNonAktif.UseVisualStyleBackColor = True
        '
        'RadioButtonAktif
        '
        Me.RadioButtonAktif.AutoSize = True
        Me.RadioButtonAktif.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonAktif.Name = "RadioButtonAktif"
        Me.RadioButtonAktif.Size = New System.Drawing.Size(46, 17)
        Me.RadioButtonAktif.TabIndex = 3
        Me.RadioButtonAktif.TabStop = True
        Me.RadioButtonAktif.Text = "Aktif"
        Me.RadioButtonAktif.UseVisualStyleBackColor = True
        '
        'PanelStatus
        '
        Me.PanelStatus.Controls.Add(Me.RadioButtonNonAktif)
        Me.PanelStatus.Controls.Add(Me.RadioButtonAktif)
        Me.PanelStatus.Location = New System.Drawing.Point(87, 83)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(197, 23)
        Me.PanelStatus.TabIndex = 19
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
        'MenuStripAction
        '
        Me.MenuStripAction.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonAdd, Me.ButtonEdit, Me.ButtonSave, Me.ButtonDelete, Me.ButtonRefresh})
        Me.MenuStripAction.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripAction.Name = "MenuStripAction"
        Me.MenuStripAction.Size = New System.Drawing.Size(396, 42)
        Me.MenuStripAction.TabIndex = 0
        Me.MenuStripAction.Text = "MenuStrip1"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Teal
        Me.ButtonAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAdd.Image = Global.MYAPPVB.My.Resources.Resources.add
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Padding = New System.Windows.Forms.Padding(7)
        Me.ButtonAdd.Size = New System.Drawing.Size(63, 34)
        Me.ButtonAdd.Text = "Add"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.ButtonEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEdit.Image = Global.MYAPPVB.My.Resources.Resources.edit
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Padding = New System.Windows.Forms.Padding(7)
        Me.ButtonEdit.Size = New System.Drawing.Size(61, 34)
        Me.ButtonEdit.Text = "Edit"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonSave.Image = Global.MYAPPVB.My.Resources.Resources.save
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Padding = New System.Windows.Forms.Padding(7)
        Me.ButtonSave.Size = New System.Drawing.Size(66, 34)
        Me.ButtonSave.Text = "Save"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDelete.Image = Global.MYAPPVB.My.Resources.Resources.delete
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Padding = New System.Windows.Forms.Padding(7)
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 34)
        Me.ButtonDelete.Text = "Delete"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Crimson
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRefresh.Image = Global.MYAPPVB.My.Resources.Resources.refresh
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Padding = New System.Windows.Forms.Padding(7)
        Me.ButtonRefresh.Size = New System.Drawing.Size(80, 34)
        Me.ButtonRefresh.Text = "Refresh"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(403, 116)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(197, 27)
        Me.TextBoxPassword.TabIndex = 10
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(325, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Password"
        '
        'TextBoxNohp
        '
        Me.TextBoxNohp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNohp.Location = New System.Drawing.Point(403, 83)
        Me.TextBoxNohp.Name = "TextBoxNohp"
        Me.TextBoxNohp.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxNohp.TabIndex = 9
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.MenuStripAction)
        Me.PanelButton.Location = New System.Drawing.Point(21, 240)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(396, 38)
        Me.PanelButton.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "No HP"
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(8, 3)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonMale.TabIndex = 7
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Laki-laki"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(620, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(623, 251)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(176, 24)
        Me.TextBoxSearch.TabIndex = 32
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 9, 0, 9)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Location = New System.Drawing.Point(21, 284)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.Height = 35
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(778, 221)
        Me.dgv.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Data User"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Jenis Kelamin"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlamat.Location = New System.Drawing.Point(87, 116)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxAlamat.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Alamat"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNama.Location = New System.Drawing.Point(87, 52)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxNama.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama"
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
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.PanelGender)
        Me.GroupBoxInputData.Controls.Add(Me.PanelStatus)
        Me.GroupBoxInputData.Controls.Add(Me.ButtonOpenGaleri)
        Me.GroupBoxInputData.Controls.Add(Me.PictureBoxProfile)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxInputData.Controls.Add(Me.Label12)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxNohp)
        Me.GroupBoxInputData.Controls.Add(Me.Label9)
        Me.GroupBoxInputData.Controls.Add(Me.Label8)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxAlamat)
        Me.GroupBoxInputData.Controls.Add(Me.Label7)
        Me.GroupBoxInputData.Controls.Add(Me.Label6)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxNama)
        Me.GroupBoxInputData.Controls.Add(Me.Label5)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxInputData.Controls.Add(Me.Label4)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxUserId)
        Me.GroupBoxInputData.Controls.Add(Me.Label3)
        Me.GroupBoxInputData.Enabled = False
        Me.GroupBoxInputData.Location = New System.Drawing.Point(21, 77)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(783, 154)
        Me.GroupBoxInputData.TabIndex = 34
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Form Input Data"
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
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(403, 19)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(197, 24)
        Me.TextBoxEmail.TabIndex = 6
        '
        'FormTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(834, 528)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTemplate"
        Me.Tag = "Barang"
        Me.Text = "FormTemplate"
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripAction.ResumeLayout(False)
        Me.MenuStripAction.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGender.ResumeLayout(False)
        Me.PanelGender.PerformLayout()
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButtonPemale As RadioButton
    Friend WithEvents RadioButtonNonAktif As RadioButton
    Friend WithEvents RadioButtonAktif As RadioButton
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents ButtonOpenGaleri As Button
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents MenuStripAction As MenuStrip
    Friend WithEvents ButtonAdd As ToolStripMenuItem
    Friend WithEvents ButtonEdit As ToolStripMenuItem
    Friend WithEvents ButtonSave As ToolStripMenuItem
    Friend WithEvents ButtonDelete As ToolStripMenuItem
    Friend WithEvents ButtonRefresh As ToolStripMenuItem
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxNohp As TextBox
    Public WithEvents PanelButton As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelGender As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEmail As TextBox
End Class
