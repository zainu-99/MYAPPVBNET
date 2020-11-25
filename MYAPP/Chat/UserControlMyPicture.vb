Imports System.IO

Public Class UserControlMyPicture
    Public IdMessage As String
    Public IdUserRecieve As String
    Private Sub UserControlMyFileAttach_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxMesage.MouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStripChat.Show(Me.PictureBoxMesage, e.Location)
        Else
            Dim FormImgZoom As New Form()
            Dim pb As New PictureBox
            pb.Image = PictureBoxMesage.Image
            pb.SizeMode = PictureBoxSizeMode.Zoom
            FormImgZoom.Controls.Add(pb)
            pb.Dock = DockStyle.Fill
            FormImgZoom.MaximizeBox = False
            FormImgZoom.MinimizeBox = False
            FormImgZoom.Text = "Perbesar Gambar"
            FormImgZoom.StartPosition = FormStartPosition.CenterParent
            'FormImgZoom.FormBorderStyle = FormBorderStyle.FixedDialog
            FormImgZoom.Size = New System.Drawing.Size(450, 450)
            FormImgZoom.ShowDialog()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ExecuteQuery("delete from ChatMessage where ID = '" & IdMessage & "'")
        Try
            If Path.GetDirectoryName(Me.PictureBoxMesage.Tag.ToString) <> "\\10.80.1.3\d_sharing\MISCA\gif" Then
                My.Computer.FileSystem.DeleteFile(Me.PictureBoxMesage.Tag.ToString)
            End If
        Catch ex As Exception

        End Try
        Dim msg As New TcpData()
        Dim obj As New ActionMessage()
        obj.idUserSender = My.Settings.id_user
        obj.idUserReciever = IdUserRecieve
        obj.action = "deletemessage"
        obj.booleanValue = True
        msg.actionmessage = obj
        msg.type = obj.GetType().Name
        msg.remark = ""
        TcpHelper.TcpSend(msg.getJsonString)
        Me.Dispose()
    End Sub


    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        If PictureBoxMesage.Tag.ToString <> "-" And PictureBoxMesage.Tag.ToString <> "" Then
            Dim sfd As New SaveFileDialog
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            sfd.FileName = Path.GetFileName(PictureBoxMesage.Tag.ToString)
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim FileDownload As String
                FileDownload = sfd.FileName
                If System.IO.File.Exists(PictureBoxMesage.Tag.ToString) = True Then
                    System.IO.File.Copy(PictureBoxMesage.Tag.ToString, FileDownload)
                    MessageBox.Show("File is Downloaded")
                End If
            End If
        Else
            MessageBox.Show("No File")
        End If
    End Sub

    Private Sub PictureBoxMesage_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBoxMesage.LoadCompleted
        Try
            PictureBoxMesage.Width = PictureBoxMesage.Image.Width
            PictureBoxMesage.Height = PictureBoxMesage.Image.Height
        Catch ex As Exception

        End Try
    End Sub

End Class
