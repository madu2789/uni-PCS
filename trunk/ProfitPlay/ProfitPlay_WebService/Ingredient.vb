Public Class Ingredient

    Dim BD As New ProfitPlay_DB.ControlDB

    Private Id As Integer
    Private nom As String
    Private Preu As Double
    Private Quantitat As Integer
    Private StockMinim As Integer

    Public Sub New()
        Id = 0
        nom = ""
        Preu = 0
        Quantitat = 0
        StockMinim = 0
    End Sub

    Public Sub setQuantitat(ByVal s As Integer)
        Quantitat = s
    End Sub

    Public Sub setNom(ByVal s As String)
        nom = s
    End Sub

    Public Sub setPreu(ByVal s As Double)
        preu = s
    End Sub

    Public Sub setStockMinim(ByVal s As Integer)
        StockMinim = s
    End Sub

    Public Function getStockMinim() As Integer
        Return StockMinim
    End Function

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getPreu() As Double
        Return preu
    End Function

    Public Function getQuantitat() As Integer
        Return Quantitat
    End Function

    Public Function getId() As Integer
        Return Id
    End Function

    Public Function ObteIngredients() As DataTable

        Dim ingredientsDB As DataTable = BD.getIngredients
        Return ingredientsDB

    End Function

    Public Function getStockActualById(ByVal id As Integer) As Integer
        Return BD.GetStockActualById(id)
    End Function

    Public Function updateStockActualById(ByVal id As Integer, ByVal decrement As Integer) As Integer
        Dim actual As Integer = BD.GetStockActualById(id)
        actual = actual - (decrement)
        Return BD.UpdateStockActualById(id, actual)
    End Function

    Public Function getIdIngredientByNom(ByVal Nom As String) As Integer
        Return BD.GetIdIngredientByNom(Nom)
    End Function

    Public Function getNomIngredientById(ByVal id As Integer) As String
        Return BD.GetNomIngredientById(id)
    End Function

    Public Function SetIngredient(ByVal nom As String, ByVal preu As Double, ByVal quantitat As Integer, ByVal stock As Integer, ByVal stockminim As Integer) As Boolean
        Return BD.SetIngredient(nom, preu, quantitat, stock, stockminim)
    End Function

End Class
