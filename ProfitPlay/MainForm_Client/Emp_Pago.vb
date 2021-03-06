﻿Public Class Emp_Pago

    Dim ws As New ws_profitplay.Service1SoapClient

    Private Sub btn_gest_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_users.Click
        Me.Hide()
        Emp_Gestio_usuaris.Show()
    End Sub

    Private Sub btn_gest_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_carta.Click
        Me.Hide()
        Emp_carta.Show()
    End Sub

    Private Sub btn_gest_stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_stock.Click
        Me.Hide()
        Emp_stock.Show()
    End Sub

    Private Sub Emp_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_user.Text = Mainform_empleado.nomempleat
        lbl_rol.Text = Mainform_empleado.rolempleat

        Select Case Mainform_empleado.rolempleat
            Case "Administrador"
                btn_gest_comandes.Hide()
                'btn_gest_pagos.Hide()
            Case "Cambrer"
                btn_gest_users.Hide()
                btn_gest_carta.Hide()
                btn_gest_stock.Hide()
                btn_config_fichero.Hide()
            Case "Barman"
                btn_gest_users.Hide()
                btn_gest_carta.Hide()
                ' btn_gest_pagos.Hide()
                btn_gest_stock.Hide()
                btn_config_fichero.Hide()
            Case "Cheff"
                btn_gest_users.Hide()
                btn_gest_carta.Hide()
                ' btn_gest_pagos.Hide()
                btn_gest_stock.Hide()
                btn_config_fichero.Hide()
            Case Else
        End Select

        Dim users = ws.GetAllUsers()
        cb_taula.Items.Clear()

        For Each a In users
            cb_taula.Items.Add("Taula " + a.Id_usuari.ToString)
        Next

    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
    End Sub

    Private Sub cb_taula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_taula.SelectedIndexChanged

        Dim comandes_taula As New List(Of Comanda)
        Dim totes_comandes = ws.GetAllComandes
        Dim preu As Integer = 0

        Dim comandes = ws.GetComandaByUserId(getIdTaula())

        For Each fila In comandes

            ws.SolPagarComanda(fila.id)
            preu += ws.GetPreuProducteById(fila.Id_producte)

        Next

        lbl_importtotal.Text = "Import total: " + preu.ToString

        Dim usuaris = ws.GetAllUsers

        For Each i In usuaris

            If i.Id_usuari = getIdTaula() Then
                lbl_importparcial.Text = "Import per persona " + (preu / i.Comensals).ToString
                Exit For
            End If

        Next


    End Sub

    Public Function getIdTaula() As Integer

        If (cb_taula.SelectedItem <> Nothing) Then
            Return CInt(cb_taula.SelectedItem.ToString.Substring(cb_taula.SelectedItem.ToString.LastIndexOf("a") + 1))
        End If
        Return Nothing
    End Function

    Private Sub btn_efectiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_efectiu.Click
        paga(getIdTaula)
    End Sub

    Private Sub btn_mixt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mixt.Click
        paga(getIdTaula)
    End Sub

    Private Sub btn_tc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tc.Click
        paga(getIdTaula)
    End Sub

    Public Sub paga(ByVal id As Integer)

        Dim tot_per_pagar As Boolean = True

        If (id = Nothing) Then
            MsgBox("Cap taula sel.leccionada", MsgBoxStyle.Critical, "Cap taula sel.leccionada")
        Else
            Dim comandes_user = ws.GetComandaByUserId(getIdTaula)
            For Each c In comandes_user

                If c.Estat <> "Sol·licitat per pagar" Then
                    tot_per_pagar = False
                End If

            Next

            If (tot_per_pagar = True) Then
                ws.deleteComandaByUserId(id)
                ws.deleteUser(id)
            Else
                MsgBox("Tots els productes no estan sol.licitats per pagar", MsgBoxStyle.Critical, "Error en els estats de les comandes")
            End If

        End If

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
      
    End Sub
End Class