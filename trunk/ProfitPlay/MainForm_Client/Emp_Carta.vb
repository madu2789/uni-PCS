Public Class Emp_carta

    Private listofproducts As New List(Of Producto)

    Private Sub Emp_carta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    End Sub

    Private Sub ompleLlistaProductes()

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("beguda " + i.ToString)
            p.setPreu(i)
            p.setTipus("beguda")
            listofproducts.Add(p)

        Next

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("primer " + i.ToString)
            p.setPreu(i)
            p.setTipus("primer")
            listofproducts.Add(p)

        Next

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("segon " + i.ToString)
            p.setPreu(i)
            p.setTipus("segon")
            listofproducts.Add(p)

        Next

        For i As Integer = 0 To 9 Step 1

            Dim p As Producto = New Producto()
            p.setDescripcio("Desc")
            p.setNom("postre " + i.ToString)
            p.setPreu(i)
            p.setTipus("postre")
            listofproducts.Add(p)

        Next


    End Sub

    Private Sub btn_gest_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_users.Click
        Me.Hide()
        Emp_Gestio_usuaris.Show()
    End Sub

    Private Sub btn_gest_stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_stock.Click
        Me.Hide()
        Emp_stock.Show()
    End Sub

    Private Sub btn_gest_pagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_pagos.Click
        Me.Hide()
        Emp_Pago.Show()
    End Sub

    
    Private Sub btn_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_producto.Click

    End Sub
End Class