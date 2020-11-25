Public Class FormErrorReport
    Private Sub FormLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowNavPageData()
    End Sub

    Sub ShowNavPageData()
        dgv.DataSource = Nothing
        Dim query As String = "select top (select convert(int, ceiliNG(count(*)/ (convert(float," & ComboBoxEntries.Text & "))))from ErrorReport a left join Users b on a.UserId =b.ID) a.id from ErrorReport a left join Users b on a.UserId =b.ID  where (convert(date,[Datetime])>='" & DateTimePickerStart.Value.ToString("yyyy-MM-dd") & "' and convert(date,[Datetime]) <= '" & DateTimePickerUntil.Value.ToString("yyyy-MM-dd") & "') and (a.Action like '%" & TextBoxSearch.Text & "%' or a.MsgError like '%" & TextBoxSearch.Text & "%'  or a.Note like '%" & TextBoxSearch.Text & "%' or b.name like '%" & TextBoxSearch.Text & "%' )"
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
        Dim query As String = "select  a.Id,a.Action,a.MsgError,a.Datetime,a.Note,concat(b.userid,'-',b.name) as [User] from ErrorReport a left join Users b on a.UserId =b.ID where (convert(date,[Datetime])>='" & DateTimePickerStart.Value.ToString("yyyy-MM-dd") & "' and convert(date,[Datetime]) <= '" & DateTimePickerUntil.Value.ToString("yyyy-MM-dd") & "') and (a.Action like '%" & TextBoxSearch.Text & "%' or a.MsgError like '%" & TextBoxSearch.Text & "%'  or a.Note like '%" & TextBoxSearch.Text & "%' or b.name like '%" & TextBoxSearch.Text & "%' ) order by a.Id desc OFFSET " & BindingSourcePaging.Position & " ROWS FETCH NEXT " & ComboBoxEntries.Text & " ROWS ONLY;"
        dgv.DataSource = getDataTable(query)
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click
        ShowNavPageData()
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