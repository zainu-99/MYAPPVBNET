<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlReadStatus
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
        Me.LabelReadStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelReadStatus
        '
        Me.LabelReadStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelReadStatus.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReadStatus.ForeColor = System.Drawing.Color.White
        Me.LabelReadStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelReadStatus.Location = New System.Drawing.Point(0, 0)
        Me.LabelReadStatus.Name = "LabelReadStatus"
        Me.LabelReadStatus.Size = New System.Drawing.Size(459, 24)
        Me.LabelReadStatus.TabIndex = 51
        Me.LabelReadStatus.Text = "-------Read-------"
        Me.LabelReadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserControlReadStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelReadStatus)
        Me.Name = "UserControlReadStatus"
        Me.Size = New System.Drawing.Size(459, 79)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelReadStatus As Label
End Class
