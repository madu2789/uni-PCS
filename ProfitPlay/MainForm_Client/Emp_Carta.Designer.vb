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
        Me.grb_carta = New System.Windows.Forms.GroupBox
        Me.grb_insert = New System.Windows.Forms.GroupBox
        Me.lbl_stock = New System.Windows.Forms.Label
        Me.txtb_stockMin = New System.Windows.Forms.TextBox
        Me.lbl_stockMin = New System.Windows.Forms.Label
        Me.txtb_stock = New System.Windows.Forms.TextBox
        Me.btn_afegir = New System.Windows.Forms.Button
        Me.btn_cancela = New System.Windows.Forms.Button
        Me.cmbx_tipus = New System.Windows.Forms.ComboBox
        Me.txtb_descripcio = New System.Windows.Forms.TextBox
        Me.txtb_preu = New System.Windows.Forms.TextBox
        Me.txtb_nom = New System.Windows.Forms.TextBox
        Me.lbl_tipus = New System.Windows.Forms.Label
        Me.lbl_descripció = New System.Windows.Forms.Label
        Me.lbl_preu = New System.Windows.Forms.Label
        Me.lbl_nom = New System.Windows.Forms.Label
        Me.btn_confirmar = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_crear_producte = New System.Windows.Forms.Button
        Me.lbl_productos_dispo = New System.Windows.Forms.Label
        Me.emp_lv_productos_seleccionats = New System.Windows.Forms.ListView
        Me.Nombre = New System.Windows.Forms.ColumnHeader
        Me.Cantidad = New System.Windows.Forms.ColumnHeader
        Me.emp_lv_productos_disp = New System.Windows.Forms.ListView
        Me.lbl_productes_seleccinats = New System.Windows.Forms.Label
        Me.btn_add_prod_emp = New System.Windows.Forms.Button
        Me.btn_del_prod_emp = New System.Windows.Forms.Button
        Me.btn_info_prod_emp = New System.Windows.Forms.Button
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.gpb_gestio.SuspendLayout()
        Me.grb_carta.SuspendLayout()
        Me.grb_insert.SuspendLayout()
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
        Me.pnl_estat.Location = New System.Drawing.Point(144, -7)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(704, 66)
        Me.pnl_estat.TabIndex = 34
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(543, 3)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(76, 86)
        Me.btn_estat.TabIndex = 24
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'pcb_sortir
        '
        Me.pcb_sortir.Image = CType(resources.GetObject("pcb_sortir.Image"), System.Drawing.Image)
        Me.pcb_sortir.Location = New System.Drawing.Point(625, 3)
        Me.pcb_sortir.Name = "pcb_sortir"
        Me.pcb_sortir.Size = New System.Drawing.Size(76, 61)
        Me.pcb_sortir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_sortir.TabIndex = 23
        Me.pcb_sortir.TabStop = False
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_taula.Location = New System.Drawing.Point(102, 20)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(173, 31)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Usuari: XXX"
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_punts.Location = New System.Drawing.Point(342, 20)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(132, 31)
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
        Me.pnl_plats.Location = New System.Drawing.Point(1, -7)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 485)
        Me.pnl_plats.TabIndex = 33
        '
        'btn_gest_pagos
        '
        Me.btn_gest_pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pagos.Location = New System.Drawing.Point(1, 323)
        Me.btn_gest_pagos.Name = "btn_gest_pagos"
        Me.btn_gest_pagos.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_pagos.TabIndex = 24
        Me.btn_gest_pagos.Text = "Gestionar Pagaments"
        Me.btn_gest_pagos.UseVisualStyleBackColor = True
        '
        'btn_gest_stock
        '
        Me.btn_gest_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_stock.Location = New System.Drawing.Point(1, 257)
        Me.btn_gest_stock.Name = "btn_gest_stock"
        Me.btn_gest_stock.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_stock.TabIndex = 18
        Me.btn_gest_stock.Text = "Gestionar Stock"
        Me.btn_gest_stock.UseVisualStyleBackColor = True
        '
        'btn_config_fichero
        '
        Me.btn_config_fichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config_fichero.Location = New System.Drawing.Point(1, 389)
        Me.btn_config_fichero.Name = "btn_config_fichero"
        Me.btn_config_fichero.Size = New System.Drawing.Size(135, 85)
        Me.btn_config_fichero.TabIndex = 17
        Me.btn_config_fichero.Text = "Configurar interesos"
        Me.btn_config_fichero.UseVisualStyleBackColor = True
        '
        'btn_gest_users
        '
        Me.btn_gest_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_users.Location = New System.Drawing.Point(1, 59)
        Me.btn_gest_users.Name = "btn_gest_users"
        Me.btn_gest_users.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_users.TabIndex = 11
        Me.btn_gest_users.Text = "Gestionar Usuaris"
        Me.btn_gest_users.UseVisualStyleBackColor = True
        '
        'btn_gest_comandes
        '
        Me.btn_gest_comandes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_comandes.Location = New System.Drawing.Point(1, 191)
        Me.btn_gest_comandes.Name = "btn_gest_comandes"
        Me.btn_gest_comandes.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_comandes.TabIndex = 14
        Me.btn_gest_comandes.Text = "Gestionar Comandes"
        Me.btn_gest_comandes.UseVisualStyleBackColor = True
        '
        'btn_gest_carta
        '
        Me.btn_gest_carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_carta.Location = New System.Drawing.Point(1, 125)
        Me.btn_gest_carta.Name = "btn_gest_carta"
        Me.btn_gest_carta.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_carta.TabIndex = 13
        Me.btn_gest_carta.Text = "Gestionar Carta"
        Me.btn_gest_carta.UseVisualStyleBackColor = True
        '
        'gpb_gestio
        '
        Me.gpb_gestio.Controls.Add(Me.btn_ingrediente)
        Me.gpb_gestio.Controls.Add(Me.btn_producto)
        Me.gpb_gestio.Location = New System.Drawing.Point(163, 78)
        Me.gpb_gestio.Name = "gpb_gestio"
        Me.gpb_gestio.Size = New System.Drawing.Size(669, 72)
        Me.gpb_gestio.TabIndex = 35
        Me.gpb_gestio.TabStop = False
        Me.gpb_gestio.Text = "Gestió"
        '
        'btn_ingrediente
        '
        Me.btn_ingrediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingrediente.Location = New System.Drawing.Point(354, 11)
        Me.btn_ingrediente.Name = "btn_ingrediente"
        Me.btn_ingrediente.Size = New System.Drawing.Size(160, 55)
        Me.btn_ingrediente.TabIndex = 12
        Me.btn_ingrediente.Text = "Ingredients"
        Me.btn_ingrediente.UseVisualStyleBackColor = True
        '
        'btn_producto
        '
        Me.btn_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_producto.Location = New System.Drawing.Point(80, 12)
        Me.btn_producto.Name = "btn_producto"
        Me.btn_producto.Size = New System.Drawing.Size(136, 54)
        Me.btn_producto.TabIndex = 11
        Me.btn_producto.Text = "Productes"
        Me.btn_producto.UseVisualStyleBackColor = True
        '
        'grb_carta
        '
        Me.grb_carta.Controls.Add(Me.grb_insert)
        Me.grb_carta.Controls.Add(Me.btn_confirmar)
        Me.grb_carta.Controls.Add(Me.btn_eliminar)
        Me.grb_carta.Controls.Add(Me.btn_crear_producte)
        Me.grb_carta.Controls.Add(Me.lbl_productos_dispo)
        Me.grb_carta.Controls.Add(Me.emp_lv_productos_seleccionats)
        Me.grb_carta.Controls.Add(Me.emp_lv_productos_disp)
        Me.grb_carta.Controls.Add(Me.lbl_productes_seleccinats)
        Me.grb_carta.Controls.Add(Me.btn_add_prod_emp)
        Me.grb_carta.Controls.Add(Me.btn_del_prod_emp)
        Me.grb_carta.Controls.Add(Me.btn_info_prod_emp)
        Me.grb_carta.Location = New System.Drawing.Point(166, 162)
        Me.grb_carta.Name = "grb_carta"
        Me.grb_carta.Size = New System.Drawing.Size(666, 307)
        Me.grb_carta.TabIndex = 36
        Me.grb_carta.TabStop = False
        Me.grb_carta.Text = "Carta"
        '
        'grb_insert
        '
        Me.grb_insert.Controls.Add(Me.lbl_stock)
        Me.grb_insert.Controls.Add(Me.txtb_stockMin)
        Me.grb_insert.Controls.Add(Me.lbl_stockMin)
        Me.grb_insert.Controls.Add(Me.txtb_stock)
        Me.grb_insert.Controls.Add(Me.btn_afegir)
        Me.grb_insert.Controls.Add(Me.btn_cancela)
        Me.grb_insert.Controls.Add(Me.cmbx_tipus)
        Me.grb_insert.Controls.Add(Me.txtb_descripcio)
        Me.grb_insert.Controls.Add(Me.txtb_preu)
        Me.grb_insert.Controls.Add(Me.txtb_nom)
        Me.grb_insert.Controls.Add(Me.lbl_tipus)
        Me.grb_insert.Controls.Add(Me.lbl_descripció)
        Me.grb_insert.Controls.Add(Me.lbl_preu)
        Me.grb_insert.Controls.Add(Me.lbl_nom)
        Me.grb_insert.Location = New System.Drawing.Point(167, 19)
        Me.grb_insert.Name = "grb_insert"
        Me.grb_insert.Size = New System.Drawing.Size(493, 282)
        Me.grb_insert.TabIndex = 38
        Me.grb_insert.TabStop = False
        Me.grb_insert.Text = "Info"
        Me.grb_insert.Visible = False
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(267, 71)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(38, 13)
        Me.lbl_stock.TabIndex = 47
        Me.lbl_stock.Text = "Stock:"
        Me.lbl_stock.Visible = False
        '
        'txtb_stockMin
        '
        Me.txtb_stockMin.Location = New System.Drawing.Point(345, 110)
        Me.txtb_stockMin.Name = "txtb_stockMin"
        Me.txtb_stockMin.Size = New System.Drawing.Size(108, 20)
        Me.txtb_stockMin.TabIndex = 46
        Me.txtb_stockMin.Visible = False
        '
        'lbl_stockMin
        '
        Me.lbl_stockMin.AutoSize = True
        Me.lbl_stockMin.Location = New System.Drawing.Point(267, 113)
        Me.lbl_stockMin.Name = "lbl_stockMin"
        Me.lbl_stockMin.Size = New System.Drawing.Size(69, 13)
        Me.lbl_stockMin.TabIndex = 45
        Me.lbl_stockMin.Text = "Stock mínim:"
        Me.lbl_stockMin.Visible = False
        '
        'txtb_stock
        '
        Me.txtb_stock.Location = New System.Drawing.Point(345, 68)
        Me.txtb_stock.Name = "txtb_stock"
        Me.txtb_stock.Size = New System.Drawing.Size(108, 20)
        Me.txtb_stock.TabIndex = 44
        Me.txtb_stock.Visible = False
        '
        'btn_afegir
        '
        Me.btn_afegir.BackColor = System.Drawing.Color.Lime
        Me.btn_afegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_afegir.Location = New System.Drawing.Point(192, 222)
        Me.btn_afegir.Name = "btn_afegir"
        Me.btn_afegir.Size = New System.Drawing.Size(85, 45)
        Me.btn_afegir.TabIndex = 42
        Me.btn_afegir.Text = "Afegeix"
        Me.btn_afegir.UseVisualStyleBackColor = False
        '
        'btn_cancela
        '
        Me.btn_cancela.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(47, 222)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(85, 45)
        Me.btn_cancela.TabIndex = 41
        Me.btn_cancela.Text = "Cancel·la"
        Me.btn_cancela.UseVisualStyleBackColor = False
        '
        'cmbx_tipus
        '
        Me.cmbx_tipus.FormattingEnabled = True
        Me.cmbx_tipus.Items.AddRange(New Object() {"Beguda", "Primer", "Segon", "Postre"})
        Me.cmbx_tipus.Location = New System.Drawing.Point(126, 151)
        Me.cmbx_tipus.Name = "cmbx_tipus"
        Me.cmbx_tipus.Size = New System.Drawing.Size(108, 21)
        Me.cmbx_tipus.TabIndex = 40
        '
        'txtb_descripcio
        '
        Me.txtb_descripcio.Location = New System.Drawing.Point(126, 68)
        Me.txtb_descripcio.Name = "txtb_descripcio"
        Me.txtb_descripcio.Size = New System.Drawing.Size(108, 20)
        Me.txtb_descripcio.TabIndex = 38
        '
        'txtb_preu
        '
        Me.txtb_preu.Location = New System.Drawing.Point(126, 110)
        Me.txtb_preu.Name = "txtb_preu"
        Me.txtb_preu.Size = New System.Drawing.Size(108, 20)
        Me.txtb_preu.TabIndex = 39
        '
        'txtb_nom
        '
        Me.txtb_nom.Location = New System.Drawing.Point(126, 26)
        Me.txtb_nom.Name = "txtb_nom"
        Me.txtb_nom.Size = New System.Drawing.Size(108, 20)
        Me.txtb_nom.TabIndex = 3
        '
        'lbl_tipus
        '
        Me.lbl_tipus.AutoSize = True
        Me.lbl_tipus.Location = New System.Drawing.Point(44, 154)
        Me.lbl_tipus.Name = "lbl_tipus"
        Me.lbl_tipus.Size = New System.Drawing.Size(36, 13)
        Me.lbl_tipus.TabIndex = 2
        Me.lbl_tipus.Text = "Tipus:"
        '
        'lbl_descripció
        '
        Me.lbl_descripció.AutoSize = True
        Me.lbl_descripció.Location = New System.Drawing.Point(44, 71)
        Me.lbl_descripció.Name = "lbl_descripció"
        Me.lbl_descripció.Size = New System.Drawing.Size(60, 13)
        Me.lbl_descripció.TabIndex = 1
        Me.lbl_descripció.Text = "Descripció:"
        '
        'lbl_preu
        '
        Me.lbl_preu.AutoSize = True
        Me.lbl_preu.Location = New System.Drawing.Point(44, 113)
        Me.lbl_preu.Name = "lbl_preu"
        Me.lbl_preu.Size = New System.Drawing.Size(32, 13)
        Me.lbl_preu.TabIndex = 1
        Me.lbl_preu.Text = "Preu:"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(44, 29)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(32, 13)
        Me.lbl_nom.TabIndex = 0
        Me.lbl_nom.Text = "Nom:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(274, 278)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(110, 23)
        Me.btn_confirmar.TabIndex = 40
        Me.btn_confirmar.Text = "Confirmar selecció"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        Me.btn_confirmar.Visible = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(171, 242)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 39
        Me.btn_eliminar.Text = "Eliminar producte"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_crear_producte
        '
        Me.btn_crear_producte.Location = New System.Drawing.Point(171, 199)
        Me.btn_crear_producte.Name = "btn_crear_producte"
        Me.btn_crear_producte.Size = New System.Drawing.Size(75, 23)
        Me.btn_crear_producte.TabIndex = 35
        Me.btn_crear_producte.Text = "Crear producte"
        Me.btn_crear_producte.UseVisualStyleBackColor = True
        '
        'lbl_productos_dispo
        '
        Me.lbl_productos_dispo.AutoSize = True
        Me.lbl_productos_dispo.Location = New System.Drawing.Point(6, 24)
        Me.lbl_productos_dispo.Name = "lbl_productos_dispo"
        Me.lbl_productos_dispo.Size = New System.Drawing.Size(110, 13)
        Me.lbl_productos_dispo.TabIndex = 26
        Me.lbl_productos_dispo.Text = "Productes disponibles"
        '
        'emp_lv_productos_seleccionats
        '
        Me.emp_lv_productos_seleccionats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Cantidad})
        Me.emp_lv_productos_seleccionats.Location = New System.Drawing.Point(252, 40)
        Me.emp_lv_productos_seleccionats.Name = "emp_lv_productos_seleccionats"
        Me.emp_lv_productos_seleccionats.Size = New System.Drawing.Size(155, 230)
        Me.emp_lv_productos_seleccionats.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.emp_lv_productos_seleccionats.TabIndex = 24
        Me.emp_lv_productos_seleccionats.TileSize = New System.Drawing.Size(170, 30)
        Me.emp_lv_productos_seleccionats.UseCompatibleStateImageBehavior = False
        Me.emp_lv_productos_seleccionats.View = System.Windows.Forms.View.Tile
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'Cantidad
        '
        Me.Cantidad.Text = "Cantidad"
        '
        'emp_lv_productos_disp
        '
        Me.emp_lv_productos_disp.Location = New System.Drawing.Point(6, 40)
        Me.emp_lv_productos_disp.Name = "emp_lv_productos_disp"
        Me.emp_lv_productos_disp.Size = New System.Drawing.Size(155, 230)
        Me.emp_lv_productos_disp.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.emp_lv_productos_disp.TabIndex = 29
        Me.emp_lv_productos_disp.TileSize = New System.Drawing.Size(170, 30)
        Me.emp_lv_productos_disp.UseCompatibleStateImageBehavior = False
        Me.emp_lv_productos_disp.View = System.Windows.Forms.View.Tile
        '
        'lbl_productes_seleccinats
        '
        Me.lbl_productes_seleccinats.AutoSize = True
        Me.lbl_productes_seleccinats.Location = New System.Drawing.Point(249, 24)
        Me.lbl_productes_seleccinats.Name = "lbl_productes_seleccinats"
        Me.lbl_productes_seleccinats.Size = New System.Drawing.Size(62, 13)
        Me.lbl_productes_seleccinats.TabIndex = 30
        Me.lbl_productes_seleccinats.Text = "Ingredients:"
        '
        'btn_add_prod_emp
        '
        Me.btn_add_prod_emp.Location = New System.Drawing.Point(171, 43)
        Me.btn_add_prod_emp.Name = "btn_add_prod_emp"
        Me.btn_add_prod_emp.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_prod_emp.TabIndex = 31
        Me.btn_add_prod_emp.Text = "--->"
        Me.btn_add_prod_emp.UseVisualStyleBackColor = True
        '
        'btn_del_prod_emp
        '
        Me.btn_del_prod_emp.Location = New System.Drawing.Point(171, 95)
        Me.btn_del_prod_emp.Name = "btn_del_prod_emp"
        Me.btn_del_prod_emp.Size = New System.Drawing.Size(75, 23)
        Me.btn_del_prod_emp.TabIndex = 32
        Me.btn_del_prod_emp.Text = "<---"
        Me.btn_del_prod_emp.UseVisualStyleBackColor = True
        '
        'btn_info_prod_emp
        '
        Me.btn_info_prod_emp.Location = New System.Drawing.Point(171, 146)
        Me.btn_info_prod_emp.Name = "btn_info_prod_emp"
        Me.btn_info_prod_emp.Size = New System.Drawing.Size(75, 23)
        Me.btn_info_prod_emp.TabIndex = 33
        Me.btn_info_prod_emp.Text = "Veure Info"
        Me.btn_info_prod_emp.UseVisualStyleBackColor = True
        '
        'Emp_carta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(844, 472)
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
        Me.grb_insert.ResumeLayout(False)
        Me.grb_insert.PerformLayout()
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
    Friend WithEvents grb_carta As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_productos_dispo As System.Windows.Forms.Label
    Friend WithEvents emp_lv_productos_seleccionats As System.Windows.Forms.ListView
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents emp_lv_productos_disp As System.Windows.Forms.ListView
    Friend WithEvents lbl_productes_seleccinats As System.Windows.Forms.Label
    Friend WithEvents btn_add_prod_emp As System.Windows.Forms.Button
    Friend WithEvents btn_del_prod_emp As System.Windows.Forms.Button
    Friend WithEvents btn_info_prod_emp As System.Windows.Forms.Button
    Friend WithEvents btn_crear_producte As System.Windows.Forms.Button
    Friend WithEvents grb_insert As System.Windows.Forms.GroupBox
    Friend WithEvents btn_afegir As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents cmbx_tipus As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_descripcio As System.Windows.Forms.TextBox
    Friend WithEvents txtb_preu As System.Windows.Forms.TextBox
    Friend WithEvents txtb_nom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipus As System.Windows.Forms.Label
    Friend WithEvents lbl_descripció As System.Windows.Forms.Label
    Friend WithEvents lbl_preu As System.Windows.Forms.Label
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents txtb_stockMin As System.Windows.Forms.TextBox
    Friend WithEvents lbl_stockMin As System.Windows.Forms.Label
    Friend WithEvents txtb_stock As System.Windows.Forms.TextBox
End Class
