Public Class Carta

    Private elements_carta As Plats

    Structure Plats
        Dim primers As ArrayList
        Dim segons As ArrayList
        Dim postres As ArrayList
        Dim begudes As ArrayList
    End Structure

    Public Sub New()

        elements_carta.primers = New ArrayList
        elements_carta.segons = New ArrayList
        elements_carta.postres = New ArrayList
        elements_carta.begudes = New ArrayList

    End Sub


    Public Function getCarta() As Plats
        Return elements_carta
    End Function

    
    Public Sub deleteElement(ByVal toDelete As String)

        For i As Integer = 0 To elements_carta.primers.Count - 1 Step 1

            If (elements_carta.primers.Item(i) = toDelete) Then

                elements_carta.primers.RemoveAt(i)

            End If

        Next

        For i As Integer = 0 To elements_carta.segons.Count - 1 Step 1

            If (elements_carta.segons.Item(i) = toDelete) Then

                elements_carta.segons.RemoveAt(i)

            End If

        Next

        For i As Integer = 0 To elements_carta.postres.Count - 1 Step 1

            If (elements_carta.postres.Item(i) = toDelete) Then

                elements_carta.postres.RemoveAt(i)

            End If

        Next

        For i As Integer = 0 To elements_carta.begudes.Count - 1 Step 1

            If (elements_carta.begudes.Item(i) = toDelete) Then

                elements_carta.begudes.RemoveAt(i)

            End If

        Next

    End Sub

    Public Sub fillElements(ByVal prod As String, ByVal categoria As String)

        If (categoria = "primer") Then

            For i As Integer = 0 To 10 Step 1

                elements_carta.primers.Add(prod & i.ToString)

            Next

        ElseIf (categoria = "segon") Then

            For i As Integer = 0 To 10 Step 1

                elements_carta.segons.Add(prod & i.ToString)

            Next

        ElseIf (categoria = "postre") Then

            For i As Integer = 0 To 10 Step 1

                elements_carta.postres.Add(prod & i.ToString)

            Next

        ElseIf (categoria = "beguda") Then

            For i As Integer = 0 To 10 Step 1

                elements_carta.begudes.Add(prod & i.ToString)

            Next

        End If

    End Sub

    Public Sub insertElement(ByVal prod As String, ByVal categoria As String)

        If (categoria = "primer") Then

            elements_carta.primers.Add(prod)

        ElseIf (categoria = "segon") Then

            elements_carta.segons.Add(prod)

        ElseIf (categoria = "postre") Then

            elements_carta.postres.Add(prod)

        ElseIf (categoria = "beguda") Then

            elements_carta.begudes.Add(prod)

        End If

    End Sub

End Class