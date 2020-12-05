<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserRole
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllowView = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowAdd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowPrint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AllowCustom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessView = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessAdd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessPrint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessCustom = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxGroupLevel = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGroupLevel = New System.Windows.Forms.ComboBox()
        Me.CheckBoxAllView = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllAdd = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllEdit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllDelete = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllPrint = New System.Windows.Forms.CheckBox()
        Me.ButtonFilter = New System.Windows.Forms.Button()
        Me.GroupBoxInputData.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGroupLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxUser)
        Me.GroupBoxInputData.Location = New System.Drawing.Point(20, 45)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(253, 54)
        Me.GroupBoxInputData.TabIndex = 32
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Data User"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUser.Location = New System.Drawing.Point(12, 19)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.ReadOnly = True
        Me.TextBoxUser.Size = New System.Drawing.Size(235, 24)
        Me.TextBoxUser.TabIndex = 7
        Me.TextBoxUser.Tag = "0"
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 9, 0, 9)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Role, Me.Remark, Me.AllowView, Me.AllowAdd, Me.AllowEdit, Me.AllowDelete, Me.AllowPrint, Me.AllowCustom, Me.AccessView, Me.AccessAdd, Me.AccessEdit, Me.AccessDelete, Me.AccessPrint, Me.AccessCustom})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Location = New System.Drawing.Point(20, 155)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
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
        Me.dgv.Size = New System.Drawing.Size(1032, 307)
        Me.dgv.TabIndex = 28
        '
        'ID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        Me.ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Role
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Role.DefaultCellStyle = DataGridViewCellStyle3
        Me.Role.HeaderText = "Role"
        Me.Role.Name = "Role"
        Me.Role.ReadOnly = True
        '
        'Remark
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle4
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'AllowView
        '
        Me.AllowView.DataPropertyName = "Access"
        Me.AllowView.HeaderText = "View"
        Me.AllowView.Name = "AllowView"
        Me.AllowView.ReadOnly = True
        Me.AllowView.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AllowAdd
        '
        Me.AllowAdd.DataPropertyName = "Access"
        Me.AllowAdd.HeaderText = "Add"
        Me.AllowAdd.Name = "AllowAdd"
        Me.AllowAdd.ReadOnly = True
        Me.AllowAdd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AllowEdit
        '
        Me.AllowEdit.DataPropertyName = "Access"
        Me.AllowEdit.HeaderText = "Edit"
        Me.AllowEdit.Name = "AllowEdit"
        Me.AllowEdit.ReadOnly = True
        Me.AllowEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AllowDelete
        '
        Me.AllowDelete.DataPropertyName = "Access"
        Me.AllowDelete.HeaderText = "Delete"
        Me.AllowDelete.Name = "AllowDelete"
        Me.AllowDelete.ReadOnly = True
        Me.AllowDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AllowPrint
        '
        Me.AllowPrint.DataPropertyName = "Access"
        Me.AllowPrint.HeaderText = "Print"
        Me.AllowPrint.Name = "AllowPrint"
        Me.AllowPrint.ReadOnly = True
        Me.AllowPrint.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AllowCustom
        '
        Me.AllowCustom.DataPropertyName = "Access"
        Me.AllowCustom.HeaderText = "Custom"
        Me.AllowCustom.Name = "AllowCustom"
        Me.AllowCustom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'AccessView
        '
        Me.AccessView.HeaderText = "AccessView"
        Me.AccessView.Name = "AccessView"
        Me.AccessView.Visible = False
        '
        'AccessAdd
        '
        Me.AccessAdd.HeaderText = "AccessAdd"
        Me.AccessAdd.Name = "AccessAdd"
        Me.AccessAdd.Visible = False
        '
        'AccessEdit
        '
        Me.AccessEdit.HeaderText = "AccessEdit"
        Me.AccessEdit.Name = "AccessEdit"
        Me.AccessEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccessEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AccessEdit.Visible = False
        '
        'AccessDelete
        '
        Me.AccessDelete.HeaderText = "AccessDelete"
        Me.AccessDelete.Name = "AccessDelete"
        Me.AccessDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccessDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AccessDelete.Visible = False
        '
        'AccessPrint
        '
        Me.AccessPrint.HeaderText = "AccessPrint"
        Me.AccessPrint.Name = "AccessPrint"
        Me.AccessPrint.Visible = False
        '
        'AccessCustom
        '
        Me.AccessCustom.HeaderText = "AccessCustom"
        Me.AccessCustom.Name = "AccessCustom"
        Me.AccessCustom.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(17, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(20, 127)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(195, 24)
        Me.TextBoxSearch.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Data Role"
        '
        'GroupBoxGroupLevel
        '
        Me.GroupBoxGroupLevel.Controls.Add(Me.ComboBoxGroupLevel)
        Me.GroupBoxGroupLevel.Location = New System.Drawing.Point(279, 45)
        Me.GroupBoxGroupLevel.Name = "GroupBoxGroupLevel"
        Me.GroupBoxGroupLevel.Size = New System.Drawing.Size(227, 54)
        Me.GroupBoxGroupLevel.TabIndex = 33
        Me.GroupBoxGroupLevel.TabStop = False
        Me.GroupBoxGroupLevel.Text = "Data Group Level"
        '
        'ComboBoxGroupLevel
        '
        Me.ComboBoxGroupLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGroupLevel.FormattingEnabled = True
        Me.ComboBoxGroupLevel.Location = New System.Drawing.Point(6, 18)
        Me.ComboBoxGroupLevel.Name = "ComboBoxGroupLevel"
        Me.ComboBoxGroupLevel.Size = New System.Drawing.Size(205, 26)
        Me.ComboBoxGroupLevel.TabIndex = 6
        '
        'CheckBoxAllView
        '
        Me.CheckBoxAllView.AutoSize = True
        Me.CheckBoxAllView.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAllView.Location = New System.Drawing.Point(221, 129)
        Me.CheckBoxAllView.Name = "CheckBoxAllView"
        Me.CheckBoxAllView.Size = New System.Drawing.Size(66, 20)
        Me.CheckBoxAllView.TabIndex = 35
        Me.CheckBoxAllView.Text = "All View"
        Me.CheckBoxAllView.UseVisualStyleBackColor = True
        '
        'CheckBoxAllAdd
        '
        Me.CheckBoxAllAdd.AutoSize = True
        Me.CheckBoxAllAdd.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAllAdd.Location = New System.Drawing.Point(290, 129)
        Me.CheckBoxAllAdd.Name = "CheckBoxAllAdd"
        Me.CheckBoxAllAdd.Size = New System.Drawing.Size(62, 20)
        Me.CheckBoxAllAdd.TabIndex = 36
        Me.CheckBoxAllAdd.Text = "All Add"
        Me.CheckBoxAllAdd.UseVisualStyleBackColor = True
        '
        'CheckBoxAllEdit
        '
        Me.CheckBoxAllEdit.AutoSize = True
        Me.CheckBoxAllEdit.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAllEdit.Location = New System.Drawing.Point(355, 129)
        Me.CheckBoxAllEdit.Name = "CheckBoxAllEdit"
        Me.CheckBoxAllEdit.Size = New System.Drawing.Size(61, 20)
        Me.CheckBoxAllEdit.TabIndex = 37
        Me.CheckBoxAllEdit.Text = "All Edit"
        Me.CheckBoxAllEdit.UseVisualStyleBackColor = True
        '
        'CheckBoxAllDelete
        '
        Me.CheckBoxAllDelete.AutoSize = True
        Me.CheckBoxAllDelete.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAllDelete.Location = New System.Drawing.Point(419, 129)
        Me.CheckBoxAllDelete.Name = "CheckBoxAllDelete"
        Me.CheckBoxAllDelete.Size = New System.Drawing.Size(71, 20)
        Me.CheckBoxAllDelete.TabIndex = 38
        Me.CheckBoxAllDelete.Text = "All Delete"
        Me.CheckBoxAllDelete.UseVisualStyleBackColor = True
        '
        'CheckBoxAllPrint
        '
        Me.CheckBoxAllPrint.AutoSize = True
        Me.CheckBoxAllPrint.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAllPrint.Location = New System.Drawing.Point(493, 129)
        Me.CheckBoxAllPrint.Name = "CheckBoxAllPrint"
        Me.CheckBoxAllPrint.Size = New System.Drawing.Size(66, 20)
        Me.CheckBoxAllPrint.TabIndex = 39
        Me.CheckBoxAllPrint.Text = "All Print"
        Me.CheckBoxAllPrint.UseVisualStyleBackColor = True
        '
        'ButtonFilter
        '
        Me.ButtonFilter.BackColor = System.Drawing.Color.Teal
        Me.ButtonFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonFilter.FlatAppearance.BorderSize = 0
        Me.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFilter.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ButtonFilter.Image = Global.MYAPPVB.My.Resources.Resources.filter
        Me.ButtonFilter.Location = New System.Drawing.Point(512, 50)
        Me.ButtonFilter.Name = "ButtonFilter"
        Me.ButtonFilter.Size = New System.Drawing.Size(47, 47)
        Me.ButtonFilter.TabIndex = 34
        Me.ButtonFilter.UseVisualStyleBackColor = False
        '
        'FormUserRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1068, 483)
        Me.Controls.Add(Me.CheckBoxAllPrint)
        Me.Controls.Add(Me.CheckBoxAllDelete)
        Me.Controls.Add(Me.CheckBoxAllEdit)
        Me.Controls.Add(Me.CheckBoxAllAdd)
        Me.Controls.Add(Me.CheckBoxAllView)
        Me.Controls.Add(Me.ButtonFilter)
        Me.Controls.Add(Me.GroupBoxGroupLevel)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUserRole"
        Me.Tag = "User Access"
        Me.Text = "FormUserRole"
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGroupLevel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxGroupLevel As GroupBox
    Friend WithEvents ComboBoxGroupLevel As ComboBox
    Friend WithEvents ButtonFilter As Button
    Friend WithEvents CheckBoxAllView As CheckBox
    Friend WithEvents CheckBoxAllAdd As CheckBox
    Friend WithEvents CheckBoxAllEdit As CheckBox
    Friend WithEvents CheckBoxAllDelete As CheckBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents CheckBoxAllPrint As CheckBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents AllowView As DataGridViewCheckBoxColumn
    Friend WithEvents AllowAdd As DataGridViewCheckBoxColumn
    Friend WithEvents AllowEdit As DataGridViewCheckBoxColumn
    Friend WithEvents AllowDelete As DataGridViewCheckBoxColumn
    Friend WithEvents AllowPrint As DataGridViewCheckBoxColumn
    Friend WithEvents AllowCustom As DataGridViewTextBoxColumn
    Friend WithEvents AccessView As DataGridViewCheckBoxColumn
    Friend WithEvents AccessAdd As DataGridViewCheckBoxColumn
    Friend WithEvents AccessEdit As DataGridViewCheckBoxColumn
    Friend WithEvents AccessDelete As DataGridViewCheckBoxColumn
    Friend WithEvents AccessPrint As DataGridViewCheckBoxColumn
    Friend WithEvents AccessCustom As DataGridViewCheckBoxColumn
End Class
