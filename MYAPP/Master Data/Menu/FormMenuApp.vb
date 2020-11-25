Imports System.IO

Public Class FormMenuApp
    Dim IdMenu = 0
    Sub ShowCBTag()
        ComboBoxTag.DataSource = getDataTable("select * from Roles order by name asc")
        ComboBoxTag.ValueMember = "name"
        ComboBoxTag.DisplayMember = "name"
    End Sub

    Sub ShowParentMenu()
        ComboBoxParentMenu.DataSource = getDataTable("select NULL as ID,'-No Parent-' as MenuText union all select ID,MenuText from MenuApp where ID <> " & IdMenu & " and (IDParentMenu is Null or IDParentMenu <> " & IdMenu & ") order by MenuText asc")
        ComboBoxParentMenu.ValueMember = "ID"
        ComboBoxParentMenu.DisplayMember = "MenuText"
    End Sub


    Public Sub showDataGridView(ByVal txtSearch As String)
        Dim query = "select a.ID,a.MenuTag,a.MenuText,a.FormName,iif(b.[MenuText] is null,'-No Parent-',b.[MenuText]) as Parent,cast (null as image) as IconMenu,a.OrderSort,a.IDParentMenu from MenuApp a left join MenuApp b on a.IDParentMenu =b.ID where ((a.IDParentMenu is NULL) or (  a.IDParentMenu is Not NULL))  order by a.OrderSort,a.MenuText Asc"
        Dim itemmenu = getDataTable(query)
        If txtSearch <> "" Then
        End If
        dgv.Rows.Clear()
        ctr = 0
        GetMenuLevel(itemmenu, "IDParentMenu is Null", "")
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            .Columns("MenuLevel").HeaderCell.Value = "Menu"
            .Columns("MenuID").HeaderCell.Value = "Menu ID"
            .Columns("MenuID").Visible = False
            .Columns("MenuTag").HeaderCell.Value = "Role Name"
            .Columns("MenuText").HeaderCell.Value = "Menu Text"
            .Columns("MenuText").Visible = False
            .Columns("OpenForm").HeaderCell.Value = "Open Form Name"
            .Columns("ParentMenu").HeaderCell.Value = "Parent"
            .Columns("IconMenu").HeaderCell.Value = "Icon"
            .Columns("IconMenu").Width = 35
            .Columns("OrderSort").HeaderCell.Value = "Order Sort"
            .Columns("OrderSort").Width = 150
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
        ctr = 0
    End Sub
    Dim ctr As Int32 = 0
    Sub GetMenuLevel(dt As DataTable, filter As String, tagSparator As String)
        For Each dr As DataRow In dt.Select(filter)
            AddToDgv(dr, tagSparator & "➧ ")
            If tagSparator Is "" Then
                dgv.Rows(ctr).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End If
            ctr = ctr + 1
            GetMenuLevel(dt, "IDParentMenu = " & dr.Item(0), tagSparator & "       ")
        Next
    End Sub

    Sub AddToDgv(ByVal dr As DataRow, ByVal levelTag As String)
        dgv.Rows.Add(levelTag & dr.Item(2), dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
    End Sub

    Private Sub dgv_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv.CellPainting

        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return
        If dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).GetType = GetType(DataGridViewImageCell) Then
            CType(dgv.Rows(e.RowIndex).Cells(e.ColumnIndex),
              DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Stretch
        End If
        If IsDBNull(dgv.Rows(e.RowIndex).Cells("IconMenu").Value) Then
            Dim valuepic = getDataTable("select IconMenu from MenuApp where ID = " & dgv.Rows(e.RowIndex).Cells("MenuID").Value.ToString).Rows(0).Item(0)
            'dgv.Rows(e.RowIndex).Cells("picture").Value = valuepic
            dgv.Rows(e.RowIndex).Cells(dgv.Columns("IconMenu").Index).Value = valuepic

        End If
    End Sub

    Private Sub FormMenuApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowCBTag()
        ShowParentMenu()
        showDataGridView("")
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        GroupBoxInputData.Enabled = True
        TextBoxOpenFormName.Text = ""
        TextBoxMenuText.Text = ""
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
        Dim stream As New MemoryStream()
        PictureBoxIconMenu.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Dim pic = stream.ToArray()
        Dim command As ModSqlCommand
        Dim valcmb = ""
        If ComboBoxParentMenu.Text = "-No Parent-" Then
            valcmb = "null"
        Else
            valcmb = ComboBoxParentMenu.SelectedValue
        End If
        If ButtonEdit.Enabled = False Then
            command = getCommand("insert into MenuApp (MenuTag,MenuText,FormName,IDParentMenu,IconMenu,OrderSort) values('" & ReplaceStrQuote(ComboBoxTag.Text) & "',N'" & ReplaceStrQuote(TextBoxMenuText.Text) & "','" & ReplaceStrQuote(TextBoxOpenFormName.Text) & "'," & valcmb & ",@pic," & ReplaceStrQuote(NumericUpDownOrderSort.Value) & ")")
            command.sqlCommand.Parameters.AddWithValue("@Pic", pic)
        Else
            command = getCommand("update MenuApp set MenuTag= '" & ReplaceStrQuote(ComboBoxTag.Text) & "',MenuText=N'" & ReplaceStrQuote(TextBoxMenuText.Text) & "',FormName='" & ReplaceStrQuote(TextBoxOpenFormName.Text) & "',IDParentMenu=" & valcmb & ",IconMenu=@pic,OrderSort=" & ReplaceStrQuote(NumericUpDownOrderSort.Value) & " where ID = " & IdMenu)
            command.sqlCommand.Parameters.AddWithValue("@Pic", pic)
        End If
        command.sqlCommand.ExecuteNonQuery()
        command.sqlConnection.Close()
        Reload()
    End Sub
    Sub Reload()
        GroupBoxInputData.Enabled = False
        TextBoxSearch.Clear()
        showDataGridView("")
        TextBoxOpenFormName.Text = ""
        TextBoxMenuText.Text = ""
        IdMenu = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As Integer = MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ExecuteQuery("delete from MenuApp where ID = " & IdMenu)
            Reload()
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub

    Private Sub PictureBoxIconMenu_Click(sender As Object, e As EventArgs) Handles PictureBoxIconMenu.Click
        Dim Galeri = New OpenFileDialog()
        Galeri.Filter = "(*.PNG)|*.PNG"
        If Galeri.ShowDialog = DialogResult.OK Then
            PictureBoxIconMenu.ImageLocation = Galeri.FileName
        Else
            PictureBoxIconMenu.Image = My.Resources.ic_menu
        End If
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        GroupBoxInputData.Enabled = False
        IdMenu = dgv.CurrentRow.Cells(1).Value.ToString
        ComboBoxTag.Text = dgv.CurrentRow.Cells(2).Value.ToString
        TextBoxMenuText.Text = dgv.CurrentRow.Cells(3).Value.ToString
        TextBoxOpenFormName.Text = dgv.CurrentRow.Cells(4).Value.ToString
        ShowParentMenu()
        ComboBoxParentMenu.Text = dgv.CurrentRow.Cells(5).Value.ToString
        Dim bytes As [Byte]() = dgv.CurrentRow.Cells(6).Value
        Dim ms As New MemoryStream(bytes)
        PictureBoxIconMenu.Image = Image.FromStream(ms)
        NumericUpDownOrderSort.Value = dgv.CurrentRow.Cells(7).Value
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub

    Private Sub FormMenuApp_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        showDataGridView("")
    End Sub




    Private Sub ComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxTag.KeyPress, ComboBoxParentMenu.KeyPress
        e.Handled = True
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs)
        dgv.ClearSelection()
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells("MenuText").Value.ToString.ToLower = TextBoxSearch.Text.ToString.ToLower Then
                dgv.Rows(row.Index).Selected = True
            End If
        Next
    End Sub

    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            For i = ctr To dgv.Rows.Count - 1 Step 1
                With dgv.Rows(i)
                    ctr = i + 1
                    If .Cells("MenuTag").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Or .Cells("MenuText").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Or .Cells("OpenForm").Value.ToString.ToLower Like "*" & TextBoxSearch.Text.ToLower & "*" Then
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