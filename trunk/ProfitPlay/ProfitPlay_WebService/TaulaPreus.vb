Public Class TaulaPreus

    Dim BD As New ProfitPlay_DB.ControlDB

    Private Id_producte As Integer
    Private EsPotPreparar As Integer
    Private PreuEstandard As Integer
    Private Interes As String


    Public Function UpdateInteresById(ByVal interes As String, ByVal id_producte As String) As Boolean
        Return BD.UpdateInteresTaulaById(interes, id_producte)
    End Function

    Public Sub InsertProducteTaulaPreus(ByVal IdProducte As String, ByVal Preu As Double)
        BD.InsertProducteTaulaPreus(IdProducte, Preu)
    End Sub

    Public Function UpdateStockTaulaPreus(ByVal id_producte As String, ByVal stock As String) As Boolean
        Return BD.UpdateStockTaulaPreus(stock, id_producte)
    End Function

    Public Function GetTaulaPreus() As DataTable
        Return BD.GetTaulaPreus()
    End Function

End Class
