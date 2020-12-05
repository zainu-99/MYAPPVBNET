Public Class FormUserRole
    Dim Table As DataTable
    Private Sub FormUserRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDataGridView()
    End Sub


    Sub ShowGroupLevel()
        Dim query As String = "select a.*,concat(b.name,' - ',a.remark) as info from GroupLevel as a left join Groups as b on a.id_group = b.id left join UserGroupLevel c on a.id =c.id_group_level where c.id_user ='" & TextBoxUser.Tag.ToString & "'"
        ComboBoxGroupLevel.DataSource = getDataTable(query)
        ComboBoxGroupLevel.ValueMember = "id"
        ComboBoxGroupLevel.DisplayMember = "info"
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click
        If ComboBoxGroupLevel.Items.Count > 0 Then
            dgv.Rows.Clear()
            showDataGridView()
        Else
            MsgBox("Please Select Group Level")
        End If
    End Sub

    Public Sub showDataGridView()
        Dim query As String = "select a.id,a.name,a.remark,iif((select id from UserRole where id_role = a.id and id_user = '" & TextBoxUser.Tag & "' and allow_view= 1) is null,0,1) as allow_view,iif((select id from UserRole where id_role = a.id and id_user = '" & TextBoxUser.Tag & "' and allow_add= 1) is null,0,1) as allow_add,iif((select id from UserRole where id_role = a.id and id_user = '" & TextBoxUser.Tag & "' and allow_update= 1) is null,0,1) as allow_update,iif((select id from UserRole where id_role = a.id and id_user = '" & TextBoxUser.Tag & "' and allow_delete= 1) is null,0,1) as allow_delete,iif((select id from UserRole where id_role = a.id and id_user = '" & TextBoxUser.Tag & "' and allow_print= 1) is null,0,1) as allow_print,allow_custom_access,d.isView,d.isAdd,d.isEdit,d.isDelete,d.isPrint,d.isCustom from Roles a left join (select * from UserRole where id_user=" & TextBoxUser.Tag & ") b on a.id = b.id_role left join Users c on b.id_user = c.id left join RoleGroupLevel d on a.id =d.id_role where d.id_group_level ='" & ComboBoxGroupLevel.SelectedValue & "' and 1 in (d.isView,d.isAdd,d.isEdit,d.isDelete,d.isPrint,d.isCustom) order by a.remark,a.name"
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Table = getDataTable(query)
        With dgv
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
        CheckBoxAllView.Checked = True
        CheckBoxAllAdd.Checked = True
        CheckBoxAllEdit.Checked = True
        CheckBoxAllDelete.Checked = True
        CheckBoxAllPrint.Checked = True
        For i As Integer = 0 To Table.Rows.Count - 1
            dgv.Rows.Add(Table.Rows(i).Item(0), Table.Rows(i).Item(1), Table.Rows(i).Item(2), Table.Rows(i).Item(3), Table.Rows(i).Item(4), Table.Rows(i).Item(5), Table.Rows(i).Item(6), Table.Rows(i).Item(7), Table.Rows(i).Item(8), Table.Rows(i).Item(9), Table.Rows(i).Item(10), Table.Rows(i).Item(11), Table.Rows(i).Item(12), Table.Rows(i).Item(13), Table.Rows(i).Item(14))
            If Table.Rows(i).Item(3) = 0 And CheckBoxAllView.Checked And Not dgv.Rows(i).Cells(3).Tag = "Disable" Then
                CheckBoxAllView.Checked = False
            End If
            If Table.Rows(i).Item(4) = 0 And CheckBoxAllAdd.Checked And Not dgv.Rows(i).Cells(4).Tag = "Disable" Then
                CheckBoxAllAdd.Checked = False
            End If
            If Table.Rows(i).Item(5) = 0 And CheckBoxAllEdit.Checked And Not dgv.Rows(i).Cells(5).Tag = "Disable" Then
                CheckBoxAllEdit.Checked = False
            End If
            If Table.Rows(i).Item(6) = 0 And CheckBoxAllDelete.Checked And Not dgv.Rows(i).Cells(6).Tag = "Disable" Then
                CheckBoxAllDelete.Checked = False
            End If
            If Table.Rows(i).Item(7) = 0 And CheckBoxAllPrint.Checked And Not dgv.Rows(i).Cells(7).Tag = "Disable" Then
                CheckBoxAllPrint.Checked = False
            End If
        Next
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If TextBoxUser.Tag <> 0 Then
            If e.RowIndex >= 0 And e.ColumnIndex <> 0 And e.ColumnIndex > 2 And e.ColumnIndex <> 8 Then
                If dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0 Then
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1
                Else
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                End If
                CheckedCheckBox(e.RowIndex)
                CheckBoxAllView.Checked = True
                CheckBoxAllAdd.Checked = True
                CheckBoxAllEdit.Checked = True
                CheckBoxAllDelete.Checked = True
                CheckBoxAllPrint.Checked = True
                For Each row As DataGridViewRow In dgv.Rows()
                    If row.Cells(3).Value = 0 And CheckBoxAllView.Checked And Not row.Cells(3).Tag = "Disable" Then
                        CheckBoxAllView.Checked = False
                    End If
                    If row.Cells(4).Value = 0 And CheckBoxAllAdd.Checked And Not row.Cells(4).Tag = "Disable" Then
                        CheckBoxAllAdd.Checked = False
                    End If
                    If row.Cells(5).Value = 0 And CheckBoxAllEdit.Checked And Not row.Cells(5).Tag = "Disable" Then
                        CheckBoxAllEdit.Checked = False
                    End If
                    If row.Cells(6).Value = 0 And CheckBoxAllDelete.Checked And Not row.Cells(6).Tag = "Disable" Then
                        CheckBoxAllDelete.Checked = False
                    End If
                    If row.Cells(7).Value = 0 And CheckBoxAllPrint.Checked And Not row.Cells(7).Tag = "Disable" Then
                        CheckBoxAllPrint.Checked = False
                    End If
                Next
            ElseIf e.ColumnIndex = 8 Then


            End If
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Sub CheckedCheckBox(e As Int32)
        Dim check = getDataTable("select * from UserRole where id_user ='" & TextBoxUser.Tag & "' and id_role='" & dgv.Rows(e).Cells(0).Value & "'")
        If check.Rows.Count = 0 Then
            ExecuteQuery("insert into UserRole (id_user,id_role,allow_view,allow_add,allow_update,allow_delete,allow_print,allow_custom_access) values('" & TextBoxUser.Tag & "','" & dgv.Rows(e).Cells(0).Value & "','" & dgv.Rows(e).Cells(3).Value & "','" & dgv.Rows(e).Cells(4).Value & "','" & dgv.Rows(e).Cells(5).Value & "','" & dgv.Rows(e).Cells(6).Value & "','" & dgv.Rows(e).Cells(7).Value & "','" & dgv.Rows(e).Cells(8).Value & "')")
        Else
            ExecuteQuery("update UserRole set allow_view='" & dgv.Rows(e).Cells(3).Value & "', allow_add='" & dgv.Rows(e).Cells(4).Value & "',allow_update='" & dgv.Rows(e).Cells(5).Value & "',allow_delete='" & dgv.Rows(e).Cells(6).Value & "',allow_print='" & dgv.Rows(e).Cells(7).Value & "',allow_custom_access='" & dgv.Rows(e).Cells(8).Value & "' where id_user='" & TextBoxUser.Tag & "' and id_role='" & dgv.Rows(e).Cells(0).Value & "'")
        End If
    End Sub
    Dim ctr = 0
    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            For i = ctr To dgv.Rows.Count - 1 Step 1
                With dgv.Rows(i)
                    ctr = i + 1
                    If .Cells("Role").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Or .Cells("Remark").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Then
                        dgv.Rows(i).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = i
                        Exit Sub
                    End If
                End With
            Next
            ctr = 0
        End If
    End Sub
    Private Sub CheckBoxAllView_Click(sender As Object, e As EventArgs) Handles CheckBoxAllView.Click
        If TextBoxUser.Tag <> 0 Then
            Dim ctr = 0
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.Cells(3).Tag = "Disable" Then
                    row.Cells(3).Value = IIf(CheckBoxAllView.Checked, 1, 0)
                End If
                CheckedCheckBox(ctr)
                    ctr += 1
            Next
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub CheckBoxAllAdd_Click(sender As Object, e As EventArgs) Handles CheckBoxAllAdd.Click
        If TextBoxUser.Tag <> 0 Then
            Dim ctr = 0
            For Each row In dgv.Rows
                If Not row.Cells(3).Tag = "Disable" Then
                    row.Cells(4).Value = IIf(CheckBoxAllAdd.Checked, 1, 0)
                End If
                CheckedCheckBox(ctr)
                ctr += 1
            Next
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub CheckBoxAllEdit_Click(sender As Object, e As EventArgs) Handles CheckBoxAllEdit.Click
        If TextBoxUser.Tag <> 0 Then
            Dim ctr = 0
            For Each row In dgv.Rows
                If Not row.Cells(3).Tag = "Disable" Then
                    row.Cells(5).Value = IIf(CheckBoxAllEdit.Checked, 1, 0)
                End If
                CheckedCheckBox(ctr)
                ctr += 1
            Next
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub CheckBoxAllDelete_Click(sender As Object, e As EventArgs) Handles CheckBoxAllDelete.Click
        If TextBoxUser.Tag <> 0 Then
            Dim ctr = 0
            For Each row In dgv.Rows
                If Not row.Cells(3).Tag = "Disable" Then
                    row.Cells(6).Value = IIf(CheckBoxAllDelete.Checked, 1, 0)
                End If
                CheckedCheckBox(ctr)
                ctr += 1
            Next
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub CheckBoxAllPrint_Click(sender As Object, e As EventArgs) Handles CheckBoxAllPrint.Click
        If TextBoxUser.Tag <> 0 Then
            Dim ctr = 0
            For Each row In dgv.Rows
                If Not row.Cells(3).Tag = "Disable" Then
                    row.Cells(7).Value = IIf(CheckBoxAllPrint.Checked, 1, 0)
                End If
                CheckedCheckBox(ctr)
                ctr += 1
            Next
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub TextBoxUser_Click(sender As Object, e As EventArgs) Handles TextBoxUser.Click
        'FormUserDataPopUp.SetPassingTextBox(TextBoxUser)
        'FormUserDataPopUp.ShowDialog()
    End Sub

    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged
        ComboBoxGroupLevel.Text = ""
        ShowGroupLevel()
        dgv.Rows.Clear()
    End Sub

    Private Sub ComboBoxGroupLevel_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxGroupLevel.SelectedValueChanged
        dgv.Rows.Clear()
    End Sub

    Private Sub dgv_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv.EditingControlShowing
        If TextBoxUser.Tag <> 0 Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf ColumnCustom_KeyPress
            RemoveHandler CType(e.Control, TextBox).Leave, AddressOf ColumnCustom_Leave
            If dgv.CurrentCell.ColumnIndex = 8 Then
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf ColumnCustom_KeyPress
                AddHandler CType(e.Control, TextBox).Leave, AddressOf ColumnCustom_Leave
            End If
        Else
            MsgBox("Please Select User")
        End If
    End Sub

    Private Sub ColumnCustom_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ColumnCustom_Leave(sender As Object, e As EventArgs)
        Dim check = getDataTable("select * from UserRole where id_user ='" & TextBoxUser.Tag & "' and id_role='" & dgv.CurrentRow.Cells(0).Value & "'")
        If check.Rows.Count = 0 Then
            ExecuteQuery("insert into UserRole (id_user,id_role,allow_view,allow_add,allow_update,allow_delete,allow_print,allow_custom_access) values('" & TextBoxUser.Tag & "','" & dgv.CurrentRow.Cells(0).Value & "','" & dgv.CurrentRow.Cells(3).Value & "','" & dgv.CurrentRow.Cells(4).Value & "','" & dgv.CurrentRow.Cells(5).Value & "','" & dgv.CurrentRow.Cells(6).Value & "','" & dgv.CurrentRow.Cells(7).Value & "','" & sender.Text & "')")
        Else
            ExecuteQuery("update UserRole set allow_view='" & dgv.CurrentRow.Cells(3).Value & "', allow_add='" & dgv.CurrentRow.Cells(4).Value & "',allow_update='" & dgv.CurrentRow.Cells(5).Value & "',allow_delete='" & dgv.CurrentRow.Cells(6).Value & "',allow_print='" & dgv.CurrentRow.Cells(7).Value & "',allow_custom_access='" & sender.Text & "' where id_user='" & TextBoxUser.Tag & "' and id_role='" & dgv.CurrentRow.Cells(0).Value & "'")
        End If
    End Sub

    Private Sub ComboBoxGroupLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxGroupLevel.KeyPress
        e.Handled = True
    End Sub

    Private Sub dgv_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv.CellPainting
        Try
            If dgv.Rows.Count = 0 Then Exit Sub
            If dgv.Columns(e.ColumnIndex).DataPropertyName = "Access" Then
                Dim colname = dgv.Columns(e.ColumnIndex).Name.Replace("Allow", "Access")
                If Not IIf(IsDBNull(dgv.Rows(e.RowIndex).Cells(colname).Value), False, dgv.Rows(e.RowIndex).Cells(colname).Value) Then
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag = "Disable"
                    e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)
                    e.PaintBackground(e.CellBounds, False)
                    e.Handled = True
                Else
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False
                    dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag = "Anable"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class