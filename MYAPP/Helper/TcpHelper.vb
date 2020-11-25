Imports System.IO
Imports System.Net.Sockets
Imports Newtonsoft.Json

Public Class TcpHelper
    Private Shared client As TcpClient
    Private Shared sWriter As StreamWriter
    Private Shared listenerData As Action(Of String)
    Public Shared Sub Connect(ipaddress As String, port As Int32)
        Try
            If client IsNot Nothing Then client.Dispose()
            client = New TcpClient(ipaddress, port)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf ListeningData), Nothing)
        Catch ex As Exception
            LogError.Write(ex.Message)
        End Try
    End Sub

    Public Shared Function GetTcpClient() As TcpClient
        Try
            Return client
        Catch ex As Exception
            LogError.Write(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub TcpSend(ByVal messageString As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(messageString)
            sWriter.Flush()
        Catch ex As Exception
            LogError.Write(ex.Message)
        End Try
    End Sub

    Public Shared Sub SetListenerData(listener As Action(Of String))
        listenerData = listener
    End Sub

    Public Shared Function ReadData() As String
        If client IsNot Nothing Then
            Try
                Return New StreamReader(client.GetStream).ReadLine
            Catch ex As Exception
                LogError.Write(ex.Message)
                Return ""
            End Try
        End If
        Return Nothing
    End Function

    Private Shared Sub ListeningData(ByVal ar As IAsyncResult)
        Try
            If TcpHelper.GetTcpClient IsNot Nothing Then
                Try
                    If listenerData IsNot Nothing Then
                        listenerData(New StreamReader(client.GetStream).ReadLine)
                    End If
                Catch ex As Exception
                    LogError.Write(ex.Message)
                    Console.WriteLine(ex.Message)
                End Try
                client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf ListeningData, Nothing)
            End If
        Catch ex As Exception
            LogError.Write(ex.Message)
            Console.WriteLine("Connection lose")
        End Try
    End Sub
    Public Shared Sub Close()
        Try
            If client IsNot Nothing Then client.Dispose()
        Catch ex As Exception
            LogError.Write(ex.Message)
        End Try
    End Sub

End Class
