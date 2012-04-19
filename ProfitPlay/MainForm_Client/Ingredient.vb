Public Class Ingredient

    Public id_ingredient As Integer
    Public nom As String
    Public preu As Double
    Public quantitat As Integer
    Public StockMinim As Integer
    Public StockActual As Integer

    Public Sub New()
        id_ingredient = 0
        nom = ""
        Preu = 0
        quantitat = 0
        StockMinim = 0
    End Sub

    Public Sub setIdIngredient(ByVal id As Integer)
        id_ingredient = id
    End Sub
    Public Sub setStockActual(ByVal s As Integer)
        StockActual = s
    End Sub

    Public Sub setQuantitat(ByVal s As String)
        Quantitat = s
    End Sub

    Public Sub setNom(ByVal s As String)
        nom = s
    End Sub

    Public Sub setPreu(ByVal s As Double)
        preu = s
    End Sub

    Public Sub setStockMinim(ByVal s As Double)
        StockMinim = s
    End Sub

    Public Function getStockActual() As Integer
        Return StockActual
    End Function

    Public Function getStockMinim() As Double
        Return StockMinim
    End Function

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getPreu() As Double
        Return preu
    End Function

    Public Function getQuantitat() As Integer
        Return quantitat
    End Function

    Public Function getIdIngredient() As Integer
        Return id_ingredient
    End Function

End Class