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

        Dim alerta As String = ""
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

        Dim productes = ws.GetIngredients
        Dim compres = ws.getCompres()
        Dim comprat As Boolean = False

        For Each fila In productes

            Dim pro As New Ingredient

            pro.id_ingredient = fila.id
            pro.preu = fila.preu
            pro.nom = fila.nom
            pro.quantitat = fila.quantitat
            pro.StockActual = fila.stock_actual
            pro.StockMinim = fila.stock_minim
            For Each c In compres

                If c.Id_ingredient = pro.id_ingredient Then
                    comprat = True
                End If

            Next

            If (pro.StockActual <= pro.StockMinim And comprat = False) Then
                alerta += pro.nom + vbCr
            End If

            If (pro.StockActual <= pro.StockMinim And comprat = True) Then
                alerta += "(*) " + pro.nom + vbCr
            End If

            comprat = False
            ts_productes_stock.Items.Add(pro.nom)

        Next

        If alerta.Length <> 0 Then
            MsgBox("(*) Indica ja demanat" + vbCr + vbCr + alerta + vbCr + vbCr, MsgBoxStyle.Critical, "Sense Stock o Stock Minim")
        End If

    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
        Me.Dispose()
    End Sub

    Private Sub ts_productes_stock_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ts_productes_stock.ItemClicked

        'MsgBox("Stock actual de " + e.ClickedItem.Text + ": " + ws.GetStockActualById(ws.GetIdIngredientByNom(e.ClickedItem.Text)).ToString, MsgBoxStyle.Information, "Control de Stock")

    End Sub

    Private Sub btn_segundos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segundos.Click

        Dim stock As New Control_Stock
        stock.Show()

    End Sub

    Private Sub btn_compres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compres.Click
        Dim compres As New Compres_Pendents
        compres.Show()
    End Sub

    Private Sub btn_config_fichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_config_fichero.Click
        Me.Hide()
        Emp_interessos.Show()
    End Sub

    Private Sub pcb_sortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcb_sortir.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub
End Class