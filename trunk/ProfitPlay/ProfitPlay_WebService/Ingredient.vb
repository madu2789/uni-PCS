Public Class Ingredient

    Dim BD As New ProfitPlay_DB.ControlDB

    Private Id As String
    Private nom As String
    Private Preu As Double
    Private Quantitat As Double
    Private StockMinim As Double

    Public Sub New()
        Id = ""
        nom = ""
        Preu = 0
        Quantitat = 0
        StockMinim = 0
    End Sub

    Public Function ObteIngredients() As DataTable

        Dim ingredientsDB As DataTable = BD.getIngredients

        Return ingredientsDB

    End Function

End Class
