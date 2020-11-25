Imports System.IO

Public Class LogError
    Public Shared Sub Write(ByVal strError As String)
        Dim sPath As String
        If Not Directory.Exists(My.Application.Info.DirectoryPath & "\LogError") Then
            Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\LogError")
        End If
        sPath = My.Application.Info.DirectoryPath & "\LogError\" & Format(Now, "yyyyMMdd") & "LogError.txt"
        File.AppendAllText(sPath, Now & "   " & strError & " - " & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & "-" & FormMain.FormActive & "-" & My.Settings.userid & " " & Chr(13) + Chr(10))
    End Sub
    Public Shared Sub Insert(ByVal action As String, ByVal messageError As String, ByVal Note As String)
        ExecuteQuery("insert into ErrorReport ([Action],MsgError,[Datetime],Note,UserID) values('" & action & "','" & ReplaceStrQuote(messageError) & "',GETDATE(),'" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & " - " & FormMain.FormActive & " - " & Note & "','" & My.Settings.id_user & "')")
    End Sub

End Class
