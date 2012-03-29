
Imports System.Runtime.Serialization
Imports System.Collections.Generic

Public Class Empleat

    Dim id As Integer
    Dim rol As String
    Dim nom As String
    Dim cognom As String
    Dim username As String
    Dim password As String

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String) As String

        Dim validacio As String = Nothing
        Dim info As DataTable
        Dim passwordBD As String = ""
        Dim rol As String = ""

        Try
            info = BD.consulta_empleat(user)

            For Each fila In info.Rows
                passwordBD = fila("Password").ToString
                rol = fila("Rol").ToString
            Next
        Catch ex As Exception
            MsgBox("error al traspas de dades al WS", MsgBoxStyle.Critical)
        End Try

        If passwordBD = password Then
            validacio = rol
        End If

        Return validacio
    End Function

    Public Function GetEmpleats() As DataTable

        'Dim empleat As String = ""
        Dim info As DataTable = New DataTable("Empleat")
        Dim column As DataColumn
        Dim row As DataRow

        'Creem una nova columna per al datatable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "id"
        column.Unique = True

        ' Afegim la columna
        info.Columns.Add(column)

       'Creem una nova columna per al datatable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "rol"

        ' Afegim la columna
        info.Columns.Add(column)

        'Creem una nova columna per al datatable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "nom"

        ' Afegim la columna
        info.Columns.Add(column)

        'Creem una nova columna per al datatable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "cognom"

        ' Afegim la columna
        info.Columns.Add(column)

       'Creem una nova columna per al datatable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "username"

        ' Afegim la columna
        info.Columns.Add(column)

        'Creem una nova columna per al datatable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "password"

        ' Afegim la columna
        info.Columns.Add(column)

        info = BD.GetEmpleats

        For Each fila In info.Rows

            row = info.NewRow()
            row("id") = fila("Id_empleat").ToString
            row("rol") = fila("Rol").ToString
            row("nom") = fila("Nom").ToString
            row("cognom") = fila("Cognom").ToString
            row("username") = fila("Username").ToString
            row("password") = fila("Password").ToString
            info.ImportRow(row)
            MsgBox(row("id"), MsgBoxStyle.AbortRetryIgnore)

        Next

        Return info

    End Function

    Public Function SetEmpleats(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return BD.SetEmpleat(nom, password, rol)
    End Function

End Class
