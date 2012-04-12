
Public Class Producte

    Dim BD As New ProfitPlay_DB.ControlDB

    Private tipus As String
    Private nom As String
    Private descripicio As String
    Private preu As Double

    Public Sub New()
        tipus = ""
        nom = ""
        descripicio = ""
        preu = 0
    End Sub

    Public Sub setTipus(ByVal s As String)
        tipus = s
    End Sub

    Public Sub setNom(ByVal s As String)
        nom = s
    End Sub

    Public Sub setDescripcio(ByVal s As String)
        descripicio = s
    End Sub

    Public Sub setPreu(ByVal s As Double)
        preu = s
    End Sub

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getDescripcio() As String
        Return descripicio
    End Function

    Public Function getTipus() As String
        Return tipus
    End Function

    Public Function getPreu() As Double
        Return preu
    End Function

    Public Function GetProducte() As DataTable
        Return BD.GetProductes()
    End Function

    Public Function ContaProductes() As Integer
        Dim numProductes As Integer = 0

        numProductes = BD.ContaProductes()

        Return numProductes
    End Function

    Public Function ObteProductes() As DataTable

        Dim productesDB As DataTable = BD.GetProductes()

        Return productesDB
    End Function

End Class
