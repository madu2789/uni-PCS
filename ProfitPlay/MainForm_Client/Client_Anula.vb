﻿Public Class Client_Anula

    Dim ws As New ws_profitplay.Service1SoapClient
    Dim element As New ToolStripButton()
    Dim m_comanda As Comanda
    Dim tota_comanda As Comanda = New Comanda

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

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'per fer!
    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click

        'grabo el que ja tenia a la bbdd a la bbdd i afeixo que el que hem venia (menys el eliminat)
        Client_Carta.setComanda(m_comanda)
        Client_Carta.refreshComanda()
        Client_Carta.Show()
        Me.Dispose()
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

        lbl_taula.Text = Mainform_client.nom_taula + ": " + Id_usuari.ToString
        lbl_punts.Text = lbl_punts.Text + Mainform_client.punts_taula

        m_comanda = Client_Carta.getComanda()

        'llegir tot el que hi ha acumulat a la bbdd
        ObteComandes()

        'llegeixo el que hem ve de nou de la carta
        insertToolStripItem()

    End Sub

    Private Sub ObteComandes()

        Dim comandesDB = ws.GetComandaByUserId(Id_usuari)

        For Each fila In comandesDB

            Dim pro As New Comanda

            pro.Id_comanda = fila.id
            pro.Id_producte = fila.Id_producte
            pro.Id_usuari = fila.Id_usuari
            pro.Hora = fila.Hora
            pro.Notes = fila.Notes
            pro.Estat = fila.Estat

            If (pro.Estat = "Sol·licitat") Then
                llista_productes_eliminar.Items.Add(ws.GetNomProducteById(pro.Id_producte))
            Else
                llista_resta_productes.Items.Add(ws.GetNomProducteById(pro.Id_producte))
            End If

        Next

    End Sub

    Public Sub regenerateStock(ByVal id As Integer)

        Dim plats = ws.GetAllPlats

        For Each p In plats

            If (p.id_producte = id) Then
                ws.UpdateStockActualById(p.id_ingredient, -p.quantitat)
            End If

        Next

    End Sub

    Private Sub DeleteItem(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles llista_productes_eliminar.ItemClicked

        Dim result = MsgBox("Realment vol SOLICITAR ANULAR " & e.ClickedItem.Text & "?", MsgBoxStyle.OkCancel, "Està segur?")

        If result = MsgBoxResult.Ok Then

            For i As Integer = 0 To llista_productes_eliminar.Items.Count - 1

                If (llista_productes_eliminar.Items(i).Text = e.ClickedItem.Text) Then

                    regenerateStock(ws.GetIdProducteByNom(llista_productes_eliminar.Items(i).Text))
                    ws.SolAnulaComanda(ws.GetIdProducteByNom(llista_productes_eliminar.Items(i).Text), Id_usuari)
                    llista_productes_eliminar.Items(i).Text = llista_productes_eliminar.Items(i).Text + " - A"
                    'llista_productes_eliminar.Items.RemoveAt(i)

                    Exit For

                End If

            Next

            llista_productes_eliminar.Refresh()
            llista_resta_productes.Refresh()

        End If

    End Sub

    Private Sub insertToolStripItem()

        If m_comanda IsNot Nothing Then

            For Each p As String In m_comanda.getComanda
                llista_productes_eliminar.Items.Add(p)
            Next

            'nomes inserim aqui el que ja no esta en espera (de la bbdd)
            For Each p As String In m_comanda.getComanda
                llista_resta_productes.Items.Add(p)

            Next
        End If


    End Sub

    Private Sub insertToolStripItemOLD()

        Dim input = InputBox("Que vols afegir?", "Afegir", "")
        Dim element_list As ToolStripItemCollection = llista_productes_eliminar.Items
        Dim e As ToolStripButton = New ToolStripButton()

        For i As Integer = 0 To m_comanda.getComanda.Count - 1 Step 1

            Try

                e.Text = m_comanda.getComanda.Item(i)
                setDefaults(e)
                element_list.Insert(element_list.Count, e)
                llista_productes_eliminar.Refresh()

            Catch ex As Exception

            End Try

        Next

    End Sub

    Private Sub btn_estat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click
        Client_Pago.Show()
        Me.Hide()
    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click

        Me.Close()
        Me.Dispose()
        Dim a = New Client_Anula
        a.Show()

    End Sub
End Class
