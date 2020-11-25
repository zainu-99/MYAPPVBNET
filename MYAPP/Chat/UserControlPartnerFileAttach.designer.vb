<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlPartnerFileAttach
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripChat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FlowLayoutPanel.SuspendLayout()
        Me.ContextMenuStripChat.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonDownload)
        Me.FlowLayoutPanel.Controls.Add(Me.LabelDateTime)
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(20, 15)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(996, 56)
        Me.FlowLayoutPanel.TabIndex = 5
        '
        'ButtonDownload
        '
        Me.ButtonDownload.AutoSize = True
        Me.ButtonDownload.BackColor = System.Drawing.Color.White
        Me.ButtonDownload.FlatAppearance.BorderSize = 0
        Me.ButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDownload.ForeColor = System.Drawing.Color.Green
        Me.ButtonDownload.Location = New System.Drawing.Point(3, 3)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(85, 43)
        Me.ButtonDownload.TabIndex = 4
        Me.ButtonDownload.Text = "Download"
        Me.ButtonDownload.UseVisualStyleBackColor = False
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(94, 31)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(113, 18)
        Me.LabelDateTime.TabIndex = 3
        Me.LabelDateTime.Text = "2019-11-21 12:00:00"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'ContextMenuStripChat
        '
        Me.ContextMenuStripChat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem})
        Me.ContextMenuStripChat.Name = "ContextMenuStripChat"
        Me.ContextMenuStripChat.Size = New System.Drawing.Size(125, 26)
        Me.ContextMenuStripChat.Tag = "PartnerMessage"
        '
        'UserControlPartnerFileAttach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Name = "UserControlPartnerFileAttach"
        Me.Size = New System.Drawing.Size(1036, 86)
        Me.Tag = "PartnerMessage"
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.FlowLayoutPanel.PerformLayout()
        Me.ContextMenuStripChat.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripChat As ContextMenuStrip
End Class
