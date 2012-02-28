Public Class Client_Anula

    Dim element As New ToolStripButton()

    Private Sub setDefaults(ByVal e As ToolStripButton)

        Dim padding As PaddingConverter = New PaddingConverter

        e.Alignment = ToolStripItemAlignment.Left
        e.AutoSize = True
        e.AutoToolTip = True
        e.BackColor = Color.LightBlue
        e.Image = System.Drawing.SystemIcons.Application.ToBitmap
        e.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        e.DoubleClickEnabled = False
        e.ImageAlign = ContentAlignment.MiddleCenter
        e.ImageScaling = ToolStripItemImageScaling.SizeToFit
        e.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        e.Width = 168
        e.Height = 20

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
   
    Private Sub Client_Anula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_taula.Text = Mainform_client.nom_taula
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula

        Dim a As PaddingConverter = New PaddingConverter()
        Dim i As Integer = 0
        Dim element_list As ToolStripItemCollection = llista_productes_eliminar.Items
        For i = 0 To element_list.Count

            'MsgBox("Padding: " & a.ConvertFromString(element_list.Item(i).Padding.ToString), MsgBoxStyle.Critical)

        Next
    End Sub

    Private Sub DeleteItem(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles llista_productes_eliminar.ItemClicked

        Dim result = MsgBox("Realment vol eliminar " & e.ClickedItem.Text & "?", MsgBoxStyle.OkCancel, "Està segur?")
        Dim element_list As ToolStripItemCollection = llista_productes_eliminar.Items

        If result = MsgBoxResult.Ok Then

            For i As Integer = 0 To element_list.Count

                If (element_list.Item(i).Text = e.ClickedItem.Text) Then

                    element_list.RemoveAt(i)
                    Exit For

                End If

            Next

            llista_productes_eliminar.Refresh()

        End If

    End Sub

    Private Sub insertToolStripItem()

        Dim input = InputBox("Que vols afegir?", "Afegir", "")
        Dim element_list As ToolStripItemCollection = llista_productes_eliminar.Items
        Dim e As ToolStripButton = New ToolStripButton()

        Try

            e.Text = input
            setDefaults(e)
            element_list.Insert(element_list.Count, e)
            llista_productes_eliminar.Refresh()

        Catch ex As Exception

            MsgBox("El contador val " & element_list.Count, MsgBoxStyle.Critical)

        End Try
        
    End Sub

    Private Sub pcb_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcb_anular.Click

        insertToolStripItem()

    End Sub
End Class
