Imports MySql.Data.MySqlClient 'imports the library of ADO.net that provides classes, objects, functions that will be used to connect to your database and to retrieve and manipulate data
Module Module1

    'this is a declaration of variables that stores the functions we will use to manage our database

    Public connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public sql As String


    'until here

    'Public Function openConnection() As MySqlConnection
    '    Dim connection As MySqlConnection = New MySqlConnection()
    '    connection.ConnectionString = "YourConnectionStringHere"
    '    Try
    '        If connection.State = ConnectionState.Closed Then
    '            connection.Open()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString())
    '    End Try
    '    Return connection
    'End Function


    Sub openConnnection() 'subroutine that doesnt return a value but performs a specific tasks
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        connection.ConnectionString = "Server=127.0.0.1;Port=3307;Database=librarymanagementsystem;Uid=lesthuuur;Pwd=admin123;"
        connection.Open()
    End Sub


End Module
