Public Class Comanda

    Dim BD As New ProfitPlay_DB.ControlDB

    Public Id_comanda As Integer
    Public Id_usuari As Integer
    Public Id_producte As Integer
    Public Hora As String
    Public Notes As String
    Public Estat As String
    Public Producte As String

    Public Sub New()

        Hora = ""
        Notes = ""
        Estat = ""
        Producte = ""

    End Sub

    Public Sub setHora(ByVal s As String)
        hora = s
    End Sub

    Public Sub setNotes(ByVal s As String)
        notes = s
    End Sub

    Public Sub setEstat(ByVal s As String)
        estat = s
    End Sub

    Public Sub setProducte(ByVal s As String)
        Producte = s
    End Sub

    Public Function getHora() As String
        Return Hora
    End Function

    Public Function getNotes() As String
        Return Notes
    End Function

    Public Function getEstat() As String
        Return Estat
    End Function

    Public Function getProducte() As String
        Return Producte
    End Function

    

    Public Function SetComanda(ByVal id_comanda As String, ByVal taula As String, ByVal producte As String) As Boolean
        Dim ok = BD.SetComanda(id_comanda, taula, producte)
        Return ok
    End Function

    Public Function GetComanda() As DataTable
        Return BD.GetComanda()
    End Function

End Class
