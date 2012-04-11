Public Class Emp_anula

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim listofcommands As List(Of Producto)
    Dim isCancelable As Boolean = True


    Private Sub Emp_anula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        listofcommands = New List(Of Producto)
        CarregaComandes()
        MostraComandes()

    End Sub

    Private Sub CarregaComandes()

        Dim Llistaproductes = ws.GetProducte()
        For Each fila In Llistaproductes

            Dim pro As New Producto

            pro.id = fila.id
            pro.nom = fila.nom
            pro.preu = fila.preu
            pro.tipus = fila.tipus
            pro.descripcio = fila.descripicio

            listofcommands.Add(pro)

        Next

    End Sub

    Private Sub MostraComandes()

        For Each p In listofcommands

            If (isCancelable) Then

                llista_productes_eliminar.Items.Add(p.nom)

            Else

                llista_resta_productes.Items.Add(p.nom)

            End If

        Next

    End Sub

    Private Sub btn_gest_comandes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gest_comandes.Click

    End Sub
End Class