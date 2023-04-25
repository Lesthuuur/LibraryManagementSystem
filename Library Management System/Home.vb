Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports iTextSharp.text.pdf.parser
Imports System.Xml

Public Class Home
    Public path As String
    Public dr As MySqlDataReader

    Private Sub updateDgv()
        dgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT title, author, description, path FROM books"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))

            Next
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        dr.Close()
        connection.Close()
    End Sub
    Private Sub selfhelpGradientBt_click(sender As Object, e As EventArgs) Handles selfhelpGradientBtn.Click
        dgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT title, author, description, path FROM books WHERE genre = 'SELF HELP'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        dr.Close()
        connection.Close()
    End Sub

    Public publicBookTitle As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fixSize(Me)

        RichTextBox1.ReadOnly = True
        addReview.Enabled = False
        viewReviewsBtn.Enabled = False
        centerAll(Me)
        bookTitleChange.Hide()
        authorTextChange.Hide()
        bookTitleChange.AutoSize = False

        bookTitleChange.TextAlign = ContentAlignment.MiddleCenter
        bookTitleChange.Dock = DockStyle.Fill
        authorTextChange.AutoSize = False
        authorTextChange.TextAlign = ContentAlignment.MiddleCenter
        authorTextChange.Dock = DockStyle.Fill

        If studentLogin.userType = "student" Then
            accountsPicBox.Hide()
            logoutBtn.Location = New Point(1171, 39)

        ElseIf librarianLogin.userType = "librarian" Then
            accountsPicBox.Show()
        End If

        openConnnection()
        Try
            sql = "SELECT title, author, description, path FROM books"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()
            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        dr.Close()
        connection.Close()



    End Sub

    Private Sub readBtn_Click_1(sender As Object, e As EventArgs) Handles readBtn.Click
        Dim filePath As String = Me.path
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = filePath
        processInfo.Verb = "Open"
        processInfo.WindowStyle = ProcessWindowStyle.Normal
        Dim process As New Process()
        process.StartInfo = processInfo
        process.Start()
    End Sub

    Private Sub romanceGradBtn_Click(sender As Object, e As EventArgs) Handles romanceGradBtn.Click
        dgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT title, author, description, path FROM books WHERE genre = 'ROMANCE'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        dr.Close()
        connection.Close()
    End Sub

    Private Sub historyGradientBtn_Click(sender As Object, e As EventArgs) Handles historyGradientBtn.Click
        dgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT title, author, description, path FROM books WHERE genre = 'HISTORY'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        dr.Close()
        connection.Close()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim rowIndex As Integer = dgv.SelectedRows(0).Index

        ' Get the values of the title and author columns for the selected row
        Dim title As String = dgv.Rows(rowIndex).Cells("bookTitle").Value.ToString()
        Dim author As String = dgv.Rows(rowIndex).Cells("bookAuthor").Value.ToString()
        Dim description As String = dgv.Rows(rowIndex).Cells("bookDescription").Value.ToString()
        Dim path As String = dgv.Rows(rowIndex).Cells("bookPath").Value.ToString()
        ' Display the values on the labels

        bookTitleChange.Show()
        authorTextChange.Show()
        bookTitleChange.Text = title
        authorTextChange.Text = author
        RichTextBox1.Text = description
        Me.path = path

        bookTitleChange.AutoSize = False
        bookTitleChange.TextAlign = ContentAlignment.MiddleCenter
        bookTitleChange.Dock = DockStyle.Fill
        authorTextChange.AutoSize = False
        authorTextChange.TextAlign = ContentAlignment.MiddleCenter
        authorTextChange.Dock = DockStyle.Fill

        publicBookTitle = title
        viewReviewsBtn.Enabled = True
        addReview.Enabled = True
    End Sub

    Private Sub fictionGradBtn_Click(sender As Object, e As EventArgs) Handles fictionGradBtn.Click
        dgv.Rows.Clear()
        openConnnection()

        Try
            sql = "SELECT title, author, description, path FROM books WHERE genre = 'FICTION'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        connection.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles accountsPicBox.Click
        accounts.Show()
        Me.Hide()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click

        ' Reset the login state

        ' Redirect the user to the home page

        ' Display a confirmation message

        Me.Close()

        If isClosing = True Then
            welcomePage.Show()
            studentLogin.userType = False
            librarianLogin.userType = False

        Else
            isClosing = False
        End If

    End Sub

    Private isClosing As Boolean = False

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isClosing Then
            isClosing = True
            Dim confirmation As DialogResult = MessageBox.Show("Do you want to Logout?", "Confirmation", MessageBoxButtons.YesNo)
            If confirmation = DialogResult.Yes Then
                welcomePage.Show()
            Else
                ' If the user doesn't want to exit, cancel the form closing event
                e.Cancel = True
                isClosing = False
            End If
        End If
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Try
            openConnnection()
            sql = "SELECT title, author, genre, description, path FROM books WHERE author LIKE @search OR title LIKE @search"
            cmd = New MySqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@search", searchTextBox.Text)
            'cmd.Parameters.AddWithValue("@title", searchTextBox.Text)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dgv.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("genre"), row("description"), row("path"))
                searchTextBox.Clear()
                connection.Close()
            Next
            dr.Close()
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
        connection.Close()

    End Sub

    Private Sub allBtn_Click(sender As Object, e As EventArgs) Handles allBtn.Click
        updateDgv()
    End Sub

    Private Sub Home_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        updateDgv()
        clearTextbox(Me)
        bookTitleChange.Hide()
        authorTextChange.Hide()
        addReview.Enabled = False
        viewReviewsBtn.Enabled = False
    End Sub

    Public title As String

    Private Sub addReview_Click(sender As Object, e As EventArgs) Handles addReview.Click
        Me.Hide()
        reviews.Show()
    End Sub

    Private Sub viewReviewsBtn_Click(sender As Object, e As EventArgs) Handles viewReviewsBtn.Click
        Me.Hide()
        viewReviews.Show()

    End Sub

    Private Sub programmingGradientBtn_Click(sender As Object, e As EventArgs) Handles programmingGradientBtn.Click
        dgv.Rows.Clear()
        openConnnection()
        Try
            sql = "SELECT title, author, description, path FROM books WHERE genre = 'PROGRAMMING'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()

            For Each row As DataRow In dt.Rows
                dgv.Rows.Add(row("title"), row("author"), row("description"), row("path"))
                connection.Close()
            Next
            dr.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        dr.Close()
        connection.Close()
    End Sub
    Private Sub homeClearBtn_Click(sender As Object, e As EventArgs) Handles homeClearBtn.Click
        clearTextbox(Me)
        bookTitleChange.Hide()
        authorTextChange.Hide()
        addReview.Enabled = False
        viewReviewsBtn.Enabled = False
    End Sub
End Class