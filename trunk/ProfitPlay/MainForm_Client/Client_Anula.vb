Public Class Client_Anula

    Dim element As ToolStripItem
    Private Sub addItem(ByVal cadena As String)

        ToolStrip1.Items.Add(cadena)

    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click
        'per fer!
    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click
        Client_Carta.Show()
        Me.Hide()
    End Sub

    Private Sub btn_jugar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jugar.Click
        Client_Juego.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pagar.Click
        Client_Pago.Show()
        Me.Hide()
    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click

    End Sub

    Private Sub grb_anular_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grb_anular.Enter

    End Sub
   
    Private Sub Client_Anula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim element_list As ToolStripItemCollection = ToolStrip1.Items
        For i = 0 To element_list.Count

            MsgBox("Nom: " & element_list.Item(i).Text, MsgBoxStyle.Critical)

        Next
    End Sub

    Private Sub DeleteItem(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

        Dim result = MsgBox("Realment vol eliminar " & e.ClickedItem.Text & "?", MsgBoxStyle.OkCancel, "Està segur?")
        Dim element_list As ToolStripItemCollection = ToolStrip1.Items

        If result = MsgBoxResult.Ok Then

            For i As Integer = 0 To element_list.Count

                If (element_list.Item(i).Text = e.ClickedItem.Text) Then

                    element_list.RemoveAt(i)
                    Exit For

                End If

            Next

            ToolStrip1.Refresh()

        End If

    End Sub
End Class
