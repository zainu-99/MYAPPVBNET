<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRoleGroup
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGroupLevel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsView = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsAdd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsPrint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsCustom = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessView = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessAdd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessPrint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AccessCustom = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBoxInputData.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.ComboBoxGroupLevel)
        Me.GroupBoxInputData.Controls.Add(Me.Label5)
        Me.GroupBoxInputData.Location = New System.Drawing.Point(12, 57)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(770, 54)
        Me.GroupBoxInputData.TabIndex = 39
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Data Group Level"
        '
        'ComboBoxGroupLevel
        '
        Me.ComboBoxGroupLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxGroupLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGroupLevel.FormattingEnabled = True
        Me.ComboBoxGroupLevel.Location = New System.Drawing.Point(91, 16)
        Me.ComboBoxGroupLevel.Name = "ComboBoxGroupLevel"
        Me.ComboBoxGroupLevel.Size = New System.Drawing.Size(673, 26)
        Me.ComboBoxGroupLevel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Group Level"
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Role, Me.Keterangan, Me.IsView, Me.IsAdd, Me.IsEdit, Me.IsDelete, Me.IsPrint, Me.IsCustom, Me.AccessView, Me.AccessAdd, Me.AccessEdit, Me.AccessDelete, Me.AccessPrint, Me.AccessCustom})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(12, 117)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.Height = 35
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1032, 412)
        Me.dgv.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(841, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(844, 76)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(200, 24)
        Me.TextBoxSearch.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(43, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Data Role Group"
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
        Me.ButtonBack.Location = New System.Drawing.Point(10, 6)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(27, 33)
        Me.ButtonBack.TabIndex = 41
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Teal
        Me.ButtonRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonRefresh.FlatAppearance.BorderSize = 0
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ButtonRefresh.Image = Global.MYAPPVB.My.Resources.Resources.refresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(788, 62)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(47, 47)
        Me.ButtonRefresh.TabIndex = 40
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Role
        '
        Me.Role.HeaderText = "Role"
        Me.Role.Name = "Role"
        Me.Role.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'IsView
        '
        Me.IsView.DataPropertyName = "Access"
        Me.IsView.HeaderText = "Is View"
        Me.IsView.Name = "IsView"
        '
        'IsAdd
        '
        Me.IsAdd.DataPropertyName = "Access"
        Me.IsAdd.HeaderText = "Is Add"
        Me.IsAdd.Name = "IsAdd"
        '
        'IsEdit
        '
        Me.IsEdit.DataPropertyName = "Access"
        Me.IsEdit.HeaderText = "Is Edit"
        Me.IsEdit.Name = "IsEdit"
        '
        'IsDelete
        '
        Me.IsDelete.DataPropertyName = "Access"
        Me.IsDelete.HeaderText = "Is Delete"
        Me.IsDelete.Name = "IsDelete"
        '
        'IsPrint
        '
        Me.IsPrint.DataPropertyName = "Access"
        Me.IsPrint.HeaderText = "Is Print"
        Me.IsPrint.Name = "IsPrint"
        '
        'IsCustom
        '
        Me.IsCustom.DataPropertyName = "Access"
        Me.IsCustom.HeaderText = "IsCustom"
        Me.IsCustom.Name = "IsCustom"
        Me.IsCustom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsCustom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        Me.AccessEdit.Visible = False
        '
        'AccessDelete
        '
        Me.AccessDelete.HeaderText = "AccessDelete"
        Me.AccessDelete.Name = "AccessDelete"
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
        'FormRoleGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1068, 555)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRoleGroup"
        Me.Tag = "Role Group"
        Me.Text = "FormRoleGroup"
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents ComboBoxGroupLevel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As DataGridViewTextBoxColumn
    Friend WithEvents IsView As DataGridViewCheckBoxColumn
    Friend WithEvents IsAdd As DataGridViewCheckBoxColumn
    Friend WithEvents IsEdit As DataGridViewCheckBoxColumn
    Friend WithEvents IsDelete As DataGridViewCheckBoxColumn
    Friend WithEvents IsPrint As DataGridViewCheckBoxColumn
    Friend WithEvents IsCustom As DataGridViewCheckBoxColumn
    Friend WithEvents AccessView As DataGridViewCheckBoxColumn
    Friend WithEvents AccessAdd As DataGridViewCheckBoxColumn
    Friend WithEvents AccessEdit As DataGridViewCheckBoxColumn
    Friend WithEvents AccessDelete As DataGridViewCheckBoxColumn
    Friend WithEvents AccessPrint As DataGridViewCheckBoxColumn
    Friend WithEvents AccessCustom As DataGridViewCheckBoxColumn
End Class
