Imports System.Security.Cryptography
Imports System.Text

Module ModuleUtils
    Function GetHashMD5(theInput As String) As String

        Using hasher As MD5 = MD5.Create()

            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            Dim sBuilder As New StringBuilder()

            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

End Module
