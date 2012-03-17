Public Class Welcome

    Dim ws As New Profit_WS.Service1SoapClient
    Dim estat As Boolean = True 'indica qui accedeix al sistema:
    'true vol dir mode client
    'false mode empleat

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

    End Sub
    Sub Form1_KeyPress(ByVal sender As Object, _
    ByVal e As KeyPressEventArgs) Handles Me.KeyPress

        If (e.KeyChar.ToString() = ">") Then

            If estat = True Then
                gpb_client.Hide()
                gpb_empleat.Show()
                pcb_client.Hide()
                pcb_empleat.Show()
                estat = False
            Else
                gpb_client.Show()
                gpb_empleat.Hide()
                pcb_client.Show()
                pcb_empleat.Hide()
                estat = True
            End If

            e.Handled = True

        End If

    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click

        If estat = True Then
            'client: accedeix directament al sistema
            If num_comensals.Value < 1 Then
                MsgBox("Número de comensals incorrecte!!!", MsgBoxStyle.Critical)
            Else
                Me.Hide()
                If txtb_nomTaula.Text Is Nothing Then
                    'constructor amb nom propi (nostre)!
                    Dim main As New Mainform_client(txtb_nomTaula.Text, "0")
                    main.ShowDialog()
                Else
                    'constructor amb nom demanat!
                    Dim main As New Mainform_client(txtb_nomTaula.Text, "0")
                    main.ShowDialog()
                End If
            End If
        Else
            'empleat: accedeix a la base de dades per log
            If txtb_login.Text = "" Or txtb_password.Text = "" Then
                MsgBox("error introdueix dades!")
                Me.Hide()
                Dim main As New Mainform_empleado("debug", "debug")
                main.ShowDialog()
            Else
                'acces a la base de dades

                Dim rol As String = ws.LogEmpleat(txtb_login.Text, txtb_password.Text)
                'Dim rol As String = "Administrador"
                If rol IsNot Nothing Then
                    Me.Hide()
                    Dim main As New Mainform_empleado(txtb_login.Text, rol)
                    main.ShowDialog()
                Else
                    MsgBox("error! accés denegat!", MsgBoxStyle.Critical)
                End If
            End If
        End If

    End Sub

End Class