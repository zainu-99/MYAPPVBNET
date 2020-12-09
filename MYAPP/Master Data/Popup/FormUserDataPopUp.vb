Public Class FormUserDataPopUp

    Private tb As TextBox
    Private Sub FormUserDataPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowNavPageData()
    End Sub
    Public Sub showDataGridView()
        Dim query As String = "select id,userid,name,nohp,email,address,status,gender,created_at,updated_at,password_noencrypt from users where name like '%" & TextBoxSearch.Text & "%' order by id desc OFFSET " & BindingSourcePaging.Position + CInt(ComboBoxEntries.Text) & " ROWS FETCH NEXT " & ComboBoxEntries.Text & " ROWS ONLY;"
        dgv.DataSource = getDataTable(query)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "User Id"
            .Columns(2).HeaderCell.Value = "Name"
            .Columns(3).HeaderCell.Value = "No HP"
            .Columns(4).HeaderCell.Value = "Email"
            .Columns(5).HeaderCell.Value = "Address"
            .Columns(6).HeaderCell.Value = "Status"
            .Columns(7).HeaderCell.Value = "Gender"
            .Columns(8).HeaderCell.Value = "Created At"
            .Columns(9).HeaderCell.Value = "Update At"
            .Columns(10).Visible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Sub ShowNavPageData()
        dgv.DataSource = Nothing
        Dim query As String = "select top (select convert(int, ceiliNG(count(*)/ (convert(float," & ComboBoxEntries.Text & ")))) from Users) id from Users where name like '%" & TextBoxSearch.Text & "%'"
        BindingSourcePaging.DataSource = getDataTable(query)
        BindingNavigatorPaging.BindingSource = BindingSourcePaging
        If BindingSourcePaging.Position >= 0 Then
            showDataGridView()
        End If
    End Sub

    Private Sub BindingSourcePaging_PositionChanged(sender As Object, e As EventArgs) Handles BindingSourcePaging.PositionChanged

    End Sub

    Sub SetPassingTextBox(ByRef tb As TextBox)
        Me.tb = tb
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

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        tb.Tag = dgv.CurrentRow.Cells(0).Value
        tb.Text = dgv.CurrentRow.Cells(1).Value & " - " & dgv.CurrentRow.Cells(2).Value
        Close()
    End Sub
End Class