Imports MySql.Data.MySqlClient

Public Class PurokForm
    Private Sub PurokForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTime.Text = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Me.dgPurokLeaders.Rows.Clear()
        SQL = "SELECT * FROM purok"
        ConnectToDB()
        CmdSqlRead()
        While dr.Read()
            Me.dgPurokLeaders.Rows.Add(New Object() {dr.Item("purok_name"), dr.Item("purok_leader")})
        End While
        DBconnection.Close()

        Me.dgPurok.Rows.Clear()
        SQL = "SELECT * FROM purok"
        ConnectToDB()
        CmdSqlRead()
        While dr.Read()
            Me.dgPurok.Rows.Add(New Object() {dr.Item("purok_id"), dr.Item("purok_name"), dr.Item("population_per_purok")})
        End While
        DBconnection.Close()

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 1 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population1.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 1 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population1.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 2 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population2.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 2 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population2.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 3 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population3.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 3 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population3.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 4 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population4.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 4 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population4.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 5 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population5.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 5 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population5.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 6 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population6.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 6 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population6.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 7 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population7.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 7 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population7.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 8 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population8.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 8 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population8.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 9 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population9.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 9 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population9.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 10 and sex = 'male'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            female_population10.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            SQL = "SELECT COUNT(*) FROM residents WHERE r_purok_id = 10 and sex = 'female'"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            male_population10.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

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
        Me.Show()
    End Sub

    Private Sub logout_tab_Click(sender As Object, e As EventArgs) Handles logout_tab.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub officials_tab_Click(sender As Object, e As EventArgs) Handles officials_tab.Click
        OfficialsForm.Show()
        Me.Hide()
    End Sub

End Class