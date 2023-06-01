Imports System.IO
Imports MySql.Data.MySqlClient

Public Class OfficialsForm
    Dim i As Integer
    Private Sub OfficialsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTime.Text = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Brgy_Load()
        ClearOffFields()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Captain'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        brgy_captain.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Secretary'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        brgy_secretary.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Treasurer'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        brgy_treasurer.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 1'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad1.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 2'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad2.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 3'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad3.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 4'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad4.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 5'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad5.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 6'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad6.Text = dr("full_name").ToString()
        DBconnection.Close()

        SQL = "SELECT full_name FROM bg_officials WHERE position = 'Barangay Kagawad 7'"
        ConnectToDB()
        CmdSqlRead()
        dr.Read()
        kagawad7.Text = dr("full_name").ToString()
        DBconnection.Close()

    End Sub

    Public Sub Brgy_Load()
        Try
            dgBrgyOfficials.Rows.Clear()
            SQL = "SELECT bg_official_id, position, full_name, start_term, end_term, term_index FROM bg_officials"
            ConnectToDB()
            CmdSqlRead()
            While dr.Read()
                dgBrgyOfficials.Rows.Add(New Object() {dr.Item("bg_official_id"), dr.Item("position"), dr.Item("full_name"), CDate(dr.Item("start_term")).ToString("yyyy/MM/dd"), CDate(dr.Item("end_term")).ToString("yyyy/MM/dd"), dr.Item("term_index")})
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBconnection.Close()
        End Try
    End Sub

    Public Sub updateOffRecord()
        If dgBrgyOfficials.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgBrgyOfficials.SelectedRows(0)
            Dim official_ID As Integer = Convert.ToInt32(selectedRow.Cells("brgy_official_id").Value)

            Try
                SQL = "UPDATE bg_officials SET position=@position, full_name=@full_name, start_term=@start_term, end_term=@end_term, term_index=@term_index WHERE bg_official_id=@official_ID"
                ConnectToDB()
                cmd.CommandText = SQL
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@official_ID", official_ID)
                cmd.Parameters.AddWithValue("@position", position_box.Text)
                cmd.Parameters.AddWithValue("@full_name", name_box.Text)
                cmd.Parameters.AddWithValue("@start_term", CDate(start_term.Text))
                cmd.Parameters.AddWithValue("@end_term", CDate(end_term.Text))
                cmd.Parameters.AddWithValue("@term_index", (term_index.Text))

                Dim affectedRows As Integer = cmd.ExecuteNonQuery()
                If affectedRows > 0 Then
                    MessageBox.Show("Record Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                DBconnection.Close()
            End Try

            ClearOffFields()
            Brgy_Load()
        Else
            MessageBox.Show("Please select an official to update.")
        End If
    End Sub

    Private Sub update_off_Click(sender As Object, e As EventArgs) Handles update_off.Click
        updateOffRecord()
    End Sub

    Public Sub ClearOffFields()
        position_box.Clear()
        name_box.Clear()
        start_term.Value = Now
        end_term.Value = Now
        term_index.Clear()
    End Sub


    Private Sub dashboard_tab_Click(sender As Object, e As EventArgs) Handles dashboard_tab.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub residents_tab_Click(sender As Object, e As EventArgs) Handles residents_tab.Click
        ResidentsForm.Show()
        Me.Hide()
    End Sub

    Private Sub purok_tab_Click(sender As Object, e As EventArgs) Handles purok_tab.Click
        PurokForm.Show()
        Me.Hide()
    End Sub
    Private Sub officials_tab_Click(sender As Object, e As EventArgs) Handles officials_tab.Click
        Me.Show()
    End Sub

    Private Sub add_off_Click(sender As Object, e As EventArgs) Handles add_off.Click
        Try
            SQL = "INSERT INTO bg_officials (position, full_name, start_term, end_term, term_index) VALUES (@position, @full_name, @start_term, @end_term, @term_index)"
            ConnectToDB()
            cmd.CommandText = SQL
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@position", position_box.Text)
            cmd.Parameters.AddWithValue("@full_name", name_box.Text)
            cmd.Parameters.AddWithValue("@start_term", CDate(start_term.Text))
            cmd.Parameters.AddWithValue("@end_term", CDate(end_term.Text))
            cmd.Parameters.AddWithValue("@term_index", term_index.Text)

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

        Brgy_Load()
        ClearOffFields()
    End Sub

    Private Sub delete_off_Click(sender As Object, e As EventArgs) Handles delete_off.Click
        If dgBrgyOfficials.SelectedRows.Count > 0 Then
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = dgBrgyOfficials.SelectedRows(0)
                Dim official_ID As Integer = Convert.ToInt32(selectedRow.Cells("brgy_official_id").Value)

                Try
                    SQL = "DELETE FROM bg_officials WHERE bg_official_id = @official_ID"
                    ConnectToDB()
                    cmd.CommandText = SQL
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@official_ID", official_ID)

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

                Brgy_Load()
            End If
        Else
            MessageBox.Show("Please select an official to delete.")
        End If

        ClearOffFields()
    End Sub

    Private Sub dgBrgyOfficials_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBrgyOfficials.CellClick
        position_box.Text = dgBrgyOfficials.CurrentRow.Cells(1).Value
        name_box.Text = dgBrgyOfficials.CurrentRow.Cells(2).Value
        start_term.Text = dgBrgyOfficials.CurrentRow.Cells(3).Value
        end_term.Text = dgBrgyOfficials.CurrentRow.Cells(4).Value
        term_index.Text = dgBrgyOfficials.CurrentRow.Cells(5).Value

        add_off.Enabled = False
    End Sub

    Private Sub logout_tab_Click(sender As Object, e As EventArgs) Handles logout_tab.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class