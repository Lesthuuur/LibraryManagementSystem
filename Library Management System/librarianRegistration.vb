Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class librarianRegistration
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub librarianRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerAll(Me)
        welcomePage.Hide()
        librarianLogin.Hide()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub adminRegButton_Click_1(sender As Object, e As EventArgs) Handles adminRegButton.Click

        openConnnection()

        If librarianLnameRegTextBox.Text = "" Or librarianFnameRegTextBox.Text = "" Or librarianMnameRegTxtBox.Text = "" _
            Or librarianUserRegTextBox.Text = "" Or librarianPassRegTextBox.Text = " " Then

            MessageBox.Show("All fields are required!")

        ElseIf librarianPassRegTextBox.Text.Length < 8 Then
            MessageBox.Show("Password must be 8 characters long!")

        ElseIf Not Regex.IsMatch(librarianPassRegTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$") Then
            ' The password does not meet the requirements
            MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter,
            one digit, and one special character.")

        ElseIf librarianPassRegTextBox.Text <> reEnterPassTxtbox.Text() Then
            MessageBox.Show("Password does not match!")

        Else

            Try
                sql = "INSERT INTO librarian(librarian_lastName, librarian_firstName, librarian_MidName, username, password)
            VALUES (@lastname, @firstname, @middlename, @username,  SHA2(@password, 256))"

                cmd = New MySqlCommand(sql, connection)

                cmd.Parameters.AddWithValue("@lastname", librarianLnameRegTextBox.Text)
                cmd.Parameters.AddWithValue("@firstname", librarianFnameRegTextBox.Text)
                cmd.Parameters.AddWithValue("@middlename", librarianMnameRegTxtBox.Text)
                cmd.Parameters.AddWithValue("@username", librarianUserRegTextBox.Text)
                cmd.Parameters.AddWithValue("@password", librarianPassRegTextBox.Text)


                da = New MySqlDataAdapter(cmd)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Registration Complete!")
                MessageBox.Show("Proceed to login!")
                librarianLogin.Show()
                clearTextbox(Me)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try

            connection.Close()
        End If

    End Sub

    Private Sub librarianRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        librarianLogin.Show()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearTextbox(Me)
    End Sub

    Private Sub showPassLbl_Click(sender As Object, e As EventArgs) Handles showPassLbl.Click
        If librarianPassRegTextBox.PasswordChar = "*" Then
            librarianPassRegTextBox.PasswordChar = ""
            showPassLbl.Text = "Hide Password"

        Else
            librarianPassRegTextBox.PasswordChar = "*"
            showPassLbl.Text = "Show Password"

        End If
    End Sub
End Class