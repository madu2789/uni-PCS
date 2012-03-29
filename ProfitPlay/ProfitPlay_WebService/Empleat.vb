
Public Class Empleat

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String) As String
        Dim validacio As String = Nothing
        Dim info As DataTable
        Dim passwordBD As String = ""
        Dim rol As String = ""

        Try
            info = BD.consulta_empleat(user)

            MsgBox(info.Rows.Count, MsgBoxStyle.Critical)
            For Each fila In info.Rows
                MsgBox(fila("Password").ToString(), MsgBoxStyle.Exclamation)
                MsgBox(fila("Rol").ToString(), MsgBoxStyle.Exclamation)
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

        Dim empleat As String = ""
        Dim info As DataTable

        info = BD.GetEmpleats

        'For Each fila In info.Rows
        '    MsgBox(fila("nom").ToString(), MsgBoxStyle.Exclamation)
        '    empleat = fila("nom").ToString
        'Next

        'Return empleat
        Return info
    End Function

    Public Function SetEmpleats(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return BD.SetEmpleat(nom, password, rol)
    End Function

End Class
