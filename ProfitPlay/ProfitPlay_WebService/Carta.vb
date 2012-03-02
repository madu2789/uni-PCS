Public Class Carta

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function donamDades() As DataTable
        Dim ds As New DataTable
        ds = BD.GetCarta()
        Return ds
    End Function
End Class
