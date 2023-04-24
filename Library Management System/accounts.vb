Public Class accounts
    Private Sub manageStudent_Click(sender As Object, e As EventArgs) Handles manageStudent.Click
        manageStudents.Show()
        Me.Hide()
    End Sub

    Private Sub manageLibrarianBtn_Click(sender As Object, e As EventArgs) Handles manageLibrarianBtn.Click
        manageLibrarian.Show()
        Me.Hide()

    End Sub

    Private Sub manageBooks_Click(sender As Object, e As EventArgs) Handles manageBooksBtn.Click
        manageBooks.Show()
        Me.Hide()
    End Sub

    Private Sub accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerAll(Me)
    End Sub

    Private Sub accounts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the Home form again when the Accounts form is closed
        Home.Show()
    End Sub
End Class