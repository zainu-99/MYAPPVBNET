<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUI
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxVarDesignName = New System.Windows.Forms.ComboBox()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxSetDesign = New System.Windows.Forms.GroupBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonSetUp = New System.Windows.Forms.Button()
        Me.GroupBoxSetDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "UI Design"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Variable Design Name "
        '
        'ComboBoxVarDesignName
        '
        Me.ComboBoxVarDesignName.FormattingEnabled = True
        Me.ComboBoxVarDesignName.Location = New System.Drawing.Point(21, 59)
        Me.ComboBoxVarDesignName.Name = "ComboBoxVarDesignName"
        Me.ComboBoxVarDesignName.Size = New System.Drawing.Size(260, 28)
        Me.ComboBoxVarDesignName.TabIndex = 33
        Me.ComboBoxVarDesignName.Text = "--Selected--"
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Location = New System.Drawing.Point(329, 59)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(237, 28)
        Me.ComboBoxColor.TabIndex = 35
        Me.ComboBoxColor.Text = "--Selected--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Color"
        '
        'GroupBoxSetDesign
        '
        Me.GroupBoxSetDesign.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxSetDesign.Controls.Add(Me.ButtonReset)
        Me.GroupBoxSetDesign.Controls.Add(Me.ButtonSetUp)
        Me.GroupBoxSetDesign.Controls.Add(Me.Label2)
        Me.GroupBoxSetDesign.Controls.Add(Me.ComboBoxColor)
        Me.GroupBoxSetDesign.Controls.Add(Me.ComboBoxVarDesignName)
        Me.GroupBoxSetDesign.Controls.Add(Me.Label3)
        Me.GroupBoxSetDesign.Location = New System.Drawing.Point(227, 237)
        Me.GroupBoxSetDesign.Name = "GroupBoxSetDesign"
        Me.GroupBoxSetDesign.Size = New System.Drawing.Size(818, 135)
        Me.GroupBoxSetDesign.TabIndex = 36
        Me.GroupBoxSetDesign.TabStop = False
        Me.GroupBoxSetDesign.Text = "Set Design"
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Orange
        Me.ButtonReset.FlatAppearance.BorderSize = 0
        Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReset.ForeColor = System.Drawing.Color.White
        Me.ButtonReset.Location = New System.Drawing.Point(682, 53)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(112, 38)
        Me.ButtonReset.TabIndex = 37
        Me.ButtonReset.Text = "Reset Default"
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'ButtonSetUp
        '
        Me.ButtonSetUp.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonSetUp.FlatAppearance.BorderSize = 0
        Me.ButtonSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSetUp.ForeColor = System.Drawing.Color.White
        Me.ButtonSetUp.Location = New System.Drawing.Point(592, 53)
        Me.ButtonSetUp.Name = "ButtonSetUp"
        Me.ButtonSetUp.Size = New System.Drawing.Size(75, 38)
        Me.ButtonSetUp.TabIndex = 36
        Me.ButtonSetUp.Text = "Set Up"
        Me.ButtonSetUp.UseVisualStyleBackColor = False
        '
        'FormUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1236, 679)
        Me.Controls.Add(Me.GroupBoxSetDesign)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUI"
        Me.Tag = "UI"
        Me.Text = "FormUI"
        Me.GroupBoxSetDesign.ResumeLayout(False)
        Me.GroupBoxSetDesign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxVarDesignName As ComboBox
    Friend WithEvents ComboBoxColor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxSetDesign As GroupBox
    Friend WithEvents ButtonSetUp As Button
    Friend WithEvents ButtonReset As Button
End Class
