<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_interessos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_interessos))
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
        Me.lbl_moltbarat = New System.Windows.Forms.Label
        Me.lbl_subvencionat = New System.Windows.Forms.Label
        Me.lbl_normal = New System.Windows.Forms.Label
        Me.lbl_car = New System.Windows.Forms.Label
        Me.lbl_moltcar = New System.Windows.Forms.Label
        Me.btn_puja_barat = New System.Windows.Forms.Button
        Me.lv_moltcar = New System.Windows.Forms.ListView
        Me.btn_puja_normal = New System.Windows.Forms.Button
        Me.btn_puja_moltcar = New System.Windows.Forms.Button
        Me.btn_puja_car = New System.Windows.Forms.Button
        Me.btn_baix_moltbarat = New System.Windows.Forms.Button
        Me.btn_baix_barat = New System.Windows.Forms.Button
        Me.btn_baix_normal = New System.Windows.Forms.Button
        Me.btn_baix_car = New System.Windows.Forms.Button
        Me.btn_guardarconfig = New System.Windows.Forms.Button
        Me.lv_car = New System.Windows.Forms.ListView
        Me.lv_normal = New System.Windows.Forms.ListView
        Me.lv_barat = New System.Windows.Forms.ListView
        Me.lv_molbarat = New System.Windows.Forms.ListView
        Me.nud_moltbarat = New System.Windows.Forms.NumericUpDown
        Me.nud_barat = New System.Windows.Forms.NumericUpDown
        Me.nud_car = New System.Windows.Forms.NumericUpDown
        Me.nud_moltcar = New System.Windows.Forms.NumericUpDown
        Me.nud_normal = New System.Windows.Forms.NumericUpDown
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        CType(Me.nud_moltbarat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_barat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_moltcar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_normal, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_estat.Location = New System.Drawing.Point(127, -1)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(759, 68)
        Me.pnl_estat.TabIndex = 41
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
        Me.lbl_taula.Size = New System.Drawing.Size(116, 31)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Usuari: "
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_punts.Location = New System.Drawing.Point(342, 20)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(67, 31)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Rol:"
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
        Me.pnl_plats.Location = New System.Drawing.Point(-4, -1)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(147, 485)
        Me.pnl_plats.TabIndex = 40
        '
        'btn_gest_pagos
        '
        Me.btn_gest_pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pagos.Location = New System.Drawing.Point(5, 317)
        Me.btn_gest_pagos.Name = "btn_gest_pagos"
        Me.btn_gest_pagos.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_pagos.TabIndex = 24
        Me.btn_gest_pagos.Text = "Gestionar Pagaments"
        Me.btn_gest_pagos.UseVisualStyleBackColor = True
        '
        'btn_gest_stock
        '
        Me.btn_gest_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_stock.Location = New System.Drawing.Point(5, 252)
        Me.btn_gest_stock.Name = "btn_gest_stock"
        Me.btn_gest_stock.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_stock.TabIndex = 18
        Me.btn_gest_stock.Text = "Gestionar Stock"
        Me.btn_gest_stock.UseVisualStyleBackColor = True
        '
        'btn_config_fichero
        '
        Me.btn_config_fichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config_fichero.Location = New System.Drawing.Point(5, 382)
        Me.btn_config_fichero.Name = "btn_config_fichero"
        Me.btn_config_fichero.Size = New System.Drawing.Size(135, 85)
        Me.btn_config_fichero.TabIndex = 17
        Me.btn_config_fichero.Text = "Configurar interesos"
        Me.btn_config_fichero.UseVisualStyleBackColor = True
        '
        'btn_gest_users
        '
        Me.btn_gest_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_users.Location = New System.Drawing.Point(5, 61)
        Me.btn_gest_users.Name = "btn_gest_users"
        Me.btn_gest_users.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_users.TabIndex = 11
        Me.btn_gest_users.Text = "Gestionar Usuaris"
        Me.btn_gest_users.UseVisualStyleBackColor = True
        '
        'btn_gest_comandes
        '
        Me.btn_gest_comandes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_comandes.Location = New System.Drawing.Point(5, 188)
        Me.btn_gest_comandes.Name = "btn_gest_comandes"
        Me.btn_gest_comandes.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_comandes.TabIndex = 14
        Me.btn_gest_comandes.Text = "Gestionar Comandes"
        Me.btn_gest_comandes.UseVisualStyleBackColor = True
        '
        'btn_gest_carta
        '
        Me.btn_gest_carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_carta.Location = New System.Drawing.Point(5, 124)
        Me.btn_gest_carta.Name = "btn_gest_carta"
        Me.btn_gest_carta.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_carta.TabIndex = 13
        Me.btn_gest_carta.Text = "Gestionar Carta"
        Me.btn_gest_carta.UseVisualStyleBackColor = True
        '
        'lbl_moltbarat
        '
        Me.lbl_moltbarat.AutoSize = True
        Me.lbl_moltbarat.Location = New System.Drawing.Point(157, 99)
        Me.lbl_moltbarat.Name = "lbl_moltbarat"
        Me.lbl_moltbarat.Size = New System.Drawing.Size(96, 13)
        Me.lbl_moltbarat.TabIndex = 47
        Me.lbl_moltbarat.Text = "Molt Subvencionat"
        '
        'lbl_subvencionat
        '
        Me.lbl_subvencionat.AutoSize = True
        Me.lbl_subvencionat.Location = New System.Drawing.Point(309, 99)
        Me.lbl_subvencionat.Name = "lbl_subvencionat"
        Me.lbl_subvencionat.Size = New System.Drawing.Size(73, 13)
        Me.lbl_subvencionat.TabIndex = 48
        Me.lbl_subvencionat.Text = "Subvencionat"
        '
        'lbl_normal
        '
        Me.lbl_normal.AutoSize = True
        Me.lbl_normal.Location = New System.Drawing.Point(465, 99)
        Me.lbl_normal.Name = "lbl_normal"
        Me.lbl_normal.Size = New System.Drawing.Size(63, 13)
        Me.lbl_normal.TabIndex = 49
        Me.lbl_normal.Text = "Preu normal"
        '
        'lbl_car
        '
        Me.lbl_car.AutoSize = True
        Me.lbl_car.Location = New System.Drawing.Point(620, 99)
        Me.lbl_car.Name = "lbl_car"
        Me.lbl_car.Size = New System.Drawing.Size(52, 13)
        Me.lbl_car.TabIndex = 50
        Me.lbl_car.Text = "Reclamat"
        '
        'lbl_moltcar
        '
        Me.lbl_moltcar.AutoSize = True
        Me.lbl_moltcar.Location = New System.Drawing.Point(772, 99)
        Me.lbl_moltcar.Name = "lbl_moltcar"
        Me.lbl_moltcar.Size = New System.Drawing.Size(75, 13)
        Me.lbl_moltcar.TabIndex = 51
        Me.lbl_moltcar.Text = "Molt Reclamat"
        '
        'btn_puja_barat
        '
        Me.btn_puja_barat.Location = New System.Drawing.Point(263, 235)
        Me.btn_puja_barat.Name = "btn_puja_barat"
        Me.btn_puja_barat.Size = New System.Drawing.Size(43, 22)
        Me.btn_puja_barat.TabIndex = 52
        Me.btn_puja_barat.Text = "--->"
        Me.btn_puja_barat.UseVisualStyleBackColor = True
        '
        'lv_moltcar
        '
        Me.lv_moltcar.Location = New System.Drawing.Point(775, 168)
        Me.lv_moltcar.Name = "lv_moltcar"
        Me.lv_moltcar.Size = New System.Drawing.Size(97, 239)
        Me.lv_moltcar.TabIndex = 56
        Me.lv_moltcar.UseCompatibleStateImageBehavior = False
        '
        'btn_puja_normal
        '
        Me.btn_puja_normal.Location = New System.Drawing.Point(419, 235)
        Me.btn_puja_normal.Name = "btn_puja_normal"
        Me.btn_puja_normal.Size = New System.Drawing.Size(43, 22)
        Me.btn_puja_normal.TabIndex = 57
        Me.btn_puja_normal.Text = "--->"
        Me.btn_puja_normal.UseVisualStyleBackColor = True
        '
        'btn_puja_moltcar
        '
        Me.btn_puja_moltcar.Location = New System.Drawing.Point(726, 235)
        Me.btn_puja_moltcar.Name = "btn_puja_moltcar"
        Me.btn_puja_moltcar.Size = New System.Drawing.Size(43, 22)
        Me.btn_puja_moltcar.TabIndex = 58
        Me.btn_puja_moltcar.Text = "--->"
        Me.btn_puja_moltcar.UseVisualStyleBackColor = True
        '
        'btn_puja_car
        '
        Me.btn_puja_car.Location = New System.Drawing.Point(574, 235)
        Me.btn_puja_car.Name = "btn_puja_car"
        Me.btn_puja_car.Size = New System.Drawing.Size(43, 22)
        Me.btn_puja_car.TabIndex = 59
        Me.btn_puja_car.Text = "--->"
        Me.btn_puja_car.UseVisualStyleBackColor = True
        '
        'btn_baix_moltbarat
        '
        Me.btn_baix_moltbarat.Location = New System.Drawing.Point(263, 301)
        Me.btn_baix_moltbarat.Name = "btn_baix_moltbarat"
        Me.btn_baix_moltbarat.Size = New System.Drawing.Size(43, 22)
        Me.btn_baix_moltbarat.TabIndex = 60
        Me.btn_baix_moltbarat.Text = "<---"
        Me.btn_baix_moltbarat.UseVisualStyleBackColor = True
        '
        'btn_baix_barat
        '
        Me.btn_baix_barat.Location = New System.Drawing.Point(419, 301)
        Me.btn_baix_barat.Name = "btn_baix_barat"
        Me.btn_baix_barat.Size = New System.Drawing.Size(43, 22)
        Me.btn_baix_barat.TabIndex = 61
        Me.btn_baix_barat.Text = "<---"
        Me.btn_baix_barat.UseVisualStyleBackColor = True
        '
        'btn_baix_normal
        '
        Me.btn_baix_normal.Location = New System.Drawing.Point(574, 301)
        Me.btn_baix_normal.Name = "btn_baix_normal"
        Me.btn_baix_normal.Size = New System.Drawing.Size(43, 22)
        Me.btn_baix_normal.TabIndex = 62
        Me.btn_baix_normal.Text = "<---"
        Me.btn_baix_normal.UseVisualStyleBackColor = True
        '
        'btn_baix_car
        '
        Me.btn_baix_car.Location = New System.Drawing.Point(726, 291)
        Me.btn_baix_car.Name = "btn_baix_car"
        Me.btn_baix_car.Size = New System.Drawing.Size(43, 22)
        Me.btn_baix_car.TabIndex = 63
        Me.btn_baix_car.Text = "<---"
        Me.btn_baix_car.UseVisualStyleBackColor = True
        '
        'btn_guardarconfig
        '
        Me.btn_guardarconfig.Location = New System.Drawing.Point(456, 429)
        Me.btn_guardarconfig.Name = "btn_guardarconfig"
        Me.btn_guardarconfig.Size = New System.Drawing.Size(131, 31)
        Me.btn_guardarconfig.TabIndex = 64
        Me.btn_guardarconfig.Text = "Guardar Configuració"
        Me.btn_guardarconfig.UseVisualStyleBackColor = True
        '
        'lv_car
        '
        Me.lv_car.Location = New System.Drawing.Point(623, 168)
        Me.lv_car.Name = "lv_car"
        Me.lv_car.Size = New System.Drawing.Size(97, 239)
        Me.lv_car.TabIndex = 65
        Me.lv_car.UseCompatibleStateImageBehavior = False
        '
        'lv_normal
        '
        Me.lv_normal.Location = New System.Drawing.Point(468, 168)
        Me.lv_normal.Name = "lv_normal"
        Me.lv_normal.Size = New System.Drawing.Size(100, 239)
        Me.lv_normal.TabIndex = 66
        Me.lv_normal.UseCompatibleStateImageBehavior = False
        '
        'lv_barat
        '
        Me.lv_barat.Location = New System.Drawing.Point(312, 168)
        Me.lv_barat.Name = "lv_barat"
        Me.lv_barat.Size = New System.Drawing.Size(101, 239)
        Me.lv_barat.TabIndex = 67
        Me.lv_barat.UseCompatibleStateImageBehavior = False
        '
        'lv_molbarat
        '
        Me.lv_molbarat.Location = New System.Drawing.Point(160, 168)
        Me.lv_molbarat.Name = "lv_molbarat"
        Me.lv_molbarat.Size = New System.Drawing.Size(97, 239)
        Me.lv_molbarat.TabIndex = 68
        Me.lv_molbarat.UseCompatibleStateImageBehavior = False
        '
        'nud_moltbarat
        '
        Me.nud_moltbarat.Location = New System.Drawing.Point(160, 125)
        Me.nud_moltbarat.Name = "nud_moltbarat"
        Me.nud_moltbarat.Size = New System.Drawing.Size(97, 20)
        Me.nud_moltbarat.TabIndex = 69
        Me.nud_moltbarat.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nud_barat
        '
        Me.nud_barat.Location = New System.Drawing.Point(312, 126)
        Me.nud_barat.Name = "nud_barat"
        Me.nud_barat.Size = New System.Drawing.Size(101, 20)
        Me.nud_barat.TabIndex = 70
        Me.nud_barat.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nud_car
        '
        Me.nud_car.Location = New System.Drawing.Point(623, 125)
        Me.nud_car.Name = "nud_car"
        Me.nud_car.Size = New System.Drawing.Size(97, 20)
        Me.nud_car.TabIndex = 71
        Me.nud_car.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nud_moltcar
        '
        Me.nud_moltcar.Location = New System.Drawing.Point(775, 126)
        Me.nud_moltcar.Name = "nud_moltcar"
        Me.nud_moltcar.Size = New System.Drawing.Size(97, 20)
        Me.nud_moltcar.TabIndex = 72
        Me.nud_moltcar.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nud_normal
        '
        Me.nud_normal.Location = New System.Drawing.Point(468, 126)
        Me.nud_normal.Name = "nud_normal"
        Me.nud_normal.Size = New System.Drawing.Size(100, 20)
        Me.nud_normal.TabIndex = 73
        '
        'Emp_interessos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(884, 472)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.nud_normal)
        Me.Controls.Add(Me.nud_moltcar)
        Me.Controls.Add(Me.nud_car)
        Me.Controls.Add(Me.nud_barat)
        Me.Controls.Add(Me.nud_moltbarat)
        Me.Controls.Add(Me.lv_molbarat)
        Me.Controls.Add(Me.lv_barat)
        Me.Controls.Add(Me.lv_normal)
        Me.Controls.Add(Me.lv_car)
        Me.Controls.Add(Me.btn_guardarconfig)
        Me.Controls.Add(Me.btn_baix_car)
        Me.Controls.Add(Me.btn_baix_normal)
        Me.Controls.Add(Me.btn_baix_barat)
        Me.Controls.Add(Me.btn_baix_moltbarat)
        Me.Controls.Add(Me.btn_puja_car)
        Me.Controls.Add(Me.btn_puja_moltcar)
        Me.Controls.Add(Me.btn_puja_normal)
        Me.Controls.Add(Me.lv_moltcar)
        Me.Controls.Add(Me.btn_puja_barat)
        Me.Controls.Add(Me.lbl_moltcar)
        Me.Controls.Add(Me.lbl_car)
        Me.Controls.Add(Me.lbl_normal)
        Me.Controls.Add(Me.lbl_subvencionat)
        Me.Controls.Add(Me.lbl_moltbarat)
        Me.Controls.Add(Me.pnl_estat)
        Me.Name = "Emp_interessos"
        Me.Text = "Emp_interessos"
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        CType(Me.nud_moltbarat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_barat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_moltcar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_normal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents btn_estat As System.Windows.Forms.Button
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
    Friend WithEvents lbl_moltbarat As System.Windows.Forms.Label
    Friend WithEvents lbl_subvencionat As System.Windows.Forms.Label
    Friend WithEvents lbl_normal As System.Windows.Forms.Label
    Friend WithEvents lbl_car As System.Windows.Forms.Label
    Friend WithEvents lbl_moltcar As System.Windows.Forms.Label
    Friend WithEvents btn_puja_barat As System.Windows.Forms.Button
    Friend WithEvents lv_moltcar As System.Windows.Forms.ListView
    Friend WithEvents btn_puja_normal As System.Windows.Forms.Button
    Friend WithEvents btn_puja_moltcar As System.Windows.Forms.Button
    Friend WithEvents btn_puja_car As System.Windows.Forms.Button
    Friend WithEvents btn_baix_moltbarat As System.Windows.Forms.Button
    Friend WithEvents btn_baix_barat As System.Windows.Forms.Button
    Friend WithEvents btn_baix_normal As System.Windows.Forms.Button
    Friend WithEvents btn_baix_car As System.Windows.Forms.Button
    Friend WithEvents btn_guardarconfig As System.Windows.Forms.Button
    Friend WithEvents lv_car As System.Windows.Forms.ListView
    Friend WithEvents lv_normal As System.Windows.Forms.ListView
    Friend WithEvents lv_barat As System.Windows.Forms.ListView
    Friend WithEvents lv_molbarat As System.Windows.Forms.ListView
    Friend WithEvents nud_moltbarat As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_barat As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_car As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_moltcar As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_normal As System.Windows.Forms.NumericUpDown
End Class
