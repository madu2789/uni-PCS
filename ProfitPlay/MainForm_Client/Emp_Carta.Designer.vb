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
        Me.btn_carta = New System.Windows.Forms.Button
        Me.grb_carta = New System.Windows.Forms.GroupBox
        Me.btn_crear_carta = New System.Windows.Forms.Button
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
        Me.pnl_estat.Location = New System.Drawing.Point(141, -7)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(703, 66)
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
        Me.gpb_gestio.Controls.Add(Me.btn_carta)
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
        Me.btn_ingrediente.Location = New System.Drawing.Point(460, 11)
        Me.btn_ingrediente.Name = "btn_ingrediente"
        Me.btn_ingrediente.Size = New System.Drawing.Size(160, 55)
        Me.btn_ingrediente.TabIndex = 12
        Me.btn_ingrediente.Text = "Ingredients"
        Me.btn_ingrediente.UseVisualStyleBackColor = True
        '
        'btn_producto
        '
        Me.btn_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_producto.Location = New System.Drawing.Point(255, 11)
        Me.btn_producto.Name = "btn_producto"
        Me.btn_producto.Size = New System.Drawing.Size(136, 54)
        Me.btn_producto.TabIndex = 11
        Me.btn_producto.Text = "Productes"
        Me.btn_producto.UseVisualStyleBackColor = True
        '
        'btn_carta
        '
        Me.btn_carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carta.Location = New System.Drawing.Point(49, 11)
        Me.btn_carta.Name = "btn_carta"
        Me.btn_carta.Size = New System.Drawing.Size(136, 53)
        Me.btn_carta.TabIndex = 10
        Me.btn_carta.Text = "Carta"
        Me.btn_carta.UseVisualStyleBackColor = True
        '
        'grb_carta
        '
        Me.grb_carta.Controls.Add(Me.btn_crear_carta)
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
        'btn_crear_carta
        '
        Me.btn_crear_carta.Location = New System.Drawing.Point(550, 266)
        Me.btn_crear_carta.Name = "btn_crear_carta"
        Me.btn_crear_carta.Size = New System.Drawing.Size(110, 32)
        Me.btn_crear_carta.TabIndex = 34
        Me.btn_crear_carta.Text = "Crear Carta"
        Me.btn_crear_carta.UseVisualStyleBackColor = True
        '
        'lbl_productos_dispo
        '
        Me.lbl_productos_dispo.AutoSize = True
        Me.lbl_productos_dispo.Location = New System.Drawing.Point(6, 36)
        Me.lbl_productos_dispo.Name = "lbl_productos_dispo"
        Me.lbl_productos_dispo.Size = New System.Drawing.Size(110, 13)
        Me.lbl_productos_dispo.TabIndex = 26
        Me.lbl_productos_dispo.Text = "Productes disponibles"
        '
        'emp_lv_productos_seleccionats
        '
        Me.emp_lv_productos_seleccionats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Cantidad})
        Me.emp_lv_productos_seleccionats.Location = New System.Drawing.Point(252, 68)
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
        Me.emp_lv_productos_disp.Location = New System.Drawing.Point(6, 68)
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
        Me.lbl_productes_seleccinats.Location = New System.Drawing.Point(249, 36)
        Me.lbl_productes_seleccinats.Name = "lbl_productes_seleccinats"
        Me.lbl_productes_seleccinats.Size = New System.Drawing.Size(119, 13)
        Me.lbl_productes_seleccinats.TabIndex = 30
        Me.lbl_productes_seleccinats.Text = "Productes Seleccionats"
        '
        'btn_add_prod_emp
        '
        Me.btn_add_prod_emp.Location = New System.Drawing.Point(167, 102)
        Me.btn_add_prod_emp.Name = "btn_add_prod_emp"
        Me.btn_add_prod_emp.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_prod_emp.TabIndex = 31
        Me.btn_add_prod_emp.Text = "--->"
        Me.btn_add_prod_emp.UseVisualStyleBackColor = True
        '
        'btn_del_prod_emp
        '
        Me.btn_del_prod_emp.Location = New System.Drawing.Point(167, 154)
        Me.btn_del_prod_emp.Name = "btn_del_prod_emp"
        Me.btn_del_prod_emp.Size = New System.Drawing.Size(75, 23)
        Me.btn_del_prod_emp.TabIndex = 32
        Me.btn_del_prod_emp.Text = "<---"
        Me.btn_del_prod_emp.UseVisualStyleBackColor = True
        '
        'btn_info_prod_emp
        '
        Me.btn_info_prod_emp.Location = New System.Drawing.Point(167, 204)
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
    Friend WithEvents btn_crear_carta As System.Windows.Forms.Button
End Class
