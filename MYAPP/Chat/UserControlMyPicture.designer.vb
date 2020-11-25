<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlMyPicture
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
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.ContextMenuStripChat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBoxMesage = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.ContextMenuStripChat.SuspendLayout()
        CType(Me.PictureBoxMesage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.Controls.Add(Me.PictureBoxMesage)
        Me.FlowLayoutPanel.Controls.Add(Me.LabelDateTime)
        Me.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(3, 20)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(646, 252)
        Me.FlowLayoutPanel.TabIndex = 4
        '
        'LabelDateTime
        '
        Me.LabelDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(299, 235)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(106, 13)
        Me.LabelDateTime.TabIndex = 1
        Me.LabelDateTime.Text = "2019-11-21 12:00:00"
        Me.LabelDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContextMenuStripChat
        '
        Me.ContextMenuStripChat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.DownloadToolStripMenuItem})
        Me.ContextMenuStripChat.Name = "ContextMenuStripChat"
        Me.ContextMenuStripChat.Size = New System.Drawing.Size(129, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Tag = "MyMessage"
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'PictureBoxMesage
        '
        Me.PictureBoxMesage.ErrorImage = Global.MYAPPVB.My.Resources.Resources.not_found
        Me.PictureBoxMesage.Location = New System.Drawing.Point(411, 3)
        Me.PictureBoxMesage.MaximumSize = New System.Drawing.Size(433, 433)
        Me.PictureBoxMesage.Name = "PictureBoxMesage"
        Me.PictureBoxMesage.Size = New System.Drawing.Size(232, 242)
        Me.PictureBoxMesage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMesage.TabIndex = 2
        Me.PictureBoxMesage.TabStop = False
        '
        'UserControlMyPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Name = "UserControlMyPicture"
        Me.Size = New System.Drawing.Size(652, 291)
        Me.Tag = "MyMessage"
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.FlowLayoutPanel.PerformLayout()
        Me.ContextMenuStripChat.ResumeLayout(False)
        CType(Me.PictureBoxMesage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents PictureBoxMesage As PictureBox
    Friend WithEvents ContextMenuStripChat As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents DownloadToolStripMenuItem As ToolStripMenuItem
End Class
