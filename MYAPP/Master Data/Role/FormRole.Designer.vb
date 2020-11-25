<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRole
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRole))
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCustom = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPrint = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDelete = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEdit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAdd = New System.Windows.Forms.CheckBox()
        Me.CheckBoxView = New System.Windows.Forms.CheckBox()
        Me.TextBoxRemark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxRole = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.MenuStripAction = New System.Windows.Forms.MenuStrip()
        Me.ButtonAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDgv = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxEntries = New System.Windows.Forms.ComboBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxInputData.Controls.Add(Me.CheckBoxCustom)
        Me.GroupBoxInputData.Controls.Add(Me.CheckBoxPrint)
        Me.GroupBoxInputData.Controls.Add(Me.CheckBoxDelete)
        Me.GroupBoxInputData.Controls.Add(Me.CheckBoxEdit)
        Me.GroupBoxInputData.Controls.Add(Me.CheckBoxAdd)
        Me.GroupBoxInputData.Controls.Add(Me.CheckBoxView)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxRemark)
        Me.GroupBoxInputData.Controls.Add(Me.Label7)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxRole)
        Me.GroupBoxInputData.Controls.Add(Me.Label5)
        Me.GroupBoxInputData.Enabled = False
        Me.GroupBoxInputData.Location = New System.Drawing.Point(12, 31)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(1080, 54)
        Me.GroupBoxInputData.TabIndex = 21
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Form Input Data"
        '
        'CheckBoxCustom
        '
        Me.CheckBoxCustom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCustom.AutoSize = True
        Me.CheckBoxCustom.Location = New System.Drawing.Point(891, 21)
        Me.CheckBoxCustom.Name = "CheckBoxCustom"
        Me.CheckBoxCustom.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxCustom.TabIndex = 13
        Me.CheckBoxCustom.Text = "Custom"
        Me.CheckBoxCustom.UseVisualStyleBackColor = True
        '
        'CheckBoxPrint
        '
        Me.CheckBoxPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxPrint.AutoSize = True
        Me.CheckBoxPrint.Location = New System.Drawing.Point(831, 21)
        Me.CheckBoxPrint.Name = "CheckBoxPrint"
        Me.CheckBoxPrint.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxPrint.TabIndex = 14
        Me.CheckBoxPrint.Text = "Print"
        Me.CheckBoxPrint.UseVisualStyleBackColor = True
        '
        'CheckBoxDelete
        '
        Me.CheckBoxDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxDelete.AutoSize = True
        Me.CheckBoxDelete.Location = New System.Drawing.Point(759, 21)
        Me.CheckBoxDelete.Name = "CheckBoxDelete"
        Me.CheckBoxDelete.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxDelete.TabIndex = 15
        Me.CheckBoxDelete.Text = "Delete"
        Me.CheckBoxDelete.UseVisualStyleBackColor = True
        '
        'CheckBoxEdit
        '
        Me.CheckBoxEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxEdit.AutoSize = True
        Me.CheckBoxEdit.Location = New System.Drawing.Point(705, 21)
        Me.CheckBoxEdit.Name = "CheckBoxEdit"
        Me.CheckBoxEdit.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxEdit.TabIndex = 16
        Me.CheckBoxEdit.Text = "Edit"
        Me.CheckBoxEdit.UseVisualStyleBackColor = True
        '
        'CheckBoxAdd
        '
        Me.CheckBoxAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxAdd.AutoSize = True
        Me.CheckBoxAdd.Location = New System.Drawing.Point(648, 21)
        Me.CheckBoxAdd.Name = "CheckBoxAdd"
        Me.CheckBoxAdd.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxAdd.TabIndex = 17
        Me.CheckBoxAdd.Text = "Add"
        Me.CheckBoxAdd.UseVisualStyleBackColor = True
        '
        'CheckBoxView
        '
        Me.CheckBoxView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxView.AutoSize = True
        Me.CheckBoxView.Checked = True
        Me.CheckBoxView.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxView.Location = New System.Drawing.Point(589, 21)
        Me.CheckBoxView.Name = "CheckBoxView"
        Me.CheckBoxView.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxView.TabIndex = 18
        Me.CheckBoxView.Text = "View"
        Me.CheckBoxView.UseVisualStyleBackColor = True
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRemark.Location = New System.Drawing.Point(242, 17)
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(335, 24)
        Me.TextBoxRemark.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Remark"
        '
        'TextBoxRole
        '
        Me.TextBoxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRole.Location = New System.Drawing.Point(58, 17)
        Me.TextBoxRole.Name = "TextBoxRole"
        Me.TextBoxRole.Size = New System.Drawing.Size(108, 24)
        Me.TextBoxRole.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(13, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data Role"
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.MenuStripAction)
        Me.PanelButton.Location = New System.Drawing.Point(6, 88)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(382, 38)
        Me.PanelButton.TabIndex = 30
        '
        'MenuStripAction
        '
        Me.MenuStripAction.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonAdd, Me.ButtonEdit, Me.ButtonSave, Me.ButtonDelete, Me.ButtonRefresh})
        Me.MenuStripAction.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripAction.Name = "MenuStripAction"
        Me.MenuStripAction.Size = New System.Drawing.Size(382, 42)
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
        Me.PanelDgv.Location = New System.Drawing.Point(17, 133)
        Me.PanelDgv.Name = "PanelDgv"
        Me.PanelDgv.Size = New System.Drawing.Size(1075, 422)
        Me.PanelDgv.TabIndex = 32
        '
        'dgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 9, 0, 9)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Location = New System.Drawing.Point(6, 71)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.Height = 35
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1061, 348)
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
        Me.Panel1.Size = New System.Drawing.Size(1074, 37)
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
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(893, 6)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(176, 24)
        Me.TextBoxSearch.TabIndex = 3
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(847, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search"
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
        Me.BindingNavigatorPaging.Size = New System.Drawing.Size(1075, 25)
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
        'FormRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 567)
        Me.Controls.Add(Me.PanelDgv)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRole"
        Me.Tag = ""
        Me.Text = "FormRole"
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
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
    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents TextBoxRemark As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxRole As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStripAction As MenuStrip
    Friend WithEvents ButtonAdd As ToolStripMenuItem
    Friend WithEvents ButtonEdit As ToolStripMenuItem
    Friend WithEvents ButtonSave As ToolStripMenuItem
    Friend WithEvents ButtonDelete As ToolStripMenuItem
    Friend WithEvents ButtonRefresh As ToolStripMenuItem
    Public WithEvents PanelButton As Panel
    Friend WithEvents PanelDgv As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxEntries As ComboBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents BindingSourcePaging As BindingSource
    Friend WithEvents CheckBoxCustom As CheckBox
    Friend WithEvents CheckBoxPrint As CheckBox
    Friend WithEvents CheckBoxDelete As CheckBox
    Friend WithEvents CheckBoxEdit As CheckBox
    Friend WithEvents CheckBoxAdd As CheckBox
    Friend WithEvents CheckBoxView As CheckBox
End Class
