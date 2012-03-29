
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
        Dim info As DataTable = BD.GetEmpleats

        Dim empleats As New List(Of Empleat)

        For Each fila In info.Rows
            Dim empl As Empleat = New Empleat()
            empl.id = fila("Id_empleat").ToString
            empl.rol = fila("Rol").ToString
            empl.nom = fila("Nom").ToString
            empl.cognom = fila("Cognom").ToString
            empl.username = fila("Username").ToString
            empl.password = fila("Password").ToString
            empleats.Add(empl)
            'MsgBox(empl.id, MsgBoxStyle.Information)
        Next

        Return info
    End Function

    Public Function SetEmpleats(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return BD.SetEmpleat(nom, password, rol)
    End Function

End Class
