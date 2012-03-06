<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_Gestio_usuaris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_Gestio_usuaris))
        Me.grb_users = New System.Windows.Forms.GroupBox
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
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
        Me.grb_insert_modifica = New System.Windows.Forms.GroupBox
        Me.btn_afegir = New System.Windows.Forms.Button
        Me.btn_cancela = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtb_cognom = New System.Windows.Forms.TextBox
        Me.txtb_password = New System.Windows.Forms.TextBox
        Me.txtb_nom = New System.Windows.Forms.TextBox
        Me.lbl_rol = New System.Windows.Forms.Label
        Me.lbl_cognom = New System.Windows.Forms.Label
        Me.lbl_password = New System.Windows.Forms.Label
        Me.lbl_nom = New System.Windows.Forms.Label
        Me.grb_users.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.grb_insert_modifica.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_users
        '
        Me.grb_users.Controls.Add(Me.ToolStripContainer1)
        Me.grb_users.Location = New System.Drawing.Point(180, 122)
        Me.grb_users.Name = "grb_users"
        Me.grb_users.Size = New System.Drawing.Size(240, 326)
        Me.grb_users.TabIndex = 36
        Me.grb_users.TabStop = False
        Me.grb_users.Text = "Gestió usuaris"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(170, 178)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(28, 39)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(170, 203)
        Me.ToolStripContainer1.TabIndex = 33
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(170, 178)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.EliminarToolStripMenuItem2})
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(168, 20)
        Me.ToolStripButton2.Text = "Daniel Madurell"
        Me.ToolStripButton2.ToolTipText = "Administrador"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem1, Me.EliminarToolStripMenuItem3})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(168, 20)
        Me.ToolStripButton1.Text = "David DeAlvarado"
        Me.ToolStripButton1.ToolTipText = "Cheff"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem3
        '
        Me.EliminarToolStripMenuItem3.Name = "EliminarToolStripMenuItem3"
        Me.EliminarToolStripMenuItem3.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem3.Text = "Eliminar"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(107, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "Afegir"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton3.Text = "Afegir Usuari"
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.Green
        Me.pnl_estat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Controls.Add(Me.pcb_sortir)
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Location = New System.Drawing.Point(113, 6)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(664, 69)
        Me.pnl_estat.TabIndex = 35
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = CType(resources.GetObject("btn_estat.Image"), System.Drawing.Image)
        Me.btn_estat.Location = New System.Drawing.Point(516, 5)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(55, 57)
        Me.btn_estat.TabIndex = 38
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'pcb_sortir
        '
        Me.pcb_sortir.Image = CType(resources.GetObject("pcb_sortir.Image"), System.Drawing.Image)
        Me.pcb_sortir.Location = New System.Drawing.Point(577, 5)
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
        Me.pnl_plats.Location = New System.Drawing.Point(-1, 1)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 466)
        Me.pnl_plats.TabIndex = 34
        '
        'btn_gest_pagos
        '
        Me.btn_gest_pagos.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pagos.Location = New System.Drawing.Point(2, 204)
        Me.btn_gest_pagos.Name = "btn_gest_pagos"
        Me.btn_gest_pagos.Size = New System.Drawing.Size(135, 55)
        Me.btn_gest_pagos.TabIndex = 25
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
        'grb_insert_modifica
        '
        Me.grb_insert_modifica.Controls.Add(Me.btn_afegir)
        Me.grb_insert_modifica.Controls.Add(Me.btn_cancela)
        Me.grb_insert_modifica.Controls.Add(Me.ComboBox1)
        Me.grb_insert_modifica.Controls.Add(Me.txtb_cognom)
        Me.grb_insert_modifica.Controls.Add(Me.txtb_password)
        Me.grb_insert_modifica.Controls.Add(Me.txtb_nom)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_rol)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_cognom)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_password)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_nom)
        Me.grb_insert_modifica.Location = New System.Drawing.Point(437, 122)
        Me.grb_insert_modifica.Name = "grb_insert_modifica"
        Me.grb_insert_modifica.Size = New System.Drawing.Size(297, 326)
        Me.grb_insert_modifica.TabIndex = 37
        Me.grb_insert_modifica.TabStop = False
        Me.grb_insert_modifica.Text = "Info"
        Me.grb_insert_modifica.Visible = False
        '
        'btn_afegir
        '
        Me.btn_afegir.BackColor = System.Drawing.Color.Lime
        Me.btn_afegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_afegir.Location = New System.Drawing.Point(192, 246)
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
        Me.btn_cancela.Location = New System.Drawing.Point(38, 246)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(85, 45)
        Me.btn_cancela.TabIndex = 41
        Me.btn_cancela.Text = "Cancel·la"
        Me.btn_cancela.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrador", "Cheff", "Barman", "Camarero"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 184)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox1.TabIndex = 40
        '
        'txtb_cognom
        '
        Me.txtb_cognom.Location = New System.Drawing.Point(128, 90)
        Me.txtb_cognom.Name = "txtb_cognom"
        Me.txtb_cognom.Size = New System.Drawing.Size(108, 20)
        Me.txtb_cognom.TabIndex = 38
        '
        'txtb_password
        '
        Me.txtb_password.Location = New System.Drawing.Point(128, 132)
        Me.txtb_password.Name = "txtb_password"
        Me.txtb_password.Size = New System.Drawing.Size(108, 20)
        Me.txtb_password.TabIndex = 39
        '
        'txtb_nom
        '
        Me.txtb_nom.Location = New System.Drawing.Point(128, 48)
        Me.txtb_nom.Name = "txtb_nom"
        Me.txtb_nom.Size = New System.Drawing.Size(108, 20)
        Me.txtb_nom.TabIndex = 3
        '
        'lbl_rol
        '
        Me.lbl_rol.AutoSize = True
        Me.lbl_rol.Location = New System.Drawing.Point(42, 187)
        Me.lbl_rol.Name = "lbl_rol"
        Me.lbl_rol.Size = New System.Drawing.Size(26, 13)
        Me.lbl_rol.TabIndex = 2
        Me.lbl_rol.Text = "Rol:"
        '
        'lbl_cognom
        '
        Me.lbl_cognom.AutoSize = True
        Me.lbl_cognom.Location = New System.Drawing.Point(42, 93)
        Me.lbl_cognom.Name = "lbl_cognom"
        Me.lbl_cognom.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cognom.TabIndex = 1
        Me.lbl_cognom.Text = "Cognom:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(42, 139)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(56, 13)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Password:"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(42, 51)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(32, 13)
        Me.lbl_nom.TabIndex = 0
        Me.lbl_nom.Text = "Nom:"
        '
        'Emp_Gestio_usuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(761, 479)
        Me.Controls.Add(Me.grb_insert_modifica)
        Me.Controls.Add(Me.grb_users)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.Name = "Emp_Gestio_usuaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emp_Gestio_usuaris"
        Me.grb_users.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        Me.grb_insert_modifica.ResumeLayout(False)
        Me.grb_insert_modifica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_users As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents pcb_sortir As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_gest_stock As System.Windows.Forms.Button
    Friend WithEvents btn_config_fichero As System.Windows.Forms.Button
    Friend WithEvents btn_gest_users As System.Windows.Forms.Button
    Friend WithEvents btn_gest_comandes As System.Windows.Forms.Button
    Friend WithEvents btn_gest_carta As System.Windows.Forms.Button
    Friend WithEvents grb_insert_modifica As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cognom As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents lbl_rol As System.Windows.Forms.Label
    Friend WithEvents txtb_cognom As System.Windows.Forms.TextBox
    Friend WithEvents txtb_password As System.Windows.Forms.TextBox
    Friend WithEvents txtb_nom As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_afegir As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents btn_gest_pagos As System.Windows.Forms.Button
End Class
