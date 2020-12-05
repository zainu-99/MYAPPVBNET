Public Class FormUserGroup
    Dim Table As DataTable
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        FormMain.TabControlForm.Controls.RemoveByKey(Me.Name)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub

    Sub Reload()
        dgv.Rows.Clear()
        showDataGridView("")
    End Sub


    Public Sub showDataGridView(ByVal txtSearch As String)
        Dim query As String = "select a.id,CONCAT(d.name,' - ',a.remark) as [group],CONCAT(f.name,' - ',e.remark)as parent,a.remark,a.id_parent,IIF((select id_user from UserGroupLevel where id_user ='" & TextBoxUser.Tag & "' and id_group_level = b.id_group_level) is null,0,1) as IsJoin from GroupLevel a left join (select * from UserGroupLevel where id_user='" & TextBoxUser.Tag & "') b on a.id = b.id_group_level left join  Groups as d on a.id_group = d.id left join GroupLevel as e on a.id_parent =e.id left join Groups as f on e.id_group = f.id"
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Table = getDataTable(query)
        GetGroupLevel(Table, "id_parent is Null", "")
        With dgv
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
    End Sub
    Sub GetGroupLevel(DT As DataTable, filter As String, ByVal levelTag As String)
        For Each dtrow As DataRow In DT.Select(filter)
            AddToDgv(dtrow, levelTag & "➧ ")
            GetGroupLevel(DT, "id_parent = " & dtrow.Item(0), levelTag & "        ")
        Next
    End Sub
    Sub AddToDgv(ByVal dr As DataRow, ByVal levelTag As String)
        dgv.Rows.Add(dr.Item(0), levelTag & dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(5))
    End Sub


    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If TextBoxUser.Tag <> Nothing Then
            If e.RowIndex >= 0 And e.ColumnIndex = 4 Then
                If dgv.Rows(e.RowIndex).Cells(4).Value = 0 Then
                    ExecuteQuery("insert into UserGroupLevel (id_user, id_group_level) values('" & TextBoxUser.Tag & "','" & dgv.Rows(e.RowIndex).Cells(0).Value & "')")
                    dgv.Rows(e.RowIndex).Cells(4).Value = 1
                Else
                    ExecuteQuery("delete from UserGroupLevel where id_user = '" & TextBoxUser.Tag & "' and id_group_level = '" & dgv.Rows(e.RowIndex).Cells(0).Value & "'")
                    dgv.Rows(e.RowIndex).Cells(4).Value = 0
                End If
            End If
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub TextBoxUser_Click(sender As Object, e As EventArgs) Handles TextBoxUser.Click
        'FormUserDataPopUp.SetPassingTextBox(TextBoxUser)
        'FormUserDataPopUp.ShowDialog()
    End Sub

    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged
        If Table IsNot Nothing Then
            Reload()
        End If
    End Sub
End Class