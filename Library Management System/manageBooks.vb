Imports System.Net
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class manageBooks

    Private Sub updateDgv()
        manageBooksDgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT title, author, genre, description, path FROM books"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                manageBooksDgv.Rows.Add(row("title"), row("author"), row("genre"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub

    Private Sub ManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerAll(Me)
        openConnnection()

        Try
            sql = "SELECT title, author, genre, description, path FROM books"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                manageBooksDgv.Rows.Add(row("title"), row("author"), row("genre"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub
    Private Sub manageBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        accounts.Show()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles manageBooksDeleteButton.Click
        openConnnection()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            sql = "DELETE FROM books WHERE title = @title"
            cmd = New MySqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@title", titleTxtbox.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Succesfully Deleted")
            updateDgv()
            clearTextbox(Me)

        End If
        connection.Close()
    End Sub
    Private Sub manageBooksAddButton_Click(sender As Object, e As EventArgs) Handles manageBooksAddButton.Click
        openConnnection()

        If titleTxtbox.Text = "" Or authorTxtbox.Text = "" Or pathTxtbox.Text = "" Then
            MessageBox.Show("All fields are required")

        Else
            Try
                sql = "INSERT INTO books(title, author, genre, description, path) VALUES(@title, @author, @genre, @description, @path)"
                cmd = New MySqlCommand(sql, connection)
                da = New MySqlDataAdapter(cmd)

                cmd.Parameters.AddWithValue("@title", titleTxtbox.Text)
                cmd.Parameters.AddWithValue("@author", authorTxtbox.Text)
                cmd.Parameters.AddWithValue("@genre", genreTxtbox.Text)
                cmd.Parameters.AddWithValue("@description", descriptionRichTxtbox.Text)
                cmd.Parameters.AddWithValue("@path", pathTxtbox.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("New book succesfully added!")
                connection.Close()
                clearTextbox(Me)
                updateDgv()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
            connection.Close()


        End If


    End Sub
    Private Sub genreTxtbox_TextChanged(sender As Object, e As EventArgs) Handles genreTxtbox.TextChanged
        genreTxtbox.Text = genreTxtbox.Text.ToUpper()
        genreTxtbox.SelectionStart = genreTxtbox.Text.Length ' Keep the cursor at the end of the text
    End Sub

    Private Sub manageBooksDgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles manageBooksDgv.CellDoubleClick
        Dim rowIndex As Integer = manageBooksDgv.SelectedRows(0).Index

        ' Get the values of the title and author columns for the selected row
        Dim title As String = manageBooksDgv.Rows(rowIndex).Cells("title").Value.ToString()
        Dim author As String = manageBooksDgv.Rows(rowIndex).Cells("author").Value.ToString()
        Dim genre As String = manageBooksDgv.Rows(rowIndex).Cells("genre").Value.ToString()
        Dim description As String = manageBooksDgv.Rows(rowIndex).Cells("description").Value.ToString()
        Dim path As String = manageBooksDgv.Rows(rowIndex).Cells("path").Value.ToString()
        ' Display the values on the labels

        titleTxtbox.Text = title
        authorTxtbox.Text = author
        genreTxtbox.Text = genre
        descriptionRichTxtbox.Text = description
        pathTxtbox.Text = path



    End Sub

    Private Sub manageBooksUpdateButton_Click(sender As Object, e As EventArgs) Handles manageBooksUpdateButton.Click

        If titleTxtbox.Text = "" Or authorTxtbox.Text = "" Or pathTxtbox.Text = "" Then

            MessageBox.Show("All fields are required")
        Else
            Try
                openConnnection()
                Dim sql As String = "UPDATE books SET title=@title, author=@author, 
                        genre=@genre, description=@description, path=@path 
                        WHERE title = @title"

                Dim cmd As New MySqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@title", titleTxtbox.Text)
                cmd.Parameters.AddWithValue("@author", authorTxtbox.Text)
                cmd.Parameters.AddWithValue("@genre", genreTxtbox.Text)
                cmd.Parameters.AddWithValue("@description", descriptionRichTxtbox.Text)
                cmd.Parameters.AddWithValue("@path", pathTxtbox.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Book updated successfully!")
                clearTextbox(Me)
                updateDgv()
                descriptionRichTxtbox.Clear()
                clearTextbox(Me)
                connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearTextbox(Me)
    End Sub

    Private Sub manageBooksSearchButton_Click(sender As Object, e As EventArgs) Handles manageBooksSearchButton.Click


        Try
            openConnnection()
            sql = "SELECT title, author, genre, description, path FROM books WHERE author LIKE @search OR title LIKE @title"
            cmd = New MySqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@search", searchTxtbox.Text)
            cmd.Parameters.AddWithValue("@title", searchTxtbox.Text)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            manageBooksDgv.Rows.Clear()

            For Each row As DataRow In dt.Rows
                manageBooksDgv.Rows.Add(row("title"), row("author"), row("genre"), row("description"), row("path"))
                clearTextbox(Me)
            Next

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Label2_Leave(sender As Object, e As EventArgs) Handles Label2.Leave

    End Sub

    Private Sub showAll_Click(sender As Object, e As EventArgs) Handles showAll.Click
        updateDgv()
    End Sub

    Private Sub openFileDialog_Click(sender As Object, e As EventArgs) Handles openFileDialog.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the default directory and filter for the OpenFileDialog
        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        ' Show the OpenFileDialog and check if the user clicked OK
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Get the selected file path and display it in the book path textbox
            pathTxtbox.Text = openFileDialog1.FileName
        End If
    End Sub
End Class