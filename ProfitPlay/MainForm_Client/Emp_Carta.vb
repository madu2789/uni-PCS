Public Class Emp_carta

    Dim ws As New ws_profitplay.Service1SoapClient
    Private listofproducts
    Private listofingredient
    Private m_comanda

    Private Sub Emp_carta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_empleado.nomempleat
        lbl_punts.Text = Mainform_empleado.rolempleat

        listofproducts = New List(Of Producto)
        listofingredient = New List(Of Ingredient)
        m_comanda = New Comanda()

        Select Case Mainform_empleado.rolempleat

            Case "Administrador"
                btn_gest_comandes.Hide()
                btn_gest_pagos.Hide()
            Case "Cambrero"
                btn_gest_users.Hide()
                btn_gest_carta.Hide()
                btn_gest_stock.Hide()
                btn_config_fichero.Hide()
            Case "Barman"
                btn_gest_users.Hide()
                btn_gest_carta.Hide()
                btn_gest_pagos.Hide()
                btn_gest_stock.Hide()
                btn_config_fichero.Hide()
            Case "Cheff"
                btn_gest_users.Hide()
                btn_gest_carta.Hide()
                btn_gest_pagos.Hide()
                btn_gest_stock.Hide()
                btn_config_fichero.Hide()
            Case Else

        End Select

        'ompleLlistaProductes()
        ObteProductes()
        btn_producto.PerformClick()

    End Sub

    'vindra de la bbdd
    Private Sub ompleLlistaProductes()

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("bebida " + i.ToString)
            p.setPreu(i)
            p.setTipus("bebida")
            listofproducts.Add(p)

        Next

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("primero " + i.ToString)
            p.setPreu(i)
            p.setTipus("primero")
            listofproducts.Add(p)

        Next

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("segundo " + i.ToString)
            p.setPreu(i)
            p.setTipus("segundo")
            listofproducts.Add(p)

        Next

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("postre " + i.ToString)
            p.setPreu(i)
            p.setTipus("postre")
            listofproducts.Add(p)

        Next


    End Sub

    Private Sub ObteProductes()

        Dim Llistaproductes = ws.GetProducte()

        For Each fila In Llistaproductes
            Dim pro As New Producto

            pro.id = fila.id
            pro.nom = fila.nom
            pro.preu = fila.preu
            pro.tipus = fila.tipus
            pro.descripcio = fila.descripicio

            listofproducts.Add(pro)
        Next

    End Sub

    Private Sub ObteIngredients()

        lbl_productos_dispo.Text = "Ingredients disponibles:"
        lbl_productes_seleccinats.Text = "Ingredients seleccionats:"
        emp_lv_productos_seleccionats.Clear()
        emp_lv_productos_disp.Clear()

        Dim Llistaingredients = ws.GetIngredients()

        For Each fila In Llistaingredients
            Dim ingr As New Ingredient

            ingr.id_ingredient = fila.id
            ingr.nom = fila.nom
            ingr.preu = fila.preu
            ingr.quantitat = fila.quantitat
            ingr.StockActual = fila.stock_actual
            ingr.StockMinim = fila.stock_minim

            listofingredient.Add(ingr)
            emp_lv_productos_disp.Items.Add(ingr.getNom)
        Next

        emp_lv_productos_disp.Refresh()

    End Sub

    Private Sub btn_gest_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_users.Click
        Me.Hide()
        Emp_Gestio_usuaris.Show()
    End Sub

    Private Sub btn_gest_stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_stock.Click
        Me.Hide()
        Emp_stock.Show()
    End Sub

    Private Sub btn_gest_pagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_pagos.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub

    
    Private Sub btn_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_producto.Click

        grb_insert.Hide()
        emp_lv_productos_seleccionats.Clear()
        emp_lv_productos_disp.Clear()

        For Each s As Producto In listofproducts

            emp_lv_productos_disp.Items.Add(s.getNom)

        Next

        emp_lv_productos_disp.Refresh()

        grb_carta.Text = "Crear Carta"

    End Sub

    Private Sub btn_add_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_prod_emp.Click

        For i As Integer = 0 To emp_lv_productos_disp.Items.Count - 1 Step 1

            If (emp_lv_productos_disp.Items.Item(i).Selected = True) Then

                emp_lv_productos_seleccionats.Items.Add(emp_lv_productos_disp.Items.Item(i).Text)

            End If

        Next

    End Sub

    Private Sub btn_del_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del_prod_emp.Click

        If emp_lv_productos_seleccionats.Items.Count > 0 Then

            For i As Integer = emp_lv_productos_seleccionats.Items.Count - 1 To 0 Step -1

                If (emp_lv_productos_seleccionats.Items.Item(i).Selected = True) Then

                    emp_lv_productos_seleccionats.Items.Item(i).Selected = False
                    emp_lv_productos_seleccionats.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_info_prod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_info_prod_emp.Click

        Dim dialog As New info_producte
        Dim added As Boolean = False

        'aixo ve de la bbdd
        dialog.lbl_titol_producte.Text = "Aquesta es el titol"
        dialog.lbl_descripcio.Text = "Aquesta es la descripccio"
        dialog.lbl_ingredients.Text = "Els ingredients: a, b, c, d"

        Dim res = dialog.ShowDialog()
        Dim quantitat = dialog.getQuanitat()
        dialog.Dispose()

        If (res = Windows.Forms.DialogResult.OK) Then

            For i As Integer = 0 To emp_lv_productos_disp.Items.Count - 1 Step 1

                If (emp_lv_productos_disp.Items.Item(i).Selected = True And added = False) Then

                    For a As Integer = 0 To quantitat - 1 Step 1

                        emp_lv_productos_seleccionats.Items.Add(emp_lv_productos_disp.Items.Item(i).Text)
                        added = True

                    Next

                End If

            Next

        End If
    End Sub

    'cal guardar la nova carta a la bbdd
    Private Sub btn_crear_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim result = MsgBox("Crear nova carta?", MsgBoxStyle.OkCancel, "Crear nova carta?")
        If (result = MsgBoxResult.Ok) Then

            Dim input = InputBox("Entra nom de la carta", "Nom de la carta?", "")

            If (input = "") Then

                MsgBox("Nom de la carta incorrecte", MsgBoxStyle.Critical, "Nom incorrecte")

            Else

                For s As Integer = 0 To emp_lv_productos_seleccionats.Items.Count - 1 Step 1

                    m_comanda.insertElement(emp_lv_productos_seleccionats.Items.Item(s).Text)

                Next

                m_comanda.showComanda()
                emp_lv_productos_seleccionats.Clear()

            End If

        End If

    End Sub

    Private Sub btn_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grb_carta.Text = "Veure Cartes Creades"
    End Sub

    Private Sub btn_ingrediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingrediente.Click

        grb_insert.Hide()
        grb_carta.Text = "Veure Ingredients"
        ObteIngredients()

    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
    End Sub

    Private Sub btn_gest_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_carta.Click

    End Sub

    Private Sub btn_crear_producte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear_producte.Click

        grb_insert.Show()

    End Sub

    Private Sub btn_afegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_afegir.Click

        'insert a la base de dades
        'taula productes
        If (txtb_nom.Text = "" Or txtb_descripcio.Text = "" Or txtb_preu.Text = "" Or cmbx_tipus.Text = "") Then
            MsgBox("Error, camps incomplerts!", MsgBoxStyle.Critical)
        Else
            ws.SetProducte(txtb_nom.Text, txtb_descripcio.Text, txtb_preu.Text, cmbx_tipus.Text)
            MsgBox("Producte inserit correctament!", MsgBoxStyle.Information)
            grb_insert.Hide()
        End If


        'taula productes-ingredients

    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        grb_insert.Hide()
    End Sub
End Class