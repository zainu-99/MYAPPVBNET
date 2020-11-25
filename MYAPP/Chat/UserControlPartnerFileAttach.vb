Imports System.IO

Public Class UserControlPartnerFileAttach
    Public IdMessage As String

    Private Sub ButtonDownload_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonDownload.MouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStripChat.Show(Me.ButtonDownload, e.Location)
        Else
            If sender.Tag.ToString <> "-" And sender.Tag.ToString <> "" Then
                Dim sfd As New SaveFileDialog
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                sfd.FileName = Path.GetFileName(sender.Tag.ToString)
                If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Dim FileDownload As String
                    FileDownload = sfd.FileName
                    If System.IO.File.Exists(sender.Tag.ToString) = True Then
                        System.IO.File.Copy(sender.Tag.ToString, FileDownload)
                        MessageBox.Show("File is Downloaded")
                    End If
                End If
            Else
                MessageBox.Show("No File")
            End If
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Try
            Process.Start(ButtonDownload.Tag.ToString)
        Catch ex As Exception

        End Try
    End Sub
End Class
