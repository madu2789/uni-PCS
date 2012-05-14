Public Class Client_Carta
    Dim ws As New ws_profitplay.Service1SoapClient
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

        ObteProductes()

    End Sub

    Private Sub ObteProductes()

        Try

            Dim Llistaproductes = ws.GetAllProductes

            For Each fila In Llistaproductes

                Dim pro As New Producto

                pro.id = fila.id
                pro.nom = fila.nom
                pro.preu = fila.preu
                pro.tipus = fila.tipus
                pro.descripcio = fila.descripicio
                productes.Add(pro)

            Next

        Catch ex As Exception
            MsgBox("Error obtenint productes", MsgBoxStyle.Critical, "Error en obtenir productes")
        End Try

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
        addInfoLvPedidos("Beguda")
        grb_pedido.Text = "Afegir Begudes a la comanda"
    End Sub

    Private Sub btn_primeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_primeros.Click
        addInfoLvPedidos("Primer")
        grb_pedido.Text = "Afegir Primers a la comanda"
    End Sub

    Private Sub btn_segundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segundos.Click
        addInfoLvPedidos("Segon")
        grb_pedido.Text = "Afegir Segons a la comanda"
    End Sub

    Private Sub btn_postres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_postres.Click
        addInfoLvPedidos("Postre")
        grb_pedido.Text = "Afegir Postres a la comanda"
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

    Private Sub resetForm()
        lv_pedidos.Clear()
        grb_pedido.Show()
        productes = New List(Of Producto)
        m_comanda = New Comanda
    End Sub

    Public Sub refreshComanda()

        If m_comanda IsNot Nothing Then

            lv_pedidos.Clear()
            For s As Integer = 0 To m_comanda.getComanda.Count - 1 Step 1

                lv_pedidos.Items.Add(m_comanda.getComanda.Item(s))

            Next

        End If

    End Sub

    Private Sub btn_confirma_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirma_carta.Click

        Dim plats = ws.GetAllPlats()
        Dim result = MsgBox("Confirmem la comanda?", MsgBoxStyle.OkCancel, "Està segur?")
        If (result = MsgBoxResult.Ok) Then

            For s As Integer = 0 To lv_pedidos.Items.Count - 1 Step 1

                For Each p In plats

                    Dim idUsuari As String = Id_usuari.ToString
                    Dim idProducte As String = ws.GetIdProducteByNom(lv_pedidos.Items.Item(s).Text)
                    Dim notes As String = ""
                    Dim hora As Date = Now
                    Dim estat = "Sol·licitat"

                    MsgBox("Id " + p.id_producte.ToString + " y " + CInt(idProducte).ToString)
                    If (p.id_producte = CInt(idProducte)) Then

                        Dim ok = comprovaStock(p.id_producte)

                        If (ok = 1) Then
                            m_comanda.insertElement(lv_pedidos.Items.Item(s).Text)
                            ws.UpdateStockActualById(p.id_producte, p.quantitat)
                            ws.SetComanda(Id_usuari, idProducte, estat, notes, hora)
                        Else
                            MsgBox("No tenim disponible " + ws.GetNomProducteById(idProducte))
                            Exit For
                        End If
                    End If
                Next
            Next

            resetForm()

        End If
    End Sub

    Private Function comprovaStock(ByVal id As Integer) As Integer

        Dim ingredients = ws.GetIngredients
        Dim plats = ws.GetAllPlats

        For Each p In plats

            If (p.id_producte = id) Then

                For Each i In ingredients

                    If (p.id_ingredient = i.id) Then

                        MsgBox("Tenim " + i.stock_actual.ToString + " de " + i.nom)
                        i.stock_actual = i.stock_actual - p.quantitat
                        If (i.stock_actual <= 0) Then
                            Return 0
                        End If

                    End If
                Next
            End If
        Next

        Return 1

    End Function

    Private Sub btn_add_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_prod.Click

        For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

            If (lv_productos_disp.Items.Item(i).Selected = True) Then

                lv_pedidos.Items.Add(lv_productos_disp.Items.Item(i).Text)

            End If

        Next

    End Sub

    Private Sub btn_del_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del_prod.Click

        If lv_pedidos.Items.Count > 0 Then

            For i As Integer = lv_pedidos.Items.Count - 1 To 0 Step -1

                If (lv_pedidos.Items.Item(i).Selected = True) Then

                    lv_pedidos.Items.RemoveAt(i)
                    lv_pedidos.Items.Item(i).Selected = False

                End If

            Next

        End If

    End Sub

    Private Sub btn_info_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_info_prod.Click

        Dim dialog As New info_producte
        Dim added As Boolean = False
        Dim nom_prod As String = ""

        For i As Integer = 0 To lv_productos_disp.Items.Count - 1 Step 1

            If (lv_productos_disp.Items.Item(i).Selected = True And added = False) Then
                nom_prod = lv_productos_disp.Items.Item(i).Text
                added = True
            End If
        Next

        Dim productes = ws.GetAllProductes
        Dim plats = ws.GetAllPlats

        For Each p In productes

            If p.nom = nom_prod Then

                dialog.lbl_titol_producte.Text = "Nom del producte: " + p.nom

                If (p.descripicio <> "") Then
                    dialog.lbl_descripcio.Text = "Descripcció: " + p.descripicio
                Else
                    dialog.lbl_descripcio.Text = "Descripcció no disponible "
                End If

            End If

        Next

        For Each Plat In plats
            If (Plat.id_producte = ws.GetIdProducteByNom(nom_prod)) Then
                dialog.lbl_ingredients.Text += ws.GetNomIngredientById(Plat.id_ingredient) + ", "
            End If
        Next

        dialog.lbl_ingredients.Text.Remove(dialog.lbl_ingredients.Text.LastIndexOf(",") - 1, 2)

        Dim res = dialog.ShowDialog()
        Dim quantitat = dialog.getQuanitat()
        dialog.Dispose()

        If (res = Windows.Forms.DialogResult.OK) Then
            If (nom_prod <> "") Then
                For a As Integer = 1 To quantitat Step 1

                    lv_pedidos.Items.Add(nom_prod)

                Next
            End If
        End If

    End Sub

    Private Sub btn_estat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click

    End Sub
End Class