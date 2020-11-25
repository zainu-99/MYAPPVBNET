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
        Dim query As String = "select a.id,CONCAT(d.name,' - ',a.remark) as [group],CONCAT(f.name,' - ',e.remark)as parent,a.remark,IIF((select id_user from UserGroupLevel where id_user ='" & TextBoxUser.Tag & "' and id_group_level = b.id_group_level) is null,0,1) as IsJoin from GroupLevel a left join (select * from UserGroupLevel where id_user='" & TextBoxUser.Tag & "') b on a.id = b.id_group_level left join  Groups as d on a.id_group = d.id left join GroupLevel as e on a.id_parent =e.id left join Groups as f on e.id_group = f.id"
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Table = getDataTable(query)
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
        For i As Integer = 0 To Table.Rows.Count - 1
            dgv.Rows.Add(Table.Rows(i).Item(0), Table.Rows(i).Item(1), Table.Rows(i).Item(2), Table.Rows(i).Item(3), Table.Rows(i).Item(4))
        Next
    End Sub


    Private Sub FormUserGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If TextBoxUser.Tag <> Nothing Then
            If e.RowIndex >= 0 And e.ColumnIndex = 4 Then
                If dgv.Rows(e.RowIndex).Cells(4).Value = 0 Then
                    ExecuteQuery("insert into UserGroupLevel (id_user,id_group_level) values('" & TextBoxUser.Tag & "','" & dgv.Rows(e.RowIndex).Cells(0).Value & "')")
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
        FormUserDataPopUp.SetPassingTextBox(TextBoxUser)
        FormUserDataPopUp.ShowDialog()
    End Sub

    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged
        If Table IsNot Nothing Then
            dgv.Rows.Clear()
            showDataGridView("")
        End If
    End Sub
End Class