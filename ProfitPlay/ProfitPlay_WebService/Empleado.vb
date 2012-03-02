
Public Class Empleado

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String)
        Dim validacio As Boolean = False
        Dim password_trobat As String

        password_trobat = BD.consulta_empleat(user, password)

        If password_trobat = password Then
            validacio = True
        End If

        Return validacio
    End Function


End Class
