﻿Imports System.Collections.ObjectModel

Namespace My
    Partial Friend Class MyApplication
        Private WithEvents Domain As AppDomain = AppDomain.CurrentDomain
        Private Function DomainCheck(sender As Object, e As System.ResolveEventArgs) As System.Reflection.Assembly Handles Domain.AssemblyResolve
            If e.Name.Contains("Newtonsoft.Json") Then
                Return System.Reflection.Assembly.Load(My.Resources.Newtonsoft_Json)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace
