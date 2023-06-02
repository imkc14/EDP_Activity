Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ResidentsForm
    Dim i As Integer
    Private Sub ResidentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTime.Text = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")

        DGV_Load()
        ClearFields()
    End Sub

    Public Sub DGV_Load()
        Try
            dgResidents.Rows.Clear()
            SQL = "SELECT resident_id, r_purok_id, lastname, middlename, firstname, CONVERT(birthdate, DATE) AS birthdate, age, civil_status, religion, sex, raddress, voter FROM residents"
            ConnectToDB()
            CmdSqlRead()
            While dr.Read()
                dgResidents.Rows.Add(New Object() {dr.Item("resident_id"), dr.Item("r_purok_id"), dr.Item("lastname"), dr.Item("middlename"), dr.Item("firstname"), CDate(dr.Item("birthdate")).ToString("yyyy/MM/dd"), dr.Item("age"), dr.Item("civil_status"), dr.Item("religion"), dr.Item("sex"), dr.Item("raddress"), dr.Item("voter")})
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBconnection.Close()
        End Try
    End Sub

    Private Sub add_resi_Click(sender As Object, e As EventArgs) Handles add_resi.Click
        Try
            SQL = "INSERT INTO residents (r_purok_id, lastname, middlename, firstname, birthdate, age, civil_status, religion, sex, raddress, voter) VALUES (@r_purok_id, @lastname, @middlename, @firstname, @birthdate, @age, @civil_status, @religion, @sex, @raddress, @voter)"
            ConnectToDB()
            cmd.CommandText = SQL
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@r_purok_id", CDec(purokID.Text))
            cmd.Parameters.AddWithValue("@lastname", lname.Text)
            cmd.Parameters.AddWithValue("@middlename", mname.Text)
            cmd.Parameters.AddWithValue("@firstname", fname.Text)
            cmd.Parameters.AddWithValue("@birthdate", CDate(birthday.Text))
            cmd.Parameters.AddWithValue("@age", age_box.Text)
            cmd.Parameters.AddWithValue("@civil_status", c_status.Text)
            cmd.Parameters.AddWithValue("@religion", religion_box.Text)
            cmd.Parameters.AddWithValue("@sex", sex_box.Text)
            cmd.Parameters.AddWithValue("@raddress", address.Text)
            cmd.Parameters.AddWithValue("@voter", r_voter.Text)

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("New Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBconnection.Close()
        End Try

        DGV_Load()
        ClearFields()
    End Sub


    Private Sub dgResidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResidents.CellClick
        purokID.Text = dgResidents.CurrentRow.Cells(1).Value
        lname.Text = dgResidents.CurrentRow.Cells(2).Value
        mname.Text = dgResidents.CurrentRow.Cells(3).Value
        fname.Text = dgResidents.CurrentRow.Cells(4).Value
        birthday.Text = dgResidents.CurrentRow.Cells(5).Value
        age_box.Text = dgResidents.CurrentRow.Cells(6).Value
        c_status.Text = dgResidents.CurrentRow.Cells(7).Value
        religion_box.Text = dgResidents.CurrentRow.Cells(8).Value
        sex_box.Text = dgResidents.CurrentRow.Cells(9).Value
        address.Text = dgResidents.CurrentRow.Cells(10).Value
        r_voter.Text = dgResidents.CurrentRow.Cells(11).Value

        add_resi.Enabled = False
    End Sub

    Public Sub updateRecord()
        If dgResidents.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgResidents.SelectedRows(0)
            Dim resident_ID As Integer = Convert.ToInt32(selectedRow.Cells("resident_id").Value)

            Try
                SQL = "UPDATE residents SET lastname=@lastname, middlename=@middlename, firstname=@firstname, birthdate=@birthdate, age=@age, civil_status=@civil_status, religion=@religion, sex=@sex, r_purok_id=@r_purok_id, raddress=@raddress, voter=@voter WHERE resident_id=@resident_ID"
                ConnectToDB()
                cmd.CommandText = SQL
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@r_purok_id", CDec(purokID.Text))
                cmd.Parameters.AddWithValue("@lastname", lname.Text)
                cmd.Parameters.AddWithValue("@middlename", mname.Text)
                cmd.Parameters.AddWithValue("@firstname", fname.Text)
                cmd.Parameters.AddWithValue("@birthdate", CDate(birthday.Text))
                cmd.Parameters.AddWithValue("@age", age_box.Text)
                cmd.Parameters.AddWithValue("@civil_status", c_status.Text)
                cmd.Parameters.AddWithValue("@religion", religion_box.Text)
                cmd.Parameters.AddWithValue("@sex", sex_box.Text)
                cmd.Parameters.AddWithValue("@raddress", address.Text)
                cmd.Parameters.AddWithValue("@voter", r_voter.Text)
                cmd.Parameters.AddWithValue("@resident_ID", resident_ID)

                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Record Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                DBconnection.Close()
            End Try
            ClearFields()
            DGV_Load()
        Else
            MessageBox.Show("Please select a resident to update.")
        End If
    End Sub

    Private Sub update_resi_Click(sender As Object, e As EventArgs) Handles update_resi.Click
        updateRecord()
    End Sub

    Public Sub ClearFields()
        lname.Clear()
        mname.Clear()
        fname.Clear()
        sex_box.Text = ""
        age_box.Clear()
        birthday.Value = Now
        c_status.Text = ""
        religion_box.Clear()
        purokID.Text = ""
        address.Text = ""
        r_voter.Text = ""
    End Sub

    Private Sub delete_resi_Click(sender As Object, e As EventArgs) Handles delete_resi.Click
        If dgResidents.SelectedRows.Count > 0 Then
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = dgResidents.SelectedRows(0)
                Dim resident_ID As Integer = Convert.ToInt32(selectedRow.Cells("resident_id").Value)

                Try
                    SQL = "DELETE FROM residents WHERE resident_id = @resident_ID"
                    ConnectToDB()
                    cmd.CommandText = SQL
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@resident_ID", resident_ID)

                    i = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MessageBox.Show("Record Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    DBconnection.Close()
                End Try

                DGV_Load()
            End If
        Else
            MessageBox.Show("Please select a resident to delete.")
        End If

        ClearFields()
    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        dgResidents.Rows.Clear()
        Try
            SQL = "SELECT * FROM residents WHERE resident_id LIKE '%" & search_box.Text & "%' OR lastname LIKE '%" & search_box.Text & "%' OR middlename LIKE '%" & search_box.Text & "%' OR firstname LIKE '%" & search_box.Text & "%'"
            ConnectToDB()
            cmd.CommandText = SQL
            CmdSqlRead()
            While dr.Read()
                dgResidents.Rows.Add(dr.Item("resident_id"), dr.Item("lastname"), dr.Item("middlename"), dr.Item("firstname"), dr.Item("sex"), CDate(dr.Item("birthdate")).ToString("yyyy/MM/dd"), dr.Item("age"), dr.Item("civil_status"), dr.Item("religion"), dr.Item("r_purok_id"), dr.Item("raddress"), dr.Item("voter"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBconnection.Close()
        End Try
    End Sub

    Private Sub dashboard_tab_Click(sender As Object, e As EventArgs) Handles dashboard_tab.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub residents_tab_Click(sender As Object, e As EventArgs) Handles residents_tab.Click
        Me.Show()
    End Sub

    Private Sub logout_tab_Click(sender As Object, e As EventArgs) Handles logout_tab.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub purok_tab_Click(sender As Object, e As EventArgs) Handles purok_tab.Click
        PurokForm.Show()
        Me.Hide()
    End Sub

    Private Sub officials_tab_Click(sender As Object, e As EventArgs) Handles officials_tab.Click
        OfficialsForm.Show()
        Me.Hide()
    End Sub

    Private Sub importdata_Click(sender As Object, e As EventArgs) Handles importdata.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.ShowDialog()

        If openFileDialog.FileName <> "" Then
            Dim tableName As String = "residents"

            Try
                Using reader As New StreamReader(openFileDialog.FileName)

                    Dim header As String = reader.ReadLine()

                    Dim columns As String() = header.Split(",")
                    Dim columnCount As Integer = columns.Length

                    Dim sqlInsert As String = $"INSERT INTO residents ({String.Join(",", columns)}) VALUES "

                    ConnectToDB()

                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim values As String() = line.Split(",")

                        Dim sqlValues As String = "(" & String.Join(",", Enumerable.Range(0, columnCount).Select(Function(i) $"@param{i}")) & ")"

                        Dim command As New MySqlCommand(sqlInsert & sqlValues, DBconnection)
                        For i As Integer = 0 To columnCount - 1
                            command.Parameters.AddWithValue($"@param{i}", values(i))
                        Next

                        command.ExecuteNonQuery()
                    End While

                    DBconnection.Close()

                    MessageBox.Show("Data imported successfully!", "Import Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DGV_Load()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error importing data: " & ex.Message, "Import Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call exportToExcel(Me.dgResidents, "resident_masterlist.xlsx")
    End Sub

End Class