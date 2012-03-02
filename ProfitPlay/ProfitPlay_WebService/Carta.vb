Public Class Carta

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function GetCarta() As DataTable
        Return BD.GetCarta()
    End Function
End Class
