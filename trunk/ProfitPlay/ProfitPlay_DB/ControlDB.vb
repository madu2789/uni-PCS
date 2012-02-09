Public Class ControlDB


    Dim conDB As OleDb.OleDbConnection
    ' Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Desktop\MyMovieDatabase\MyMovieDatabase_DB\MyMovieDatabase.accdb;Persist Security Info=False"

    'Dim personDA As New MyMovieDatabaseDataSetTableAdapters.PersonTableAdapter
   

    'MyMovieDatabaseDataSet
    'Private DS As New MyMovieDatabaseDataSet()
    Private cmd As OleDb.OleDbCommand

    Public Sub connect()
        Try
            ' conDB = New OleDb.OleDbConnection(conString)
            conDB.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub disconnect()
        conDB.Close()
    End Sub


End Class
