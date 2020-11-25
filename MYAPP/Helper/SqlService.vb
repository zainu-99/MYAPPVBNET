Imports System.Data.SqlClient
Imports System.Data.SQLite

Module SqlService

    Private sqlconn As New SqlConnection
    Private sqlda As New SqlDataAdapter
    Private sqldr As  SqlDataReader
    Private sqlds As New DataSet
    Private sqlcmd As New SqlCommand
    Private sqlbs As New BindingSource
    Dim strcon As String

    Public Property StrConnectionDB As String
        Get
            Return strcon
        End Get
        Set(value As String)
            strcon = value
        End Set
    End Property

    'fungsi dataAdapter
    Function getAdapter(stringQuery As String) As SqlDataAdapter
        Dim sqlcon = New SqlConnection(StrConnectionDB)
        sqlcon.Open()
        Dim sqlDataAdapter = New SqlDataAdapter()
        Try
            sqlDataAdapter = New SqlDataAdapter(stringQuery, sqlcon)
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getAdapter", ex.Message, "")
        End Try
        sqlcon.Close()
        Return sqlDataAdapter
    End Function
    'fungsi dataSet
    Function getDataSet(Optional ByVal stringQuery As String = Nothing, Optional ByVal tableName As String = "Table") As DataSet
        If stringQuery = Nothing Then
            Return sqlds
        End If
        Dim sqlcon = New SqlConnection(StrConnectionDB)
        sqlcon.Open()
        Try
            Dim dataAdapter = New SqlDataAdapter(stringQuery, sqlcon)
            If sqlds.Tables.Contains(tableName) Then
                sqlds.Tables.Remove(tableName)
            End If
            dataAdapter.Fill(sqlds, tableName)
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getDataSet", ex.Message, "")
        End Try
        sqlcon.Close()
        Return sqlds
    End Function

    Function getDataTable(Optional ByVal stringQuery As String = Nothing, Optional ByVal tableName As String = "Table") As DataTable
        If stringQuery = Nothing Then Return sqlds.Tables(tableName)
        Dim sqlcon = New SqlConnection(StrConnectionDB)
        sqlcon.Open()
        Try
            Dim dataAdapter = New SqlDataAdapter(stringQuery, sqlcon)
            If sqlds.Tables.Contains(tableName) Then
                sqlds.Tables.Remove(tableName)
            End If
            dataAdapter.Fill(sqlds, tableName)
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getDataSet", ex.Message, "")
        End Try
        sqlcon.Close()
        Return sqlds.Tables(tableName)
    End Function
    'fungsi sqlCommand tanpa execute
    Function getCommand(stringQuery As String) As ModSqlCommand
        Dim msc = New ModSqlCommand
        Try
            Dim sqlcon = New SqlConnection(StrConnectionDB)
            sqlcon.Open()
            Dim sqlCommand = New SqlCommand(stringQuery, sqlcon)
            msc.sqlConnection = sqlcon
            msc.sqlCommand = sqlCommand
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getCommand", ex.Message, "")
        End Try
        Return msc
    End Function
    'fungsi sqlCommand menggunakan execute
    Function ExecuteQuery(ByVal stringQuery) As ExecuteQueryReturn
        Dim sqlcon = New SqlConnection(StrConnectionDB)
        sqlcon.Open()
        Dim com = New SqlCommand(stringQuery, sqlcon)
        Try
            com.ExecuteNonQuery()
            Return New ExecuteQueryReturn()
        Catch ex As Exception
            LogError.Write(ex.Message)
            LogError.Insert("ExecuteQuery", ex.Message, "")
            Dim eqr As New ExecuteQueryReturn()
            eqr.success = False
            eqr.message = ex.Message
            Return eqr
        End Try
        sqlcon.Close()
    End Function
    'fungsi dataReader
    Function getDataReader(ByVal stringQuery) As ModSqlRaeder
        Dim msr = New ModSqlRaeder
        Try
            Dim sqlcon = New SqlConnection(StrConnectionDB)
            sqlcon.Open()
            Dim com = New SqlCommand(stringQuery, sqlcon)
            msr.sqlConnection = sqlcon
            msr.sqlDataReader = com.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getDataReader", ex.Message, "")
        End Try
        Return msr
    End Function


    Class ModSqlCommand
        Public sqlCommand As SqlCommand
        Public sqlConnection As SqlConnection

    End Class

    Class ModSqlRaeder
        Public sqlDataReader As SqlDataReader
        Public sqlConnection As SqlConnection
    End Class

    Class ExecuteQueryReturn
        Public success As Boolean = True
        Public message As String = ""
    End Class


End Module

