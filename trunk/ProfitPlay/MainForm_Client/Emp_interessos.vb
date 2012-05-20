Public Class Emp_interessos

    Dim ws As New ws_profitplay.Service1SoapClient
    Private listofproducts

    Private Sub Emp_interessos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_empleado.nomempleat
        lbl_punts.Text = Mainform_empleado.rolempleat

        Select Case Mainform_empleado.rolempleat
            Case "Administrador"
                btn_gest_comandes.Hide()
                btn_gest_pagos.Hide()
            Case "Cambrer"
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

        listofproducts = New List(Of Producto)

        ObteProductes()

    End Sub

    Private Sub ObteProductes()

        Dim Llistaproductes = ws.GetAllProductes()

        For Each fila In Llistaproductes
            Dim pro As New Producto

            pro.id = fila.id
            pro.nom = fila.nom
            pro.preu = fila.preu
            pro.tipus = fila.tipus
            pro.descripcio = fila.descripicio

            listofproducts.Add(pro)
            lv_normal.Items.Add(pro.nom)
        Next

    End Sub

    Private Sub btn_puja_car_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_puja_car.Click

        'afegeixo a la llista que em cal
        For i As Integer = 0 To lv_normal.Items.Count - 1 Step 1

            If (lv_normal.Items.Item(i).Selected = True) Then

                lv_car.Items.Add(lv_normal.Items.Item(i).Text)

            End If

        Next

        'ara elimino de la llista que he tret
        If lv_normal.Items.Count > 0 Then

            For i As Integer = lv_normal.Items.Count - 1 To 0 Step -1

                If (lv_normal.Items.Item(i).Selected = True) Then

                    lv_normal.Items.Item(i).Selected = False
                    lv_normal.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_puja_moltcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_puja_moltcar.Click

        For i As Integer = 0 To lv_car.Items.Count - 1 Step 1

            If (lv_car.Items.Item(i).Selected = True) Then

                lv_moltcar.Items.Add(lv_car.Items.Item(i).Text)

            End If
        Next

        If lv_car.Items.Count > 0 Then

            For i As Integer = lv_car.Items.Count - 1 To 0 Step -1

                If (lv_car.Items.Item(i).Selected = True) Then

                    lv_car.Items.Item(i).Selected = False
                    lv_car.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_baix_car_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baix_car.Click

        For i As Integer = 0 To lv_moltcar.Items.Count - 1 Step 1

            If (lv_moltcar.Items.Item(i).Selected = True) Then

                lv_car.Items.Add(lv_moltcar.Items.Item(i).Text)

            End If

        Next

        If lv_moltcar.Items.Count > 0 Then

            For i As Integer = lv_moltcar.Items.Count - 1 To 0 Step -1

                If (lv_moltcar.Items.Item(i).Selected = True) Then

                    lv_moltcar.Items.Item(i).Selected = False
                    lv_moltcar.Items.RemoveAt(i)

                End If

            Next

        End If


    End Sub

    Private Sub btn_baix_normal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baix_normal.Click

        For i As Integer = 0 To lv_car.Items.Count - 1 Step 1

            If (lv_car.Items.Item(i).Selected = True) Then

                lv_normal.Items.Add(lv_car.Items.Item(i).Text)

            End If

        Next

        If lv_car.Items.Count > 0 Then

            For i As Integer = lv_car.Items.Count - 1 To 0 Step -1

                If (lv_car.Items.Item(i).Selected = True) Then

                    lv_car.Items.Item(i).Selected = False
                    lv_car.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_baix_barat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baix_barat.Click

        For i As Integer = 0 To lv_normal.Items.Count - 1 Step 1

            If (lv_normal.Items.Item(i).Selected = True) Then

                lv_barat.Items.Add(lv_normal.Items.Item(i).Text)

            End If

        Next

        If lv_normal.Items.Count > 0 Then

            For i As Integer = lv_normal.Items.Count - 1 To 0 Step -1

                If (lv_normal.Items.Item(i).Selected = True) Then

                    lv_normal.Items.Item(i).Selected = False
                    lv_normal.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_baix_moltbarat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baix_moltbarat.Click

        For i As Integer = 0 To lv_barat.Items.Count - 1 Step 1

            If (lv_barat.Items.Item(i).Selected = True) Then

                lv_molbarat.Items.Add(lv_barat.Items.Item(i).Text)

            End If

        Next

        If lv_barat.Items.Count > 0 Then

            For i As Integer = lv_barat.Items.Count - 1 To 0 Step -1

                If (lv_barat.Items.Item(i).Selected = True) Then

                    lv_barat.Items.Item(i).Selected = False
                    lv_barat.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_puja_barat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_puja_barat.Click

        For i As Integer = 0 To lv_molbarat.Items.Count - 1 Step 1

            If (lv_molbarat.Items.Item(i).Selected = True) Then

                lv_barat.Items.Add(lv_molbarat.Items.Item(i).Text)

            End If

        Next

        If lv_molbarat.Items.Count > 0 Then

            For i As Integer = lv_molbarat.Items.Count - 1 To 0 Step -1

                If (lv_molbarat.Items.Item(i).Selected = True) Then

                    lv_molbarat.Items.Item(i).Selected = False
                    lv_molbarat.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    Private Sub btn_puja_normal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_puja_normal.Click

        For i As Integer = 0 To lv_barat.Items.Count - 1 Step 1

            If (lv_barat.Items.Item(i).Selected = True) Then

                lv_normal.Items.Add(lv_barat.Items.Item(i).Text)

            End If

        Next

        If lv_barat.Items.Count > 0 Then

            For i As Integer = lv_barat.Items.Count - 1 To 0 Step -1

                If (lv_barat.Items.Item(i).Selected = True) Then

                    lv_barat.Items.Item(i).Selected = False
                    lv_barat.Items.RemoveAt(i)

                End If

            Next

        End If

    End Sub

    
    Private Sub btn_guardarconfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardarconfig.Click

        'Guardar a la taula nivell de prioritat

        For i As Integer = 0 To lv_molbarat.Items.Count - 1 Step 1

            Try
                Dim id_producte = ws.GetIdProducteByNom(lv_molbarat.Items.Item(i).Text)
                ws.UpdateInteresById("1", id_producte)
            Catch ex As Exception

            End Try
        Next

        For i As Integer = 0 To lv_barat.Items.Count - 1 Step 1
            Try
                Dim id_producte = ws.GetIdProducteByNom(lv_barat.Items.Item(i).Text)
                ws.UpdateInteresById("2", id_producte)
            Catch ex As Exception

            End Try 
        Next

        For i As Integer = 0 To lv_normal.Items.Count - 1 Step 1
            Try
                Dim id_producte = ws.GetIdProducteByNom(lv_normal.Items.Item(i).Text)
                ws.UpdateInteresById("3", id_producte)
            Catch ex As Exception

            End Try
        Next

        For i As Integer = 0 To lv_car.Items.Count - 1 Step 1
            Try
                Dim id_producte = ws.GetIdProducteByNom(lv_car.Items.Item(i).Text)
                ws.UpdateInteresById("4", id_producte)
            Catch ex As Exception

            End Try
        Next

        For i As Integer = 0 To lv_moltcar.Items.Count - 1 Step 1
            Try
                Dim id_producte = ws.GetIdProducteByNom(lv_moltcar.Items.Item(i).Text)
                ws.UpdateInteresById("5", id_producte)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub btn_gest_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_carta.Click
        Me.Hide()
        Emp_carta.Show()
    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
    End Sub

    Private Sub btn_gest_stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_stock.Click
        Me.Hide()
        Emp_stock.Show()
    End Sub

    Private Sub btn_gest_pagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_pagos.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub

    Private Sub btn_gest_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_users.Click
        Me.Hide()
        Emp_Gestio_usuaris.Show()
    End Sub
End Class