Public Class FormRoleGroup
    Dim Table As DataTable
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        FormMain.TabControlForm.Controls.RemoveByKey(Me.Name)
    End Sub

    Public Sub showDataGridView(ByVal txtSearch As String)
        Dim query As String = "
select a.id,a.name,a.remark,isView,isAdd,isEdit,isDelete,isPrint,isCustom,AccessView,AccessAdd,AccessEdit,AccessDelete,AccessPrint,AccessCustom from Roles a left join (select * from  RoleGroupLevel where id_group_level=" + TextBoxGroupLevel.Tag.ToString() + ") b on a.id =b.id_role where name like '%" & txtSearch & "%' or remark like '%" & txtSearch & "%' order by a.remark,a.name"
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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
        End With
        For i As Integer = 0 To Table.Rows.Count - 1
            dgv.Rows.Add(Table.Rows(i).Item(0), Table.Rows(i).Item(1), Table.Rows(i).Item(2), Table.Rows(i).Item(3), Table.Rows(i).Item(4), Table.Rows(i).Item(5), Table.Rows(i).Item(6), Table.Rows(i).Item(7), Table.Rows(i).Item(8), Table.Rows(i).Item(9), Table.Rows(i).Item(10), Table.Rows(i).Item(11), Table.Rows(i).Item(12), Table.Rows(i).Item(13), Table.Rows(i).Item(14))
        Next
    End Sub

    Sub Reload()
        dgv.Rows.Clear()
        TextBoxSearch.Clear()
        showDataGridView("")
    End Sub

    Private Sub ComboBoxGroupLevel_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Dim ctr = 0
    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            For i = ctr To dgv.Rows.Count - 1 Step 1
                With dgv.Rows(i)
                    ctr = i + 1
                    If .Cells("Role").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Or .Cells("remark").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Then
                        dgv.Rows(i).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = i
                        Exit Sub
                    End If
                End With
            Next
            ctr = 0
        End If
    End Sub
    Private Sub dgv_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv.CellPainting
        Try
            If dgv.Rows.Count = 0 Then Exit Sub
            If dgv.Columns(e.ColumnIndex).DataPropertyName = "Access" Then
                Dim colname = dgv.Columns(e.ColumnIndex).Name.Replace("Is", "Access")
                If Not IIf(IsDBNull(dgv.Rows(e.RowIndex).Cells(colname).Value), False, dgv.Rows(e.RowIndex).Cells(colname).Value) Then
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
                    e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)
                    e.PaintBackground(e.CellBounds, False)
                    e.Handled = True
                Else
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        With dgv.Rows(e.RowIndex)
            Dim Exist As Boolean = getDataTable("select count(id) from RoleGroupLevel where id_group_level = " & TextBoxGroupLevel.Tag & " and id_role = " & .Cells("ID").Value).Rows(0).Item(0) > 0
            If Exist Then
                ExecuteQuery("update RoleGroupLevel set [isView] = '" & .Cells("IsView").Value & "' ,[isAdd] = '" & .Cells("isAdd").Value & "',[isEdit] = '" & .Cells("isEdit").Value & "',[isDelete] = '" & .Cells("isDelete").Value & "',[isPrint] = '" & .Cells("isPrint").Value & "',[isCustom] = '" & .Cells("isCustom").Value & "' where id_group_level = '" & TextBoxGroupLevel.Tag & "' and id_role = '" & .Cells("ID").Value & "'")
            Else
                ExecuteQuery("insert into RoleGroupLevel (id_group_level,id_role,[isView],[isAdd],[isEdit],[isDelete],[isPrint],[isCustom]) values('" & TextBoxGroupLevel.Tag & "','" & .Cells("ID").Value & "','" & .Cells("IsView").Value & "','" & .Cells("IsView").Value & "','" & .Cells("IsAdd").Value & "','" & .Cells("IsEdit").Value & "','" & .Cells("IsDelete").Value & "','" & .Cells("IsCustom").Value & "')")
            End If
        End With
    End Sub

    Private Sub TextBoxGroupLevel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGroupLevel.TextChanged
        dgv.Rows.Clear()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub

End Class