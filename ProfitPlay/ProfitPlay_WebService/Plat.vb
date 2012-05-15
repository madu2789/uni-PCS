Public Class Plat

    Dim BD As New ProfitPlay_DB.ControlDB

    Private Id_producte As Integer
    Private Id_ingredient As Integer
    Private Quantitat As Integer

    Public Sub New()
        Id_producte = 0
        Id_ingredient = 0
        Quantitat = 0
    End Sub

    Public Function getProducte() As Integer
        Return Id_producte
    End Function

    Public Function getIngredient() As Integer
        Return Id_ingredient
    End Function

    Public Function getQuantitat() As Integer
        Return Quantitat
    End Function

    Public Sub setProducte(ByVal s As Integer)
        Id_producte = s
    End Sub

    Public Sub setIngredient(ByVal s As Integer)
        Id_ingredient = s
    End Sub

    Public Sub setQuantitat(ByVal s As Integer)
        Quantitat = s
    End Sub

    Public Function ObtePlats() As DataTable
        Dim data As DataTable = BD.GetPlats
        Return data
    End Function

    'aixo no tocaria aqui:

    Public Function UpdateInteresById(ByVal interes As String, ByVal id_producte As String) As Boolean
        Return BD.UpdateInteresTaulaById(interes, id_producte)
    End Function

    Public Sub InsertProducteTaulaPreus(ByVal IdProducte As String, ByVal Preu As Double)
        BD.InsertProducteTaulaPreus(Id_producte, Preu)
    End Sub

End Class