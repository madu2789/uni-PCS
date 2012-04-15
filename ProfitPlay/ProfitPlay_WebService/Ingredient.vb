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

    Public Function getStockMinim() As Double
        Return StockMinim
    End Function

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getPreu() As Double
        Return preu
    End Function

    Public Function getQuantitat() As String
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

    Public Sub updateStockActualById(ByVal id As Integer, ByVal stock As Integer)
        BD.UpdateStockActualById(id, stock)
    End Sub

    Public Function getIdIngredientByNom(ByVal Nom As String) As Integer
        Return BD.GetIdIngredientByNom(Nom)
    End Function

    Public Function getNomIngredientById(ByVal id As Integer) As String
        Return BD.GetNomIngredientById(id)
    End Function


End Class
