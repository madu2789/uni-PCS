﻿Public Class Producto

    Public id As Integer
    Public tipus As String
    Public nom As String
    Public descripcio As String
    Public preu As Double

    Public Sub New()
        tipus = ""
        nom = ""
        descripcio = ""
        preu = 0
    End Sub

    Public Sub setTipus(ByVal s As String)
        tipus = s
    End Sub

    Public Sub setNom(ByVal s As String)
        nom = s
    End Sub

    Public Sub setDescripcio(ByVal s As String)
        descripcio = s
    End Sub

    Public Sub setPreu(ByVal s As Double)
        preu = s
    End Sub

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getDescripcio() As String
        Return descripcio
    End Function

    Public Function getTipus() As String
        Return tipus
    End Function

    Public Function getPreu() As Double
        Return preu
    End Function

End Class