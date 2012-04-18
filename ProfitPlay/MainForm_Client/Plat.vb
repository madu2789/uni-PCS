Public Class Plat

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

End Class