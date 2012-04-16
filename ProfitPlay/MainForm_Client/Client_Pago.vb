Public Class Client_Pago
    Dim ws As New ws_profitplay.Service1SoapClient
    Dim preuTotal As Double
    Dim preuParcial As Double
    Dim numComensals As Integer = 2

    Private Sub Client_Pago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula

        'més endavant dividirem el preu entre els clients de la taula <- Welcome
        'numComensals = 

        preuTotal = CalculaPreu()
        lbl_importtotal.Text = lbl_importtotal.Text + preuTotal.ToString
        preuParcial = preuTotal / numComensals
        lbl_importparcial.Text = lbl_importparcial.Text + preuParcial.ToString
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
        'cal agafar el id del user
        Dim id As Integer = 1

        Dim comandes = ws.GetComanda()

        For Each fila In comandes
            If fila.Id_usuari = id Then
                ws.SolPagarComanda(fila.id)
                preuProducte = ws.GetPreuProducteById(fila.Id_producte)
                preu += preuProducte
            End If
        Next

        Return preu
    End Function

    Private Sub SolPagarComanda()
        Dim id_user As Integer = 1
        Dim comandes = ws.GetComanda()

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