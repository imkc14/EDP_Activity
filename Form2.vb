Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTime.Text = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Me.dgPurok.Rows.Clear()
        SQL = "SELECT * FROM purok"
        ConnectToDB()
        CmdSqlRead()
        While dr.Read()
            Me.dgPurok.Rows.Add(New Object() {dr.Item("purok_name"), dr.Item("population_per_purok")})
        End While
        DBconnection.Close()

        Try
            SQL = "SELECT COUNT(*) FROM residents"
            ConnectToDB()
            Dim cmdd As New MySqlCommand(SQL, DBconnection)
            Dim populationCount As Integer = CInt(cmdd.ExecuteScalar())
            total_population.Text = populationCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            ConnectToDB()
            SQL = "SELECT COUNT(sex) FROM residents WHERE sex = 'Female'"
            Dim comd As New MySqlCommand(SQL, DBconnection)
            Dim femaleCount As Integer = CInt(comd.ExecuteScalar())
            total_female.Text = femaleCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            ConnectToDB()
            SQL = "SELECT COUNT(sex) FROM residents WHERE sex = 'Male'"
            Dim comd As New MySqlCommand(SQL, DBconnection)
            Dim maleCount As Integer = CInt(comd.ExecuteScalar())
            total_male.Text = maleCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try

        Try
            ConnectToDB()
            SQL = "SELECT COUNT(voter) FROM residents WHERE voter ='Yes'"
            Dim comd As New MySqlCommand(SQL, DBconnection)
            Dim voterCount As Integer = CInt(comd.ExecuteScalar())
            total_voters.Text = voterCount.ToString()
        Catch ex As Exception
        Finally
            DBconnection.Close()
        End Try
    End Sub

    Private Sub residents_tab_Click(sender As Object, e As EventArgs) Handles residents_tab.Click
        ResidentsForm.Show()
        Me.Hide()
    End Sub

    Private Sub dashboard_tab_Click(sender As Object, e As EventArgs) Handles dashboard_tab.Click
        Me.Show()
    End Sub

    Private Sub refresh_dashboard_Click(sender As Object, e As EventArgs) Handles refresh_dashboard.Click
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

    Private Sub backupBtn_Click(sender As Object, e As EventArgs) Handles backupBtn.Click

        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ConnectToDB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = DBconnection
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            DBconnection.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

    End Sub


End Class