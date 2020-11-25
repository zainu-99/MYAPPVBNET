Module AuthHelper
    Private DataSetAuth As DataTable

    Sub InitUserAut()
        DataSetAuth = getDataTable("select a.allow_view,b.name,allow_view,allow_add,allow_update,allow_delete,allow_print,allow_custom_access from UserRole a left join Roles b on a.id_role = b.id where a.id_user=" & My.Settings.id_user)
    End Sub
    Function GetAutUserView(ByVal RoleName As String) As Boolean
        If DataSetAuth.Select("name = '" & RoleName & "' and allow_view=1").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetAutUserAdd(ByVal RoleName As String) As Boolean
        If DataSetAuth.Select("name = '" & RoleName & "' and allow_add=1").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetAutUserEdit(ByVal RoleName As String) As Boolean
        If DataSetAuth.Select("name = '" & RoleName & "' and allow_update=1").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetAutUserDelete(ByVal RoleName As String) As Boolean
        If DataSetAuth.Select("name = '" & RoleName & "' and allow_delete=1").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetAutUserPrint(ByVal RoleName As String) As Boolean
        If DataSetAuth.Select("name = '" & RoleName & "' and allow_print=1").Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetAutUserCustom(ByVal RoleName As String) As Int32
        Return DataSetAuth.Select("name = '" & RoleName & "'")(0).Item("allow_custom_access")
    End Function
End Module
