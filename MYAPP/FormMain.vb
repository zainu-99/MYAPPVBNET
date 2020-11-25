Imports System.IO
Imports System.Reflection
Imports Newtonsoft.Json

Public Class FormMain
#Region "Not For Change"
    Dim formLoading As New FormLoading
    Dim task As Task
#Region "Init Behaviour Form"
    Dim idUser = My.Settings.id_user
    Public FormActive As String = "FormMain"
    Public MyAppIsActive As Boolean = True
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        PanelSideBar.Visible = Not PanelSideBar.Visible
    End Sub
    Private Sub btnMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnMenu.MouseEnter
        btnMenu.BackColor = DesignColor.PanelTitle
    End Sub
    Private Sub btnMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMenu.MouseLeave
        btnMenu.BackColor = DesignColor.PanelHeader
    End Sub
    Sub InitData()
        Dim user = getDataTable("select userid,name,avatar from users where id ='" & My.Settings.id_user & "'")
        LabelUserId.Text = user.Rows(0).Item("userid")
        LabelNama.Text = user.Rows(0).Item("name")
        Try
            Dim bytes As [Byte]() = user.Rows(0).Item("avatar")
            Dim ms As New MemoryStream(bytes)
            PictureBoxProfile.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form To panel"

    Public Sub fillFormToPanel(ByVal obj As Form, Optional roleName As String = Nothing)
        If roleName IsNot Nothing Then obj.Tag = roleName
        If Not GetAutUserView(NothingString(obj.Tag)) And NothingString(obj.Tag) <> "" Then
            MsgBox("You Dont Have Access")
            Exit Sub
        End If
        Try
            ProgressBarLoad.Value = 0
            Application.DoEvents()
            If TabControlForm.Controls.Find(obj.Name, True).Count = 0 Then
                obj.TopLevel = False
                If roleName IsNot Nothing Then obj.Tag = roleName
                AddHandler obj.Shown, AddressOf Form_Shown
                TabControlForm.TabPages.Add(obj.Name, obj.Text)
                TabControlForm.TabPages.Item(obj.Name).Controls.Add(obj)
                obj.Show()
                TabControlForm.SelectTab(obj.Name)
            Else
                TabControlForm.SelectTab(obj.Name)
            End If
            obj.Dock = DockStyle.Fill
            obj.BringToFront()
            FormActive = obj.Name
            LabelTitle.Text = obj.Text
            ProgressBarLoad.Value = 100
        Catch ex As Exception
            MsgBox("Form Name Not Found")
        End Try
    End Sub
    Public Function GetFormInTabControl(ByVal FormName As String) As Form
        If TabControlForm.Controls.Find(FormName, True).Count > 0 Then
            Return TabControlForm.TabPages.Item(FormName).Controls.Find(FormName, True)(0)
        Else
            Return Nothing
        End If
    End Function
    Private Sub Form_Shown(sender As Object, e As EventArgs)
        If sender.Controls.Find("PanelButton", True).Length > 0 Then
            For Each ctrl As MenuStrip In sender.PanelButton.Controls
                For Each item As ToolStripMenuItem In ctrl.Items
                    If item.Tag = "ButtonAdd" And Not GetAutUserAdd(sender.Tag) Then
                        item.Visible = False
                    End If
                    If item.Tag = "ButtonEdit" And Not GetAutUserEdit(sender.Tag) Then
                        item.Visible = False
                    End If
                    If item.Tag = "ButtonDelete" And Not GetAutUserDelete(sender.Tag) Then
                        item.Visible = False
                    End If
                    If item.Tag = "ButtonPrint" And Not GetAutUserPrint(sender.Tag) Then
                        item.Visible = False
                    End If
                    '--Design Color--'
                    If item.Tag = "ButtonAdd" Then
                        item.BackColor = DesignColor.ButtonAdd
                        item.ForeColor = DesignColor.ButtonText
                    End If
                    If item.Tag = "ButtonEdit" Then
                        item.BackColor = DesignColor.ButtonEdit
                        item.ForeColor = DesignColor.ButtonText
                    End If
                    If item.Tag = "ButtonDelete" Then
                        item.BackColor = DesignColor.ButtonDelete
                        item.ForeColor = DesignColor.ButtonText
                    End If
                    If item.Tag = "ButtonSave" Then
                        item.BackColor = DesignColor.ButtonSave
                        item.ForeColor = DesignColor.ButtonText
                    End If
                    If item.Tag = "ButtonRefresh" Then
                        item.BackColor = DesignColor.ButtonRefesh
                        item.ForeColor = DesignColor.ButtonText
                    End If
                Next
            Next
        End If
        If sender.Controls.Find("dgv", True).Length > 0 Then
            Dim dgv As DataGridView = sender.Controls.Find("dgv", True)(0)
            With dgv
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .BorderStyle = BorderStyle.None
                .EnableHeadersVisualStyles = False
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                .AlternatingRowsDefaultCellStyle.BackColor = DesignColor.dgv_AlternatingRowsDefaultCellStyle
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            End With
        End If
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub
#End Region
#Region "Methode"
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlForm.Dock = DockStyle.Fill
        CreateMenuAccess()
        SetDesignMainForm()
        InitData()
        LabelVersion.Text = "Version: " & Me.GetType.Assembly.GetName.Version.ToString
        If AuthHelper.GetAutUserView("Chatting") Then
            task = New Task(AddressOf TcpConnect)
            task.Start()
            CountMessage()
            formLoading.ShowDialog()
        Else
            btnMessage.Visible = False
        End If
    End Sub
    Public Sub TcpConnect()
        Try
            TcpHelper.Connect(ServerTcpAddressForChat, CInt(ServerTcpPortForChat))
            Dim msg As New TcpData()
            Dim obj As New UserConnected()
            obj.idUser = My.Settings.id_user
            obj.status = "online"
            obj.note = ""
            msg.userconnected = obj
            msg.type = obj.GetType().Name
            msg.remark = ""
            TcpHelper.TcpSend(msg.getJsonString)
            SetListenerTcp()
        Catch ex As Exception
            MsgBox("Server Under Maintenance")
        End Try
        closeFormLoading()
    End Sub

    Public Sub SetListenerTcp()
        TcpHelper.SetListenerData(AddressOf TcpReadData)
    End Sub

    Sub TcpReadData(msg As String)
        If InvokeRequired Then
            Invoke(Sub() TcpReadData(msg))
        Else
            Dim tcpData As TcpData = TcpData.getJsonObject(msg)
            If tcpData.type = "ChatMessage" Then
                Dim data = tcpData.chatmessage
                If data.idUserReciever = My.Settings.id_user Then
                    CountMessage()
                    NotifyIconMessage.ShowBalloonTip(250, "New Personal Message", data.message, ToolTipIcon.Info)
                End If
            End If
        End If
    End Sub
    Sub CountMessage()
        Dim query As String = "  select count(id) from ChatMessage where ReadStatus = 0 and UserIDReciever = " & My.Settings.id_user
        Dim countUnread = getDataTable(query).Rows(0).Item(0)
        btnMessage.Text = countUnread
    End Sub
    Sub closeFormLoading()
        If InvokeRequired Then
            Invoke(New Action(AddressOf closeFormLoading))
        Else
            formLoading.Close()
        End If
    End Sub
    'Create Menu
    Sub CreateMenuAccess()
        Dim itemmenu = getDataTable("select ID,MenuTag,MenuText,FormName,IDParentMenu,IconMenu,OrderSort from MenuApp order by OrderSort,MenuText Asc", "MenuApp")
        InitUserAut()
        GetMenuLevel(itemmenu, "IDParentMenu is Null", MenuApp)
    End Sub
    'GetMenuLevel
    Sub GetMenuLevel(dt As DataTable, filter As String, parent As Object)
        For Each dtrow As DataRow In dt.Select(filter)
            If GetAutUserView(dtrow.Item(1)) Then
                Dim obj = CreateMenu(dtrow, parent)
                GetMenuLevel(dt, "IDParentMenu = " & dtrow.Item(0), obj)
            End If
        Next
    End Sub
    Function CreateMenu(itemMenu, parent) As ToolStripMenuItem
        Dim tsm = New ToolStripMenuItem()
        tsm.Name = itemMenu.Item("ID")
        tsm.Tag = itemMenu.Item("MenuTag")
        tsm.Text = itemMenu.Item("MenuText")
        If itemMenu.Item(5).ToString IsNot "" Then
            Dim ImgStream As New IO.MemoryStream(CType(itemMenu.Item(5), Byte()))
            tsm.Image = Image.FromStream(ImgStream)
        End If
        AddHandler tsm.Click, AddressOf CreateMenuEventHandler
        If parent.GetType() Is GetType(ToolStripMenuItem) Then
            parent.DropDownItems.Add(tsm)
        Else
            parent.Items.Add(tsm)
        End If
        Return tsm
    End Function
    Sub CreateMenuEventHandler(sender As Object, e As EventArgs)
        Try
            Dim FormName = getDataTable(Nothing, "MenuApp").Select("ID = " & sender.Name)(0).Item("FormName")
            If FormName IsNot "" Then
                Dim om As New ObjectMenu
                om.Id = CInt(sender.Name)
                om.MenuText = sender.Text
                om._menuTag = sender.Tag
                om.FormName = FormName
                MenuClicked = om
                Dim frm As New Form
                frm = DirectCast(CreateObjectInstance(FormName), Form)
                frm.Tag = sender.Tag
                fillFormToPanel(frm)
            End If
        Catch ex As Exception
            MsgBox("Oops, May Menu Has Been Losed")
        End Try
    End Sub
    Public Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try
            If objectName.LastIndexOf(".") = -1 Then
                objectName = [Assembly].GetEntryAssembly.GetName.Name & "." & objectName
            End If
            obj = [Assembly].GetEntryAssembly.CreateInstance(objectName)
        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj
    End Function
#End Region
    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim msg As New TcpData()
            Dim obj As New UserConnected()
            obj.idUser = My.Settings.id_user
            obj.status = "offline"
            obj.note = ""
            msg.userconnected = obj
            msg.type = obj.GetType().Name
            msg.remark = ""
            TcpHelper.TcpSend(msg.getJsonString)
            TcpHelper.Close()
        Catch ex As Exception
            'MsgBox("")
        End Try
        FormLogin.Show()
        LogApp.Logout()
    End Sub
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        SetDesignMainForm()
        MenuApp.Items.Clear()
        CreateMenuAccess()
        InitData()
        LabelVersion.Text = "Version: " & Me.GetType.Assembly.GetName.Version.ToString
    End Sub
    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        fillFormToPanel(FormChatting)
    End Sub
    'Set Design Color
    Public Sub SetDesignMainForm()
        PanelHeader.BackColor = DesignColor.PanelHeader
        btnMessage.BackColor = DesignColor.PanelHeader
        btnLogout.BackColor = DesignColor.PanelHeader
        PanelTitle.BackColor = DesignColor.PanelTitle
        PanelProfile.BackColor = DesignColor.PanelProfile
        PanelMenu.BackColor = DesignColor.PanelMenuBackground
        LabelVersion.BackColor = DesignColor.PanelFooter
        LabelTitle.ForeColor = DesignColor.TextForeColor
        LabelNama.ForeColor = DesignColor.TextForeColor
        LabelUserId.ForeColor = DesignColor.TextForeColor
        LabelMenu.ForeColor = DesignColor.TextForeColor
    End Sub
    Private Sub FormMainChat_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        MyAppIsActive = True
    End Sub

    Private Sub FormMainChat_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        MyAppIsActive = False
    End Sub

#Region "<<Status Bar Function>>"
    Dim counterSecond = 0
    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        LabelDate.Text = Date.Now.ToString("dd/MM/yyyy")
        LabelClock.Text = DateTime.Now.ToString("hh:mm:ss")
        counterSecond = counterSecond + 1
        LabelCounter.Text = ConvertSecondToHours(counterSecond)
        LabelSignal.Tag = SignalChecker("localhost")
        If LabelSignal.Tag = 999 Then
            PictureBoxSignal.Image = My.Resources.sgnal_no
        ElseIf LabelSignal.Tag < 17 Then
            PictureBoxSignal.Image = My.Resources.signal_hight
        ElseIf LabelSignal.Tag >= 1 Then
            PictureBoxSignal.Image = My.Resources.signal_low
        End If

    End Sub
    Function ConvertSecondToHours(ByVal second) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '

        'Seconds'
        Sec = second Mod 60

        'Minutes'
        Min = ((second - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((second - (Sec + (Min * 60))) / 3600) 'Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function


    Function SignalChecker(ByVal ip)
        Try
            Dim ping As New System.Net.NetworkInformation.Ping
            Return ping.Send(ip).RoundtripTime
        Catch ex As Exception
            Return 999
        End Try
    End Function

    Private Sub ButtonSetting_Click(sender As Object, e As EventArgs) Handles ButtonSetting.Click
        fillFormToPanel(FormAccount)
    End Sub
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Try
            If AuthHelper.GetAutUserView("Chatting") Then
                task = New Task(AddressOf TcpConnect)
                task.Start()
                formLoading.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonHelp_Click(sender As Object, e As EventArgs) Handles ButtonHelp.Click
        MsgBox("Contact Us: Zainu.developer@gmail.com" & vbNewLine & "Website: www.deretcode.com")
    End Sub

    Private Sub TabControlForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlForm.SelectedIndexChanged
        If TabControlForm.SelectedIndex = -1 Then
            LabelTitle.Text = "MYAPPVB CORE SYSTEM"
            Exit Sub
        End If
        LabelTitle.Text = TabControlForm.TabPages(TabControlForm.SelectedIndex).Text
    End Sub

    Private Sub TabControlForm_TabClosing(sender As Object, e As TabControlCancelEventArgs) Handles TabControlForm.TabClosing
        Try
            TabControlForm.SelectTab(e.TabPageIndex - 1)
        Catch ex As Exception
        End Try
    End Sub

#End Region
#End Region
End Class
