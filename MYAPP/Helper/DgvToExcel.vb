Imports ClosedXML.Excel
Module DgvToExcel
    Public Sub ExportDgvToExcel(ByVal dgv As DataGridView)
        Try
            If dgv Is Nothing OrElse dgv.RowCount <= 0 Then
                MsgBox("The Data is empty!!!")
                Exit Sub
            End If
            Dim sfdExcel As SaveFileDialog = New SaveFileDialog
            sfdExcel.Filter = "Excel File|*.xlsx"
            sfdExcel.Title = "Save an Excel File"
            sfdExcel.ShowDialog()
            If sfdExcel.FileName = "" Then
                MsgBox("Please Type File Name")
                Exit Sub
            End If
            Dim wb As XLWorkbook = New XLWorkbook
            wb.AddWorksheet(Format(Now, "dd MMM yy"))
            Dim ws = wb.Worksheet(Format(Now, "dd MMM yy"))
            Dim ctrColumn As Int32 = 1
            For Each column As DataGridViewColumn In dgv.Columns
                If column.Visible Then
                    ws.Cell(1, ctrColumn).Value = column.HeaderText
                    With ws.Cell(1, ctrColumn).Style
                        .Font.Bold = True
                        .Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        .Border.OutsideBorder = XLBorderStyleValues.Thin
                        .Fill.BackgroundColor = XLColor.LightGreen
                    End With
                    ws.RowHeight = dgv.ColumnHeadersHeight
                    ctrColumn += 1
                End If
            Next
            For Each row As DataGridViewRow In dgv.Rows
                ctrColumn = 1
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        ws.Cell(cell.RowIndex + 2, ctrColumn).Value = cell.Value.ToString
                        ctrColumn += 1
                    End If
                Next
            Next
            wb.SaveAs(sfdExcel.FileName)
            If MsgBox("Do You Want To Open File", vbQuestion + vbYesNo, "Question?") = vbYes Then
                Process.Start(sfdExcel.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'WriteErrorLog("sub saveExcelFile Form7--> Error saat export data")
        End Try
    End Sub

End Module
