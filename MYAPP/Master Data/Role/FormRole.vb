Public Class FormRole
    Dim id_role = ""
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Sub Reload()
        GroupBoxInputData.Enabled = False
        ShowNavPageData()
        TextBoxRole.Text = ""
        TextBoxRemark.Text = ""
        id_role = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = False
    End Sub

    Sub ShowNavPageData()
        dgv.DataSource = Nothing
        Dim query As String = "select top (select convert(int, ceiliNG(count(*)/ (convert(float," & ComboBoxEntries.Text & ")))) from Roles) id from Roles where name like '%" & TextBoxSearch.Text & "%'"
        BindingSourcePaging.DataSource = getDataTable(query)
        BindingNavigatorPaging.BindingSource = BindingSourcePaging
        If BindingSourcePaging.Position >= 0 Then
            showDataGridView()
        End If
    End Sub

    Private Sub BindingSourcePaging_PositionChanged(sender As Object, e As EventArgs) Handles BindingSourcePaging.PositionChanged
        If BindingSourcePaging.Count > 0 Then
            showDataGridView()
        End If
    End Sub
    Public Sub showDataGridView()
        Dim query As String = "select * from Roles where name like '%" & TextBoxSearch.Text & "%'  order by remark asc OFFSET " & BindingSourcePaging.Position & " ROWS FETCH NEXT " & ComboBoxEntries.Text & " ROWS ONLY;"
        dgv.DataSource = getDataTable(query)
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        With dgv
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "Role"
            .Columns(2).HeaderCell.Value = "remark"
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        GroupBoxInputData.Enabled = True
        ShowNavPageData()
        TextBoxRole.Text = ""
        TextBoxRemark.Text = ""
        id_role = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        GroupBoxInputData.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If ButtonEdit.Enabled = False Then
            If Not ExecuteQuery("insert into Roles (name,remark,AccessView,AccessAdd,AccessEdit,AccessDelete,AccessPrint,AccessCustom) 
            values(
                '" & ReplaceStrQuote(TextBoxRole.Text) & "',
                '" & ReplaceStrQuote(TextBoxRemark.Text) & "',
                '" & CheckBoxView.Checked & "',
                '" & CheckBoxAdd.Checked & "',
                '" & CheckBoxEdit.Checked & "',
                '" & CheckBoxDelete.Checked & "',
                '" & CheckBoxPrint.Checked & "',
                '" & CheckBoxCustom.Checked & "'
            )").success Then
                MsgBox("Role Name Must Be Unique")
            End If
        Else
            If Not ExecuteQuery("update Roles set name='" & ReplaceStrQuote(TextBoxRole.Text) & "',remark='" & ReplaceStrQuote(TextBoxRemark.Text) & "',AccessView = '" & CheckBoxView.Checked & "',AccessAdd = '" & CheckBoxAdd.Checked & "',AccessEdit = '" & CheckBoxEdit.Checked & "',AccessDelete = '" & CheckBoxDelete.Checked & "',AccessPrint = '" & CheckBoxPrint.Checked & "',AccessCustom = '" & CheckBoxCustom.Checked & "' where id = '" & id_role & "'").success Then
                MsgBox("Role Name Must Be Unique")
            End If
        End If
        Reload()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        GroupBoxInputData.Enabled = False
        id_role = dgv.CurrentRow.Cells(0).Value
        TextBoxRole.Text = dgv.CurrentRow.Cells(1).Value
        TextBoxRemark.Text = dgv.CurrentRow.Cells(2).Value

        CheckBoxView.Checked = IIf(IsDBNull(dgv.CurrentRow.Cells("AccessView").Value), False, dgv.CurrentRow.Cells("AccessView").Value)
        CheckBoxAdd.Checked = IIf(IsDBNull(dgv.CurrentRow.Cells("AccessAdd").Value), False, dgv.CurrentRow.Cells("AccessAdd").Value)
        CheckBoxEdit.Checked = IIf(IsDBNull(dgv.CurrentRow.Cells("AccessEdit").Value), False, dgv.CurrentRow.Cells("AccessEdit").Value)
        CheckBoxDelete.Checked = IIf(IsDBNull(dgv.CurrentRow.Cells("AccessDelete").Value), False, dgv.CurrentRow.Cells("AccessDelete").Value)
        CheckBoxPrint.Checked = IIf(IsDBNull(dgv.CurrentRow.Cells("AccessPrint").Value), False, dgv.CurrentRow.Cells("AccessPrint").Value)
        CheckBoxCustom.Checked = IIf(IsDBNull(dgv.CurrentRow.Cells("AccessCustom").Value), False, dgv.CurrentRow.Cells("AccessCustom").Value)

        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As Integer = MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ExecuteQuery("delete from Roles where id = '" & id_role & "'")
            Reload()
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub

    Private Sub ComboBoxEntries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxEntries.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBoxEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEntries.SelectedIndexChanged
        ShowNavPageData()
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        ShowNavPageData()
    End Sub
End Class