Public Class Client_Carta

    Dim carta As structure_carta

    Structure structure_carta

        Dim primers As ArrayList
        Dim segons As ArrayList
        Dim postres As ArrayList
        Dim begudes As ArrayList

    End Structure


    Private Sub initStructure()

        carta = New structure_carta
        carta.primers = New ArrayList
        carta.segons = New ArrayList
        carta.postres = New ArrayList
        carta.begudes = New ArrayList

        lv_productos_disp.Clear()
        lv_pedidos.Clear()
        grb_pedido.Show()

    End Sub

    Private Sub fillStructure(ByVal s As String, ByRef carta As structure_carta)

        initStructure()

        If (s = "primer") Then

            For i As Integer = 0 To 10 Step 1

                carta.primers.Add(s & i.ToString)

            Next

        ElseIf (s = "segon") Then

            For i As Integer = 0 To 10 Step 1

                carta.segons.Add(s & i.ToString)

            Next

        ElseIf (s = "postre") Then

            For i As Integer = 0 To 10 Step 1

                carta.postres.Add(s & i.ToString)

            Next

        ElseIf (s = "beguda") Then

            For i As Integer = 0 To 10 Step 1

                carta.begudes.Add(s & i.ToString)

            Next

        End If

    End Sub

    Private Sub addInfoLvPedidos(ByVal p As ArrayList)

        lv_productos_disp.Show()
        If (p IsNot Nothing) Then

            lv_productos_disp.Items.Clear()
            For Each nom As String In p

                lv_productos_disp.Items.Add(nom)

            Next

            lv_productos_disp.Update()

        End If

    End Sub

    Private Sub Client_Carta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula
    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click
        Client_Anula.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click
        'per fer!
    End Sub

    Private Sub btn_jugar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jugar.Click
        Client_Juego.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pagar.Click
        Client_Pago.Show()
        Me.Hide()
    End Sub


    Private Sub btn_bebidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bebidas.Click

        Me.Show()
        fillStructure("beguda", carta)
        addInfoLvPedidos(carta.begudes)

    End Sub

    Private Sub btn_primeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_primeros.Click
        fillStructure("primer", carta)
        addInfoLvPedidos(carta.primers)
    End Sub

    Private Sub btn_segundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segundos.Click
        fillStructure("segon", carta)
        addInfoLvPedidos(carta.segons)
    End Sub

    Private Sub btn_postres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_postres.Click
        fillStructure("postre", carta)
        addInfoLvPedidos(carta.postres)
    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click
        initStructure()
        btn_primeros.PerformClick()
    End Sub
    Private Sub lv_productes_disponibles_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_productos_disp.Click



    End Sub
End Class