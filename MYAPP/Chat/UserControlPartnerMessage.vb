Imports System.Drawing.Drawing2D

Public Class UserControlPartnerMessage

    Public IdMessage As String
    Public NameUserRecieve As String = ""
    Public boxmsg As EmojiRichText
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

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If LabelMessage.SelectedText = "" Then
            Clipboard.SetText(NameUserRecieve & ":" & LabelMessage.Text)
        Else
            Clipboard.SetText(LabelMessage.SelectedText)
        End If
    End Sub
    Private Sub UserControlPartnerMessage_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim gp As GraphicsPath = GetPath(PanelMsg.ClientRectangle, 20)
        PanelMsg.Region = New Region(gp)
        'LabelMessage.MaximumSize = New System.Drawing.Size(Me.FlowLayoutPanel.Size.Width - 139, 0)
        'LabelMessage.Width = Me.FlowLayoutPanel.Size.Width - 139
    End Sub

    Private Sub ReplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplyToolStripMenuItem.Click
        Try
            Dim sparator = "----------------------------"
            boxmsg.Enabled = True
            Dim msg As String() = LabelMessage.Text.Split((sparator))
            If msg.Length > 1 Then
                boxmsg.Text = "Reply : " & msg(msg.Length - 1).ToString.Remove(0, 1) & vbNewLine & LabelDateTime.Text & vbNewLine & sparator & vbNewLine
            Else
                boxmsg.Text = "Reply : " & LabelMessage.Text & vbNewLine & LabelDateTime.Text & vbNewLine & sparator & vbNewLine
            End If
            boxmsg.Focus()
            boxmsg.SelectionStart = boxmsg.TextLength
            boxmsg.SelectionLength = 0
        Catch ex As Exception
            MsgBox("this message cannot reply")
            boxmsg.Enabled = True
        End Try

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
