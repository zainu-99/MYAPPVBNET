Public Class GetComputerInfo
    Public Shared Function GetIPAddress()
#Disable Warning BC40000 ' Type or member is obsolete
        Return System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()
#Enable Warning BC40000 ' Type or member is obsolete
    End Function

    Public Shared Function GetHostName()
        Return System.Net.Dns.GetHostName()
    End Function
End Class
