Public Class Client_Carta

    Private m_comanda As Comanda
    Private productes As List(Of Producto)

    Private Sub Client_Carta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula
        initStructure()
        btn_bebidas.PerformClick()
        refreshComanda()

    End Sub

    Private Sub initStructure()

        lv_productos_disp.Clear()
        lv_pedidos.Clear()
        grb_pedido.Show()
        productes = New List(Of Producto)
        m_comanda = New Comanda

        fillStructure()

    End Sub

    Private Sub fillStructure()

        For i As Integer = 0 To 10 Step 1

            Dim p As Producto = New Producto()
            p.setNom("primero " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(CType(i, Double))
            p.setTipus("primero")
            productes.Add(p)

        Next

        For i As Integer = 0 To 10 Step 1

            Dim p As Producto = New Producto()
            p.setNom("segundo " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(CType(i, Double))
            p.setTipus("segundo")
            productes.Add(p)

        Next

        For i As Integer = 0 To 10 Step 1

            Dim p As Producto = New Producto()
            p.setNom("postre " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(CType(i, Double))
            p.setTipus("postre")
            productes.Add(p)

        Next

        For i As Integer = 0 To 10 Step 1

            Dim p As Producto = New Producto()
            p.setNom("bebida " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(CType(i, Double))
            p.setTipus("bebida")
            productes.Add(p)

        Next

    End Sub

    Private Sub addInfoLvPedidos(ByVal s As String)

        Dim item As ListViewItem = New ListViewItem

        lv_productos_disp.Show()
        lv_productos_disp.Items.Clear()

        For i As Integer = 0 To productes.Count - 1 Step 1

            If (s = productes(i).getTipus) Then

                lv_productos_disp.Items.Add(productes.Item(i).getNom)

            End If

        Next

        lv_productos_disp.Update()

    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click

        Client_Anula.Show()
        Me.Hide()
        Me.Dispose()

    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i As Integer = 0 To lv_pedidos.Items.Count - 1

            MsgBox("Seleccionat " + lv_pedidos.Items.Item(i).Text)
            m_comanda.insertElement(lv_pedidos.Items.Item(i).Text)

        Next

        lv_pedidos.Clear()

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
        addInfoLvPedidos("bebida")
    End Sub

    Private Sub btn_primeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_primeros.Click
        addInfoLvPedidos("primero")
    End Sub

    Private Sub btn_segundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segundos.Click
        addInfoLvPedidos("segundo")
    End Sub

    Private Sub btn_postres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_postres.Click
        addInfoLvPedidos("postre")
    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click
        btn_bebidas.PerformClick()
    End Sub

    Public Function getComanda() As Comanda
        Return m_comanda
    End Function

    Public Sub setComanda(ByVal edited_command As Comanda)
        Me.m_comanda = edited_command
    End Sub

    Private Sub grb_menu_carta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grb_menu_carta.Enter

    End Sub

    Public Sub refreshComanda()

        If m_comanda IsNot Nothing Then

            lv_pedidos.Clear()
            For s As Integer = 0 To m_comanda.getComanda.Count - 1 Step 1

                lv_pedidos.Items.Add(m_comanda.getComanda.Item(s))

            Next

        End If

    End Sub

    'Private Sub btn_afegeix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

    '        If (lv_productos_disp.Items.Item(i).Selected = True) Then

    '            If (nud_cantitat.Value = 0) Then

    '                MsgBox("Selecciona una quantitat", MsgBoxStyle.Exclamation, "Error de quantitat")
    '                pnl_info_producte.Show()

    '            Else

    '                For a As Integer = 0 To nud_cantitat.Value - 1 Step 1

    '                    lv_pedidos.Items.Add(lv_productos_disp.Items.Item(i).Text)
    '                    m_comanda.insertElement(lv_productos_disp.Items.Item(i).Text)
    '                    pnl_info_producte.Hide()

    '                Next

    '            End If

    '        End If

    '    Next

    'End Sub

    Private Sub btn_confirma_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirma_carta.Click

        Dim result = MsgBox("Confirmem la comanda?", MsgBoxStyle.OkCancel)
        If (result = MsgBoxResult.Ok) Then

            Dim merda As New Client_Carta
            merda.ShowDialog()
            Me.Dispose()

        End If
    End Sub

    Private Sub btn_add_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_prod.Click

        For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

            If (lv_productos_disp.Items.Item(i).Selected = True) Then

                lv_pedidos.Items.Add(lv_productos_disp.Items.Item(i).Text)
                m_comanda.insertElement(lv_productos_disp.Items.Item(i).Text)

            End If

        Next

    End Sub

    Private Sub btn_del_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del_prod.Click

        If lv_pedidos.Items.Count > 0 Then

            For i As Integer = lv_pedidos.Items.Count - 1 To 0 Step -1

                If (lv_pedidos.Items.Item(i).Selected = True) Then

                    m_comanda.deleteElement(lv_pedidos.Items.Item(i).Text)
                    lv_pedidos.Items.Item(i).Selected = False
                    lv_pedidos.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_info_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_info_prod.Click

        Dim dialog As New info_producte

        'aixo ve de la bbdd
        dialog.lbl_titol_producte.Text = "Aquesta es el titol"
        dialog.lbl_descripcio.Text = "Aquesta es la descripccio"
        dialog.lbl_ingredients.Text = "Els ingredients: a, b, c, d"

        Dim res = dialog.ShowDialog()
        Dim quantitat = dialog.getQuanitat()
        dialog.Dispose()

        If (res = Windows.Forms.DialogResult.OK) Then

            For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

                If (lv_productos_disp.Items.Item(i).Selected = True) Then

                    For a As Integer = 1 To quantitat Step 1

                        lv_pedidos.Items.Add(lv_productos_disp.Items.Item(i).Text)
                        m_comanda.insertElement(lv_productos_disp.Items.Item(i).Text)

                    Next

                End If

            Next

        End If
    End Sub
End Class