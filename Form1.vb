Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If (uname.Text = "" And pass_txt.Text = "") Then
            MsgBox("Please enter your username and password.")
            uname.Focus()
            Exit Sub
        End If
        If (uname.Text = "") Then
            MsgBox("Please enter your username.")
            uname.Focus()
            Exit Sub
        End If
        If (pass_txt.Text = "") Then
            MsgBox("Please enter your password.")
            uname.Focus()
            Exit Sub
        End If

        SQL = "SELECT * FROM users WHERE username = '" & uname.Text & "' AND password = '" & pass_txt.Text & "'"
        ConnectToDB()
        CmdSqlRead()
        If dr.Read Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password.")
            uname.Text = ""
            pass_txt.Text = ""
        End If
        DBconnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class
