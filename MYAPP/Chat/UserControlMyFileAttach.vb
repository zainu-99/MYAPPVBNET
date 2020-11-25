Imports System.IO

Public Class UserControlMyFileAttach
    Public IdMessage As String
    Public IdUserRecieve As String

    Private Sub UserControlMyFileAttach_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonDownload.MouseUp
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

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ExecuteQuery("delete from ChatMessage where ID = '" & IdMessage & "'")
        Try
            If Path.GetDirectoryName(Me.ButtonDownload.Tag.ToString) <> "\\10.80.1.3\d_sharing\MISCA\gif" Then
                My.Computer.FileSystem.DeleteFile(Me.ButtonDownload.Tag.ToString)
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

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Try
            Process.Start(ButtonDownload.Tag.ToString)
        Catch ex As Exception

        End Try
    End Sub
End Class
