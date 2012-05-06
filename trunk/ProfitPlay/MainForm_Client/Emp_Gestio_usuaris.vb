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

        lv_users.Items.Clear()
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

        Dim empleats = ws.getEmpleats()

        For Each empleat In empleats
            lv_users.Items.Add(empleat.username)
        Next

    End Sub

    Private Sub btn_afegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_afegir.Click

        If txtb_nom.Text = "" Or txtb_cognom.Text = "" Or txtb_username.Text = "" Or cmbx_rol.Text = "" Then
            MsgBox("Has d'introduir tots els camps!!!", MsgBoxStyle.Critical, "Camps incomplerts")
        Else

            'insert a base de dades empleat
            Dim validacio As Boolean
            validacio = ws.SetEmpleat(txtb_nom.Text, txtb_cognom.Text, txtb_username.Text, txtb_password.Text, cmbx_rol.Text)
            If validacio = True Then
                lv_users.Items.Add(txtb_username.Text)
                grb_insert_modifica.Hide()
            ElseIf (validacio = False Or txtb_nom.Text = "" Or txtb_username.Text = "" Or cmbx_rol.Text = "" Or txtb_cognom.Text = "") Then
                MsgBox("Validació incorrecte!", MsgBoxStyle.Critical, "ERROR DE VALIDACIÓ")
            End If
        End If

    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        grb_insert_modifica.Hide()
    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
    End Sub

    Public Function findEmpleatId(ByVal nom As String, ByVal sur As String) As Integer
        Dim empleats = ws.getEmpleats

        For Each empleat In empleats
            If (empleat.nom = nom And empleat.cognom = sur) Then
                Return empleat.id
            End If
        Next
        Return -1
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elimina_user.Click

        Dim eliminar As New List(Of Integer)

        For i As Integer = 0 To lv_users.Items.Count - 1 Step 1
            If lv_users.Items(i).Selected = True Then
                eliminar.Add(i)
            End If
        Next


        For i As Integer = 0 To eliminar.Count - 1 Step 1
            lv_users.Items.RemoveAt(eliminar(i))
        Next


    End Sub

    Private Sub btn_update_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update_user.Click

        Dim i As Integer = 0
        Dim moded As Boolean = False

        While i < lv_users.Items.Count And moded = False
            If lv_users.Items(i).Selected = True Then
                moded = True
                grb_insert_modifica.BringToFront()
                'agafar id del usuari, carregar les dades i guardar
            End If
        End While
    End Sub

    Private Sub btn_add_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_user.Click
        grb_insert_modifica.Show()
    End Sub

End Class