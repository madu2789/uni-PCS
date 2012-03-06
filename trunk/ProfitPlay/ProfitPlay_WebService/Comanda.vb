Public Class Comanda

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function SetComanda(ByVal id_comanda As String, ByVal taula As String, ByVal productes As ArrayList) As Boolean
        Dim ok = BD.SetComanda(id_comanda, taula, productes)
        Return ok
    End Function



End Class
