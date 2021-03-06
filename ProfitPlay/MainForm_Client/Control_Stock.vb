﻿Public Class Control_Stock

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim plats As New List(Of Producto)
    Dim plats_compra As New List(Of Producto)
    Dim quantitats As New List(Of Integer)


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compra_stock.Click

        plats.Clear()

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

                    Dim quantitat = InputBox("Quants plats de " + plats(a).getNom + " vols preparar?", "Entra la quantitat", "0")

                    'Deixem que pugui no posar res
                    If (quantitat <> "") Then
                        quantitats.Add(CInt(quantitat))
                        plats_compra.Add(plats(a))
                    End If

                    err = False

                Catch ex As Exception
                    MsgBox("Error en el valor introduït", MsgBoxStyle.Critical, "Valor incorrecte")
                    err = True
                End Try

            End While

        Next
    End Sub

    Private Sub Control_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim plats = ws.GetAllProductes()
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

        Dim ingredients As New List(Of Ingredient)
        Dim plats = ws.GetAllPlats
        Dim count As Integer = 0
        For Each producte In plats_compra

            For Each plat In plats

                If (ws.GetIdProducteByNom(producte.getNom) = plat.id_producte) Then

                    Dim i As New Ingredient
                    i.setNom(ws.GetNomIngredientById(plat.id_ingredient))
                    i.setQuantitat(i.getQuantitat + (quantitats(count) * plat.quantitat))
                    i.setIdIngredient(plat.id_ingredient)
                    ingredients.Add(i)

                End If

            Next
            count = count + 1
        Next

        Dim quantes As Integer = 0
        For Each i In ingredients

            quantes = quantes + ws.insertCompra(i.getIdIngredient, i.getQuantitat, "En espera")
            ws.UpdateStockActualById(i.getIdIngredient, -i.getQuantitat)

        Next

        MsgBox("Realitzades " + quantes.ToString + " sol.licituds de compra", MsgBoxStyle.Information, "Compra de Ingredients")
        Me.Dispose()
    End Sub
End Class