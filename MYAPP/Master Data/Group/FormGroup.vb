Public Class FormGroup
    Dim id_group = ""
    Private Sub ButtonGroupLevel_Click(sender As Object, e As EventArgs) Handles ButtonGroupLevel.Click
        FormMain.fillFormToPanel(FormGroupLevel)
        Dim form As FormGroupLevel = DirectCast(FormMain.GetFormInTabControl(FormGroupLevel.Name), FormGroupLevel)
        form.ComboBoxGroup.SelectedValue = dgv.CurrentRow.Cells(0).Value
        form.ComboBoxGroup.Text = dgv.CurrentRow.Cells(1).Value & " - " & dgv.CurrentRow.Cells(2).Value
    End Sub


    Private Sub FormGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Sub Reload()
        GroupBoxInputData.Enabled = False
        ButtonGroupLevel.Enabled = False
        ShowNavPageData()
        TextBoxGroup.Text = ""
        TextBoxRemark.Text = ""
        id_group = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = False
    End Sub
    Sub ShowNavPageData()
        dgv.DataSource = Nothing
        Dim query As String = "select top (select convert(int, ceiliNG(count(*)/ (convert(float," & ComboBoxEntries.Text & ")))) from Groups) id from Groups where name like '%" & TextBoxSearch.Text & "%'"
        BindingSourcePaging.DataSource = getDataTable(query)
        BindingNavigatorPaging.BindingSource = BindingSourcePaging
        If BindingSourcePaging.Position >= 0 Then
            showDataGridView()
        End If
    End Sub
    Public Sub showDataGridView()
        Dim query As String = "select * from Groups where name like '%" & TextBoxSearch.Text & "%' order by id desc OFFSET " & BindingSourcePaging.Position & " ROWS FETCH NEXT " & ComboBoxEntries.Text & " ROWS ONLY;"
        dgv.DataSource = getDataTable(query)
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "Group"
            .Columns(2).HeaderCell.Value = "remark"
            .Columns(3).HeaderCell.Value = "Created At"
            .Columns(4).HeaderCell.Value = "Update At"
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Private Sub BindingSourcePaging_PositionChanged(sender As Object, e As EventArgs) Handles BindingSourcePaging.PositionChanged
        If BindingSourcePaging.Count > 0 Then
            showDataGridView()
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        GroupBoxInputData.Enabled = True
        ButtonGroupLevel.Enabled = False
        TextBoxGroup.Text = ""
        TextBoxRemark.Text = ""
        id_group = ""
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
            ExecuteQuery("insert into Groups (name,remark,created_at) 
            values(
                '" & ReplaceStrQuote(TextBoxGroup.Text) & "',
                '" & ReplaceStrQuote(TextBoxRemark.Text) & "',
                '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "'
            )")
        Else
            ExecuteQuery("update groups set name='" & ReplaceStrQuote(TextBoxGroup.Text) & "',remark='" & ReplaceStrQuote(TextBoxRemark.Text) & "',updated_at ='" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "' where id = '" & id_group & "'")
        End If
        Reload()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        GroupBoxInputData.Enabled = False
        ButtonGroupLevel.Enabled = True
        id_group = dgv.CurrentRow.Cells(0).Value
        TextBoxGroup.Text = dgv.CurrentRow.Cells(1).Value
        TextBoxRemark.Text = dgv.CurrentRow.Cells(2).Value
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As Integer = MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ExecuteQuery("delete from groups where id = '" & id_group & "'")
            Reload()
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub


    Private Sub ComboBoxEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEntries.SelectedIndexChanged
        ShowNavPageData()
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        ShowNavPageData()
    End Sub

    Private Sub ComboBoxEntries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxEntries.KeyPress
        e.Handled = True
    End Sub


End Class