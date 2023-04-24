Imports MySql.Data.MySqlClient

Public Class viewReviews
    Private Sub viewReviews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reviewRichTxtbox.ReadOnly = True
        ratingsLblChanged.Hide()
        bookTitleChangeLbl.Text = Home.publicBookTitle
        Dim conn As New MySqlConnection("Server=127.0.0.1;Port=3307;Database=librarymanagementsystem;Uid=root;Pwd=;")
        Dim query As String
        Dim command As New MySqlCommand
        Dim dataAdapter As New MySqlDataAdapter
        Dim dataTable As New DataTable
        conn.Open()



        Try
            query = "SELECT r.student_id, b.title, r.review, r.ratings, r.time_date 
             FROM reviews r 
             INNER JOIN books b ON r.book_id = b.id
                WHERE b.title = @bookTitle"
            command = New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@bookTitle", Home.publicBookTitle)
            dataAdapter = New MySqlDataAdapter(command)

            dataTable = New DataTable()
            dataAdapter.Fill(dataTable)

            For Each row As DataRow In dataTable.Rows
                reviewsDgv.Rows.Add(row("student_id"), row("title"), row("review"), row("ratings"), row("time_date"))
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try

        conn.Close()

    End Sub

    Private Sub reviewsDgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles reviewsDgv.CellContentDoubleClick
        Dim rowIndex As Integer = reviewsDgv.SelectedRows(0).Index

        Dim title As String = reviewsDgv.Rows(rowIndex).Cells("booktitle").Value.ToString()
        Dim review As String = reviewsDgv.Rows(rowIndex).Cells("review").Value.ToString()
        Dim rating As String = reviewsDgv.Rows(rowIndex).Cells("rating").Value.ToString()
        Dim dateTime As String = reviewsDgv.Rows(rowIndex).Cells("timeDate").Value.ToString()

        ratingsLblChanged.Text = rating
        reviewRichTxtbox.Text = review
        dateTimeLblChange.Text = dateTime
        ratingsLblChanged.Show()


    End Sub

    Private Sub viewReviews_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Show()
    End Sub
End Class