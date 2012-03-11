
Public Class Empleat

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String) As String
        Dim validacio As Boolean = False
        Dim trobat() As String

        trobat = BD.consulta_empleat(user)

        trobat(0) = "password"
        trobat(1) = "rol"

        If trobat(0) = password Then
            validacio = True
        End If

        Return trobat(1)
    End Function


End Class
