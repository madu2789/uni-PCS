
Public Class Empleat

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String) As Boolean
        Dim validacio As Boolean = False
        Dim password_trobat As String = "blablabalala"

        password_trobat = BD.consulta_empleat(user)

        If password_trobat = password Then
            validacio = True
        End If

        Return validacio
    End Function


End Class
