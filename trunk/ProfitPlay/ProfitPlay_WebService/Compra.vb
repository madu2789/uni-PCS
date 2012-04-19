Public Class Compra

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Id_compra As Integer
    Public Id_producte As Integer
    Private Quantitat As Integer
    Public Estat As String

    Public Sub setQuantitat(ByVal s As String)
        Quantitat = s
    End Sub

    Public Sub setEstat(ByVal s As String)
        estat = s
    End Sub

    Public Function getEstat() As String
        Return Estat
    End Function

    Public Function getQuantitat() As Integer
        Return Quantitat
    End Function

    Public Function insertCompra(ByVal id_i As Integer, ByVal q As Integer, ByVal e As String) As Integer
        Return BD.insertCompra(id_i, q, e)
    End Function


End Class