

Imports System.IO
Imports System.Net.Sockets
Imports Newtonsoft.Json

Public Class FormChatting
    Dim limit = 1
    Dim curRowUser = 0
    Dim dataTableChat As DataTable
    Dim UserIDReciever = 0
    Dim FileToUpload As String
    Dim FileUploaded As String
    Dim IsTyping = False
    Dim dview As DataView
    Dim ucrs As New UserControlReadStatus
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        If Not String.IsNullOrWhiteSpace(BoxMessage.Text) Then SendData(BoxMessage.Text, UserIDReciever)
    End Sub
    Sub TcpListen(msg As String)
        If InvokeRequired Then
            Invoke(Sub() TcpListen(msg))
        Else
            Try
                Dim tcpData As TcpData = TcpData.getJsonObject(msg)
                If tcpData.type = "ChatMessage" Then
                    Dim data = tcpData.chatmessage
                    If data.idUserSender <> My.Settings.id_user Then
                        ucrs.LabelReadStatus.Visible = False
                        ShowPartnerMessage(data.idMessage, data.message, data.fileAttached, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), 2, True)
                        If Not FormMain.MyAppIsActive Or FormMain.TabControlForm.SelectedTab.Name = Name Then
                            FormMain.NotifyIconMessage.ShowBalloonTip(250, "New Personal Message", data.nameUserSender.ToString & " : " & data.message.ToString, ToolTipIcon.Info)
                        End If
                    Else
                        ShowMyMessage(data.idMessage, data.message, data.fileAttached, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), 2, True)
                    End If
                    SetNewMessageUser(data.idUserSender)
                ElseIf tcpData.type = "ActionMessage" Then
                    Dim data = tcpData.actionmessage
                    If data.action = "typinginfo" Then
                        If data.idUserSender.ToString() <> My.Settings.id_user And UserIDReciever.ToString = data.idUserSender.ToString() Then
                            LabelTyping.Visible = data.booleanValue
                        End If
                    ElseIf data.action = "readinfo" Then
                        If data.idUserReciever.ToString() = My.Settings.id_user Then
                            ShowReadStatus(data.booleanValue)
                        End If
                    ElseIf data.action = "deletemessage" Then
                        If data.idUserSender.ToString() <> My.Settings.id_user Then
                            If data.booleanValue Then
                                If data.stringValue = "EndChat" Then
                                    PanelMessage.Controls.Clear()
                                    Exit Sub
                                End If
                                For Each control As UserControlPartnerMessage In PanelMessage.Controls.OfType(Of UserControlPartnerMessage)
                                    If control.IdMessage = data.idMessage Then
                                        control.Dispose()
                                        Exit Sub
                                    End If
                                Next
                                For Each control As UserControlPartnerFileAttach In PanelMessage.Controls.OfType(Of UserControlPartnerFileAttach)
                                    If control.IdMessage = data.idMessage Then
                                        control.Dispose()
                                        Exit Sub
                                    End If
                                Next
                                For Each control As UserControlPartnerPicture In PanelMessage.Controls.OfType(Of UserControlPartnerPicture)
                                    If control.IdMessage = data.idMessage Then
                                        control.Dispose()
                                    End If
                                Next
                            End If
                        End If
                    End If
                ElseIf tcpData.type = "UserConnected" Then
                    Dim data = tcpData.userconnected
                    SetOnlineOfflineUser(data.idUser, data.status)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub SetNewMessageUser(IdUser As String)
        Try
            Dim vScroll = DgvUser.FirstDisplayedScrollingRowIndex
            If IdUser = My.Settings.id_user Then Exit Sub
            dview.Sort = "id"
            Dim idx = dview.Find(IdUser)
            If idx <> -1 Then
                Dim ctrMsg = dview(idx)("unread") + 1
                dview(idx)("unread") = ctrMsg
                dview.Sort = ""
                BindingSourceUser.DataSource = dview
                Try
                    If DgvUser.Rows.Count > 0 Then
                        If vScroll <> -1 Then DgvUser.FirstDisplayedScrollingRowIndex = vScroll
                    End If
                Catch ex As Exception

                End Try
            Else
                showDataGridViewUser(ReplaceStrQuote(TextBoxSearch.Text))
            End If
        Catch ex As Exception
            showDataGridViewUser(ReplaceStrQuote(TextBoxSearch.Text))
        End Try
    End Sub

    Sub SetOnlineOfflineUser(IdUser As String, Status As String)
        Try
            Dim vScroll = DgvUser.FirstDisplayedScrollingRowIndex
            If IdUser = My.Settings.id_user Then Exit Sub
            dview.Sort = "id"
            Dim idx = dview.Find(IdUser)
            If idx <> -1 Then
                dview(idx)("status") = Status
                dview.Sort = ""
                BindingSourceUser.DataSource = dview
                Try
                    If DgvUser.Rows.Count > 0 Then
                        If vScroll <> -1 Then DgvUser.FirstDisplayedScrollingRowIndex = vScroll
                    End If
                Catch ex As Exception

                End Try
            Else
                showDataGridViewUser(ReplaceStrQuote(TextBoxSearch.Text))
            End If
        Catch ex As Exception
            showDataGridViewUser(ReplaceStrQuote(TextBoxSearch.Text))
        End Try
    End Sub
    Private Sub FormChatting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDataGridViewUser("")
        TcpHelper.SetListenerData(AddressOf TcpListen)
    End Sub
    Public Sub showDataGridViewUser(ByVal txtSearch As String)
        Dim query As String = "select a.id,a.userid,a.name,count(b.ID) unread,iif(online_offline=1,'online','offline') as status from Users a left join ( select * from ChatMessage where ReadStatus = 0 and UserIDReciever='" & My.Settings.id_user & "') b on a.id = b.UserID where a.name like '%" & txtSearch & "%' and a.status=1 and a.id <> '" & My.Settings.id_user & "' group by a.id,a.userid,a.name,a.online_offline order by a.name asc"
        dview = New DataView(getDataTable(query), "", "id", DataViewRowState.CurrentRows)
        dview.Sort = ""
        BindingSourceUser.DataSource = dview
        DgvUser.DataSource = BindingSourceUser
        DgvUser.AllowUserToAddRows = False
        DgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        With DgvUser
            .RowHeadersVisible = False
            .Columns("id").Visible = False
            .Columns("userid").HeaderCell.Value = "UserId"
            .Columns("name").HeaderCell.Value = "Nama"
            .Columns("unread").HeaderCell.Value = "Unread"
            .Columns("status").HeaderCell.Value = "Status"
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 253)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
        If (curRowUser < DgvUser.Rows.Count) Then
            DgvUser.Rows(curRowUser).Selected = True
        End If
        Dim countUnread = 0
        For Each row As DataGridViewRow In DgvUser.Rows
            countUnread = countUnread + CInt(row.Cells("unread").Value.ToString)
        Next
        FormMain.btnMessage.Text = countUnread
        UserIDReciever = 0
        PanelAction.Visible = False
        LabelTyping.Visible = False
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        showDataGridViewUser(TextBoxSearch.Text)
    End Sub

    Private Sub DataGridViewUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUser.CellClick
        PanelAction.Visible = True
        LabelTyping.Visible = False
        UserIDReciever = DgvUser.CurrentRow.Cells("id").Value.ToString
        LabelSentTo.Text = "Send Message To : " & DgvUser.CurrentRow.Cells("userid").Value & "-" & DgvUser.CurrentRow.Cells("name").Value
        PanelMessage.Controls.Clear()
        ucrs = New UserControlReadStatus
        ucrs.Dock = DockStyle.Top
        ucrs.LabelReadStatus.Visible = False
        PanelMessage.Controls.Add(ucrs)
        ShowChatting(UserIDReciever, 1, 15)
        Dim query As String
        If (PanelMessage.Controls.Count > 0) Then
            query = "update ChatMessage set ReadStatus=1 where UserID = " & UserIDReciever & " and UserIDReciever = " & My.Settings.id_user
            ExecuteQuery(query)
        End If
        query = "select top 1 userid,ReadStatus from  ChatMessage a where (UserID =  '" & My.Settings.id_user & "' and UserIDReciever = " & UserIDReciever & ") or (UserID =  '" & UserIDReciever & "' and UserIDReciever = " & My.Settings.id_user & ") order by id desc"
        Dim datatable As DataTable = getDataTable(query)
        If datatable.Rows.Count > 0 Then
            Dim action = (datatable.Rows(0).Item("userid").ToString = My.Settings.id_user) And (datatable.Rows(0).Item("ReadStatus").ToString = "True")
            ShowReadStatus(action)
        End If
        If DgvUser.CurrentRow.Cells(3).Value > 0 Then
            DgvUser.CurrentRow.Cells(3).Value = 0
            Dim tcpdata As New TcpData()
            Dim obj As New ActionMessage()
            obj.idUserSender = My.Settings.id_user
            obj.idUserReciever = UserIDReciever
            obj.action = "readinfo"
            obj.booleanValue = True
            tcpdata.actionmessage = obj
            tcpdata.type = obj.GetType().Name
            tcpdata.remark = ""
            TcpHelper.TcpSend(tcpdata.getJsonString)
        End If
        curRowUser = DgvUser.CurrentRow.Index
        Dim countUnread = 0
        For Each row As DataGridViewRow In DgvUser.Rows
            countUnread = countUnread + CInt(row.Cells(3).Value.ToString)
        Next
        FormMain.btnMessage.Text = countUnread
        PanelMessage.ScrollControlIntoView(ucrs)
    End Sub


    Sub ShowChatting(ByVal idUserReciever As String, ByVal page As Int32, limit As Int32)
        Dim query = "select [ID]
      ,[Message]
      ,[FileAttached]
      ,[UserID]
      ,[UserIDReciever]
      ,[ReadStatus]
      ,[DeleteStatusUserSender]
      ,[DeleteStatusUserReciever]
      ,[Created_At] from ChatMessage where (UserID = " & My.Settings.id_user & " or UserIDReciever = " & My.Settings.id_user & ") and (UserID = " & UserIDReciever & " or UserIDReciever = " & UserIDReciever & ") order by ID desc OFFSET " & limit & " * (" & page & " - 1) ROWS FETCH NEXT " & limit & " ROWS ONLY;"
        dataTableChat = getDataTable(query)
        For Each row As DataRow In dataTableChat.Rows
            If row.Item("UserID").ToString = My.Settings.id_user Then
                ShowMyMessage(row.Item("ID"), row.Item("Message"), row.Item("FileAttached"), row.Item("Created_At"), 1, False)
            Else
                ShowPartnerMessage(row.Item("ID"), row.Item("Message"), row.Item("FileAttached"), row.Item("Created_At"), 1, False)
            End If
        Next
    End Sub

    Sub ShowMyMessage(idMessage As String, message As String, file_attach As String, time As String, position As Int32, focus As Boolean)
        Dim msg As UserControl
        If file_attach = "-" Then
            msg = New UserControlMyMessage
            msg.Dock = DockStyle.Top
            DirectCast(msg, UserControlMyMessage).LabelMessage.Text = message
            DirectCast(msg, UserControlMyMessage).LabelDateTime.Text = time
            DirectCast(msg, UserControlMyMessage).IdMessage = idMessage
            DirectCast(msg, UserControlMyMessage).IdUserRecieve = UserIDReciever
        ElseIf Path.GetExtension(file_attach).ToLower = ".jpg" Or Path.GetExtension(file_attach).ToLower = ".png" Or Path.GetExtension(file_attach).ToLower = ".jpeg" Or Path.GetExtension(file_attach).ToLower = ".gif" Or Path.GetExtension(file_attach).ToLower = ".jfif" Then
            msg = New UserControlMyPicture
            msg.Dock = DockStyle.Top
            DirectCast(msg, UserControlMyPicture).PictureBoxMesage.Tag = file_attach
            DirectCast(msg, UserControlMyPicture).PictureBoxMesage.ImageLocation = file_attach
            DirectCast(msg, UserControlMyPicture).LabelDateTime.Text = time
            DirectCast(msg, UserControlMyPicture).IdMessage = idMessage
            DirectCast(msg, UserControlMyPicture).IdUserRecieve = UserIDReciever
        Else
            msg = New UserControlMyFileAttach
            msg.Dock = DockStyle.Top
            DirectCast(msg, UserControlMyFileAttach).LabelDateTime.Text = time
            DirectCast(msg, UserControlMyFileAttach).IdMessage = idMessage
            DirectCast(msg, UserControlMyFileAttach).IdUserRecieve = UserIDReciever
            DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Text = "Download : " & Path.GetFileName(file_attach)
            Try
                If File.Exists(file_attach) Then
                    DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Text = "Download : " & Path.GetFileName(file_attach)
                    DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Tag = file_attach
                Else
                    DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Text = "Download : File Not Found"
                    DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Tag = "-"
                End If
            Catch ex As Exception
                DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Text = "Download : File Not Found"
                DirectCast(msg, UserControlMyFileAttach).ButtonDownload.Tag = "-"
            End Try
        End If
        PanelMessage.Controls.Add(msg)
        If position = 1 Then
            msg.SendToBack()
        Else
            msg.BringToFront()
        End If
        If focus Then
            ucrs.BringToFront()
            PanelMessage.ScrollControlIntoView(ucrs)
        End If
    End Sub
    Sub ShowPartnerMessage(idMessage As String, message As String, file_attach As String, time As String, position As Int32, focus As Boolean)
        Dim msg As New Object
        If file_attach = "-" Then
            msg = New UserControlPartnerMessage
            msg.Dock = DockStyle.Top
            DirectCast(msg, UserControlPartnerMessage).LabelMessage.Text = message
            DirectCast(msg, UserControlPartnerMessage).LabelDateTime.Text = time
            DirectCast(msg, UserControlPartnerMessage).IdMessage = idMessage
            DirectCast(msg, UserControlPartnerMessage).NameUserRecieve = My.Settings.name
            DirectCast(msg, UserControlPartnerMessage).boxmsg = BoxMessage

        ElseIf Path.GetExtension(file_attach).ToLower = ".jpg" Or Path.GetExtension(file_attach).ToLower = ".png" Or Path.GetExtension(file_attach).ToLower = ".jpeg" Or Path.GetExtension(file_attach).ToLower = ".gif" Or Path.GetExtension(file_attach).ToLower = ".jfif" Then
            msg = New UserControlPartnerPicture
            msg.Dock = DockStyle.Top
            DirectCast(msg, UserControlPartnerPicture).PictureBoxMesage.Tag = file_attach
            DirectCast(msg, UserControlPartnerPicture).PictureBoxMesage.ImageLocation = file_attach
            DirectCast(msg, UserControlPartnerPicture).LabelDateTime.Text = time
            DirectCast(msg, UserControlPartnerPicture).IdMessage = idMessage
        Else
            msg = New UserControlPartnerFileAttach
            msg.Dock = DockStyle.Top
            DirectCast(msg, UserControlPartnerFileAttach).LabelDateTime.Text = time
            DirectCast(msg, UserControlPartnerFileAttach).IdMessage = idMessage
            Try
                If File.Exists(file_attach) Then
                    DirectCast(msg, UserControlPartnerFileAttach).ButtonDownload.Text = "Download : " & Path.GetFileName(file_attach)
                    DirectCast(msg, UserControlPartnerFileAttach).ButtonDownload.Tag = file_attach
                Else
                    DirectCast(msg, UserControlPartnerFileAttach).ButtonDownload.Text = "Download : File Not Found"
                    DirectCast(msg, UserControlPartnerFileAttach).ButtonDownload.Tag = "-"
                End If
            Catch ex As Exception
                DirectCast(msg, UserControlPartnerFileAttach).ButtonDownload.Text = "Download : File Not Found"
                DirectCast(msg, UserControlPartnerFileAttach).ButtonDownload.Tag = "-"
            End Try
        End If
        PanelMessage.Controls.Add(msg)
        If position = 1 Then
            msg.SendToBack()
        Else
            msg.BringToFront()
        End If
        If focus Then
            ucrs.BringToFront()
            PanelMessage.ScrollControlIntoView(ucrs)
        End If
        If FormMain.TabControlForm.SelectedTab.Name = Name Then
            If position = 2 Then
                ExecuteQuery("update ChatMessage set ReadStatus=1 where UserIDReciever = " & UserIDReciever & " and UserID <> " & My.Settings.id_user)
                Dim tcpdata As New TcpData()
                Dim obj As New ActionMessage()
                obj.idUserSender = My.Settings.id_user
                obj.idUserReciever = UserIDReciever
                obj.action = "readinfo"
                obj.booleanValue = True
                tcpdata.actionmessage = obj
                tcpdata.type = obj.GetType().Name
                tcpdata.remark = ""
                TcpHelper.TcpSend(tcpdata.getJsonString)
            End If
        End If
    End Sub

    Private Sub ButtonToggle_Click(sender As Object, e As EventArgs) Handles ButtonToggle.Click
        PanelSideBar.Visible = Not PanelSideBar.Visible
    End Sub


    Private Sub PanelMessage_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelMessage.Scroll
        If PanelMessage.VerticalScroll.Value = 0 Then
            ShowChatting(DgvUser.CurrentRow.Cells(0).Value, (PanelMessage.Controls.Count / limit) + 1, limit)
        End If
    End Sub

    Private Sub PanelMessage_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMessage.MouseWheel
        If PanelMessage.VerticalScroll.Value = 0 And PanelMessage.Controls.Count > 0 Then
            ShowChatting(DgvUser.CurrentRow.Cells(0).Value, (PanelMessage.Controls.Count / limit) + 1, limit)
        End If
    End Sub

    Sub ShowReadStatus(action As Boolean)
        ucrs.BringToFront()
        ucrs.LabelReadStatus.Visible = action
    End Sub

    Sub SendData(mesage As String, UserIDReciever As String)
        If UserIDReciever <> 0 Then
            Dim IdMessage = getDataTable("insert into ChatMessage ([Message],[FileAttached],[UserID],[UserIDReciever],[ReadStatus],[DeleteStatusUserSender],[DeleteStatusUserReciever],[Created_At]) values(N'" & ReplaceQuote.ReplaceStrQuote(mesage) & "','" & IIf(FileUploaded = "", "-", FileUploaded) & "','" & My.Settings.id_user & "','" & UserIDReciever & "',0,0,0,GETDATE());SELECT IDENT_CURRENT('ChatMessage');").Rows(0).Item(0).ToString
            Dim msg As New TcpData()
        Dim obj As New ChatMessage()
        obj.idUserSender = My.Settings.id_user
        obj.nameUserSender = My.Settings.name
        obj.idUserReciever = UserIDReciever
        obj.message = mesage
        obj.fileAttached = IIf(FileUploaded = "", "-", FileUploaded)
        obj.idMessage = IdMessage
        msg.chatmessage = obj
        msg.type = obj.GetType().Name
        msg.remark = ""
        TcpHelper.TcpSend(msg.getJsonString)
        If (FileUploaded <> "") Then
            If File.Exists(FileToUpload) Then
                If FileToUpload <> FileUploaded Then
                    File.Copy(FileToUpload, FileUploaded)
                End If
            End If
        End If
        BoxMessage.Enabled = True
        BoxMessage.Clear()
        ButtonImage.Image = My.Resources.Resources.attach_image
        FileToUpload = ""
        FileUploaded = ""
        ShowReadStatus(False)
        End If
    End Sub
    Private Sub DataGridViewUser_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DgvUser.CellPainting
        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return
        If DgvUser.Rows(e.RowIndex).Cells(4).Value = "online" Then
            DgvUser.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.Green
        Else
            DgvUser.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.Red
        End If
    End Sub
    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            BoxMessage.Enabled = False
            BoxMessage.Text = "File Attach"
            FileToUpload = OpenFileDialog.FileName
            FileUploaded = UploadLocation & OpenFileDialog.SafeFileName
            Dim ctr = 0
            While System.IO.File.Exists(FileUploaded)
                ctr = ctr + 1
                FileUploaded = UploadLocation & ctr.ToString & "_" & OpenFileDialog.SafeFileName
            End While
        Else
            BoxMessage.Enabled = True
            BoxMessage.Clear()
            FileToUpload = ""
            FileUploaded = ""
        End If
    End Sub

    Private Sub BoxMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles BoxMessage.KeyDown
        TimerTyping.Enabled = False
        If Not IsTyping Then
            IsTyping = True
            Dim msg As New TcpData()
            Dim obj As New ActionMessage()
            obj.idUserSender = My.Settings.id_user
            obj.idUserReciever = UserIDReciever
            obj.action = "typinginfo"
            obj.booleanValue = IsTyping
            msg.actionmessage = obj
            msg.type = obj.GetType().Name
            msg.remark = ""
            TcpHelper.TcpSend(msg.getJsonString)
        End If
        If Not (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) And e.KeyCode = Keys.Enter Then
            e.Handled = True
            If Not String.IsNullOrWhiteSpace(BoxMessage.Text) Then SendData(BoxMessage.Text, UserIDReciever)
        End If
    End Sub

    Private Sub BoxMessage_KeyUp(sender As Object, e As KeyEventArgs) Handles BoxMessage.KeyUp
        TimerTyping.Enabled = True
    End Sub


    Private Sub TimerTyping_Tick(sender As Object, e As EventArgs) Handles TimerTyping.Tick
        If IsTyping Then
            IsTyping = False
            Dim msg As New TcpData()
            Dim obj As New ActionMessage()
            obj.idUserSender = My.Settings.id_user
            obj.idUserReciever = UserIDReciever
            obj.action = "typinginfo"
            obj.booleanValue = IsTyping
            msg.actionmessage = obj
            msg.type = obj.GetType().Name
            msg.remark = ""
            TcpHelper.TcpSend(msg.getJsonString)
        End If
    End Sub

    Private Sub FormChatting_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        FormMain.SetListenerTcp()
    End Sub

    Private Sub ButtonEndChat_Click(sender As Object, e As EventArgs) Handles ButtonEndChat.Click
        If UserIDReciever = 0 Then Exit Sub
        Dim result As Integer = MessageBox.Show("End Chat Will Delete All Of Chat", "Are You Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ExecuteQuery("delete FROM [ChatMessage] where (UserID = " & My.Settings.id_user & " or UserIDReciever = " & My.Settings.id_user & ") and (UserID = " & UserIDReciever & " or UserIDReciever = " & UserIDReciever & ")")
            PanelMessage.Controls.Clear()
            Dim msg As New TcpData()
            Dim obj As New ActionMessage()
            obj.idUserSender = My.Settings.id_user
            obj.idUserReciever = UserIDReciever
            obj.action = "deletemessage"
            obj.stringValue = "EndChat"
            obj.booleanValue = True
            msg.actionmessage = obj
            msg.type = obj.GetType().Name
            msg.remark = ""
            TcpHelper.TcpSend(msg.getJsonString)
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        TextBoxSearch.Clear()
        showDataGridViewUser(TextBoxSearch.Text)
    End Sub

    Private Sub ButtonEmoji_Click(sender As Object, e As EventArgs) Handles ButtonEmoji.Click
        PanelEmoji.Visible = Not PanelEmoji.Visible
    End Sub

    Private Sub ButtonImage_Click(sender As Object, e As EventArgs) Handles ButtonImage.Click
        OpenFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            BoxMessage.Enabled = False
            BoxMessage.Text = "Image Attached"
            FileToUpload = OpenFileDialog.FileName
            FileUploaded = UploadLocation & OpenFileDialog.SafeFileName
            Try
                ButtonImage.ImageLocation = FileToUpload
            Catch ex As Exception

            End Try
            Dim ctr = 0
            While System.IO.File.Exists(FileUploaded)
                ctr = ctr + 1
                FileUploaded = UploadLocation & Path.GetFileNameWithoutExtension(FileToUpload) & "_" & ctr.ToString & Path.GetExtension(FileToUpload)
            End While
        Else
            BoxMessage.Enabled = True
            BoxMessage.Clear()
            FileToUpload = ""
            FileUploaded = ""
        End If
    End Sub

    Private Sub TimerCheckState_Tick(sender As Object, e As EventArgs) Handles TimerCheckState.Tick
        If TcpHelper.GetTcpClient IsNot Nothing Then
            If TcpHelper.GetTcpClient.Connected Then
                ButtonConnect.Text = "Connect"
            Else
                ButtonConnect.Text = "Disconnect"
            End If
        Else
            ButtonConnect.Text = "Disconnect"
        End If
    End Sub

    Private Sub ButtonConnect_TextChanged(sender As Object, e As EventArgs) Handles ButtonConnect.TextChanged
        If ButtonConnect.Text = "Connect" Then
            TcpHelper.SetListenerData(AddressOf TcpListen)
        End If
    End Sub
End Class