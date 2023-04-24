Imports System.ComponentModel.Design
Imports System.Data.Common
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient


Public Class reviews


    Private Sub reviews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fixSize(Me)
        studentIDChangeLbl.Text = studentLogin.studenID
        bookTitleChangeLbl.Text = Home.publicBookTitle

        centerAll(Me)
    End Sub

    Private Sub reviewsAddBtn_Click(sender As Object, e As EventArgs) Handles reviewsAddBtn.Click

        Dim conn As New MySqlConnection("Server=127.0.0.1;Port=3307;Database=librarymanagementsystem;Uid=root;Pwd=;")
        Dim query As String
        Dim command As New MySqlCommand
        Dim dataAdapter As New MySqlDataAdapter
        conn.Open()

        Dim rating As Integer


        If ratingTxtbox.Text = "" Or reviewRichTxtbox.Text = "" Then
            MessageBox.Show("All fields are required!")


        ElseIf Not Integer.TryParse(ratingTxtbox.Text, rating) Then
            MessageBox.Show("Invalid Input! Input must be integer")

        ElseIf rating < 1 Or rating > 10 Then
            MessageBox.Show("Invalid rating. Please enter a rating between 1 and 10.")

        ElseIf reviewRichTxtbox.Text.Length > 1000 Then
            MessageBox.Show("Reviews reach the limit!")

        Else
            Try

                query = "INSERT INTO reviews(student_id, book_id, review, ratings) VALUES (@studentID, @bookID, @review, @ratings)"
                command = New MySqlCommand(query, conn)

                command.Parameters.AddWithValue("@studentID", Functions.getStudentId(studentIDChangeLbl.Text))
                command.Parameters.AddWithValue("@bookID", Functions.getBookID(bookTitleChangeLbl.Text))
                command.Parameters.AddWithValue("@review", reviewRichTxtbox.Text)
                command.Parameters.AddWithValue("@ratings", ratingTxtbox.Text)

                dataAdapter = New MySqlDataAdapter(command)
                command.ExecuteNonQuery()

                MessageBox.Show("Succesfully added!")
                ratingTxtbox.Clear()
                reviewRichTxtbox.Clear()
                Me.Close()
                Home.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
            conn.Close()
        End If


    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearTextbox(Me)
    End Sub

    Private Sub reviews_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Home.Show()
    End Sub
End Class