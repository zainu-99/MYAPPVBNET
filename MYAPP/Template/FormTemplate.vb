Public Class FormTemplate

    Dim img_loc = "", gender = "", status = "", id_user = ""
    Dim bs = New BindingSource()
    Private Sub FormDataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Public Sub showDataGridView(ByVal txtSearch As String)
        Dim query As String = "select id,userid,nama,nohp,email,alamat,status,gender,created_at,updated_at,img_loc,password_noencrypt from users where nama like '%" & txtSearch & "%' order by nama asc"
        dgv.DataSource = getDataTable(query)
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With dgv
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "User Id"
            .Columns(2).HeaderCell.Value = "Nama"
            .Columns(3).HeaderCell.Value = "No HP"
            .Columns(4).HeaderCell.Value = "Email"
            .Columns(5).HeaderCell.Value = "Alamat"
            .Columns(6).HeaderCell.Value = "Status"
            .Columns(7).HeaderCell.Value = "Gender"
            .Columns(8).HeaderCell.Value = "Created At"
            .Columns(9).HeaderCell.Value = "Update At"
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Private Sub btn_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        GroupBoxInputData.Enabled = True
        TextBoxUserId.Text = ""
        TextBoxNama.Text = ""
        TextBoxNohp.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxPassword.Text = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonRoleGroup_Click(sender As Object, e As EventArgs)
        FormMain.fillFormToPanel(FormUserGroup)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        GroupBoxInputData.Enabled = False
        id_user = dgv.CurrentRow.Cells(0).Value
        TextBoxUserId.Text = dgv.CurrentRow.Cells(1).Value
        TextBoxNama.Text = dgv.CurrentRow.Cells(2).Value
        TextBoxNohp.Text = dgv.CurrentRow.Cells(3).Value
        TextBoxEmail.Text = dgv.CurrentRow.Cells(4).Value
        TextBoxAlamat.Text = dgv.CurrentRow.Cells(5).Value
        PictureBoxProfile.ImageLocation = dgv.CurrentRow.Cells(10).Value
        TextBoxPassword.Text = dgv.CurrentRow.Cells(11).Value
        If dgv.CurrentRow.Cells(6).Value = "1" Then
            RadioButtonAktif.Checked = True
        Else
            RadioButtonNonAktif.Checked = True
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
            Reload()
        End If
    End Sub
    Private Sub TextBoxSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyUp
        showDataGridView(TextBoxSearch.Text)
    End Sub

    Private Sub ButtonOpenGaleri_Click(sender As Object, e As EventArgs) Handles ButtonOpenGaleri.Click
        Dim Galeri = New OpenFileDialog()
        Galeri.Filter = "(*.JPG)|*.JPG"
        If Galeri.ShowDialog = DialogResult.OK Then
            PictureBoxProfile.ImageLocation = Galeri.FileName
        End If
    End Sub

    Sub Reload()
        GroupBoxInputData.Enabled = False
        showDataGridView("")
        TextBoxUserId.Text = ""
        TextBoxNama.Text = ""
        TextBoxNohp.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxPassword.Text = ""
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = False
        img_loc = ""
        gender = ""
        status = ""
        id_user = ""
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        GroupBoxInputData.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If RadioButtonAktif.Checked Then
            status = 1
        Else
            status = 0
        End If

        If RadioButtonMale.Checked Then
            gender = "M"
        Else
            gender = "P"
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath() & "/ProfilePicture/")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath() & "/ProfilePicture/")
        End If
        PictureBoxProfile.Image.Save(Application.StartupPath() & "/ProfilePicture/" & TextBoxUserId.Text & ".JPG")
        img_loc = Application.StartupPath() & "/ProfilePicture/" & TextBoxUserId.Text & ".JPG"

        If ButtonEdit.Enabled = False Then
            ExecuteQuery("insert into users (userid,nama,email,nohp,alamat,img_loc,gender,status,password,password_noencrypt,token) 
            values(
                '" & TextBoxUserId.Text & "',
                '" & TextBoxNama.Text & "',
                '" & TextBoxEmail.Text & "',
                '" & TextBoxNohp.Text & "',
                '" & TextBoxAlamat.Text & "',
                '" & img_loc & "',
                '" & gender & "',
                '" & status & "',
                '" & GetHashMD5(TextBoxPassword.Text) & "',
                '" & TextBoxPassword.Text & "',
                '-'
            )")
        Else
            ExecuteQuery("update users set userid='" & TextBoxUserId.Text & "',nama='" & TextBoxNama.Text & "',email='" & TextBoxEmail.Text & "', nohp='" & TextBoxNohp.Text & "',
 alamat='" & TextBoxAlamat.Text & "', img_loc='" & img_loc & "', gender='" & gender & "', status='" & status & "',password_noencrypt='" & TextBoxPassword.Text & "', password='" & GetHashMD5(TextBoxPassword.Text) & "' where id = '" & id_user & "'")
        End If
        Reload()
    End Sub
End Class