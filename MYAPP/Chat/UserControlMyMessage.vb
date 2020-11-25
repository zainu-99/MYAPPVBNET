Imports System.Drawing.Drawing2D

Public Class UserControlMyMessage
    Public IdMessage As String
    Public IdUserRecieve As String
    Private Function GetPath(ByVal rc As Rectangle, ByVal r As Int32) As GraphicsPath
        Dim x As Int32 = rc.X, y As Int32 = rc.Y, w As Int32 = rc.Width, h As Int32 = rc.Height
        r = r << 1
        Dim path As GraphicsPath = New GraphicsPath()
        If r > 0 Then
            If (r > h) Then r = h
            If (r > w) Then r = w
            path.AddArc(x, y, r, r, 180, 90)
            path.AddArc(x + w - r, y, r, r, 270, 90)
            path.AddArc(x + w - r, y + h - r, r, r, 0, 90)
            path.AddArc(x, y + h - r, r, r, 90, 90)
            path.CloseFigure()
        Else
            path.AddRectangle(rc)
        End If
        Return path
    End Function
    Private Sub UserControlMyMessage_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelMessage.MouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStripChat.Show(Me.LabelMessage, e.Location)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ExecuteQuery("delete from ChatMessage where ID = '" & IdMessage & "'")
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

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If LabelMessage.SelectedText = "" Then
            Clipboard.SetText(My.Settings.name & ":" & LabelMessage.Text)
        Else
            Clipboard.SetText(LabelMessage.SelectedText)
        End If
    End Sub

    Private Sub UserControlMyMessage_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim gp As GraphicsPath = GetPath(PanelMsg.ClientRectangle, 20)
        PanelMsg.Region = New Region(gp)
        'LabelMessage.MaximumSize = New System.Drawing.Size(Me.FlowLayoutPanel.Size.Width - 139, 0)
        'LabelMessage.Width = Me.FlowLayoutPanel.Size.Width - 139
    End Sub

    Sub AutoSizeTextBox(ByVal txtbox As RichTextBox)
        Dim x_margin = 3
        Dim y_margin = 3
        Dim Size = TextRenderer.MeasureText(txtbox.Text, txtbox.Font)
        txtbox.ClientSize = New Size(Size.Width + x_margin, Size.Height + y_margin)
    End Sub

    Private Sub UCChatGroupMyMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoSizeTextBox(LabelMessage)
    End Sub

    Private Sub LabelMessage_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles LabelMessage.LinkClicked
        Try
            Process.Start(e.LinkText)
        Catch ex As Exception

        End Try
    End Sub
End Class
