Public Class Usuari

    Dim BD As New ProfitPlay_DB.ControlDB

    Private Id As Integer
    Private nom As String
    Private punts As Integer
    Private comensals As Integer

    Public Sub New()
        Id = 0
        nom = ""
        Punts = 0
    End Sub

    Public Sub setNom(ByVal s As String)
        nom = s
    End Sub

    Public Sub setPunts(ByVal s As Integer)
        punts = s
    End Sub

    Public Sub setComensals(ByVal s As Integer)
        comensals = s
    End Sub

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getPunts() As Double
        Return punts
    End Function

    Public Function getId() As Integer
        Return Id
    End Function

    Public Function getComensals() As Integer
        Return comensals
    End Function

    Public Function getLastUserId() As Integer
        Return BD.getLastUserId()
    End Function

    Public Sub InsertNewUser(ByVal Nom As String, ByVal Punts As Integer, ByVal Comensals As Integer)
        BD.InsertNewUser(Nom, Punts, Comensals)
    End Sub

    Public Function getAllUsers() As DataTable
        Return BD.getAllUsers()
    End Function

    Public Function deleteUser(ByVal id As Integer) As Integer
        Return BD.deleteUser(id)
    End Function




End Class