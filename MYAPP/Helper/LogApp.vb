Class LogApp
    Public Shared Sub Show(ByVal TableName, ByVal Note)
        ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Select','" & ReplaceStrQuote(TableName) & "','-','-',GETDATE(),'" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & " - " & FormMain.FormActive & " - " & ReplaceStrQuote(Note) & "','" & My.Settings.id_user & "')")
    End Sub
    Public Shared Sub Insert(ByVal TableName, ByVal Data, ByVal Note)
        ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Insert','" & ReplaceStrQuote(TableName) & "','-','" & ReplaceStrQuote(Data) & "',GETDATE(),'" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & " - " & FormMain.FormActive & " - " & ReplaceStrQuote(Note) & "','" & My.Settings.id_user & "')")
    End Sub
    Public Shared Sub Update(ByVal TableName, ByVal DataBefore, ByVal DataAfter, ByVal Note)
        ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Update','" & ReplaceStrQuote(TableName) & "','" & ReplaceStrQuote(DataBefore) & "','" & ReplaceStrQuote(DataAfter) & "',GETDATE(),'" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & " - " & FormMain.FormActive & " - " & ReplaceStrQuote(Note) & "','" & My.Settings.id_user & "')")
    End Sub
    Public Shared Sub Delete(ByVal TableName, ByVal data, ByVal Note)
        ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Delete','" & ReplaceStrQuote(TableName) & "','" & ReplaceStrQuote(data) & "','-','" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "','" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & " - " & FormMain.FormActive & " - " & ReplaceStrQuote(Note) & "','" & My.Settings.id_user & "')")
    End Sub
    Public Shared Sub Login()
        ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Login','-','-','-',GETDATE(),'" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & "','" & My.Settings.id_user & "')")
    End Sub
    Public Shared Sub Logout()
        ExecuteQuery("insert into LogApp ([Action],TableName,DataBefore,DataAfter,[Datetime],Note,UserID) values('Logout','-','-','-',GETDATE(),'" & GetComputerInfo.GetHostName & ":" & GetComputerInfo.GetIPAddress & "','" & My.Settings.id_user & "')")
    End Sub
End Class
