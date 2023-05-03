Imports MySql.Data.MySqlClient

Public Class manageStudents

    Private Sub updateDgv()
        manageStudentsDgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT student_lastName, student_firstName, student_midName, course, year_section, student_id,
            username, password FROM students"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                manageStudentsDgv.Rows.Add(row("student_lastName"), row("student_firstName"), row("student_midName"),
                row("course"), row("year_section"), row("student_id"), row("username"), row("password"))
            Next
            dr.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub
    Private Sub manageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        manageStudentsDgv.ReadOnly = True
        fixSize(Me)
        centerAll(Me)
        openConnnection()

        Try
            sql = "SELECT student_lastName, student_firstName, student_midName, course, year_section, student_id,
            username, password FROM students"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                'row values must be the name of the column in the db
                manageStudentsDgv.Rows.Add(row("student_lastName"), row("student_firstName"), row("student_midName"),
                row("course"), row("year_section"), row("student_id"), row("username"), row("password"))
                connection.Close()
            Next
            dr.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub
    Private Sub manageStudents_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        accounts.Show()
    End Sub


    Private Sub manageStudentsDgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles manageStudentsDgv.CellDoubleClick
        Dim rowIndex As Integer = manageStudentsDgv.SelectedRows(0).Index

        studentIDTxtbox.Enabled = False
        ' Get the values of the title and author columns for the selected row
        Dim studentLastname As String = manageStudentsDgv.Rows(rowIndex).Cells("lastname").Value.ToString()
        Dim studentFirstname As String = manageStudentsDgv.Rows(rowIndex).Cells("firstname").Value.ToString()
        Dim studentMiddlename As String = manageStudentsDgv.Rows(rowIndex).Cells("middlename").Value.ToString()
        Dim course As String = manageStudentsDgv.Rows(rowIndex).Cells("course").Value.ToString()
        Dim yearSec As String = manageStudentsDgv.Rows(rowIndex).Cells("yearSection").Value.ToString()
        Dim studentID As String = manageStudentsDgv.Rows(rowIndex).Cells("studentID").Value.ToString()
        Dim studentUsername As String = manageStudentsDgv.Rows(rowIndex).Cells("username").Value.ToString()
        Dim studentPassword As String = manageStudentsDgv.Rows(rowIndex).Cells("password").Value.ToString()


        lastnameTxtbox.Text = studentLastname
        firstnameTxtbox.Text = studentFirstname
        midnameTxtbox.Text = studentMiddlename
        courseTxtbox.Text = course
        yearSecTxtbox.Text = yearSec
        studentIDTxtbox.Text = studentID
        usernameTxtbox.Text = studentUsername
        passwordTxtbox.Text = studentPassword

        ' Display the values on the labels

    End Sub

    Private Sub studentIDTxtbox_TextChanged(sender As Object, e As EventArgs) Handles studentIDTxtbox.TextChanged
        studentIDTxtbox.Text = studentIDTxtbox.Text.ToUpper()
        studentIDTxtbox.SelectionStart = studentIDTxtbox.Text.Length ' Keep the cursor at the end of the text
    End Sub


    Private Sub manageStudentsClearButton_Click(sender As Object, e As EventArgs) Handles manageStudentsClearButton.Click
        clearTextbox(Me)
        studentIDTxtbox.Enabled = True
    End Sub

    Private Sub manageStudentsUpdateButton_Click(sender As Object, e As EventArgs) Handles manageStudentsUpdateButton.Click
        openConnnection()

        Dim confirmPass As String = (InputBox("Confirm Password"))

        If confirmPass <> "" Then ' Check if the user entered a password confirmation
            If librarianLogin.publicPassword = confirmPass Then
                ' Confirmation dialog
                Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNoCancel)
                If confirmResult = DialogResult.Yes Then
                    Try
                        ' Update query
                        sql = "UPDATE students SET student_lastName = @lastname, student_firstName = @firstname, student_midName = @middlename,  course = @course, year_section = @yearSec, username = @username, password = SHA2(@password, 256) WHERE student_id = @studentID"

                        cmd = New MySqlCommand(sql, connection)

                        cmd.Parameters.AddWithValue("@lastname", lastnameTxtbox.Text)
                        cmd.Parameters.AddWithValue("@firstname", firstnameTxtbox.Text)
                        cmd.Parameters.AddWithValue("@middlename", midnameTxtbox.Text)
                        cmd.Parameters.AddWithValue("@course", courseTxtbox.Text)
                        cmd.Parameters.AddWithValue("@yearSec", yearSecTxtbox.Text)
                        cmd.Parameters.AddWithValue("@studentID", studentIDTxtbox.Text)
                        cmd.Parameters.AddWithValue("@username", usernameTxtbox.Text)
                        cmd.Parameters.AddWithValue("@password", passwordTxtbox.Text)

                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Student updated succesfully!")
                        clearTextbox(Me)
                        updateDgv()
                        studentIDTxtbox.Enabled = True
                        connection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message.ToString)
                    End Try
                ElseIf confirmResult = DialogResult.No Then
                    ' Do nothing if the user clicks "No"
                ElseIf confirmResult = DialogResult.Cancel Then
                    ' Cancel the update if the user clicks "Cancel"
                    MessageBox.Show("Update canceled by user")
                End If ' End of confirmation If statement
                connection.Close()
            Else
                MessageBox.Show("Password does not match")
            End If
        Else
            ' Cancel the update if the user clicks "Cancel" on the input box
            MessageBox.Show("Update canceled by user")
        End If

    End Sub

    Private Sub manageStudentsDeleteButton_Click(sender As Object, e As EventArgs) Handles manageStudentsDeleteButton.Click
        openConnnection()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim confirmPass As String = (InputBox("Confirm Password"))

            If librarianLogin.publicPassword = confirmPass Then
                Try
                    sql = "DELETE FROM students WHERE student_id = @studentID"
                    cmd = New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@studentID", studentIDTxtbox.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Succesfully Deleted!")
                    updateDgv()
                    clearTextbox(Me)

                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try

            Else
                MessageBox.Show("Password does not match!")
            End If
        Else
            updateDgv()
            clearTextbox(Me)

        End If
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        openConnnection()
        Try
            sql = "SELECT student_lastName, student_firstName, student_midName, course, year_section, student_id,
            username, password FROM students WHERE student_lastName LIKE @search OR student_firstName LIKE @search OR course LIKE @search OR student_id 
            LIKE @search"
            cmd = New MySqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@search", searchTextBox.Text())



            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()
            manageStudentsDgv.Rows.Clear()

            For Each row As DataRow In dt.Rows
                'row values must be the name of the column in the db
                manageStudentsDgv.Rows.Add(row("student_lastName"), row("student_firstName"), row("student_midName"),
                row("course"), row("year_section"), row("student_id"), row("username"), row("password"))
                clearTextbox(Me)
                connection.Close()
            Next
            dr.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub



    Private Sub showAll_Click(sender As Object, e As EventArgs) Handles showAll.Click
        updateDgv()
    End Sub
End Class