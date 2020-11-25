Public Class FormLogin

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        DoLogin()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub TextBoxUserId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserId.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            DoLogin()
        End If
    End Sub

    Sub DoLogin()
        Dim user = getDataTable("select * from Users where userid ='" & ReplaceStrQuote(TextBoxUserId.Text) & "' and status =1 and  password='" & GetHashMD5(TextBoxPassword.Text) & "'")
        If user.Rows().Count > 0 Then
            My.Settings.id_user = user.Rows(0).Item(0)
            My.Settings.userid = user.Rows(0).Item(1)
            My.Settings.name = user.Rows(0).Item(2)
            LogApp.Login()
            Hide()
            FormMain.Show()
        Else
            MsgBox("Password Or UserId Is Wrong Or Account Disable")
        End If
        If CheckBoxRemember.Checked Then
            My.Settings.userid_remember = TextBoxUserId.Text
            My.Settings.passsword_remember = TextBoxPassword.Text
        End If
        My.Settings.Save()
    End Sub

    Private Sub FormLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'setConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" & Application.StartupPath() & "\DatabaseLocal.mdf"";Integrated Security=True")
        'setConnection("Data Source=" & Application.StartupPath() & "\MYAPP.db;Version=3")
        TextBoxUserId.Text = My.Settings.userid_remember
        TextBoxPassword.Text = My.Settings.passsword_remember
        'Label3.Text = Label3.Text.Substring(0, 5)
    End Sub
End Class