Public Class Emp_stock

    Dim ws As New ws_profitplay.Service1SoapClient

    Private Sub btn_gest_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_users.Click
        Me.Hide()
        Emp_Gestio_usuaris.Show()
    End Sub

    Private Sub btn_gest_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_carta.Click
        Me.Hide()
        Emp_carta.Show()
    End Sub

    Private Sub btn_gest_pagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_pagos.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub

    Private Sub Emp_stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_empleado.nomempleat
        lbl_punts.Text = Mainform_empleado.rolempleat

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

        Dim productes = ws.GetProducte

        For Each fila In productes

            Dim pro As New Producto

            pro.id = fila.id
            pro.preu = fila.preu
            pro.nom = fila.nom
            pro.tipus = fila.tipus
            pro.descripcio = fila.descripicio

            ts_productes_stock.Items.Add(pro.nom)

        Next

    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
        Me.Dispose()
    End Sub

    Private Sub ts_productes_stock_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ts_productes_stock.ItemClicked

        Dim res = InputBox("Stock actual de " + e.ClickedItem.Text + ": " + ws.GetStockActualById(ws.GetIdIngredientByNom(e.ClickedItem.Text)).ToString + vbCr + "Entra el nou stock", "Canvi de stock", "", , )

        If (res <> "") Then
            Try
                Dim newstock As Integer = Integer.Parse(res)
                ws.UpdateStockActualById(ws.GetIdIngredientByNom(e.ClickedItem.Text), newstock)
            Catch ex As Exception
                Dim newstock As Integer = 0
                MsgBox("Error en el format del nou stock", MsgBoxStyle.Critical, "Format Incorrecte")
            End Try
        End If
        

    End Sub

    Private Sub btn_segundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segundos.Click

        Dim stock As New Control_Stock
        stock.Show()

    End Sub
End Class