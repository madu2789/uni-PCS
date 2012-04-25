Imports System.Runtime.Serialization
Imports System.Xml.Serialization
Imports System.Xml
Imports System.Collections.Generic

Public Class Emp_Gestio_usuaris

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim empleats As New DataTable()

    Public Structure EmpleatBD
        Dim id As Integer
        Dim rol As String
        Dim nom As String
        Dim cognom As String
        Dim username As String
        Dim password As String
    End Structure


    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        grb_insert_modifica.Show()
    End Sub

    Private Sub btn_gest_carta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_carta.Click
        Me.Hide()
        Emp_carta.Show()
    End Sub

    Private Sub btn_gest_stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_stock.Click
        Me.Hide()
        Emp_stock.Show()
    End Sub

    Private Sub btn_gest_pagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_pagos.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub

    Private Sub Emp_Gestio_usuaris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_taula.Text = Mainform_empleado.nomempleat
        lbl_punts.Text = Mainform_empleado.rolempleat

        ObteEmpleats()

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
    End Sub

    Private Sub ObteEmpleats()

        Dim numUsuaris As Integer = ws.ContaEmpleats

        For i = 2 To numUsuaris + 2 ' (tot+2) petit arreglo per desajust dels ids a la BD
            Dim empleat = ws.GetEmpleat(i)
            ts_usuaris.Items.Add(empleat.nom + " " + empleat.cognom)
        Next
    End Sub

    Private Sub btn_afegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_afegir.Click

        If txtb_nom.Text = "" Or txtb_cognom.Text = "" Or txtb_password.Text = "" Or cmbx_rol.Text = "" Then
            MsgBox("Has d'introduir tots els camps!!!", MsgBoxStyle.Critical)
        Else

            'insert a base de dades empleat
            Dim validacio As Boolean
            validacio = ws.SetEmpleat(txtb_nom.Text, txtb_password.Text, cmbx_rol.Text, txtb_cognom.Text)
            If validacio = True Then
                ts_usuaris.Items.Add(txtb_nom.Text + " " + txtb_cognom.Text)
                grb_insert_modifica.Hide()
            Else
                MsgBox("validació incorrecte!", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        grb_insert_modifica.Hide()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ts_usuaris.ItemClicked

        ts_usuaris.Items.Remove(e.ClickedItem)
        'ws.deleteEmpleat(e.ClickedItem.Text)

    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
    End Sub
End Class