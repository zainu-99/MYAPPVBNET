<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlMyMessage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ContextMenuStripChat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelMsg = New System.Windows.Forms.Panel()
        Me.LabelMessage = New MYAPPVB.EmojiRichText()
        Me.ContextMenuStripChat.SuspendLayout()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.PanelMsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStripChat
        '
        Me.ContextMenuStripChat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStripChat.Name = "ContextMenuStripChat"
        Me.ContextMenuStripChat.Size = New System.Drawing.Size(108, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Tag = "MyMessage"
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(857, 63)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(106, 13)
        Me.LabelDateTime.TabIndex = 1
        Me.LabelDateTime.Text = "2019-11-21 12:00:00"
        Me.LabelDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.Controls.Add(Me.PanelMsg)
        Me.FlowLayoutPanel.Controls.Add(Me.LabelDateTime)
        Me.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(23, 7)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(1092, 76)
        Me.FlowLayoutPanel.TabIndex = 2
        '
        'PanelMsg
        '
        Me.PanelMsg.AutoSize = True
        Me.PanelMsg.BackColor = System.Drawing.Color.Green
        Me.PanelMsg.Controls.Add(Me.LabelMessage)
        Me.PanelMsg.Location = New System.Drawing.Point(969, 3)
        Me.PanelMsg.Name = "PanelMsg"
        Me.PanelMsg.Padding = New System.Windows.Forms.Padding(7)
        Me.PanelMsg.Size = New System.Drawing.Size(120, 70)
        Me.PanelMsg.TabIndex = 6
        '
        'LabelMessage
        '
        Me.LabelMessage.BackColor = System.Drawing.Color.Green
        Me.LabelMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabelMessage.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.LabelMessage.ForeColor = System.Drawing.Color.White
        Me.LabelMessage.Location = New System.Drawing.Point(10, 10)
        Me.LabelMessage.MaximumSize = New System.Drawing.Size(999, 0)
        Me.LabelMessage.MinimumSize = New System.Drawing.Size(5, 5)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.ReadOnly = True
        Me.LabelMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.LabelMessage.Size = New System.Drawing.Size(100, 50)
        Me.LabelMessage.TabIndex = 4
        Me.LabelMessage.Text = ""
        '
        'UserControlMyMessage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.DoubleBuffered = True
        Me.Name = "UserControlMyMessage"
        Me.Padding = New System.Windows.Forms.Padding(0, 7, 17, 7)
        Me.Size = New System.Drawing.Size(1132, 93)
        Me.Tag = "MyMessage"
        Me.ContextMenuStripChat.ResumeLayout(False)
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.FlowLayoutPanel.PerformLayout()
        Me.PanelMsg.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStripChat As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents PanelMsg As Panel
    Friend WithEvents LabelMessage As EmojiRichText
End Class
