Public Class Comanda

    Private productes As ArrayList

    Private hora As String
    Private taula As String
    Private producte As Integer
    Private notes As String
    Private estat As String

    'fer getters i setters

    Public Sub setHora(ByVal s As String)
        hora = s
    End Sub

    Public Sub setTaula(ByVal s As String)
        taula = s
    End Sub

    Public Sub setProducte(ByVal s As String)
        producte = s
    End Sub

    Public Sub setNotes(ByVal s As String)
        notes = s
    End Sub

    Public Sub setEstat(ByVal s As String)
        estat = s
    End Sub

    Public Sub New()

        productes = New ArrayList

    End Sub

    Public Function getComanda() As ArrayList
        Return productes
    End Function

    Public Sub setComanda(ByVal p As ArrayList)
        Me.productes = p
    End Sub

    Public Sub deleteElement(ByVal p As String)

        If (productes.Count > 0) Then

            For i As Integer = productes.Count - 1 To 0 Step -1

                If (productes.Item(i) = p) Then

                    productes.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Public Sub insertElement(ByVal s As String)

        productes.Add(s)

    End Sub

    Public Sub clearComanda()

        For Each s As String In productes

            deleteElement(s)

        Next

    End Sub

    Public Sub showComanda()

        For i As Integer = 0 To productes.Count - 1

            MsgBox("Producte " + i.ToString + " " + productes.Item(i), MsgBoxStyle.Critical, "Mostrant Comanda")

        Next

    End Sub

End Class