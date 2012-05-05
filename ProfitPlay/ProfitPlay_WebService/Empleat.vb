
Imports System.Runtime.Serialization
Imports System.Collections.Generic

Public Class Empleat

    Public id As Integer
    Public rol As String
    Public nom As String
    Public cognom As String
    Public username As String
    Public password As String

    Dim BD As New ProfitPlay_DB.ControlDB


    Public Function log_empleat(ByVal user As String, ByVal password As String) As String

        Dim validacio As String = Nothing
        Dim info As DataTable
        Dim passwordBD As String = ""
        Dim rol As String = ""

        Try
            info = BD.ConsultaEmpleat(user)

            For Each fila In info.Rows
                passwordBD = fila("Password").ToString
                rol = fila("Rol").ToString
            Next
        Catch ex As Exception
            MsgBox("Error al traspas de dades al WS", MsgBoxStyle.Critical, "ERROR EN EL WS")
        End Try

        If passwordBD = password Then
            validacio = rol
        End If

        Return validacio
    End Function

    Public Function ContaEmpleats() As Integer
        Return BD.ContaEmpleats()
    End Function

    Public Function GetEmpleat(ByVal id As Integer) As DataTable
        Return BD.GetEmpleats
    End Function

    Public Function deleteEmpleat(ByVal Nom As String, ByVal Sur As String) As Integer
        Return BD.deleteEmpleat(Nom, Sur)
    End Function

    Public Function SetEmpleat(ByVal nom As String, ByVal cognom As String, ByVal username As String, ByVal password As String, ByVal rol As String) As Boolean
        Return BD.SetEmpleat(nom, cognom, username, password, rol)
    End Function

    Public Function getEmpleats() As DataTable
        Return BD.GetEmpleats()
    End Function

End Class
