Imports System.IO
Imports Newtonsoft.Json

Public Class FormUser


    Dim avatar = "", gender = "", status = "", id_user = ""
    Dim codeTcp = "101"
    Private Sub FormDataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
        'TcpHelper.SetCallbackRefreshData(AddressOf TcpListen)
    End Sub
    Sub TcpListen()
        If InvokeRequired Then
            Invoke(New Action(AddressOf Reload))
        Else
            Dim msgFormat = TcpHelper.ReadData

        End If
    End Sub
    Public Sub showDataGridView()
        Dim query As String = "select id,userid,name,nohp,email,address,status,gender,created_at,updated_at,password_noencrypt from users where name like '%" & TextBoxSearch.Text & "%' order by id desc OFFSET " & BindingSourcePaging.Position * CInt(ComboBoxEntries.Text) & " ROWS FETCH NEXT " & ComboBoxEntries.Text & " ROWS ONLY;"
        dgv.DataSource = getDataTable(query)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "User Id"
            .Columns(2).HeaderCell.Value = "name"
            .Columns(3).HeaderCell.Value = "No HP"
            .Columns(4).HeaderCell.Value = "Email"
            .Columns(5).HeaderCell.Value = "address"
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
        Dim query As String = "select count(id) from Users where name like '%" & TextBoxSearch.Text & "%'"
        Dim datatabel = getDataTable(query)
        Dim dtable As New DataTable
        Dim dc As New DataColumn()
        dc.ColumnName = "Paging"
        dc.DataType = GetType(String)
        dtable.Columns.Add(dc)
        Dim count = Math.Ceiling(datatabel.Rows(0).Item(0) / CInt(ComboBoxEntries.Text))
        For i = 0 To count - 1
            Dim dr As DataRow = dtable.NewRow
            dr(0) = 1
            dtable.Rows.Add(dr)
        Next
        BindingSourcePaging.DataSource = dtable
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


    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        GroupBoxInputData.Enabled = True
        ButtonUserGroup.Enabled = False
        TextBoxUserId.Text = ""
        TextBoxName.Text = ""
        TextBoxNohp.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAddress.Text = ""
        TextBoxPassword.Text = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        GroupBoxInputData.Enabled = False
        ButtonUserGroup.Enabled = True
        id_user = dgv.CurrentRow.Cells(0).Value
        TextBoxUserId.Text = dgv.CurrentRow.Cells(1).Value
        TextBoxName.Text = dgv.CurrentRow.Cells(2).Value
        TextBoxNohp.Text = dgv.CurrentRow.Cells(3).Value
        TextBoxEmail.Text = dgv.CurrentRow.Cells(4).Value
        TextBoxAddress.Text = dgv.CurrentRow.Cells(5).Value
        Try
            Dim bytes As [Byte]() = getDataTable("select avatar from users where id =" & id_user).Rows(0).Item(0)
            Dim ms As New MemoryStream(bytes)
            PictureBoxProfile.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try
        TextBoxPassword.Text = dgv.CurrentRow.Cells(10).Value
        If dgv.CurrentRow.Cells(6).Value = "1" Then
            RadioButtonActive.Checked = True
        Else
            RadioButtonNonActive.Checked = True
        End If

        If dgv.CurrentRow.Cells(7).Value = "M" Then
            RadioButtonMale.Checked = True
        Else
            RadioButtonPemale.Checked = True
        End If

        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As Integer = MessageBox.Show("Delete Data", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim query As String = "delete from users where id = '" & id_user & "'"
            ExecuteQuery(query)
            LogApp.Delete("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "")
            Reload()
        End If
    End Sub

    Private Sub ButtonOpenGaleri_Click(sender As Object, e As EventArgs) Handles ButtonOpenGaleri.Click
        Dim Galeri = New OpenFileDialog()
        Galeri.Filter = "(*.JPG)|*.JPG"
        If Galeri.ShowDialog = DialogResult.OK Then
            PictureBoxProfile.ImageLocation = Galeri.FileName
        Else
            PictureBoxProfile.Image = My.Resources.user
        End If
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

    Private Sub ButtonUserGroup_Click(sender As Object, e As EventArgs) Handles ButtonUserGroup.Click
        FormMain.fillFormToPanel(FormUserGroup)
        Dim form As FormUserGroup = DirectCast(FormMain.GetFormInTabControl(FormUserGroup.Name), FormUserGroup)
        If form IsNot Nothing Then
            form.TextBoxUser.Tag = dgv.CurrentRow.Cells(0).Value
            form.TextBoxUser.Text = dgv.CurrentRow.Cells(1).Value & " - " & dgv.CurrentRow.Cells(2).Value
        End If
    End Sub

    Private Sub ButtonAuth_Click(sender As Object, e As EventArgs) Handles ButtonAccess.Click
        FormMain.fillFormToPanel(FormUserRole)
        Dim form As FormUserRole = DirectCast(FormMain.GetFormInTabControl(FormUserRole.Name), FormUserRole)
        If form IsNot Nothing Then
            form.TextBoxUser.Tag = dgv.CurrentRow.Cells(0).Value
            form.TextBoxUser.Text = dgv.CurrentRow.Cells(1).Value & " - " & dgv.CurrentRow.Cells(2).Value
        End If
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        ExportDgvToExcel(dgv)
    End Sub

    Sub Reload()
        If InvokeRequired Then
            Invoke(New Action(AddressOf Reload))
        Else
            GroupBoxInputData.Enabled = False
            ShowNavPageData()
            TextBoxUserId.Text = ""
            TextBoxName.Text = ""
            TextBoxNohp.Text = ""
            TextBoxEmail.Text = ""
            TextBoxAddress.Text = ""
            TextBoxPassword.Text = ""
            ButtonEdit.Enabled = False
            ButtonDelete.Enabled = False
            ButtonSave.Enabled = False
            ButtonUserGroup.Enabled = False
            avatar = ""
            gender = ""
            status = ""
            id_user = ""
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        GroupBoxInputData.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim command As ModSqlCommand
        If RadioButtonActive.Checked Then
            status = 1
        Else
            status = 0
        End If

        If RadioButtonMale.Checked Then
            gender = "M"
        Else
            gender = "P"
        End If
        Dim stream As New MemoryStream()
        PictureBoxProfile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Dim pic = stream.ToArray()

        If ButtonEdit.Enabled = False Then
            command = getCommand("insert into users (userid,name,email,nohp,address,avatar,gender,status,password,password_noencrypt,token) 
            values('" & ReplaceStrQuote(TextBoxUserId.Text) & "','" & ReplaceStrQuote(TextBoxName.Text) & "','" & ReplaceStrQuote(TextBoxEmail.Text) & "','" & ReplaceStrQuote(TextBoxNohp.Text) & "','" & ReplaceStrQuote(TextBoxAddress.Text) & "',@Pic,'" & gender & "','" & status & "','" & GetHashMD5(TextBoxPassword.Text) & "','" & ReplaceStrQuote(TextBoxPassword.Text) & "','-')")
            command.sqlCommand.Parameters.AddWithValue("@Pic", pic)
            command.sqlCommand.ExecuteNonQuery()
            command.sqlConnection.Close()
            Reload()
            'Fungsi Mengambil data terbaru
            Dim indexRow = getDataTable("select top 1 id,name,ROW_NUMBER() OVER(ORDER BY name) as idx from users order by id desc").Rows(0).Item(2) - 1
            LogApp.Insert("users", DgvRowToString.Generate(dgv, indexRow), "")
        Else
            command = getCommand("update users set userid='" & ReplaceStrQuote(TextBoxUserId.Text) & "',name='" & ReplaceStrQuote(TextBoxName.Text) & "',email='" & ReplaceStrQuote(TextBoxEmail.Text) & "', nohp='" & ReplaceStrQuote(TextBoxNohp.Text) & "',
 address='" & ReplaceStrQuote(TextBoxAddress.Text) & "', avatar=@Pic, gender='" & gender & "', status='" & status & "',password_noencrypt='" & ReplaceStrQuote(TextBoxPassword.Text) & "', password='" & GetHashMD5(TextBoxPassword.Text) & "' where id = '" & id_user & "'")
            command.sqlCommand.Parameters.AddWithValue("@Pic", pic)
            LogApp.Update("users", DgvRowToString.Generate(dgv, dgv.CurrentRow.Index), "-", "")
            command.sqlCommand.ExecuteNonQuery()
            command.sqlConnection.Close()
            'TcpHelper.TcpSendRefreshData(codeTcp, "refresh")
            Reload()
        End If
    End Sub
End Class