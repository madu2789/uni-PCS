Public Class Client_Pago
    Dim ws As New ws_profitplay.Service1SoapClient
    Dim preuTotal As Double
    Dim preuParcial As Double
    Dim numComensals As Integer

    Private Sub Client_Pago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula

        'més endavant dividirem el preu entre els clients de la taula <- Welcome
        'numComensals = 

        preuTotal = CalculaPreu()
        lbl_importtotal.Text = lbl_importtotal.Text + preuTotal
        preuParcial = preuTotal / numComensals
        lbl_importparcial.Text = lbl_importparcial.Text + preuParcial
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
        Dim preu As Double
        Dim preuProducte As Double
        'cal agafar el id del user
        Dim id As Integer

        Dim comandes = ws.GetComanda()

        For Each fila In comandes
            If fila.Id_usuari = id Then
                'preuProducte = ws.GetPreuProducteById(fila.Id_producte)

            End If

        Next

        Return preu
    End Function
   
End Class