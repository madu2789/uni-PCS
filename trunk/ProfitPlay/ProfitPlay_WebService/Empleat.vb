
Public Class Empleat

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String) As String
        Dim validacio As String = Nothing
        Dim info As DataTable
        Dim passwordBD As String = ""
        Dim rol As String = ""

        Try
            info = BD.consulta_empleat(user)

            For Each fila In info.Rows
                ' MsgBox(fila("password").ToString(), MsgBoxStyle.Exclamation)
                'MsgBox(fila("rol").ToString(), MsgBoxStyle.Exclamation)
                passwordBD = fila("password").ToString
                rol = fila("rol").ToString
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
        Return BD.GetEmpleats()
    End Function

    Public Function SetEmpleats(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return BD.SetEmpleat(nom, password, rol)
    End Function

End Class
