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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Carta))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Macarrons(2)")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Amanida verda(1)")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Macarrons", "6 €"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Espaguetis a la Bolonyesa", "5 €"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Amanida verda", "4.5 €"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sopa de peix", "4 €"}, -1)
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.btn_estat = New System.Windows.Forms.Button
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.btn_jugar = New System.Windows.Forms.Button
        Me.grb_menu_carta = New System.Windows.Forms.GroupBox
        Me.grb_pedido = New System.Windows.Forms.GroupBox
        Me.pnl_info_producte = New System.Windows.Forms.Panel
        Me.pcb_producte = New System.Windows.Forms.PictureBox
        Me.nud_cantitat = New System.Windows.Forms.NumericUpDown
        Me.lbl_cantitat = New System.Windows.Forms.Label
        Me.btn_afegeix = New System.Windows.Forms.Button
        Me.btn_cancela = New System.Windows.Forms.Button
        Me.lbl_ingredients = New System.Windows.Forms.Label
        Me.lbl_descripcio = New System.Windows.Forms.Label
        Me.lbl_titol_producte = New System.Windows.Forms.Label
        Me.btn_confirma_carta = New System.Windows.Forms.Button
        Me.btn_confirma_comanda = New System.Windows.Forms.Button
        Me.lbl_productos_sel = New System.Windows.Forms.Label
        Me.lbl_productos_dispo = New System.Windows.Forms.Label
        Me.lv_pedidos = New System.Windows.Forms.ListView
        Me.lv_productos_disp = New System.Windows.Forms.ListView
        Me.Nombre = New System.Windows.Forms.ColumnHeader
        Me.Cantidad = New System.Windows.Forms.ColumnHeader
        Me.btn_postres = New System.Windows.Forms.Button
        Me.btn_segundos = New System.Windows.Forms.Button
        Me.btn_primeros = New System.Windows.Forms.Button
        Me.btn_bebidas = New System.Windows.Forms.Button
        Me.pnl_estat.SuspendLayout()
        Me.pnl_plats.SuspendLayout()
        Me.grb_menu_carta.SuspendLayout()
        Me.grb_pedido.SuspendLayout()
        Me.pnl_info_producte.SuspendLayout()
        CType(Me.pcb_producte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_cantitat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Location = New System.Drawing.Point(119, -8)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(674, 66)
        Me.pnl_estat.TabIndex = 34
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_taula.Location = New System.Drawing.Point(110, 21)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(162, 29)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Taula: XXX"
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_punts.Location = New System.Drawing.Point(341, 22)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(97, 29)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Punts: "
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = CType(resources.GetObject("btn_estat.Image"), System.Drawing.Image)
        Me.btn_estat.Location = New System.Drawing.Point(591, 8)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(55, 57)
        Me.btn_estat.TabIndex = 1
        Me.btn_estat.UseVisualStyleBackColor = True
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
        Me.pnl_plats.Size = New System.Drawing.Size(131, 466)
        Me.pnl_plats.TabIndex = 35
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Location = New System.Drawing.Point(0, 278)
        Me.btn_menu_anular.Name = "btn_menu_anular"
        Me.btn_menu_anular.Size = New System.Drawing.Size(135, 85)
        Me.btn_menu_anular.TabIndex = 17
        Me.btn_menu_anular.Text = "Solicitar anular comanda"
        Me.btn_menu_anular.UseVisualStyleBackColor = True
        '
        'btn_veurecarta
        '
        Me.btn_veurecarta.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_veurecarta.Location = New System.Drawing.Point(0, 35)
        Me.btn_veurecarta.Name = "btn_veurecarta"
        Me.btn_veurecarta.Size = New System.Drawing.Size(135, 55)
        Me.btn_veurecarta.TabIndex = 11
        Me.btn_veurecarta.Text = "Veure Carta"
        Me.btn_veurecarta.UseVisualStyleBackColor = True
        '
        'btn_Pagar
        '
        Me.btn_Pagar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pagar.Location = New System.Drawing.Point(0, 141)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(135, 55)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar i sortir"
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'btn_jugar
        '
        Me.btn_jugar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jugar.Location = New System.Drawing.Point(0, 89)
        Me.btn_jugar.Name = "btn_jugar"
        Me.btn_jugar.Size = New System.Drawing.Size(135, 55)
        Me.btn_jugar.TabIndex = 13
        Me.btn_jugar.Text = "Jugar"
        Me.btn_jugar.UseVisualStyleBackColor = True
        '
        'grb_menu_carta
        '
        Me.grb_menu_carta.Controls.Add(Me.grb_pedido)
        Me.grb_menu_carta.Controls.Add(Me.btn_postres)
        Me.grb_menu_carta.Controls.Add(Me.btn_segundos)
        Me.grb_menu_carta.Controls.Add(Me.btn_primeros)
        Me.grb_menu_carta.Controls.Add(Me.btn_bebidas)
        Me.grb_menu_carta.Location = New System.Drawing.Point(135, 61)
        Me.grb_menu_carta.Name = "grb_menu_carta"
        Me.grb_menu_carta.Size = New System.Drawing.Size(658, 397)
        Me.grb_menu_carta.TabIndex = 36
        Me.grb_menu_carta.TabStop = False
        Me.grb_menu_carta.Text = "Carta"
        '
        'grb_pedido
        '
        Me.grb_pedido.Controls.Add(Me.pnl_info_producte)
        Me.grb_pedido.Controls.Add(Me.btn_confirma_carta)
        Me.grb_pedido.Controls.Add(Me.btn_confirma_comanda)
        Me.grb_pedido.Controls.Add(Me.lbl_productos_sel)
        Me.grb_pedido.Controls.Add(Me.lbl_productos_dispo)
        Me.grb_pedido.Controls.Add(Me.lv_pedidos)
        Me.grb_pedido.Controls.Add(Me.lv_productos_disp)
        Me.grb_pedido.Location = New System.Drawing.Point(6, 86)
        Me.grb_pedido.Name = "grb_pedido"
        Me.grb_pedido.Size = New System.Drawing.Size(646, 305)
        Me.grb_pedido.TabIndex = 20
        Me.grb_pedido.TabStop = False
        Me.grb_pedido.Text = "Hacer pedido"
        Me.grb_pedido.Visible = False
        '
        'pnl_info_producte
        '
        Me.pnl_info_producte.Controls.Add(Me.pcb_producte)
        Me.pnl_info_producte.Controls.Add(Me.nud_cantitat)
        Me.pnl_info_producte.Controls.Add(Me.lbl_cantitat)
        Me.pnl_info_producte.Controls.Add(Me.btn_afegeix)
        Me.pnl_info_producte.Controls.Add(Me.btn_cancela)
        Me.pnl_info_producte.Controls.Add(Me.lbl_ingredients)
        Me.pnl_info_producte.Controls.Add(Me.lbl_descripcio)
        Me.pnl_info_producte.Controls.Add(Me.lbl_titol_producte)
        Me.pnl_info_producte.Location = New System.Drawing.Point(159, 19)
        Me.pnl_info_producte.Name = "pnl_info_producte"
        Me.pnl_info_producte.Size = New System.Drawing.Size(465, 276)
        Me.pnl_info_producte.TabIndex = 23
        Me.pnl_info_producte.Visible = False
        '
        'pcb_producte
        '
        Me.pcb_producte.Image = CType(resources.GetObject("pcb_producte.Image"), System.Drawing.Image)
        Me.pcb_producte.Location = New System.Drawing.Point(316, 3)
        Me.pcb_producte.Name = "pcb_producte"
        Me.pcb_producte.Size = New System.Drawing.Size(142, 91)
        Me.pcb_producte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_producte.TabIndex = 14
        Me.pcb_producte.TabStop = False
        '
        'nud_cantitat
        '
        Me.nud_cantitat.Location = New System.Drawing.Point(123, 156)
        Me.nud_cantitat.Name = "nud_cantitat"
        Me.nud_cantitat.Size = New System.Drawing.Size(36, 20)
        Me.nud_cantitat.TabIndex = 13
        Me.nud_cantitat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_cantitat
        '
        Me.lbl_cantitat.AutoSize = True
        Me.lbl_cantitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantitat.Location = New System.Drawing.Point(26, 156)
        Me.lbl_cantitat.Name = "lbl_cantitat"
        Me.lbl_cantitat.Size = New System.Drawing.Size(63, 16)
        Me.lbl_cantitat.TabIndex = 10
        Me.lbl_cantitat.Text = "Quantitat:"
        '
        'btn_afegeix
        '
        Me.btn_afegeix.BackColor = System.Drawing.Color.Lime
        Me.btn_afegeix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_afegeix.Location = New System.Drawing.Point(154, 216)
        Me.btn_afegeix.Name = "btn_afegeix"
        Me.btn_afegeix.Size = New System.Drawing.Size(87, 32)
        Me.btn_afegeix.TabIndex = 12
        Me.btn_afegeix.Text = "Afegeix"
        Me.btn_afegeix.UseVisualStyleBackColor = False
        '
        'btn_cancela
        '
        Me.btn_cancela.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(29, 216)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(86, 32)
        Me.btn_cancela.TabIndex = 11
        Me.btn_cancela.Text = "Cancel·la"
        Me.btn_cancela.UseVisualStyleBackColor = False
        '
        'lbl_ingredients
        '
        Me.lbl_ingredients.AutoSize = True
        Me.lbl_ingredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingredients.Location = New System.Drawing.Point(26, 107)
        Me.lbl_ingredients.Name = "lbl_ingredients"
        Me.lbl_ingredients.Size = New System.Drawing.Size(314, 16)
        Me.lbl_ingredients.TabIndex = 9
        Me.lbl_ingredients.Text = "Ingredients: macarrons, formatge, tomàquet, orenga"
        '
        'lbl_descripcio
        '
        Me.lbl_descripcio.AutoSize = True
        Me.lbl_descripcio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcio.Location = New System.Drawing.Point(10, 63)
        Me.lbl_descripcio.Name = "lbl_descripcio"
        Me.lbl_descripcio.Size = New System.Drawing.Size(272, 16)
        Me.lbl_descripcio.TabIndex = 8
        Me.lbl_descripcio.Text = "Descripció: Amb salsa bolonyesa i formatge"
        '
        'lbl_titol_producte
        '
        Me.lbl_titol_producte.AutoSize = True
        Me.lbl_titol_producte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titol_producte.Location = New System.Drawing.Point(3, 18)
        Me.lbl_titol_producte.Name = "lbl_titol_producte"
        Me.lbl_titol_producte.Size = New System.Drawing.Size(187, 20)
        Me.lbl_titol_producte.TabIndex = 7
        Me.lbl_titol_producte.Text = "Macarrons amb formatge"
        '
        'btn_confirma_carta
        '
        Me.btn_confirma_carta.Location = New System.Drawing.Point(501, 236)
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
        Me.lv_pedidos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lv_pedidos.Location = New System.Drawing.Point(239, 69)
        Me.lv_pedidos.Name = "lv_pedidos"
        Me.lv_pedidos.Size = New System.Drawing.Size(147, 226)
        Me.lv_pedidos.TabIndex = 19
        Me.lv_pedidos.UseCompatibleStateImageBehavior = False
        Me.lv_pedidos.View = System.Windows.Forms.View.Tile
        '
        'lv_productos_disp
        '
        Me.lv_productos_disp.AllowDrop = True
        Me.lv_productos_disp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Cantidad})
        ListViewItem3.Checked = True
        ListViewItem3.StateImageIndex = 1
        Me.lv_productos_disp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lv_productos_disp.Location = New System.Drawing.Point(6, 67)
        Me.lv_productos_disp.Name = "lv_productos_disp"
        Me.lv_productos_disp.Size = New System.Drawing.Size(145, 228)
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
        'btn_postres
        '
        Me.btn_postres.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_postres.Location = New System.Drawing.Point(507, 19)
        Me.btn_postres.Name = "btn_postres"
        Me.btn_postres.Size = New System.Drawing.Size(144, 55)
        Me.btn_postres.TabIndex = 10
        Me.btn_postres.Text = "Postres"
        Me.btn_postres.UseVisualStyleBackColor = True
        '
        'btn_segundos
        '
        Me.btn_segundos.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_segundos.Location = New System.Drawing.Point(341, 20)
        Me.btn_segundos.Name = "btn_segundos"
        Me.btn_segundos.Size = New System.Drawing.Size(136, 55)
        Me.btn_segundos.TabIndex = 9
        Me.btn_segundos.Text = "Segons"
        Me.btn_segundos.UseVisualStyleBackColor = True
        '
        'btn_primeros
        '
        Me.btn_primeros.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_primeros.Location = New System.Drawing.Point(172, 20)
        Me.btn_primeros.Name = "btn_primeros"
        Me.btn_primeros.Size = New System.Drawing.Size(136, 54)
        Me.btn_primeros.TabIndex = 8
        Me.btn_primeros.Text = "Primers"
        Me.btn_primeros.UseVisualStyleBackColor = True
        '
        'btn_bebidas
        '
        Me.btn_bebidas.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bebidas.Location = New System.Drawing.Point(6, 23)
        Me.btn_bebidas.Name = "btn_bebidas"
        Me.btn_bebidas.Size = New System.Drawing.Size(136, 53)
        Me.btn_bebidas.TabIndex = 7
        Me.btn_bebidas.Text = "Begudes"
        Me.btn_bebidas.UseVisualStyleBackColor = True
        '
        'Client_Carta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(828, 485)
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
        Me.pnl_info_producte.ResumeLayout(False)
        Me.pnl_info_producte.PerformLayout()
        CType(Me.pcb_producte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_cantitat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents btn_jugar As System.Windows.Forms.Button
    Friend WithEvents grb_menu_carta As System.Windows.Forms.GroupBox
    Friend WithEvents btn_postres As System.Windows.Forms.Button
    Friend WithEvents grb_pedido As System.Windows.Forms.GroupBox
    Friend WithEvents pnl_info_producte As System.Windows.Forms.Panel
    Friend WithEvents pcb_producte As System.Windows.Forms.PictureBox
    Friend WithEvents nud_cantitat As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_cantitat As System.Windows.Forms.Label
    Friend WithEvents btn_afegeix As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents lbl_ingredients As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcio As System.Windows.Forms.Label
    Friend WithEvents lbl_titol_producte As System.Windows.Forms.Label
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
End Class
