Imports System.Runtime.InteropServices
Public Class FormToast
    <DllImport("user32.dll", EntryPoint:="AnimateWindow")>
    Private Shared Function AnimateWindow(ByVal hWnd As IntPtr, ByVal dwTime As UInteger, ByVal dwFlags As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Const AW_HIDE As Integer = &H10000
    Private Const AW_BLEND As Integer = &H80000

    Private Sub New(ByVal MsgTitle As String, ByVal MsgText As String)
        InitializeComponent()
        Me.TopMost = True
        LabelTitle.Text = MsgTitle
        LabelMessage.Text = MsgText
    End Sub

    Public Shared Sub ShowToast(ByVal MsgTitle As String, ByVal MsgText As String)
        Dim toast = New FormToast(MsgTitle, MsgText)
        toast.Show()
        toast.TimerClose.Enabled = True
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormToast_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AnimateWindow(Me.Handle, 500, AW_HIDE Or AW_BLEND) '500 is the milliseconds to take to fade out
    End Sub

    Private Sub FormToast_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AnimateWindow(Me.Handle, 500, AW_BLEND) '500 is the milliseconds to take to fade in
    End Sub

    Private Sub TimerClose_Tick(sender As Object, e As EventArgs) Handles TimerClose.Tick
        Close()
    End Sub
End Class