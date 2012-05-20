Public Class Mainform_empleado

    Public Shared nomempleat As String
    Public Shared rolempleat As String

    Public Sub New(ByVal nom As String, ByVal rol As String)

        InitializeComponent()
        nomempleat = nom
        rolempleat = rol
        lbl_taula.Text = nomempleat
        lbl_punts.Text = rolempleat

        Select Case rol

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

    End Sub

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

    Private Sub btn_gest_pagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_pagos.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click
        Me.Hide()
        Emp_anula.Show()
    End Sub

    Private Sub btn_config_fichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_config_fichero.Click
        Me.Hide()
        Emp_interessos.Show()
    End Sub
End Class