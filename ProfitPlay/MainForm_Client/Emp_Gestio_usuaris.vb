Imports System.Runtime.Serialization
Imports System.Xml.Serialization
Imports System.Xml
Imports System.Collections.Generic

Public Class Emp_Gestio_usuaris
    Dim ws As New ws_profitplay.Service1SoapClient

    Dim empleats As DataTable

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

        'acces a la base de dades
        Dim empleatsBD As DataTable = ws.GetEmpleat()

        ' Dim empleats As List(Of Empleado) = 


        'For Each fila In empleatsBD.
        '    Dim empl As Empleado = New Empleado()
        '    empl.id = fila("Id_empleat").ToString
        '    empl.rol = fila("Rol").ToString
        '    empl.nom = fila("Nom").ToString
        '    empl.cognom = fila("Cognom").ToString
        '    empl.username = fila("Username").ToString
        '    empl.password = fila("Password").ToString

        '    ' empleats.Add(empl)
        '    ToolStrip1.Items.Add(empl.nom)
        '    'MsgBox(empl.id, MsgBoxStyle.Information)
        'Next


    End Sub

    Private Sub btn_afegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_afegir.Click

        If txtb_nom.Text = "" Or txtb_cognom.Text = "" Or txtb_password.Text = "" Or cmbx_rol.Text = "" Then
            MsgBox("has d'introduir tots els camps!!!", MsgBoxStyle.Critical)
        Else

            'insert a base de dades empleat
            ToolStrip1.Items.Add(txtb_nom.Text + " " + txtb_cognom.Text)
            grb_insert_modifica.Hide()

        End If

    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        grb_insert_modifica.Hide()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        For i As Integer = 0 To ToolStrip1.Items.Count - 1 Step 1

            If (e.ClickedItem.Text = ToolStrip1.Items.Item(i).Text) Then
                ToolStrip1.Items.RemoveAt(i)
            End If

        Next
    End Sub
End Class