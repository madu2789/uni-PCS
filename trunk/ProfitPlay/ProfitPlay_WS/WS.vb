Public Class WS

    Dim db As New ProfitPlay_DB.ControlDB

    Public Function log_empleat(ByVal user As String, ByVal password As String) As Boolean
        Dim ok As Boolean
        ok = db.consulta_empleat(user, password)
        Return ok
    End Function


End Class
