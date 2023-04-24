Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class studentRegistration


    Private Sub studentRegLogButton_Click(sender As Object, e As EventArgs) Handles studentRegLogButton.Click

        openConnnection()

        If studentRegLNameTextBox.Text() = "" Or studentRegFNameTextBox.Text() = "" Or studentRegMNameTextBox.Text() = "" _
            Or studentRegCourseTxtBox.Text() = "" Or studentRegYearSecTextBox.Text() = "" Or studentUserRegTextBox.Text() = "" _
            Or studentPassRegTextBox.Text() = "" Then
            MessageBox.Show("All fields are required!")

        ElseIf studentPassRegTextBox.Text.Length < 8 Then
            MessageBox.Show("Password must be 8 characters long!")

        ElseIf Not Regex.IsMatch(studentPassRegTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$") Then
            ' The password does not meet the requirements
            MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")

        ElseIf studentPassRegTextBox.Text <> reEnterPassTxtbox.Text Then
            MessageBox.Show("Password does not match!")

        Else
            Try



                sql = "INSERT INTO students(student_lastname, student_firstname, student_midName, course, year_section, student_id, username, password) 
                VALUES (@lastname, @firstname, @middlename, @course, @yearSection, @student_ID, @username, SHA2(@password, 256))"
                cmd = New MySqlCommand(sql, connection)



                cmd.Parameters.AddWithValue("@lastname", studentRegLNameTextBox.Text())
                cmd.Parameters.AddWithValue("@firstname", studentRegFNameTextBox.Text())
                cmd.Parameters.AddWithValue("@middlename", studentRegMNameTextBox.Text())
                cmd.Parameters.AddWithValue("@course", studentRegCourseTxtBox.Text())
                cmd.Parameters.AddWithValue("@yearSection", studentRegYearSecTextBox.Text())
                cmd.Parameters.AddWithValue("@student_ID", studentRegIdTextBox.Text())
                cmd.Parameters.AddWithValue("@username", studentUserRegTextBox.Text())
                cmd.Parameters.AddWithValue("@password", studentPassRegTextBox.Text)
                da = New MySqlDataAdapter(cmd)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Registration Complete!")
                MessageBox.Show("Proceed to login!")
                studentLogin.Show()
                connection.Close()
                clearTextbox(Me)
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
            connection.Close()

        End If
        connection.Close()
    End Sub

    Private Sub studentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fixSize(Me)
        centerAll(Me)
        welcomePage.Hide()
        studentLogin.Hide()
        clearTextbox(Me)
    End Sub

    Private Sub studentRegIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentRegIdTextBox.TextChanged
        studentRegIdTextBox.Text = studentRegIdTextBox.Text.ToUpper()
        studentRegIdTextBox.SelectionStart = studentRegIdTextBox.Text.Length
    End Sub

    Private Sub studentRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        studentLogin.Show()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearTextbox(Me)
    End Sub

    Private Sub showPassLbl_Click(sender As Object, e As EventArgs) Handles showPassLbl.Click
        If studentPassRegTextBox.PasswordChar = "*" Then
            studentPassRegTextBox.PasswordChar = ""
            showPassLbl.Text = "Hide Password"


        Else
            studentPassRegTextBox.PasswordChar = "*"
            showPassLbl.Text = "Show Password"

        End If

    End Sub
End Class