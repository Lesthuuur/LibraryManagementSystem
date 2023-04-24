Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class librarianLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public userType As String = Functions.librarianLogin.currentUserType
    Private Sub createAccLbl_Click(sender As Object, e As EventArgs) Handles librarianCreateAccLbl.Click
        librarianRegistration.Show()
        clearTextbox(Me)
    End Sub

    Public isLibrarian As Boolean = False
    Public publicUsername As String
    Public publicPassword As String
    Private Sub librarianLogButton_Click(sender As Object, e As EventArgs) Handles librarianLogButton.Click
        userType = "librarian"
        publicPassword = librarianPassLogTextBox.Text
        openConnnection()
        Try
            sql = "SELECT * FROM librarian WHERE username = @username"
            cmd = New MySqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@username", librarianUserLogTextBox.Text)

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If librarianUserLogTextBox.Text = "" Or librarianPassLogTextBox.Text = "" Then
                MsgBox("All fields are required!")
            Else

                If dt.Rows.Count > 0 Then
                    Dim username = dt.Rows(0).Item("username")
                    Dim password = dt.Rows(0).Item("password")
                    publicUsername = username
                    publicPassword = librarianPassLogTextBox.Text

                    Dim hashedPassword = HashPassword(librarianPassLogTextBox.Text())

                    If username = librarianUserLogTextBox.Text() And password = hashedPassword Then

                        MessageBox.Show("Login Success!")
                        Home.Show()
                        Me.Hide()
                        welcomePage.Hide()
                        connection.Close()
                        clearTextbox(Me)

                    Else
                        MessageBox.Show("Incorrect")

                    End If
                Else
                    MessageBox.Show("Incorrect, please try again!")

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()

    End Sub
    Private Sub librarianLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        librarianRegistration.Hide()
        welcomePage.Show()
    End Sub
    Private Sub librarianLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerAll(Me)
    End Sub

    Private Sub librarianLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        librarianUserLogTextBox.Select()
    End Sub

    Private Sub showPassLbl_Click(sender As Object, e As EventArgs) Handles showPassLbl.Click
        If librarianPassLogTextBox.PasswordChar = "*" Then
            librarianPassLogTextBox.PasswordChar = ""
            showPassLbl.Text = "Hide Password"

        Else
            librarianPassLogTextBox.PasswordChar = "*"
            showPassLbl.Text = "Show Password"

        End If
    End Sub
End Class