<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGroupLevel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleGroup = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IDGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDParent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.TextBoxRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxParentGroup = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGroup = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.MenuStripAction = New System.Windows.Forms.MenuStrip()
        Me.ButtonAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonBack = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInputData.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.MenuStripAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 9, 0, 9)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Group, Me.Remark, Me.ParentColumn, Me.RoleGroup, Me.IDGroup, Me.IDParent})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Location = New System.Drawing.Point(11, 207)
        Me.dgv.MultiSelect = False
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
        Me.dgv.Size = New System.Drawing.Size(938, 240)
        Me.dgv.TabIndex = 43
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Group
        '
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'ParentColumn
        '
        Me.ParentColumn.HeaderText = "Parent"
        Me.ParentColumn.Name = "ParentColumn"
        Me.ParentColumn.ReadOnly = True
        '
        'RoleGroup
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RoleGroup.DefaultCellStyle = DataGridViewCellStyle2
        Me.RoleGroup.HeaderText = "Role Group"
        Me.RoleGroup.Name = "RoleGroup"
        Me.RoleGroup.ReadOnly = True
        '
        'IDGroup
        '
        Me.IDGroup.HeaderText = "IDGroup"
        Me.IDGroup.Name = "IDGroup"
        Me.IDGroup.ReadOnly = True
        Me.IDGroup.Visible = False
        '
        'IDParent
        '
        Me.IDParent.HeaderText = "IDParent"
        Me.IDParent.Name = "IDParent"
        Me.IDParent.ReadOnly = True
        Me.IDParent.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(745, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(748, 177)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(200, 24)
        Me.TextBoxSearch.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(42, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Data Group Level"
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxRemark)
        Me.GroupBoxInputData.Controls.Add(Me.Label3)
        Me.GroupBoxInputData.Controls.Add(Me.ComboBoxParentGroup)
        Me.GroupBoxInputData.Controls.Add(Me.ComboBoxGroup)
        Me.GroupBoxInputData.Controls.Add(Me.Label7)
        Me.GroupBoxInputData.Controls.Add(Me.Label5)
        Me.GroupBoxInputData.Enabled = False
        Me.GroupBoxInputData.Location = New System.Drawing.Point(9, 55)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(940, 54)
        Me.GroupBoxInputData.TabIndex = 50
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Form Input Data"
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRemark.Location = New System.Drawing.Point(497, 17)
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(424, 24)
        Me.TextBoxRemark.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Remark"
        '
        'ComboBoxParentGroup
        '
        Me.ComboBoxParentGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxParentGroup.FormattingEnabled = True
        Me.ComboBoxParentGroup.Location = New System.Drawing.Point(257, 17)
        Me.ComboBoxParentGroup.Name = "ComboBoxParentGroup"
        Me.ComboBoxParentGroup.Size = New System.Drawing.Size(166, 26)
        Me.ComboBoxParentGroup.TabIndex = 11
        '
        'ComboBoxGroup
        '
        Me.ComboBoxGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGroup.FormattingEnabled = True
        Me.ComboBoxGroup.Location = New System.Drawing.Point(48, 18)
        Me.ComboBoxGroup.Name = "ComboBoxGroup"
        Me.ComboBoxGroup.Size = New System.Drawing.Size(127, 26)
        Me.ComboBoxGroup.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Parent Group"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Group"
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.MenuStripAction)
        Me.PanelButton.Location = New System.Drawing.Point(3, 117)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(384, 38)
        Me.PanelButton.TabIndex = 51
        '
        'MenuStripAction
        '
        Me.MenuStripAction.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonAdd, Me.ButtonEdit, Me.ButtonSave, Me.ButtonDelete, Me.ButtonRefresh})
        Me.MenuStripAction.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripAction.Name = "MenuStripAction"
        Me.MenuStripAction.Size = New System.Drawing.Size(384, 42)
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
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Teal
        Me.ButtonBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ButtonBack.Image = Global.MYAPPVB.My.Resources.Resources.back
        Me.ButtonBack.Location = New System.Drawing.Point(9, 14)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(27, 33)
        Me.ButtonBack.TabIndex = 48
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'FormGroupLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(961, 461)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGroupLevel"
        Me.Tag = "Group"
        Me.Text = "FormGroupLevel"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        Me.MenuStripAction.ResumeLayout(False)
        Me.MenuStripAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxParentGroup As ComboBox
    Friend WithEvents ComboBoxGroup As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxRemark As TextBox
    Friend WithEvents MenuStripAction As MenuStrip
    Friend WithEvents ButtonAdd As ToolStripMenuItem
    Friend WithEvents ButtonEdit As ToolStripMenuItem
    Friend WithEvents ButtonSave As ToolStripMenuItem
    Friend WithEvents ButtonDelete As ToolStripMenuItem
    Friend WithEvents ButtonRefresh As ToolStripMenuItem
    Public WithEvents PanelButton As Panel
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Group As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents ParentColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleGroup As DataGridViewButtonColumn
    Friend WithEvents IDGroup As DataGridViewTextBoxColumn
    Friend WithEvents IDParent As DataGridViewTextBoxColumn
End Class
