
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

    Public Function ContaEmpleats() As Integer
        Dim numUsuaris As Integer = 0

        numUsuaris = BD.ContaEmpleats()

        Return numUsuaris
    End Function

    Public Function GetEmpleat(ByVal id As Integer) As DataTable

        Dim info As DataTable = BD.GetEmpleats

        Return info
    End Function

    Public Function SetEmpleats(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return BD.SetEmpleat(nom, password, rol)
    End Function

End Class
