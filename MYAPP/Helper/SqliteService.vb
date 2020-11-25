Imports System.Data.SQLite

Module SQLiteiteService
    Public SQLiteconn As SQLiteConnection
    Public SQLiteda As SQLiteDataAdapter
    Public SQLitedr As SQLiteDataReader
    Public SQLiteds As DataSet
    Public SQLitecmd As SQLiteCommand
    Public SQLitebs As New BindingSource
    Dim strcon As String
    Public username As String
    Sub setSqliteConnection(stringConnection As String)
        strcon = stringConnection
    End Sub
    'fungsi dataAdapter
    Function getSqliteAdapter(stringQuery As String) As SQLiteDataAdapter
        Dim SQLitecon = New SQLiteConnection(strcon)
        SQLitecon.Open()
        Dim SQLiteDataAdapter = New SQLiteDataAdapter()
        Try
            SQLiteDataAdapter = New SQLiteDataAdapter(stringQuery, SQLitecon)
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getAdapter", ex.Message, "")
        End Try
        SQLitecon.Close()
        Return SQLiteDataAdapter
    End Function
    'fungsi dataSet
    Function getSqliteDataSet(stringQuery As String) As DataSet
        Dim SQLitecon = New SQLiteConnection(strcon)
        SQLitecon.Open()
        Dim dataSet = New DataSet()
        Try
            Dim dataAdapter = New SQLiteDataAdapter(stringQuery, SQLitecon)
            dataAdapter.Fill(dataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getDataSet", ex.Message, "")
        End Try
        SQLitecon.Close()
        Return dataSet
    End Function
    'fungsi SQLiteCommand tanpa execute
    Function getSqliteCommand(stringQuery As String) As ModSQLiteCommand
        Dim msc = New ModSQLiteCommand
        Try
            Dim SQLitecon = New SQLiteConnection(strcon)
            SQLitecon.Open()
            Dim SQLiteCommand = New SQLiteCommand(stringQuery, SQLitecon)
            msc.SQLiteConnection = SQLitecon
            msc.SQLiteCommand = SQLiteCommand
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getCommand", ex.Message, "")
        End Try
        Return msc
    End Function
    'fungsi SQLiteCommand menggunakan execute
    Sub ExecuteSqliteQuery(ByVal stringQuery)
        Dim SQLitecon = New SQLiteConnection(strcon)
        SQLitecon.Open()
        Dim com = New SQLiteCommand(stringQuery, SQLitecon)
        Try
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("ExecuteQuery", ex.Message, "")
        End Try
        SQLitecon.Close()
    End Sub
    'fungsi dataReader
    Function getSqliteDataReader(ByVal stringQuery) As ModSQLiteRaeder
        Dim msr = New ModSQLiteRaeder
        Try
            Dim SQLitecon = New SQLiteConnection(strcon)
            SQLitecon.Open()
            Dim com = New SQLiteCommand(stringQuery, SQLitecon)
            msr.SQLiteConnection = SQLitecon
            msr.SQLiteDataReader = com.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogError.Write(ex.Message)
            LogError.Insert("getDataReader", ex.Message, "")
        End Try
        Return msr
    End Function


    Class ModSQLiteCommand
        Public SQLiteCommand As SQLiteCommand
        Public SQLiteConnection As SQLiteConnection

    End Class

    Class ModSQLiteRaeder
        Public SQLiteDataReader As SQLiteDataReader
        Public SQLiteConnection As SQLiteConnection
    End Class

End Module
