﻿Public Class Client_Carta

    Private m_comanda As Comanda
    Private productes As List(Of Producto)

    Private Sub initStructure()

        lv_productos_disp.Clear()
        lv_pedidos.Clear()
        grb_pedido.Show()
        productes = New List(Of Producto)

    End Sub

    Private Sub fillStructure(ByVal p As Producto)

        productes.Add(p)

    End Sub

    Private Sub addInfoLvPedidos(ByVal s As String)

        Dim item As ListViewItem = New ListViewItem

        lv_productos_disp.Show()
        If (productes IsNot Nothing) Then

            lv_productos_disp.Items.Clear()
            For i As Integer = 0 To productes.Count Step 1

                lv_productos_disp.Items.Add(productes.Item(i).getNom)

            Next

            lv_productos_disp.Update()

        End If

    End Sub

    Private Sub Client_Carta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula
        initStructure()
        btn_bebidas.PerformClick()
        refreshComanda()
    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click
        Client_Anula.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click

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

        Dim p As Producto = New Producto()
        Dim preu As Double = 10

        For i As Integer = 0 To 10 Step 1

            p.setNom("beguda " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(preu)
            fillStructure(p)

        Next

        addInfoLvPedidos("bebidas")

    End Sub

    Private Sub btn_primeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_primeros.Click

        Dim p As Producto = New Producto()
        Dim preu As Double = 20

        For i As Integer = 0 To 10 Step 1

            p.setNom("primeros " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(preu)
            fillStructure(p)

        Next

        addInfoLvPedidos("primeros")

    End Sub

    Private Sub btn_segundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segundos.Click

        Dim p As Producto = New Producto()
        Dim preu As Double = 30

        For i As Integer = 0 To 10 Step 1

            p.setNom("segundos " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(preu)
            fillStructure(p)

        Next
        addInfoLvPedidos("segundos")

    End Sub

    Private Sub btn_postres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_postres.Click

        Dim p As Producto = New Producto()
        Dim preu As Double = 40

        For i As Integer = 0 To 10 Step 1

            p.setNom("postres " + i.ToString)
            p.setDescripcio("descripcio " + i.ToString)
            p.setPreu(preu)
            fillStructure(p)

        Next
        addInfoLvPedidos("postres")

    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click
        Dim p As Producto = New Producto()
        fillStructure(p)
        btn_bebidas.PerformClick()
    End Sub
    Private Sub lv_productes_disponibles_doubleclick(ByVal sender As System.Windows.Forms.ListView, ByVal e As System.EventArgs) Handles lv_productos_disp.DoubleClick

        For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

            If (lv_productos_disp.Items.Item(i).Selected = True) Then

                lv_pedidos.Items.Add(lv_productos_disp.Items.Item(i).Text)
                m_comanda.insertElement(lv_productos_disp.Items.Item(i).Text)

            End If

        Next

    End Sub

    Private Sub lv_productes_disponibles_click(ByVal sender As System.Windows.Forms.ListView, ByVal e As System.EventArgs) Handles lv_productos_disp.Click

        pnl_info_producte.Show()
        lbl_titol_producte.Text = "Aquesta es el titol"
        lbl_descripcio.Text = "Aquesta es la descripccio"
        lbl_ingredients.Text = "Els ingredients: a, b, c, d"

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

        lv_pedidos.Clear()

        For s As Integer = 0 To m_comanda.getComanda.Count - 1 Step 1

            lv_pedidos.Items.Add(m_comanda.getComanda.Item(s))

        Next

    End Sub

    Private Sub btn_afegeix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_afegeix.Click

        For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

            If (lv_productos_disp.Items.Item(i).Selected = True) Then

                If (nud_cantitat.Value = 0) Then

                    MsgBox("Selecciona una quantitat", MsgBoxStyle.Exclamation, "Error de quantitat")
                    pnl_info_producte.Show()

                Else

                    For a As Integer = 0 To nud_cantitat.Value - 1 Step 1

                        lv_pedidos.Items.Add(lv_productos_disp.Items.Item(i).Text)
                        m_comanda.insertElement(lv_productos_disp.Items.Item(i).Text)
                        pnl_info_producte.Hide()

                    Next

                End If

            End If

        Next

    End Sub

    Private Sub btn_confirma_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirma_carta.Click
        Dim result = MsgBox("Confirmem la comanda?", MsgBoxStyle.OkCancel)

        If (result = MsgBoxResult.Ok) Then
            Me.Dispose()
            Dim merda As New Client_Carta
            merda.ShowDialog()

        End If
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        pnl_info_producte.Hide()
    End Sub
End Class