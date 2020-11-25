Imports System.Reflection

Public Class FormUI
    Private Sub FormUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetVariableDesignList()
        GetListColor()
    End Sub

    Sub GetListColor()
        ComboBoxColor.DrawMode = DrawMode.OwnerDrawFixed
        ComboBoxColor.ItemHeight = 21
        Dim colType As Type = GetType(System.Drawing.Color)
        For Each prop As PropertyInfo In colType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                ComboBoxColor.Items.Add(prop.Name)
            End If
        Next
    End Sub

    Private Sub ComboBoxColor_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBoxColor.DrawItem
        If e.Index = -1 Then
            Exit Sub
        End If
        Dim colBrush As Brush = New SolidBrush(Color.FromName(DirectCast(ComboBoxColor.Items(e.Index), String)))
        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(colBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)
        e.Graphics.DrawString(DirectCast(ComboBoxColor.Items(e.Index), String), ComboBoxColor.Font, Brushes.Black, 35, e.Bounds.Top + 2)
    End Sub
    Dim varType As Type
    Sub GetVariableDesignList()
        varType = GetType(DesignColor)
        For Each fi As System.Reflection.FieldInfo In varType.GetFields()
            ComboBoxVarDesignName.Items.Add(fi.Name)
        Next
    End Sub

    Private Sub ButtonSetUp_Click(sender As Object, e As EventArgs) Handles ButtonSetUp.Click
        If ComboBoxColor.SelectedIndex >= 0 And ComboBoxVarDesignName.SelectedIndex >= 0 Then
            Dim ColorSelected = Color.FromName(DirectCast(ComboBoxColor.Items(ComboBoxColor.SelectedIndex), String))
            Dim var = varType.GetFields()(ComboBoxVarDesignName.SelectedIndex)
            var.SetValue(Color.Transparent, ColorSelected)
            My.Settings.Item(var.Name) = ColorSelected
            My.Settings.Save()
            FormMain.SetDesignMainForm()
        Else
            MsgBox("Please Select Design and Color")
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Dim result As Integer = MessageBox.Show("Reset UI Color", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ResetDesignColor()
        End If
    End Sub

    Sub ResetDesignColor()
        Dim varType As Type = GetType(DesignColorReset)
        For Each fi As System.Reflection.FieldInfo In varType.GetFields()
            My.Settings.Item(fi.Name) = fi.GetValue(Color.Transparent)
        Next
        My.Settings.Save()
        SetDesignColor()
        FormMain.SetDesignMainForm()
    End Sub

    Sub SetDesignColor()
        Dim varType As Type = GetType(DesignColor)
        For Each fi As System.Reflection.FieldInfo In varType.GetFields()
            fi.SetValue(Color.Transparent, My.Settings.Item(fi.Name))
        Next
    End Sub
End Class