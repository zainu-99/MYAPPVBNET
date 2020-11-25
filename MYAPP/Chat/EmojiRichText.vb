
Imports System.Runtime.InteropServices

Public Class EmojiRichText
    Inherits RichTextBox
    <DllImport("kernel32.dll", EntryPoint:="LoadLibraryW", CharSet:=CharSet.Unicode, SetLastError:=True)>
    Shared Function LoadLibraryW(ByVal libname As String) As IntPtr
    End Function
    Public Shared Function LoadLibrary(ByVal libname As String) As IntPtr
        Dim mdl = LoadLibraryW(libname)
        If mdl <> IntPtr.Zero Then
            Return mdl
        Else
            Return Nothing
        End If
    End Function
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Try
                LoadLibrary("MsftEdit.dll")
                cp.ClassName = "RichEdit50W"
            Catch ex As Exception

            End Try
            Return cp
        End Get
    End Property
End Class
