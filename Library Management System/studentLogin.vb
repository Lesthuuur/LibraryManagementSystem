
Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Library_Management_System.Module1
Imports System.Security.Cryptography
Imports System.Text
Imports Org.BouncyCastle.Bcpg.OpenPgp

Public Class studentLogin
    Public isStudent As Boolean = False

    Private Sub studentCreateAccLbl_Click(sender As Object, e As EventArgs) Handles studentCreateAccLbl.Click
        studentRegistration.Show()
        clearTextbox(Me)
    End Sub

    Public studenID As String
    Public userType As String = Functions.studentLogin.currentUserType
    Private Sub studentLogButton_Click_1(sender As Object, e As EventArgs) Handles studentLogButton.Click
        userType = "student"
        'LOGIN AUTHENTICATION
        openConnnection()
        Try
            sql = "SELECT * FROM students WHERE username = @username"
            cmd = New MySqlCommand(sql, connection)

            cmd.Parameters.AddWithValue("@username", studentUserLogTextBox.Text())

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If studentUserLogTextBox.Text = "" Or studentPassLogTextBox.Text = "" Then
                MsgBox("All fields are required!")

            Else
                If dt.Rows.Count > 0 Then
                    Dim username = dt.Rows(0).Item("username")
                    Dim password = dt.Rows(0).Item("password")
                    studenID = dt.Rows(0).Item("student_id")
                    Dim hashedPassword = HashPassword(studentPassLogTextBox.Text())

                    If username = studentUserLogTextBox.Text() And password = hashedPassword Then
                        MessageBox.Show("Login Success!")
                        Home.Show()
                        Me.Hide()
                        clearTextbox(Me)
                        welcomePage.Hide()

                    ElseIf username <> studentUserLogTextBox.Text Or password <> hashedPassword Then
                        MessageBox.Show("Username or password does not match!")

                    End If

                Else
                    MessageBox.Show("Incorrect, please try again!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
        End Try
    End Sub

    Private Sub studentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerAll(Me)
        fixSize(Me)
        studentUserLogTextBox.Select()
    End Sub

    Private Sub studentLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        studentRegistration.Hide()
        welcomePage.Show()
    End Sub

    Private Sub studentLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        studentUserLogTextBox.Select()
    End Sub

    Private Sub showPassLbl_Click(sender As Object, e As EventArgs) Handles showPassLbl.Click
        If studentPassLogTextBox.PasswordChar = "*" Then
            studentPassLogTextBox.PasswordChar = ""
            showPassLbl.Text = "Hide Password"


        Else
            studentPassLogTextBox.PasswordChar = "*"
            showPassLbl.Text = "Show Password"

        End If
    End Sub
End Class
