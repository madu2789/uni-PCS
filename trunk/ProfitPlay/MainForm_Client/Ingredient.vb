﻿Public Class Ingredient

    Public id As Integer
    Public nom As String
    Public preu As Double
    Public quantitat As Integer
    Public StockMinim As Integer

    Public Sub New()
        id = 0
        nom = ""
        Preu = 0
        quantitat = 0
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

End Class