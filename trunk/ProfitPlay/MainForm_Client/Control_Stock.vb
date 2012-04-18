Public Class Control_Stock

    Dim ws As New ws_profitplay.Service1SoapClient


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compra_stock.Click

    End Sub

    Private Sub Control_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim plats = ws.GetAllPlats()
        
    End Sub
End Class