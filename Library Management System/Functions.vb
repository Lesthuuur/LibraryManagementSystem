Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module Functions
    'function for centering the items to the form
    'contains centering the form in the user screen when it loads
    Sub centerAll(form As Form)
        For Each ctrl In form.Controls
            ctrl.Anchor = AnchorStyles.None
        Next

        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        form.Location = New Point((screenWidth - form.Width) / 2, (screenHeight - form.Height) / 2)
    End Sub

    'Encrypts the password in the database table
    Public hashString As String
    Sub passEncryption(password As String)
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hashAlgorithm As New SHA256Managed()
        Dim hashBytes As Byte() = hashAlgorithm.ComputeHash(passwordBytes)
        hashString = BitConverter.ToString(hashBytes).Replace("*", "")
    End Sub

    Public Function HashPassword(password As String) As String

        ' Create a SHA256 hash from the password string
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)

        ' Convert the hash bytes to a string
        Dim sb As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            sb.Append(hash(i).ToString("x2"))
        Next
        Return sb.ToString()
    End Function

    Sub clearTextbox(control As Control)
        For Each childControl In control.Controls
            If TypeOf childControl Is TextBox Then
                DirectCast(childControl, TextBox).Text = ""
            ElseIf TypeOf childControl Is RichTextBox Then
                DirectCast(childControl, RichTextBox).Text = ""
            ElseIf childControl.Controls.Count > 0 Then
                clearTextbox(childControl)
            End If
        Next
    End Sub

    Public Class studentLogin
        Public Shared Property currentUserType As String = ""
    End Class

    Public Class librarianLogin
        Public Shared Property currentUserType As String = ""
    End Class

    Public Function getStudentId(studentID As String) As Integer
        openConnnection()
        sql = "SELECT id FROM students WHERE student_id = @id"
        cmd = New MySqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@id", studentID)
        Dim id As Integer = 0
        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                id = reader.GetInt32("id")
                connection.Close()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        connection.Close()
        Return id
    End Function

    Public Function getBookID(bookTitle As String) As Integer
        openConnnection()
        sql = "SELECT id FROM books WHERE title = @title"
        cmd = New MySqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@title", bookTitle)
        Dim id As Integer = 0
        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                id = reader.GetInt32("id")
                connection.Close()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        connection.Close()
        Return id
    End Function

End Module
