<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuApp
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMenuText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxOpenFormName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelInput = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDownOrderSort = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxParentMenu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxTag = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBoxIconMenu = New System.Windows.Forms.PictureBox()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.MenuStripAction = New System.Windows.Forms.MenuStrip()
        Me.ButtonAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.MenuLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenForm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentMenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconMenu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OrderSort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxInputData.SuspendLayout()
        Me.TableLayoutPanelInput.SuspendLayout()
        CType(Me.NumericUpDownOrderSort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxIconMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        Me.MenuStripAction.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Role Name"
        '
        'TextBoxMenuText
        '
        Me.TextBoxMenuText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMenuText.Location = New System.Drawing.Point(140, 55)
        Me.TextBoxMenuText.Name = "TextBoxMenuText"
        Me.TextBoxMenuText.Size = New System.Drawing.Size(493, 27)
        Me.TextBoxMenuText.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Menu Text"
        '
        'TextBoxOpenFormName
        '
        Me.TextBoxOpenFormName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxOpenFormName.Location = New System.Drawing.Point(140, 102)
        Me.TextBoxOpenFormName.Name = "TextBoxOpenFormName"
        Me.TextBoxOpenFormName.Size = New System.Drawing.Size(493, 27)
        Me.TextBoxOpenFormName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Open Form Name"
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxInputData.Controls.Add(Me.TableLayoutPanelInput)
        Me.GroupBoxInputData.Enabled = False
        Me.GroupBoxInputData.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(1255, 164)
        Me.GroupBoxInputData.TabIndex = 8
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Input Menu"
        '
        'TableLayoutPanelInput
        '
        Me.TableLayoutPanelInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelInput.ColumnCount = 4
        Me.TableLayoutPanelInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanelInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanelInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelInput.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanelInput.Controls.Add(Me.NumericUpDownOrderSort, 3, 1)
        Me.TableLayoutPanelInput.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanelInput.Controls.Add(Me.ComboBoxParentMenu, 3, 0)
        Me.TableLayoutPanelInput.Controls.Add(Me.Label1, 2, 1)
        Me.TableLayoutPanelInput.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanelInput.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanelInput.Controls.Add(Me.ComboBoxTag, 1, 0)
        Me.TableLayoutPanelInput.Controls.Add(Me.TextBoxMenuText, 1, 1)
        Me.TableLayoutPanelInput.Controls.Add(Me.TextBoxOpenFormName, 1, 2)
        Me.TableLayoutPanelInput.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanelInput.Controls.Add(Me.Panel1, 3, 2)
        Me.TableLayoutPanelInput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanelInput.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanelInput.Name = "TableLayoutPanelInput"
        Me.TableLayoutPanelInput.RowCount = 3
        Me.TableLayoutPanelInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelInput.Size = New System.Drawing.Size(1243, 139)
        Me.TableLayoutPanelInput.TabIndex = 16
        '
        'NumericUpDownOrderSort
        '
        Me.NumericUpDownOrderSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownOrderSort.Location = New System.Drawing.Point(747, 55)
        Me.NumericUpDownOrderSort.Name = "NumericUpDownOrderSort"
        Me.NumericUpDownOrderSort.Size = New System.Drawing.Size(493, 27)
        Me.NumericUpDownOrderSort.TabIndex = 15
        '
        'ComboBoxParentMenu
        '
        Me.ComboBoxParentMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxParentMenu.FormattingEnabled = True
        Me.ComboBoxParentMenu.Location = New System.Drawing.Point(747, 12)
        Me.ComboBoxParentMenu.Name = "ComboBoxParentMenu"
        Me.ComboBoxParentMenu.Size = New System.Drawing.Size(493, 28)
        Me.ComboBoxParentMenu.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(639, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Order Sort"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(639, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Icon Menu"
        '
        'ComboBoxTag
        '
        Me.ComboBoxTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTag.FormattingEnabled = True
        Me.ComboBoxTag.Location = New System.Drawing.Point(140, 12)
        Me.ComboBoxTag.Name = "ComboBoxTag"
        Me.ComboBoxTag.Size = New System.Drawing.Size(493, 28)
        Me.ComboBoxTag.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(639, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Parent Menu"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBoxIconMenu)
        Me.Panel1.Location = New System.Drawing.Point(747, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 41)
        Me.Panel1.TabIndex = 16
        '
        'PictureBoxIconMenu
        '
        Me.PictureBoxIconMenu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBoxIconMenu.BackColor = System.Drawing.Color.Maroon
        Me.PictureBoxIconMenu.Image = Global.MYAPPVB.My.Resources.Resources.ic_menu
        Me.PictureBoxIconMenu.Location = New System.Drawing.Point(3, 5)
        Me.PictureBoxIconMenu.Name = "PictureBoxIconMenu"
        Me.PictureBoxIconMenu.Size = New System.Drawing.Size(30, 30)
        Me.PictureBoxIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconMenu.TabIndex = 11
        Me.PictureBoxIconMenu.TabStop = False
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.MenuStripAction)
        Me.PanelButton.Location = New System.Drawing.Point(12, 186)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(382, 38)
        Me.PanelButton.TabIndex = 31
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
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 9, 0, 9)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuLevel, Me.MenuID, Me.MenuTag, Me.MenuText, Me.OpenForm, Me.ParentMenu, Me.IconMenu, Me.OrderSort})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(18, 231)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal
        Me.dgv.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(9)
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.Height = 39
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1249, 253)
        Me.dgv.TabIndex = 35
        '
        'MenuLevel
        '
        Me.MenuLevel.HeaderText = "Menu"
        Me.MenuLevel.Name = "MenuLevel"
        Me.MenuLevel.ReadOnly = True
        '
        'MenuID
        '
        Me.MenuID.HeaderText = "MenuID"
        Me.MenuID.Name = "MenuID"
        Me.MenuID.ReadOnly = True
        '
        'MenuTag
        '
        Me.MenuTag.HeaderText = "MenuTag"
        Me.MenuTag.Name = "MenuTag"
        Me.MenuTag.ReadOnly = True
        '
        'MenuText
        '
        Me.MenuText.HeaderText = "MenuText"
        Me.MenuText.Name = "MenuText"
        Me.MenuText.ReadOnly = True
        '
        'OpenForm
        '
        Me.OpenForm.HeaderText = "OpenForm"
        Me.OpenForm.Name = "OpenForm"
        Me.OpenForm.ReadOnly = True
        '
        'ParentMenu
        '
        Me.ParentMenu.HeaderText = "Parent"
        Me.ParentMenu.Name = "ParentMenu"
        Me.ParentMenu.ReadOnly = True
        '
        'IconMenu
        '
        Me.IconMenu.HeaderText = "Icon"
        Me.IconMenu.Name = "IconMenu"
        Me.IconMenu.ReadOnly = True
        Me.IconMenu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IconMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'OrderSort
        '
        Me.OrderSort.HeaderText = "OrderSort"
        Me.OrderSort.Name = "OrderSort"
        Me.OrderSort.ReadOnly = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(1041, 200)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(226, 24)
        Me.TextBoxSearch.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(1038, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Search"
        '
        'FormMenuApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1285, 496)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormMenuApp"
        Me.Tag = ""
        Me.Text = "FormMenuApp"
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.TableLayoutPanelInput.ResumeLayout(False)
        Me.TableLayoutPanelInput.PerformLayout()
        CType(Me.NumericUpDownOrderSort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxIconMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        Me.MenuStripAction.ResumeLayout(False)
        Me.MenuStripAction.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMenuText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxOpenFormName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBoxIconMenu As PictureBox
    Friend WithEvents Label6 As Label
    Public WithEvents PanelButton As Panel
    Friend WithEvents MenuStripAction As MenuStrip
    Friend WithEvents ButtonAdd As ToolStripMenuItem
    Friend WithEvents ButtonEdit As ToolStripMenuItem
    Friend WithEvents ButtonSave As ToolStripMenuItem
    Friend WithEvents ButtonDelete As ToolStripMenuItem
    Friend WithEvents ButtonRefresh As ToolStripMenuItem
    Friend WithEvents ComboBoxParentMenu As ComboBox
    Friend WithEvents ComboBoxTag As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDownOrderSort As NumericUpDown
    Friend WithEvents TableLayoutPanelInput As TableLayoutPanel
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuLevel As DataGridViewTextBoxColumn
    Friend WithEvents MenuID As DataGridViewTextBoxColumn
    Friend WithEvents MenuTag As DataGridViewTextBoxColumn
    Friend WithEvents MenuText As DataGridViewTextBoxColumn
    Friend WithEvents OpenForm As DataGridViewTextBoxColumn
    Friend WithEvents ParentMenu As DataGridViewTextBoxColumn
    Friend WithEvents IconMenu As DataGridViewImageColumn
    Friend WithEvents OrderSort As DataGridViewTextBoxColumn
End Class
