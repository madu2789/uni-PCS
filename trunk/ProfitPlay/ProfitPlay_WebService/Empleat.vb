
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

    Public Function getLastUserId() As Integer
        Return BD.getLastUserId()
    End Function

    Public Sub InsertNewUser(ByVal Nom As String, ByVal Punts As Integer)
        BD.InsertNewUser(Nom, Punts)
    End Sub


    Public Function GetEmpleat(ByVal id As Integer) As DataTable
        Return BD.GetEmpleats
    End Function

    Public Function SetEmpleats(ByVal nom As String, ByVal password As String, ByVal rol As String, ByVal cognom As String) As Boolean
        Return BD.SetEmpleat(nom, password, rol, cognom)
    End Function

End Class
