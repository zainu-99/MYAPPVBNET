<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUserGroup
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Parentt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Join = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.GroupBoxInputData.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.TextBoxUser)
        Me.GroupBoxInputData.Controls.Add(Me.Label5)
        Me.GroupBoxInputData.Location = New System.Drawing.Point(12, 56)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(743, 54)
        Me.GroupBoxInputData.TabIndex = 39
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Data User"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUser.Location = New System.Drawing.Point(55, 16)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.ReadOnly = True
        Me.TextBoxUser.Size = New System.Drawing.Size(671, 24)
        Me.TextBoxUser.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "User"
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Group, Me.Parentt, Me.Remark, Me.Join})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv.Location = New System.Drawing.Point(12, 116)
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
        Me.dgv.Size = New System.Drawing.Size(1032, 334)
        Me.dgv.TabIndex = 36
        '
        'Id
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Id.DefaultCellStyle = DataGridViewCellStyle2
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Group
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Group.DefaultCellStyle = DataGridViewCellStyle3
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        '
        'Parentt
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Parentt.DefaultCellStyle = DataGridViewCellStyle4
        Me.Parentt.HeaderText = "Parent"
        Me.Parentt.Name = "Parentt"
        Me.Parentt.ReadOnly = True
        '
        'Remark
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle5
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'Join
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.NullValue = False
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Join.DefaultCellStyle = DataGridViewCellStyle6
        Me.Join.HeaderText = "Join"
        Me.Join.Name = "Join"
        Me.Join.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(45, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Data User Group"
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
        Me.ButtonBack.Location = New System.Drawing.Point(12, 9)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(27, 33)
        Me.ButtonBack.TabIndex = 42
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
        Me.ButtonRefresh.Location = New System.Drawing.Point(761, 62)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(47, 47)
        Me.ButtonRefresh.TabIndex = 41
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'FormUserGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 461)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.GroupBoxInputData)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUserGroup"
        Me.Tag = "User Group"
        Me.Text = "FormUserGroup"
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Group As DataGridViewTextBoxColumn
    Friend WithEvents Parentt As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents Join As DataGridViewCheckBoxColumn
End Class
