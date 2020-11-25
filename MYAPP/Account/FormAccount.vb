Imports System.IO

Public Class FormAccount
    Private Sub ButtonUpdateBio_Click(sender As Object, e As EventArgs) Handles ButtonUpdateBio.Click
        Dim gender = "", status = ""
        Dim command As ModSqlCommand
        If Not GroupBoxProfile.Enabled Then
            GroupBoxProfile.Enabled = True
            ButtonUpdateBio.Text = "Save"
        Else
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

            command = getCommand("update users set userid='" & TextBoxUserId.Text & "',name='" & TextBoxName.Text & "',email='" & TextBoxEmail.Text & "', nohp='" & TextBoxNohp.Text & "',
 address='" & TextBoxAddress.Text & "', avatar=@pic, gender='" & gender & "', status='" & status & "' where id = '" & My.Settings.id_user & "'")
            command.sqlCommand.Parameters.AddWithValue("@Pic", pic)
            command.sqlCommand.ExecuteNonQuery()
            command.sqlConnection.Close()
            GroupBoxProfile.Enabled = False
            ButtonUpdateBio.Text = "Edit"
        End If
    End Sub

    Private Sub ButtonUpdatePassword_Click(sender As Object, e As EventArgs) Handles ButtonUpdatePassword.Click
        If getDataTable("select * from users where id ='" & My.Settings.id_user & "' and password = '" & GetHashMD5(TextBoxOldPassword.Text) & "'").Rows.Count = 0 Then
            MsgBox("Old Password Wrong")
        Else
            If TextBoxNewPassword.Text <> TextBoxConfirmPasssword.Text Then
                MsgBox("New Password and Confirm Password Not Match")
            Else
                ExecuteQuery("Update users set password_noencrypt='" & TextBoxNewPassword.Text & "', password='" & GetHashMD5(TextBoxNewPassword.Text) & "' where id = '" & My.Settings.id_user & "'")
                MsgBox("Change Password Success")
                TextBoxConfirmPasssword.Clear()
                TextBoxNewPassword.Clear()
                TextBoxOldPassword.Clear()
            End If
        End If
    End Sub

    Private Sub FormAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data = getDataTable("select id,userid,name,nohp,email,address,status,gender,created_at,avatar,avatar,password_noencrypt from users where id ='" & My.Settings.id_user & "'")
        TextBoxUserId.Text = data.Rows(0).Item(1)
        TextBoxName.Text = data.Rows(0).Item(2)
        TextBoxNohp.Text = data.Rows(0).Item(3)
        TextBoxEmail.Text = data.Rows(0).Item(4)
        TextBoxAddress.Text = data.Rows(0).Item(5)
        Try
            Dim bytes As [Byte]() = data.Rows(0).Item(10)
            Dim ms As New MemoryStream(bytes)
            PictureBoxProfile.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try
        If data.Rows(0).Item(6) = "1" Then
            RadioButtonActive.Checked = True
        Else
            RadioButtonNonActive.Checked = True
        End If

        If data.Rows(0).Item(7) = "M" Then
            RadioButtonMale.Checked = True
        Else
            RadioButtonPemale.Checked = True
        End If
    End Sub

    Private Sub ButtonOpenGaleri_Click(sender As Object, e As EventArgs) Handles ButtonOpenGaleri.Click
        Dim Galeri = New OpenFileDialog()
        Galeri.Filter = "(*.JPG)|*.JPG"
        If Galeri.ShowDialog = DialogResult.OK Then
            PictureBoxProfile.ImageLocation = Galeri.FileName
        End If
    End Sub
End Class