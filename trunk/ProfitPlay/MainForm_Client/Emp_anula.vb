Public Class Emp_anula

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim listofcommands As List(Of Comanda)


    Private Sub Emp_anula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_empleado.nomempleat
        lbl_punts.Text = Mainform_empleado.rolempleat

         Select Mainform_empleado.rolempleat
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

        listofcommands = New List(Of Comanda)
        CarregaComandes()
        MostraComandes()

    End Sub

    Private Sub CarregaComandes()

        Dim comandes = ws.GetAllComandes

        For Each fila In comandes

            Dim pro As New Comanda

            pro.Estat = fila.Estat
            pro.Hora = fila.Hora
            pro.Id_comanda = fila.id
            pro.Id_usuari = fila.Id_Usuari
            pro.Notes = fila.Notes
            pro.Id_producte = fila.Id_producte

            listofcommands.Add(pro)

        Next

    End Sub

    Private Sub MostraComandes()

        For Each p In listofcommands

            Dim Nom As String = ws.GetNomProducteById(p.Id_producte)
            If (p.Estat = "En Espera") Then

                llista_productes_eliminar.Items.Add(Nom)

            Else

                llista_resta_productes.Items.Add(Nom)

            End If

        Next

    End Sub

    Private Sub btn_gest_stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_stock.Click
        Me.Hide()
        Emp_stock.Show()
    End Sub

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

    Private Sub llista_productes_eliminar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles llista_productes_eliminar.ItemClicked
        Dim res = MsgBox("Eliminem aquesta comanda?", MsgBoxStyle.OkCancel, "Eliminar Comanda")

        If (res = MsgBoxResult.Ok) Then
            llista_productes_eliminar.Items.Remove(e.ClickedItem)
        End If
    End Sub

    Private Sub btn_config_fichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_config_fichero.Click
        Me.Hide()
        Emp_interessos.Show()
    End Sub
End Class