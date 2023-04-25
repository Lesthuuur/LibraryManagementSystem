Imports System.Web.UI.HtmlControls
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class manageLibrarian
    Private Sub updateDgv()
        manageLibrarianDgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT id, librarian_lastName, librarian_firstName, librarian_MidName, username, password FROM librarian"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                manageLibrarianDgv.Rows.Add(row("id"), row("librarian_lastName"), row("librarian_firstName"), row("librarian_MidName"),
                row("username"), row("password"))
                connection.Close()
            Next
            dr.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub

    Private Sub manageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        manageLibrarianDgv.ReadOnly = True
        librarianLname.Select()
        fixSize(Me)
        centerAll(Me)
        openConnnection()

        Try
            sql = "SELECT id, librarian_lastName, librarian_firstName, librarian_MidName, username, password FROM librarian"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            dr = cmd.ExecuteReader

            For Each row As DataRow In dt.Rows
                'row values must be the name of the column in the db
                manageLibrarianDgv.Rows.Add(row("id"), row("librarian_lastName"), row("librarian_firstName"), row("librarian_MidName"),
                row("username"), row("password"))
                connection.Close()
            Next
            dr.Close()
        Catch ex As Exception

        End Try
        connection.Close()
    End Sub
    Private Sub manageUsers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        accounts.Show()
    End Sub
    Private Sub manageLibrarian_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        librarianLname.Select()
    End Sub

    Private Sub manageUsersUpdateButton_Click(sender As Object, e As EventArgs) Handles manageUsersUpdateButton.Click
        openConnnection()
        Dim confirmPass As String = (InputBox("Confirm Password"))
        If confirmPass <> "" Then ' Check if the user entered a password confirmation
            If librarianLogin.publicPassword = confirmPass Then
                Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNoCancel)

                If confirmResult = DialogResult.Yes Then
                    Try
                        sql = "UPDATE librarian SET librarian_lastName = @lastname, librarian_firstName = @firstname, librarian_MidName = @middlename,  username = @username,
            password = SHA2(@password, 256) WHERE id = @userID"

                        cmd = New MySqlCommand(sql, connection)
                        cmd.Parameters.AddWithValue("@userID", librarianId)
                        cmd.Parameters.AddWithValue("@lastname", librarianLname.Text)
                        cmd.Parameters.AddWithValue("@firstname", librarianFname.Text)
                        cmd.Parameters.AddWithValue("@middlename", librarianMname.Text)
                        cmd.Parameters.AddWithValue("@username", librarianUsername.Text)
                        cmd.Parameters.AddWithValue("@password", librarianPassword.Text)

                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Librarian updated Succesfully")
                        clearTextbox(Me)
                        updateDgv()
                        connection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message.ToString)
                    End Try

                    connection.Close()

                ElseIf confirmResult = DialogResult.No Then
                    'do nothing because the user clicks no
                ElseIf confirmResult = DialogResult.Cancel Then
                    MessageBox.Show("Update canceled by user")
                End If
            End If
        Else
            ' Cancel the update if the user clicks "Cancel" on the input box
            MessageBox.Show("Password does not match!")
        End If
    End Sub

    Public librarianId As Integer
    Private Sub manageLibrarianDgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles manageLibrarianDgv.CellContentDoubleClick
        Dim rowIndex As Integer = manageLibrarianDgv.SelectedRows(0).Index
        Dim librarianIDrow As Integer = manageLibrarianDgv.Rows(rowIndex).Cells("id").Value.ToString()
        Dim librarianLastname As String = manageLibrarianDgv.Rows(rowIndex).Cells("lastname").Value.ToString()

        Dim librarianFirstname As String = manageLibrarianDgv.Rows(rowIndex).Cells("firstname").Value.ToString()
        Dim librarianMiddlename As String = manageLibrarianDgv.Rows(rowIndex).Cells("middlename").Value.ToString()
        Dim librarianUsernameRow As String = manageLibrarianDgv.Rows(rowIndex).Cells("username").Value.ToString()
        Dim librarianPasswordRow As String = manageLibrarianDgv.Rows(rowIndex).Cells("password").Value.ToString()

        librarianId = librarianIDrow
        librarianLname.Text = librarianLastname
        librarianFname.Text = librarianFirstname
        librarianMname.Text = librarianMiddlename
        librarianUsername.Text = librarianUsernameRow
        librarianPassword.Text = librarianPasswordRow

    End Sub

    Private Sub manageUsersDeleteButton_Click(sender As Object, e As EventArgs) Handles manageUsersDeleteButton.Click
        openConnnection()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Dim confirmPass As String = (InputBox("Confirm Password"))
            If librarianLogin.publicPassword = confirmPass Then
                Try
                    sql = "DELETE FROM librarian WHERE id = @id"
                    cmd = New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@id", librarianId)
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


        connection.Close()
    End Sub

    Private Sub manageUsersClearButton_Click(sender As Object, e As EventArgs) Handles manageUsersClearButton.Click
        clearTextbox(Me)
    End Sub

    Private Sub manageUsersCloseButton_Click(sender As Object, e As EventArgs) Handles manageUsersCloseButton.Click
        Me.Close()
        accounts.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        updateDgv()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        openConnnection()
        Try
            sql = "SELECT id, librarian_lastName, librarian_firstName, librarian_MidName, username, password FROM librarian 
                    WHERE librarian_lastName LIKE @search OR librarian_firstName LIKE @search OR librarian_MidName LIKE @search"
            cmd = New MySqlCommand(sql, connection)

            cmd.Parameters.AddWithValue("@search", searchTxtbox.Text())
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            dr = cmd.ExecuteReader
            manageLibrarianDgv.Rows.Clear()

            For Each row As DataRow In dt.Rows
                'row values must be the name of the column in the db
                manageLibrarianDgv.Rows.Add(row("id"), row("librarian_lastName"), row("librarian_firstName"), row("librarian_MidName"),
                row("username"), row("password"))
                clearTextbox(Me)
                connection.Close()
            Next
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

End Class