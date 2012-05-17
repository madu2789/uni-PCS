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

    Public Function SetComanda(ByVal id_user As String, ByVal id_producte As String, ByVal estat As String, ByVal notes As String, ByVal hora As Date) As Boolean
        Dim ok = BD.SetComanda(id_user, id_producte, estat, notes, hora)
        Return ok
    End Function

    Public Function GetComanda() As DataTable
        Return BD.GetComanda()
    End Function

    Public Function GetComandaByUserId(ByVal id As Integer) As DataTable
        Return BD.GetComandaByUserId(id)
    End Function

    Public Function AnulaComanda(ByVal id_comanda As String) As Boolean
        Return BD.DeleteComanda(id_comanda)
    End Function

    Public Function SolAnularComanda(ByVal id_producte As Integer, ByVal id_user As Integer) As Boolean
        Return BD.SolAnulaComanda(id_comanda, id_user)
    End Function

    Public Function SolPagarComanda(ByVal id_comanda As String) As Boolean
        Return BD.SolPagarComanda(id_comanda)
    End Function

    Public Function DeleteComandaByUserId(ByVal id As Integer) As Integer
        Return BD.DeleteComandaByUserId(id)
    End Function

End Class
