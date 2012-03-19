Public Class Comanda

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function SetComanda(ByVal id_comanda As String, ByVal taula As String, ByVal producte As String) As Boolean
        Dim ok = BD.SetComanda(id_comanda, taula, producte)
        Return ok
    End Function

    Public Function GetComanda() As DataTable
        Return BD.GetComanda()
    End Function

End Class
