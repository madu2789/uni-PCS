Public Class Producte

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Function GetProducte() As DataTable
        Return BD.GetProductes()
    End Function


End Class
