Public Class Control_Stock

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim plats As New List(Of Producto)
    Dim plats_compra As New List(Of Producto)
    Dim quantitats As New List(Of Integer)


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compra_stock.Click

        For i As Integer = 0 To lv_plats.Items.Count - 1 Step 1

            If (lv_plats.Items.Item(i).Selected) Then
                Dim plat As New Producto
                plat.setNom(lv_plats.Items(i).Text)
                plats.Add(plat)
            End If
        Next

        For a As Integer = 0 To plats.Count - 1 Step 1

            Dim err As Boolean = True
            While err = True

                Try

                    Me.TopMost = False
                    Dim quantitat = InputBox("Quants plats de " + plats(a).getNom + " vols preparar?", "Entra la quantitat", "0")

                    'Deixem que pugui no posar res
                    If (quantitat <> "") Then
                        plats_compra.Add(plats(a))
                        quantitats.Add(CInt(quantitat))
                    End If

                    err = False

                Catch ex As Exception
                    err = True
                End Try

            End While

        Next
        Me.TopMost = True
    End Sub

    Private Sub Control_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim plats = ws.GetProducte
        For Each fila In plats

            Dim pro As New Producto

            pro.id = fila.id
            pro.preu = fila.preu
            pro.nom = fila.nom
            pro.tipus = fila.tipus
            pro.descripcio = fila.descripicio

            lv_plats.Items.Add(pro.nom)

        Next
        
    End Sub

    Public Function getPlatComanda() As List(Of Producto)
        Return plats_compra
    End Function

    Public Function getQuantitatsPlatsCompra() As List(Of Integer)
        Return quantitats
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'fer els calculs
        'fer els inserts
    End Sub
End Class