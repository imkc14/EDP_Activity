Imports System.IO
Imports System.Runtime.CompilerServices
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Module VariablesModule
    Public DBconnection As MySqlConnection = New MySqlConnection
    Public SQL As String
    Public dr As MySqlDataReader
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand

    Public currentDate As DateTime = DateTime.Now
    Public strpassword = ""
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\dataXLS\"
    Public Sub ConnectToDB()

        Dim DBConnectionstring As String = "server=localhost;Uid=root;port=3306;password='nantizakc';database=barangayis_db"

        With DBconnection
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionstring
                .Open()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Error!")
                Call DisconnectToDB()
            End Try
        End With

    End Sub

    Public Sub DisconnectToDB()
        With DBconnection
            .Close()
            .Dispose()
        End With
    End Sub

    Public Sub CmdSqlRead()
        cmd.CommandText = SQL
        cmd.CommandType = CommandType.Text
        cmd.Connection = DBconnection
        dr = cmd.ExecuteReader
    End Sub

    Public Sub exportToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)
        'xlsCell = xlsSheet.Range("A1")
        'xlsSheet.Cells(3, 1) = strfilter
        Dim x, y As Integer
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 15, y + 1) = mydg.Rows(x).Cells(y).Value
            Next
        Next
        With xlsSheet.Range(convertToLetters(1) & 15, convertToLetters(mydg.ColumnCount) & x + 13)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        End With

        'xlsSheet.Cells(1, 1) = "Mike"
        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx"
        MsgBox(myfilename)
        xlsSheet.Protect(strpassword)
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)
    End Sub

    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module

