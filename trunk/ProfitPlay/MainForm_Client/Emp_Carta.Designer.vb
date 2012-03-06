<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_carta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_carta))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Macarrons", "6 €"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Espaguetis a la Bolonyesa", "5 €"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Amanida verda", "4.5 €"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sopa de peix", "4 €"}, -1)
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.pcb_sortir = New System.Windows.Forms.PictureBox
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.btn_gest_pagos = New System.Windows.Forms.Button
        Me.btn_gest_stock = New System.Windows.Forms.Button
        Me.btn_config_fichero = New System.Windows.Forms.Button
        Me.btn_gest_users = New System.Windows.Forms.Button
        Me.btn_gest_comandes = New System.Windows.Forms.Button
        Me.btn_gest_carta = New System.Windows.Forms.Button
        Me.gpb_gestio = New System.Windows.Forms.GroupBox
        Me.btn_ingrediente = New System.Windows.Forms.Button
        Me.btn_producto = New System.Windows.Forms.Button
        Me.btn_carta = New System.Windows.Forms.Button
        Me.grb_carta = New System.Windows.Forms.GroupBox
        Me.pnl_info_producte = New System.Windows.Forms.Panel
        Me.pcb_producte = New System.Windows.Forms.PictureBox
        Me.nud_cantitat = New System.Windows.Forms.NumericUpDown
        Me.lbl_cantitat = New System.Windows.Forms.Label
        Me.btn_afegeix = New System.Windows.Forms.Button
        Me.btn_cancela = New System.Windows.Forms.Button
        Me.lbl_ingredients = New System.Windows.Forms.Label
        Me.lbl_descripcio = New System.Windows.Forms.Label
        Me.lbl_titol_producte = New System.Windows.Forms.Label
        Me.lbl_productos_dispo = New System.Windows.Forms.Label
        Me.lv_productos_disp = New System.Windows.Forms.ListView
        Me.Nombre = New System.Windows.Forms.ColumnHeader
        Me.Cantidad = New System.Windows.Forms.ColumnHeader
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.gpb_gestio.SuspendLayout()
        Me.grb_carta.SuspendLayout()
        Me.pnl_info_producte.SuspendLayout()
        CType(Me.pcb_producte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_cantitat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.Green
        Me.pnl_estat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Controls.Add(Me.pcb_sortir)
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Location = New System.Drawing.Point(141, 3)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(642, 69)
        Me.pnl_estat.TabIndex = 34
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = CType(resources.GetObject("btn_estat.Image"), System.Drawing.Image)
        Me.btn_estat.Location = New System.Drawing.Point(505, 3)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(55, 57)
        Me.btn_estat.TabIndex = 24
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'pcb_sortir
        '
        Me.pcb_sortir.Image = CType(resources.GetObject("pcb_sortir.Image"), System.Drawing.Image)
        Me.pcb_sortir.Location = New System.Drawing.Point(566, 3)
        Me.pcb_sortir.Name = "pcb_sortir"
        Me.pcb_sortir.Size = New System.Drawing.Size(69, 57)
        Me.pcb_sortir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_sortir.TabIndex = 23
        Me.pcb_sortir.TabStop = False
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_taula.Location = New System.Drawing.Point(110, 21)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(173, 29)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Usuari: XXX"
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_punts.Location = New System.Drawing.Point(341, 22)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(135, 29)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Rol: XXX"
        '
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkGreen
        Me.pnl_plats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_plats.Controls.Add(Me.btn_gest_pagos)
        Me.pnl_plats.Controls.Add(Me.btn_gest_stock)
        Me.pnl_plats.Controls.Add(Me.btn_config_fichero)
        Me.pnl_plats.Controls.Add(Me.btn_gest_users)
        Me.pnl_plats.Controls.Add(Me.btn_gest_comandes)
        Me.pnl_plats.Controls.Add(Me.btn_gest_carta)
        Me.pnl_plats.Location = New System.Drawing.Point(1, 3)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 466)
        Me.pnl_plats.TabIndex = 33
        '
        'btn_gest_pagos
        '
        Me.btn_gest_pagos.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pagos.Location = New System.Drawing.Point(1, 204)
        Me.btn_gest_pagos.Name = "btn_gest_pagos"
        Me.btn_gest_pagos.Size = New System.Drawing.Size(135, 55)
        Me.btn_gest_pagos.TabIndex = 24
        Me.btn_gest_pagos.Text = "Gestionar Pagaments"
        Me.btn_gest_pagos.UseVisualStyleBackColor = True
        '
        'btn_gest_stock
        '
        Me.btn_gest_stock.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_stock.Location = New System.Drawing.Point(1, 152)
        Me.btn_gest_stock.Name = "btn_gest_stock"
        Me.btn_gest_stock.Size = New System.Drawing.Size(135, 55)
        Me.btn_gest_stock.TabIndex = 18
        Me.btn_gest_stock.Text = "Gestionar Stock"
        Me.btn_gest_stock.UseVisualStyleBackColor = True
        '
        'btn_config_fichero
        '
        Me.btn_config_fichero.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config_fichero.Location = New System.Drawing.Point(1, 365)
        Me.btn_config_fichero.Name = "btn_config_fichero"
        Me.btn_config_fichero.Size = New System.Drawing.Size(135, 85)
        Me.btn_config_fichero.TabIndex = 17
        Me.btn_config_fichero.Text = "Configurar fitxer interesos"
        Me.btn_config_fichero.UseVisualStyleBackColor = True
        '
        'btn_gest_users
        '
        Me.btn_gest_users.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_users.Location = New System.Drawing.Point(1, -2)
        Me.btn_gest_users.Name = "btn_gest_users"
        Me.btn_gest_users.Size = New System.Drawing.Size(135, 55)
        Me.btn_gest_users.TabIndex = 11
        Me.btn_gest_users.Text = "Gestionar Usuaris"
        Me.btn_gest_users.UseVisualStyleBackColor = True
        '
        'btn_gest_comandes
        '
        Me.btn_gest_comandes.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_comandes.Location = New System.Drawing.Point(1, 102)
        Me.btn_gest_comandes.Name = "btn_gest_comandes"
        Me.btn_gest_comandes.Size = New System.Drawing.Size(135, 55)
        Me.btn_gest_comandes.TabIndex = 14
        Me.btn_gest_comandes.Text = "Gestionar Comandes"
        Me.btn_gest_comandes.UseVisualStyleBackColor = True
        '
        'btn_gest_carta
        '
        Me.btn_gest_carta.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_carta.Location = New System.Drawing.Point(1, 50)
        Me.btn_gest_carta.Name = "btn_gest_carta"
        Me.btn_gest_carta.Size = New System.Drawing.Size(135, 55)
        Me.btn_gest_carta.TabIndex = 13
        Me.btn_gest_carta.Text = "Gestionar Carta"
        Me.btn_gest_carta.UseVisualStyleBackColor = True
        '
        'gpb_gestio
        '
        Me.gpb_gestio.Controls.Add(Me.btn_ingrediente)
        Me.gpb_gestio.Controls.Add(Me.btn_producto)
        Me.gpb_gestio.Controls.Add(Me.btn_carta)
        Me.gpb_gestio.Location = New System.Drawing.Point(163, 78)
        Me.gpb_gestio.Name = "gpb_gestio"
        Me.gpb_gestio.Size = New System.Drawing.Size(620, 72)
        Me.gpb_gestio.TabIndex = 35
        Me.gpb_gestio.TabStop = False
        Me.gpb_gestio.Text = "Gestió"
        '
        'btn_ingrediente
        '
        Me.btn_ingrediente.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingrediente.Location = New System.Drawing.Point(368, 12)
        Me.btn_ingrediente.Name = "btn_ingrediente"
        Me.btn_ingrediente.Size = New System.Drawing.Size(136, 55)
        Me.btn_ingrediente.TabIndex = 12
        Me.btn_ingrediente.Text = "Ingredients"
        Me.btn_ingrediente.UseVisualStyleBackColor = True
        '
        'btn_producto
        '
        Me.btn_producto.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_producto.Location = New System.Drawing.Point(206, 12)
        Me.btn_producto.Name = "btn_producto"
        Me.btn_producto.Size = New System.Drawing.Size(136, 54)
        Me.btn_producto.TabIndex = 11
        Me.btn_producto.Text = "Productes"
        Me.btn_producto.UseVisualStyleBackColor = True
        '
        'btn_carta
        '
        Me.btn_carta.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carta.Location = New System.Drawing.Point(49, 13)
        Me.btn_carta.Name = "btn_carta"
        Me.btn_carta.Size = New System.Drawing.Size(136, 53)
        Me.btn_carta.TabIndex = 10
        Me.btn_carta.Text = "Carta"
        Me.btn_carta.UseVisualStyleBackColor = True
        '
        'grb_carta
        '
        Me.grb_carta.Controls.Add(Me.pnl_info_producte)
        Me.grb_carta.Controls.Add(Me.lbl_productos_dispo)
        Me.grb_carta.Controls.Add(Me.lv_productos_disp)
        Me.grb_carta.Location = New System.Drawing.Point(166, 162)
        Me.grb_carta.Name = "grb_carta"
        Me.grb_carta.Size = New System.Drawing.Size(617, 316)
        Me.grb_carta.TabIndex = 36
        Me.grb_carta.TabStop = False
        Me.grb_carta.Text = "Carta"
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
        Me.pnl_info_producte.Location = New System.Drawing.Point(171, 19)
        Me.pnl_info_producte.Name = "pnl_info_producte"
        Me.pnl_info_producte.Size = New System.Drawing.Size(423, 276)
        Me.pnl_info_producte.TabIndex = 28
        Me.pnl_info_producte.Visible = False
        '
        'pcb_producte
        '
        Me.pcb_producte.Image = CType(resources.GetObject("pcb_producte.Image"), System.Drawing.Image)
        Me.pcb_producte.Location = New System.Drawing.Point(288, 3)
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
        '
        'lbl_cantitat
        '
        Me.lbl_cantitat.AutoSize = True
        Me.lbl_cantitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantitat.Location = New System.Drawing.Point(26, 156)
        Me.lbl_cantitat.Name = "lbl_cantitat"
        Me.lbl_cantitat.Size = New System.Drawing.Size(55, 16)
        Me.lbl_cantitat.TabIndex = 10
        Me.lbl_cantitat.Text = "Cantitat:"
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
        'lbl_productos_dispo
        '
        Me.lbl_productos_dispo.AutoSize = True
        Me.lbl_productos_dispo.Location = New System.Drawing.Point(21, 18)
        Me.lbl_productos_dispo.Name = "lbl_productos_dispo"
        Me.lbl_productos_dispo.Size = New System.Drawing.Size(110, 13)
        Me.lbl_productos_dispo.TabIndex = 26
        Me.lbl_productos_dispo.Text = "Productes disponibles"
        '
        'lv_productos_disp
        '
        Me.lv_productos_disp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Cantidad})
        ListViewItem1.Checked = True
        ListViewItem1.StateImageIndex = 1
        Me.lv_productos_disp.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lv_productos_disp.Location = New System.Drawing.Point(14, 43)
        Me.lv_productos_disp.Name = "lv_productos_disp"
        Me.lv_productos_disp.Size = New System.Drawing.Size(145, 228)
        Me.lv_productos_disp.TabIndex = 24
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
        'Emp_carta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(824, 506)
        Me.Controls.Add(Me.grb_carta)
        Me.Controls.Add(Me.gpb_gestio)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.Name = "Emp_carta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emp_carta"
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        Me.gpb_gestio.ResumeLayout(False)
        Me.grb_carta.ResumeLayout(False)
        Me.grb_carta.PerformLayout()
        Me.pnl_info_producte.ResumeLayout(False)
        Me.pnl_info_producte.PerformLayout()
        CType(Me.pcb_producte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_cantitat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents pcb_sortir As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_gest_pagos As System.Windows.Forms.Button
    Friend WithEvents btn_gest_stock As System.Windows.Forms.Button
    Friend WithEvents btn_config_fichero As System.Windows.Forms.Button
    Friend WithEvents btn_gest_users As System.Windows.Forms.Button
    Friend WithEvents btn_gest_comandes As System.Windows.Forms.Button
    Friend WithEvents btn_gest_carta As System.Windows.Forms.Button
    Friend WithEvents gpb_gestio As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ingrediente As System.Windows.Forms.Button
    Friend WithEvents btn_producto As System.Windows.Forms.Button
    Friend WithEvents btn_carta As System.Windows.Forms.Button
    Friend WithEvents grb_carta As System.Windows.Forms.GroupBox
    Friend WithEvents pnl_info_producte As System.Windows.Forms.Panel
    Friend WithEvents pcb_producte As System.Windows.Forms.PictureBox
    Friend WithEvents nud_cantitat As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_cantitat As System.Windows.Forms.Label
    Friend WithEvents btn_afegeix As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents lbl_ingredients As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcio As System.Windows.Forms.Label
    Friend WithEvents lbl_titol_producte As System.Windows.Forms.Label
    Friend WithEvents lbl_productos_dispo As System.Windows.Forms.Label
    Friend WithEvents lv_productos_disp As System.Windows.Forms.ListView
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_estat As System.Windows.Forms.Button
End Class
