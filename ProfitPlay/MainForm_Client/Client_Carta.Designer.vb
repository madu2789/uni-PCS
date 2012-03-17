<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Carta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Macarrons(2)")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Amanida verda(1)")
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.btn_jugar = New System.Windows.Forms.Button
        Me.grb_menu_carta = New System.Windows.Forms.GroupBox
        Me.grb_pedido = New System.Windows.Forms.GroupBox
        Me.btn_confirma_carta = New System.Windows.Forms.Button
        Me.btn_confirma_comanda = New System.Windows.Forms.Button
        Me.lbl_productos_sel = New System.Windows.Forms.Label
        Me.lbl_productos_dispo = New System.Windows.Forms.Label
        Me.lv_pedidos = New System.Windows.Forms.ListView
        Me.lv_productos_disp = New System.Windows.Forms.ListView
        Me.Nombre = New System.Windows.Forms.ColumnHeader
        Me.Cantidad = New System.Windows.Forms.ColumnHeader
        Me.btn_add_prod = New System.Windows.Forms.Button
        Me.btn_del_prod = New System.Windows.Forms.Button
        Me.btn_info_prod = New System.Windows.Forms.Button
        Me.btn_postres = New System.Windows.Forms.Button
        Me.btn_segundos = New System.Windows.Forms.Button
        Me.btn_primeros = New System.Windows.Forms.Button
        Me.btn_bebidas = New System.Windows.Forms.Button
        Me.pnl_estat.SuspendLayout()
        Me.pnl_plats.SuspendLayout()
        Me.grb_menu_carta.SuspendLayout()
        Me.grb_pedido.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Location = New System.Drawing.Point(119, -8)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(707, 68)
        Me.pnl_estat.TabIndex = 34
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(617, 3)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(96, 86)
        Me.btn_estat.TabIndex = 23
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_taula.Location = New System.Drawing.Point(111, 21)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(161, 31)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Taula: XXX"
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_punts.Location = New System.Drawing.Point(346, 22)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(106, 31)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Punts: "
        '
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkBlue
        Me.pnl_plats.Controls.Add(Me.btn_menu_anular)
        Me.pnl_plats.Controls.Add(Me.btn_veurecarta)
        Me.pnl_plats.Controls.Add(Me.btn_Pagar)
        Me.pnl_plats.Controls.Add(Me.btn_jugar)
        Me.pnl_plats.Location = New System.Drawing.Point(-6, -8)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(166, 473)
        Me.pnl_plats.TabIndex = 35
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Image = Global.MainForm_Client.My.Resources.Resources.carta
        Me.btn_menu_anular.Location = New System.Drawing.Point(13, 371)
        Me.btn_menu_anular.Name = "btn_menu_anular"
        Me.btn_menu_anular.Size = New System.Drawing.Size(145, 95)
        Me.btn_menu_anular.TabIndex = 17
        Me.btn_menu_anular.Text = "Comanda"
        Me.btn_menu_anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_menu_anular.UseVisualStyleBackColor = True
        '
        'btn_veurecarta
        '
        Me.btn_veurecarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_veurecarta.Image = Global.MainForm_Client.My.Resources.Resources.cubiertos
        Me.btn_veurecarta.Location = New System.Drawing.Point(13, 70)
        Me.btn_veurecarta.Name = "btn_veurecarta"
        Me.btn_veurecarta.Size = New System.Drawing.Size(145, 95)
        Me.btn_veurecarta.TabIndex = 11
        Me.btn_veurecarta.Text = "Veure Carta"
        Me.btn_veurecarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_veurecarta.UseVisualStyleBackColor = True
        '
        'btn_Pagar
        '
        Me.btn_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pagar.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_Pagar.Location = New System.Drawing.Point(13, 271)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(145, 95)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar i sortir"
        Me.btn_Pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'btn_jugar
        '
        Me.btn_jugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jugar.Image = Global.MainForm_Client.My.Resources.Resources.juego
        Me.btn_jugar.Location = New System.Drawing.Point(13, 170)
        Me.btn_jugar.Name = "btn_jugar"
        Me.btn_jugar.Size = New System.Drawing.Size(145, 95)
        Me.btn_jugar.TabIndex = 13
        Me.btn_jugar.Text = "Jugar"
        Me.btn_jugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_jugar.UseVisualStyleBackColor = True
        '
        'grb_menu_carta
        '
        Me.grb_menu_carta.Controls.Add(Me.grb_pedido)
        Me.grb_menu_carta.Controls.Add(Me.btn_postres)
        Me.grb_menu_carta.Controls.Add(Me.btn_segundos)
        Me.grb_menu_carta.Controls.Add(Me.btn_primeros)
        Me.grb_menu_carta.Controls.Add(Me.btn_bebidas)
        Me.grb_menu_carta.Location = New System.Drawing.Point(166, 63)
        Me.grb_menu_carta.Name = "grb_menu_carta"
        Me.grb_menu_carta.Size = New System.Drawing.Size(660, 397)
        Me.grb_menu_carta.TabIndex = 36
        Me.grb_menu_carta.TabStop = False
        Me.grb_menu_carta.Text = "Carta"
        '
        'grb_pedido
        '
        Me.grb_pedido.Controls.Add(Me.btn_confirma_carta)
        Me.grb_pedido.Controls.Add(Me.btn_confirma_comanda)
        Me.grb_pedido.Controls.Add(Me.lbl_productos_sel)
        Me.grb_pedido.Controls.Add(Me.lbl_productos_dispo)
        Me.grb_pedido.Controls.Add(Me.lv_pedidos)
        Me.grb_pedido.Controls.Add(Me.lv_productos_disp)
        Me.grb_pedido.Controls.Add(Me.btn_add_prod)
        Me.grb_pedido.Controls.Add(Me.btn_del_prod)
        Me.grb_pedido.Controls.Add(Me.btn_info_prod)
        Me.grb_pedido.Location = New System.Drawing.Point(6, 86)
        Me.grb_pedido.Name = "grb_pedido"
        Me.grb_pedido.Size = New System.Drawing.Size(648, 305)
        Me.grb_pedido.TabIndex = 20
        Me.grb_pedido.TabStop = False
        Me.grb_pedido.Text = "Hacer pedido"
        Me.grb_pedido.Visible = False
        '
        'btn_confirma_carta
        '
        Me.btn_confirma_carta.Location = New System.Drawing.Point(532, 263)
        Me.btn_confirma_carta.Name = "btn_confirma_carta"
        Me.btn_confirma_carta.Size = New System.Drawing.Size(110, 32)
        Me.btn_confirma_carta.TabIndex = 24
        Me.btn_confirma_carta.Text = "Confirmar Comanda"
        Me.btn_confirma_carta.UseVisualStyleBackColor = True
        '
        'btn_confirma_comanda
        '
        Me.btn_confirma_comanda.Location = New System.Drawing.Point(282, 320)
        Me.btn_confirma_comanda.Name = "btn_confirma_comanda"
        Me.btn_confirma_comanda.Size = New System.Drawing.Size(116, 23)
        Me.btn_confirma_comanda.TabIndex = 22
        Me.btn_confirma_comanda.Text = "Confirma comanda"
        Me.btn_confirma_comanda.UseVisualStyleBackColor = True
        '
        'lbl_productos_sel
        '
        Me.lbl_productos_sel.AutoSize = True
        Me.lbl_productos_sel.Location = New System.Drawing.Point(236, 38)
        Me.lbl_productos_sel.Name = "lbl_productos_sel"
        Me.lbl_productos_sel.Size = New System.Drawing.Size(117, 13)
        Me.lbl_productos_sel.TabIndex = 21
        Me.lbl_productos_sel.Text = "Productes seleccionats"
        '
        'lbl_productos_dispo
        '
        Me.lbl_productos_dispo.AutoSize = True
        Me.lbl_productos_dispo.Location = New System.Drawing.Point(13, 42)
        Me.lbl_productos_dispo.Name = "lbl_productos_dispo"
        Me.lbl_productos_dispo.Size = New System.Drawing.Size(110, 13)
        Me.lbl_productos_dispo.TabIndex = 20
        Me.lbl_productos_dispo.Text = "Productes disponibles"
        '
        'lv_pedidos
        '
        Me.lv_pedidos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7, ListViewItem8})
        Me.lv_pedidos.Location = New System.Drawing.Point(239, 69)
        Me.lv_pedidos.Name = "lv_pedidos"
        Me.lv_pedidos.Size = New System.Drawing.Size(147, 226)
        Me.lv_pedidos.TabIndex = 19
        Me.lv_pedidos.UseCompatibleStateImageBehavior = False
        Me.lv_pedidos.View = System.Windows.Forms.View.Tile
        '
        'lv_productos_disp
        '
        Me.lv_productos_disp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Cantidad})
        Me.lv_productos_disp.Location = New System.Drawing.Point(6, 67)
        Me.lv_productos_disp.Name = "lv_productos_disp"
        Me.lv_productos_disp.Size = New System.Drawing.Size(145, 228)
        Me.lv_productos_disp.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_productos_disp.TabIndex = 18
        Me.lv_productos_disp.UseCompatibleStateImageBehavior = False
        Me.lv_productos_disp.View = System.Windows.Forms.View.Tile
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'Cantidad
        '
        Me.Cantidad.Text = "Cantidad"
        '
        'btn_add_prod
        '
        Me.btn_add_prod.Location = New System.Drawing.Point(157, 105)
        Me.btn_add_prod.Name = "btn_add_prod"
        Me.btn_add_prod.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_prod.TabIndex = 25
        Me.btn_add_prod.Text = "--->"
        Me.btn_add_prod.UseVisualStyleBackColor = True
        '
        'btn_del_prod
        '
        Me.btn_del_prod.Location = New System.Drawing.Point(157, 157)
        Me.btn_del_prod.Name = "btn_del_prod"
        Me.btn_del_prod.Size = New System.Drawing.Size(75, 23)
        Me.btn_del_prod.TabIndex = 26
        Me.btn_del_prod.Text = "<---"
        Me.btn_del_prod.UseVisualStyleBackColor = True
        '
        'btn_info_prod
        '
        Me.btn_info_prod.Location = New System.Drawing.Point(157, 207)
        Me.btn_info_prod.Name = "btn_info_prod"
        Me.btn_info_prod.Size = New System.Drawing.Size(75, 23)
        Me.btn_info_prod.TabIndex = 27
        Me.btn_info_prod.Text = "Veure Info"
        Me.btn_info_prod.UseVisualStyleBackColor = True
        '
        'btn_postres
        '
        Me.btn_postres.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_postres.Location = New System.Drawing.Point(503, 20)
        Me.btn_postres.Name = "btn_postres"
        Me.btn_postres.Size = New System.Drawing.Size(151, 55)
        Me.btn_postres.TabIndex = 10
        Me.btn_postres.Text = "Postres"
        Me.btn_postres.UseVisualStyleBackColor = True
        '
        'btn_segundos
        '
        Me.btn_segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_segundos.Location = New System.Drawing.Point(340, 20)
        Me.btn_segundos.Name = "btn_segundos"
        Me.btn_segundos.Size = New System.Drawing.Size(157, 55)
        Me.btn_segundos.TabIndex = 9
        Me.btn_segundos.Text = "Segons"
        Me.btn_segundos.UseVisualStyleBackColor = True
        '
        'btn_primeros
        '
        Me.btn_primeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_primeros.Location = New System.Drawing.Point(174, 20)
        Me.btn_primeros.Name = "btn_primeros"
        Me.btn_primeros.Size = New System.Drawing.Size(160, 55)
        Me.btn_primeros.TabIndex = 8
        Me.btn_primeros.Text = "Primers"
        Me.btn_primeros.UseVisualStyleBackColor = True
        '
        'btn_bebidas
        '
        Me.btn_bebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bebidas.Location = New System.Drawing.Point(12, 20)
        Me.btn_bebidas.Name = "btn_bebidas"
        Me.btn_bebidas.Size = New System.Drawing.Size(156, 55)
        Me.btn_bebidas.TabIndex = 7
        Me.btn_bebidas.Text = "Begudes"
        Me.btn_bebidas.UseVisualStyleBackColor = True
        '
        'Client_Carta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.grb_menu_carta)
        Me.Controls.Add(Me.pnl_estat)
        Me.Name = "Client_Carta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client_Carta"
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        Me.pnl_plats.ResumeLayout(False)
        Me.grb_menu_carta.ResumeLayout(False)
        Me.grb_pedido.ResumeLayout(False)
        Me.grb_pedido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents btn_jugar As System.Windows.Forms.Button
    Friend WithEvents grb_menu_carta As System.Windows.Forms.GroupBox
    Friend WithEvents btn_postres As System.Windows.Forms.Button
    Friend WithEvents grb_pedido As System.Windows.Forms.GroupBox
    Friend WithEvents btn_confirma_comanda As System.Windows.Forms.Button
    Friend WithEvents lbl_productos_sel As System.Windows.Forms.Label
    Friend WithEvents lbl_productos_dispo As System.Windows.Forms.Label
    Friend WithEvents lv_pedidos As System.Windows.Forms.ListView
    Friend WithEvents lv_productos_disp As System.Windows.Forms.ListView
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_segundos As System.Windows.Forms.Button
    Friend WithEvents btn_primeros As System.Windows.Forms.Button
    Friend WithEvents btn_bebidas As System.Windows.Forms.Button
    Friend WithEvents btn_confirma_carta As System.Windows.Forms.Button
    Friend WithEvents btn_add_prod As System.Windows.Forms.Button
    Friend WithEvents btn_del_prod As System.Windows.Forms.Button
    Friend WithEvents btn_info_prod As System.Windows.Forms.Button
    Friend WithEvents btn_estat As System.Windows.Forms.Button
End Class
