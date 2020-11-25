<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.ButtonAccess = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelGender = New System.Windows.Forms.Panel()
        Me.RadioButtonPemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.RadioButtonNonActive = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActive = New System.Windows.Forms.RadioButton()
        Me.TextBoxNohp = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonOpenGaleri = New System.Windows.Forms.Button()
        Me.ButtonUserGroup = New System.Windows.Forms.Button()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.MenuStripAction = New System.Windows.Forms.MenuStrip()
        Me.ButtonAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDgv = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxEntries = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BindingNavigatorPaging = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingSourcePaging = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBoxInputData.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelGender.SuspendLayout()
        Me.PanelStatus.SuspendLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        Me.MenuStripAction.SuspendLayout()
        Me.PanelDgv.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigatorPaging, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorPaging.SuspendLayout()
        CType(Me.BindingSourcePaging, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data User"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(744, 6)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(176, 24)
        Me.TextBoxSearch.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(698, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "User Id"
        '
        'TextBoxUserId
        '
        Me.TextBoxUserId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserId.Location = New System.Drawing.Point(67, 3)
        Me.TextBoxUserId.Name = "TextBoxUserId"
        Me.TextBoxUserId.Size = New System.Drawing.Size(273, 24)
        Me.TextBoxUserId.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(434, 3)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(253, 24)
        Me.TextBoxEmail.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name"
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(67, 34)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(273, 24)
        Me.TextBoxName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Address"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(67, 96)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(273, 24)
        Me.TextBoxAddress.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(346, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Gender"
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.ButtonAccess)
        Me.GroupBoxInputData.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBoxInputData.Controls.Add(Me.ButtonOpenGaleri)
        Me.GroupBoxInputData.Controls.Add(Me.ButtonUserGroup)
        Me.GroupBoxInputData.Controls.Add(Me.PictureBoxProfile)
        Me.GroupBoxInputData.Enabled = False
        Me.GroupBoxInputData.Location = New System.Drawing.Point(16, 29)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(926, 153)
        Me.GroupBoxInputData.TabIndex = 6
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Form Input Data"
        '
        'ButtonAccess
        '
        Me.ButtonAccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAccess.BackColor = System.Drawing.Color.Turquoise
        Me.ButtonAccess.FlatAppearance.BorderSize = 0
        Me.ButtonAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAccess.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAccess.ForeColor = System.Drawing.Color.White
        Me.ButtonAccess.Location = New System.Drawing.Point(830, 98)
        Me.ButtonAccess.Name = "ButtonAccess"
        Me.ButtonAccess.Size = New System.Drawing.Size(83, 27)
        Me.ButtonAccess.TabIndex = 33
        Me.ButtonAccess.Text = "User Access"
        Me.ButtonAccess.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.46053!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82895!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17105!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelGender, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelStatus, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxEmail, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxNohp, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPassword, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxAddress, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxUserId, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(690, 124)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'PanelGender
        '
        Me.PanelGender.Controls.Add(Me.RadioButtonPemale)
        Me.PanelGender.Controls.Add(Me.RadioButtonMale)
        Me.PanelGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGender.Location = New System.Drawing.Point(434, 34)
        Me.PanelGender.Name = "PanelGender"
        Me.PanelGender.Size = New System.Drawing.Size(253, 25)
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
        Me.PanelStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelStatus.Controls.Add(Me.RadioButtonNonActive)
        Me.PanelStatus.Controls.Add(Me.RadioButtonActive)
        Me.PanelStatus.Location = New System.Drawing.Point(67, 65)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(273, 25)
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
        'TextBoxNohp
        '
        Me.TextBoxNohp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNohp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNohp.Location = New System.Drawing.Point(434, 65)
        Me.TextBoxNohp.Name = "TextBoxNohp"
        Me.TextBoxNohp.Size = New System.Drawing.Size(253, 24)
        Me.TextBoxNohp.TabIndex = 9
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBoxPassword.Location = New System.Drawing.Point(434, 96)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(253, 24)
        Me.TextBoxPassword.TabIndex = 10
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(346, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Phone Number"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(346, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Password"
        '
        'ButtonOpenGaleri
        '
        Me.ButtonOpenGaleri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenGaleri.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonOpenGaleri.FlatAppearance.BorderSize = 0
        Me.ButtonOpenGaleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenGaleri.ForeColor = System.Drawing.Color.White
        Me.ButtonOpenGaleri.Location = New System.Drawing.Point(830, 30)
        Me.ButtonOpenGaleri.Name = "ButtonOpenGaleri"
        Me.ButtonOpenGaleri.Size = New System.Drawing.Size(83, 29)
        Me.ButtonOpenGaleri.TabIndex = 18
        Me.ButtonOpenGaleri.Text = "Open Galeri"
        Me.ButtonOpenGaleri.UseVisualStyleBackColor = False
        '
        'ButtonUserGroup
        '
        Me.ButtonUserGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonUserGroup.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonUserGroup.Enabled = False
        Me.ButtonUserGroup.FlatAppearance.BorderSize = 0
        Me.ButtonUserGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUserGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUserGroup.ForeColor = System.Drawing.Color.White
        Me.ButtonUserGroup.Location = New System.Drawing.Point(830, 65)
        Me.ButtonUserGroup.Name = "ButtonUserGroup"
        Me.ButtonUserGroup.Size = New System.Drawing.Size(83, 27)
        Me.ButtonUserGroup.TabIndex = 28
        Me.ButtonUserGroup.Text = "User Group"
        Me.ButtonUserGroup.UseVisualStyleBackColor = False
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxProfile.Image = Global.MYAPPVB.My.Resources.Resources.user
        Me.PictureBoxProfile.Location = New System.Drawing.Point(701, 17)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(123, 124)
        Me.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProfile.TabIndex = 17
        Me.PictureBoxProfile.TabStop = False
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.MenuStripAction)
        Me.PanelButton.Location = New System.Drawing.Point(11, 186)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(573, 38)
        Me.PanelButton.TabIndex = 29
        '
        'MenuStripAction
        '
        Me.MenuStripAction.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonAdd, Me.ButtonEdit, Me.ButtonSave, Me.ButtonDelete, Me.ButtonPrint, Me.ButtonRefresh})
        Me.MenuStripAction.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripAction.Name = "MenuStripAction"
        Me.MenuStripAction.Size = New System.Drawing.Size(573, 42)
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
        Me.ButtonAdd.Tag = "ButtonAdd"
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
        Me.ButtonEdit.Tag = "ButtonEdit"
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
        Me.ButtonSave.Tag = "ButtonSave"
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
        Me.ButtonDelete.Tag = "ButtonDelete"
        Me.ButtonDelete.Text = "Delete"
        '
        'ButtonPrint
        '
        Me.ButtonPrint.BackColor = System.Drawing.Color.Turquoise
        Me.ButtonPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonPrint.Image = Global.MYAPPVB.My.Resources.Resources.ic_excel
        Me.ButtonPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Padding = New System.Windows.Forms.Padding(7)
        Me.ButtonPrint.Size = New System.Drawing.Size(105, 34)
        Me.ButtonPrint.Tag = "ButtonPrint"
        Me.ButtonPrint.Text = "Print/Export"
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
        Me.ButtonRefresh.Tag = "ButtonRefresh"
        Me.ButtonRefresh.Text = "Refresh"
        '
        'PanelDgv
        '
        Me.PanelDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDgv.Controls.Add(Me.dgv)
        Me.PanelDgv.Controls.Add(Me.Panel1)
        Me.PanelDgv.Controls.Add(Me.BindingNavigatorPaging)
        Me.PanelDgv.Location = New System.Drawing.Point(16, 231)
        Me.PanelDgv.Name = "PanelDgv"
        Me.PanelDgv.Size = New System.Drawing.Size(926, 348)
        Me.PanelDgv.TabIndex = 31
        '
        'dgv
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 9, 0, 9)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv.Location = New System.Drawing.Point(6, 71)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.Height = 35
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(912, 274)
        Me.dgv.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ComboBoxEntries)
        Me.Panel1.Controls.Add(Me.TextBoxSearch)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 37)
        Me.Panel1.TabIndex = 32
        '
        'ComboBoxEntries
        '
        Me.ComboBoxEntries.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEntries.FormattingEnabled = True
        Me.ComboBoxEntries.Items.AddRange(New Object() {"10", "25", "50", "100"})
        Me.ComboBoxEntries.Location = New System.Drawing.Point(45, 3)
        Me.ComboBoxEntries.Name = "ComboBoxEntries"
        Me.ComboBoxEntries.Size = New System.Drawing.Size(96, 28)
        Me.ComboBoxEntries.TabIndex = 5
        Me.ComboBoxEntries.Text = "10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(152, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Entries"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(10, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Show"
        '
        'BindingNavigatorPaging
        '
        Me.BindingNavigatorPaging.AddNewItem = Nothing
        Me.BindingNavigatorPaging.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorPaging.DeleteItem = Nothing
        Me.BindingNavigatorPaging.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigatorPaging.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorPaging.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorPaging.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorPaging.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorPaging.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorPaging.Name = "BindingNavigatorPaging"
        Me.BindingNavigatorPaging.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorPaging.Size = New System.Drawing.Size(926, 25)
        Me.BindingNavigatorPaging.TabIndex = 31
        Me.BindingNavigatorPaging.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingSourcePaging
        '
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(953, 591)
        Me.Controls.Add(Me.PanelDgv)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStripAction
        Me.Name = "FormUser"
        Me.Tag = ""
        Me.Text = "FormDataUser"
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelGender.ResumeLayout(False)
        Me.PanelGender.PerformLayout()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        Me.MenuStripAction.ResumeLayout(False)
        Me.MenuStripAction.PerformLayout()
        Me.PanelDgv.ResumeLayout(False)
        Me.PanelDgv.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigatorPaging, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorPaging.ResumeLayout(False)
        Me.BindingNavigatorPaging.PerformLayout()
        CType(Me.BindingSourcePaging, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents TextBoxNohp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PanelGender As Panel
    Friend WithEvents RadioButtonPemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents RadioButtonNonActive As RadioButton
    Friend WithEvents RadioButtonActive As RadioButton
    Friend WithEvents ButtonOpenGaleri As Button
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents ButtonUserGroup As Button
    Friend WithEvents ButtonAdd As ToolStripMenuItem
    Friend WithEvents ButtonEdit As ToolStripMenuItem
    Friend WithEvents ButtonDelete As ToolStripMenuItem
    Friend WithEvents ButtonSave As ToolStripMenuItem
    Friend WithEvents ButtonRefresh As ToolStripMenuItem
    Public WithEvents PanelButton As Panel
    Friend WithEvents MenuStripAction As MenuStrip
    Friend WithEvents PanelDgv As Panel
    Friend WithEvents BindingNavigatorPaging As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxEntries As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BindingSourcePaging As BindingSource
    Friend WithEvents dgv As DataGridView
    Friend WithEvents ButtonAccess As Button
    Friend WithEvents ButtonPrint As ToolStripMenuItem
End Class
