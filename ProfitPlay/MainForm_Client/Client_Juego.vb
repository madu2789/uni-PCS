Public Class Client_Juego

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim preguntes As New List(Of Joc)
    Dim punts As Integer = 0

    Private Sub Client_Juego_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula


        Dim questions = ws.getAllQuestions
        Dim added As New List(Of Integer)

        Dim rand = New Random
        Dim add As Integer = 0

        While (add <> 4)

            Dim num = Rnd() * (100)
            If (num < questions.Length) Then

                If (added.Contains(num) = False) Then

                    added.Add(num)
                    add = add + 1

                End If

            End If

        End While

        lbl_p1.Text = questions(added(0)).pregunta
        lbl_p2.Text = questions(added(1)).pregunta
        lbl_p3.Text = questions(added(2)).pregunta
        lbl_p4.Text = questions(added(3)).pregunta

        p1_a.Text = questions(added(0)).correcta
        p1_b.Text = questions(added(0)).incorrecta

        p2_a.Text = questions(added(1)).incorrecta
        p2_b.Text = questions(added(1)).correcta

        p3_a.Text = questions(added(2)).incorrecta
        p3_b.Text = questions(added(2)).correcta

        p4_a.Text = questions(added(3)).correcta
        p4_b.Text = questions(added(3)).incorrecta

        For Each q In questions

            Dim j As New Joc

            j.setCorrecte(q.correcta)
            j.setIncorrecta(q.incorrecta)
            j.setPregunta(q.pregunta)

            preguntes.Add(j)

        Next

    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click
        Client_Anula.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'per fer!
    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click
        Client_Carta.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pagar.Click
        Client_Pago.Show()
        Me.Hide()
    End Sub

    Private Sub btn_donar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_fica_punts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fica_punts.Click

        

    End Sub

    Private Sub p1_a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_a.CheckedChanged

        If (p1_b.Checked) Then
            p1_b.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p1.Text Then

                If (p1_a.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p1_b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_b.CheckedChanged

        If (p1_a.Checked) Then
            p1_a.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p1.Text Then

                If (p1_b.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p2_a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_a.CheckedChanged

        If (p2_b.Checked) Then
            p2_b.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p2.Text Then

                If (p2_a.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p2_b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_b.CheckedChanged
        If (p2_a.Checked) Then
            p2_a.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p2.Text Then

                If (p2_b.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p3_a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p3_a.CheckedChanged
        If (p3_b.Checked) Then
            p3_b.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p3.Text Then

                If (p3_a.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p3_b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p3_b.CheckedChanged

        If (p3_a.Checked) Then
            p3_a.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p3.Text Then

                If (p3_b.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p4_a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p4_a.CheckedChanged

        If (p4_b.Checked) Then
            p4_b.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p4.Text Then

                If (p4_a.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub

    Private Sub p4_b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p4_b.CheckedChanged

        If (p4_a.Checked) Then
            p4_a.Checked = False
        End If

        For Each p In preguntes

            If p.getPregunta = lbl_p4.Text Then

                If (p4_b.Text = p.getCorrecta) Then
                    punts = punts + 1
                Else
                    punts = punts - 1
                End If

            End If

        Next
        lbl_punts.Text = "Punts " + punts.ToString
    End Sub
End Class