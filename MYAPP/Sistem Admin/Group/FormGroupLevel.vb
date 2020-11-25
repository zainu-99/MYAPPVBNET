Public Class FormGroupLevel
    Dim id_group_level = -1
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        FormMain.TabControlForm.Controls.RemoveByKey(Me.Name)
    End Sub

    Sub ShowGroup()
        Dim query As String = "select id,concat(name,' - ',remark) as info from Groups"
        ComboBoxGroup.DataSource = getDataTable(query)
        ComboBoxGroup.ValueMember = "id"
        ComboBoxGroup.DisplayMember = "info"
    End Sub
    Sub ShowGroupLevel()
        Dim query As String = "select '' as id,'No Parent' as info union all select a.id,concat(b.name,' - ',a.remark) as info from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent  where a.ID <> " & id_group_level & " and (a.id_parent is null or a.id_parent <> " & id_group_level & ")"
        ComboBoxParentGroup.DataSource = getDataTable(query)
        ComboBoxParentGroup.ValueMember = "id"
        ComboBoxParentGroup.DisplayMember = "info"
    End Sub

    Private Sub FormGroupLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub


    Sub Reload()
        ShowGroup()
        ShowGroupLevel()
        GroupBoxInputData.Enabled = False
        ButtonRoleGroup.Enabled = False
        showDataGridView("")
        TextBoxRemark.Text = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = False
    End Sub
    Public Sub showDataGridView(ByVal txtSearch As String)
        Dim query As String = "select a.id,b.name,a.remark,concat(d.name,' - ',c.remark) as parent,a.id_group,a.id_parent from GroupLevel as a left join Groups as b on b.id = a.id_group left join GroupLevel c on c.id = a.id_parent left join Groups as d on c.id_group=d.id where a.remark like '%" & txtSearch & "%' order by b.name"
        Dim dt = getDataTable(query)
        dgv.Rows.Clear()
        GetGroupLevel(dt, " is Null", "")
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            '.Columns(0).Visible = False
            '.Columns(1).HeaderCell.Value = "Group"
            '.Columns(2).HeaderCell.Value = "remark"
            '.Columns(3).HeaderCell.Value = "Parent"
            '.Columns(4).Visible = False
            '.Columns(5).Visible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Sub GetGroupLevel(DT As DataTable, idParent As String, ByVal levelTag As String)
        For Each dtrow As DataRow In DT.Select("id_parent  " & idParent)
            AddToDgv(dtrow, levelTag & "* ")
            If DT.Select("id_parent = " & dtrow.Item(0)).Count > 0 Then
                GetGroupLevel(DT, "= " & dtrow.Item(0), levelTag & "-----")
            End If
        Next
    End Sub

    Sub AddToDgv(ByVal dr As DataRow, ByVal levelTag As String)
        dgv.Rows.Add(dr.Item(0), levelTag & dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5))
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        GroupBoxInputData.Enabled = True
        showDataGridView("")
        TextBoxRemark.Text = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
        ButtonRoleGroup.Enabled = False
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        GroupBoxInputData.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If ButtonEdit.Enabled = False Then
            If ComboBoxParentGroup.Text <> "No Parent" Then
                ExecuteQuery("insert into GroupLevel (id_group,id_parent,remark) values('" & ReplaceStrQuote(ComboBoxGroup.SelectedValue) & "','" & ReplaceStrQuote(ComboBoxParentGroup.SelectedValue) & "','" & ReplaceStrQuote(TextBoxRemark.Text) & "')")
            Else
                ExecuteQuery("insert into GroupLevel (id_group,remark) values('" & ReplaceStrQuote(ComboBoxGroup.SelectedValue) & "','" & ReplaceStrQuote(TextBoxRemark.Text) & "')")
            End If
        Else
            If ComboBoxParentGroup.Text <> "No Parent" Then
                ExecuteQuery("update GroupLevel set id_group='" & ReplaceStrQuote(ComboBoxGroup.SelectedValue) & "',id_parent='" & ReplaceStrQuote(ComboBoxParentGroup.SelectedValue) & "',remark ='" & ReplaceStrQuote(TextBoxRemark.Text) & "' where id = '" & id_group_level & "'")
            Else
                ExecuteQuery("update GroupLevel set id_group='" & ReplaceStrQuote(ComboBoxGroup.SelectedValue) & "',id_parent=null,remark ='" & ReplaceStrQuote(TextBoxRemark.Text) & "' where id = '" & id_group_level & "'")
            End If
        End If
        Reload()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        GroupBoxInputData.Enabled = False
        id_group_level = dgv.CurrentRow.Cells(0).Value
        TextBoxRemark.Text = dgv.CurrentRow.Cells(2).Value
        ComboBoxGroup.SelectedValue = dgv.CurrentRow.Cells(4).Value
        ShowGroupLevel()
        ComboBoxParentGroup.SelectedValue = dgv.CurrentRow.Cells(5).Value
        If ComboBoxParentGroup.Text = "" Then
            ComboBoxParentGroup.Text = "No Parent"
        End If
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
        ButtonRoleGroup.Enabled = True
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As Integer = MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ExecuteQuery("delete from GroupLevel where id = '" & id_group_level & "'")
            Reload()
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub



    Private Sub ComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxParentGroup.KeyPress, ComboBoxGroup.KeyPress
        e.Handled = True
    End Sub

    Private Sub ButtonRoleGroup_Click(sender As Object, e As EventArgs) Handles ButtonRoleGroup.Click
        FormMain.fillFormToPanel(FormRoleGroup)
        Dim form As FormRoleGroup = DirectCast(FormMain.GetFormInTabControl(FormRoleGroup.Name), FormRoleGroup)
        If form IsNot Nothing Then form.ComboBoxGroupLevel.SelectedValue = dgv.CurrentRow.Cells(0).Value
    End Sub

    Dim ctr = 0
    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            For i = ctr To dgv.Rows.Count - 1 Step 1
                With dgv.Rows(i)
                    ctr = i + 1
                    If .Cells("Group").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Or .Cells("remark").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Or .Cells("Parent").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Then
                        dgv.Rows(i).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = i
                        Exit Sub
                    End If
                End With
            Next
            ctr = 0
        End If
    End Sub
End Class