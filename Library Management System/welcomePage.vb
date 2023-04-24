Public Class welcomePage


    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click
        studentLogin.Show()
    End Sub

    Private Sub librarianBtn_Click(sender As Object, e As EventArgs) Handles librarianBtn.Click
        librarianLogin.Show()
    End Sub
    Private Sub welcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerAll(Me)
    End Sub


    Private isClosing As Boolean = False
    Private Sub welcomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isClosing Then
            isClosing = True
            Dim confirmation As DialogResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo)
            If confirmation = DialogResult.Yes Then
                Application.Exit()
            Else
                ' If the user doesn't want to exit, cancel the form closing event
                e.Cancel = True
                isClosing = False
            End If
        End If
    End Sub
End Class