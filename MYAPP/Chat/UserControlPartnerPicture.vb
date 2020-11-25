Imports System.IO

Public Class UserControlPartnerPicture
    Public IdMessage As String
    Private Sub PictureBoxMesage_Click(sender As Object, e As EventArgs) Handles PictureBoxMesage.Click

    End Sub

    Private Sub PictureBoxMesage_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxMesage.MouseUp
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
