Public Class Client_Pago
    Dim ws As New ws_profitplay.Service1SoapClient
    Dim preuTotal As Double
    Dim preuParcial As Double
    Dim numComensals As Integer = 2

    Private Sub Client_Pago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'intent dimitar al david amb
        Me.KeyPreview = True

        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula

        'més endavant dividirem el preu entre els clients de la taula <- Welcome
        numComensals = GNum_comensals

        preuTotal = CalculaPreu()

        If (GPunts = 4) Then
            preuTotal = preuTotal - (preuTotal * GDescompte / 100)
        End If

        lbl_importtotal.Text = lbl_importtotal.Text + preuTotal.ToString
        preuParcial = preuTotal / numComensals
        lbl_importparcial.Text = lbl_importparcial.Text + preuParcial.ToString


    End Sub

    Sub Form1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress

        If (e.KeyChar.ToString() = "#") Then

            'elimina usuari actual
            ws.deleteUser(Id_usuari)

            Welcome.Show()
            Welcome.txtb_nomTaula.Text = ""
            Me.Close()

            e.Handled = True

        End If

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

    Private Sub btn_jugar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jugar.Click
        Client_Juego.Show()
        Me.Hide()
    End Sub

    Private Function CalculaPreu() As Double
        Dim preu As Double = 0
        Dim preuProducte As Double

        Dim comandes = ws.GetComandaByUserId(Id_usuari)

        For Each fila In comandes

            ws.SolPagarComanda(fila.id)
            preuProducte = ws.GetPreuProducteById(fila.Id_producte)
            preuProducte = preuProducte * SistemaPreus(fila.Id_producte)
            preu += preuProducte

        Next

        Return preu
    End Function

    Private Function SistemaPreus(ByVal ID_Producte_actual As String) As Double
        Dim percentatge As Double = 1

        Dim taula = ws.GetTaulaPreus()

        For Each fila In taula
            If fila.Id_producte = ID_Producte_actual Then
                If (fila.Interes < "5") Then
                    If fila.EsPotPreparar Then
                        percentatge = 1.25
                    Else
                        percentatge = 1.5
                    End If
                ElseIf (fila.Interes < "4") Then
                    If fila.EsPotPreparar Then
                        percentatge = 1.1
                    Else
                        percentatge = 1.25
                    End If
                ElseIf (fila.Interes < "3") Then
                    If fila.EsPotPreparar Then
                        percentatge = 1
                    Else
                        percentatge = 1.1
                    End If
                ElseIf (fila.Interes < "2") Then
                    If fila.EsPotPreparar Then
                        percentatge = 0.15
                    Else
                        percentatge = 0.35
                    End If
                ElseIf (fila.Interes < "1") Then
                    If fila.EsPotPreparar Then
                        percentatge = 0.35
                    Else
                        percentatge = 0.55
                    End If
                End If
            End If
        Next


        Return percentatge
    End Function

    Private Sub SolPagarComanda()
        'agafar el id del usuari
        Dim id_user As Integer = Id_usuari
        Dim comandes = ws.GetAllComandes()

        For Each fila In comandes
            If fila.Id_usuari = id_user Then
                ws.SolPagarComanda(fila.id)
            End If
        Next
    End Sub

    Private Sub btn_efectiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_efectiu.Click
        SolPagarComanda()
    End Sub

    Private Sub btn_mixt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mixt.Click
        SolPagarComanda()
    End Sub

    Private Sub btn_tc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tc.Click
        SolPagarComanda()
    End Sub
End Class