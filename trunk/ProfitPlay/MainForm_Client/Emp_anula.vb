Public Class Emp_anula

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim listofcommands As List(Of Comanda)


    Private Sub Emp_anula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        listofcommands = New List(Of Comanda)
        CarregaComandes()
        MostraComandes()

    End Sub

    Private Sub CarregaComandes()

        Dim comandes = ws.GetComanda

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

            If (p.Estat = "En Espera") Then

                llista_productes_eliminar.Items.Add(p.Id_producte)

            Else

                llista_resta_productes.Items.Add(p.Id_producte)

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
End Class