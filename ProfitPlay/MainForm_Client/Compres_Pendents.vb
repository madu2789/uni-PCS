Public Class Compres_Pendents

    Dim ws As New ws_profitplay.Service1SoapClient

    Private Sub Compres_Pendents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim llista_compres = ws.getCompres()
        For Each i In llista_compres

            If i.Estat = "En espera" Then
                lv_compres_espera.Items.Add(ws.GetNomIngredientById(i.Id_ingredient) + " (" + i.Quantitat.ToString + ")")
            Else
                lv_compres_rebudes.Items.Add(ws.GetNomIngredientById(i.Id_ingredient) + " (" + i.Quantitat.ToString + ")")
            End If

        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compres_fet.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class