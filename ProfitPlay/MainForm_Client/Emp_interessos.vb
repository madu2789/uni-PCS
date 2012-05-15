﻿Public Class Emp_interessos

    Dim ws As New ws_profitplay.Service1SoapClient
    Private listofproducts

    Private Sub Emp_interessos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_empleado.nomempleat
        lbl_punts.Text = Mainform_empleado.rolempleat

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





    End Sub
End Class