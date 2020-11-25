Public Class DgvRowToString
    Public Shared Function Generate(ByVal dgv As DataGridView, ByVal indexRow As Int32) As String
        Dim result = ""
        For Each cell As DataGridViewCell In dgv.Rows(indexRow).Cells
            If cell.GetType IsNot GetType(DataGridViewImageCell) Then
                result = result & dgv.Columns(cell.ColumnIndex).Name.ToString & ":" & cell.Value & ";    "
            End If
        Next
        Return result
    End Function
End Class
