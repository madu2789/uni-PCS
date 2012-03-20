
Public Class Producte

    Dim BD As New ProfitPlay_DB.ControlDB
    Private productes As ArrayList

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


    Public Sub ObteProductes()

        Dim productesDB As DataTable

        productesDB = BD.GetProductes()
        'prova
        If productesDB Is Nothing Then
            MsgBox("error", MsgBoxStyle.Critical)
        End If

        For Each fila In productesDB.Rows
            'MsgBox(fila("password").ToString(), MsgBoxStyle.Exclamation)

            Dim p As Producte = New Producte()

            p.setNom(fila("nombre").ToString)
            p.setPreu(CDbl(fila("precio")))
            p.setTipus(fila("categoria").ToString)
            productes.Add(p)
        Next

    End Sub

End Class
