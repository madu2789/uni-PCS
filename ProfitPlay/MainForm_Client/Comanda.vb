Public Class Comanda

    Private productes As ArrayList

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

        For i As Integer = 0 To productes.Count - 1 Step 1

            If (productes.Item(i) = p) Then

                productes.RemoveAt(i)

            End If

        Next

    End Sub

    Public Sub insertElement(ByVal s As String)
        productes.Add(s)
    End Sub

End Class