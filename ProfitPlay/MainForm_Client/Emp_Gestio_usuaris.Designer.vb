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
        Me.lv_users = New System.Windows.Forms.ListView
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
        Me.txtb_password = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_afegir = New System.Windows.Forms.Button
        Me.btn_cancela = New System.Windows.Forms.Button
        Me.cmbx_rol = New System.Windows.Forms.ComboBox
        Me.txtb_cognom = New System.Windows.Forms.TextBox
        Me.txtb_username = New System.Windows.Forms.TextBox
        Me.txtb_nom = New System.Windows.Forms.TextBox
        Me.lbl_tipus = New System.Windows.Forms.Label
        Me.lbl_descripcio = New System.Windows.Forms.Label
        Me.lbl_preu = New System.Windows.Forms.Label
        Me.lbl_nom = New System.Windows.Forms.Label
        Me.lbl_gestio_usuaris_info = New System.Windows.Forms.Label
        Me.btn_update_user = New System.Windows.Forms.Button
        Me.btn_elimina_user = New System.Windows.Forms.Button
        Me.btn_add_user = New System.Windows.Forms.Button
        Me.grb_users.SuspendLayout()
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.grb_insert_modifica.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_users
        '
        Me.grb_users.Controls.Add(Me.lv_users)
        Me.grb_users.Location = New System.Drawing.Point(148, 115)
        Me.grb_users.Name = "grb_users"
        Me.grb_users.Size = New System.Drawing.Size(325, 345)
        Me.grb_users.TabIndex = 36
        Me.grb_users.TabStop = False
        Me.grb_users.Text = "Usuaris al sistema"
        '
        'lv_users
        '
        Me.lv_users.Location = New System.Drawing.Point(35, 39)
        Me.lv_users.Name = "lv_users"
        Me.lv_users.Size = New System.Drawing.Size(250, 275)
        Me.lv_users.TabIndex = 0
        Me.lv_users.UseCompatibleStateImageBehavior = False
        Me.lv_users.View = System.Windows.Forms.View.List
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
        Me.pnl_estat.Size = New System.Drawing.Size(719, 69)
        Me.pnl_estat.TabIndex = 35
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(565, -3)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(72, 91)
        Me.btn_estat.TabIndex = 38
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'pcb_sortir
        '
        Me.pcb_sortir.Image = CType(resources.GetObject("pcb_sortir.Image"), System.Drawing.Image)
        Me.pcb_sortir.Location = New System.Drawing.Point(643, -2)
        Me.pcb_sortir.Name = "pcb_sortir"
        Me.pcb_sortir.Size = New System.Drawing.Size(75, 69)
        Me.pcb_sortir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_sortir.TabIndex = 23
        Me.pcb_sortir.TabStop = False
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_taula.Location = New System.Drawing.Point(110, 21)
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
        Me.lbl_punts.Location = New System.Drawing.Point(341, 22)
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
        Me.pnl_plats.Location = New System.Drawing.Point(-1, 5)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 475)
        Me.pnl_plats.TabIndex = 34
        '
        'btn_gest_pagos
        '
        Me.btn_gest_pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pagos.Location = New System.Drawing.Point(2, 314)
        Me.btn_gest_pagos.Name = "btn_gest_pagos"
        Me.btn_gest_pagos.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_pagos.TabIndex = 25
        Me.btn_gest_pagos.Text = "Gestionar Pagaments"
        Me.btn_gest_pagos.UseVisualStyleBackColor = True
        '
        'btn_gest_stock
        '
        Me.btn_gest_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_stock.Location = New System.Drawing.Point(2, 252)
        Me.btn_gest_stock.Name = "btn_gest_stock"
        Me.btn_gest_stock.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_stock.TabIndex = 18
        Me.btn_gest_stock.Text = "Gestionar Stock"
        Me.btn_gest_stock.UseVisualStyleBackColor = True
        '
        'btn_config_fichero
        '
        Me.btn_config_fichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config_fichero.Location = New System.Drawing.Point(2, 377)
        Me.btn_config_fichero.Name = "btn_config_fichero"
        Me.btn_config_fichero.Size = New System.Drawing.Size(135, 85)
        Me.btn_config_fichero.TabIndex = 17
        Me.btn_config_fichero.Text = "Configurar interesos"
        Me.btn_config_fichero.UseVisualStyleBackColor = True
        '
        'btn_gest_users
        '
        Me.btn_gest_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_users.Location = New System.Drawing.Point(2, 64)
        Me.btn_gest_users.Name = "btn_gest_users"
        Me.btn_gest_users.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_users.TabIndex = 11
        Me.btn_gest_users.Text = "Gestionar Usuaris"
        Me.btn_gest_users.UseVisualStyleBackColor = True
        '
        'btn_gest_comandes
        '
        Me.btn_gest_comandes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_comandes.Location = New System.Drawing.Point(2, 190)
        Me.btn_gest_comandes.Name = "btn_gest_comandes"
        Me.btn_gest_comandes.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_comandes.TabIndex = 14
        Me.btn_gest_comandes.Text = "Gestionar Comandes"
        Me.btn_gest_comandes.UseVisualStyleBackColor = True
        '
        'btn_gest_carta
        '
        Me.btn_gest_carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_carta.Location = New System.Drawing.Point(2, 127)
        Me.btn_gest_carta.Name = "btn_gest_carta"
        Me.btn_gest_carta.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_carta.TabIndex = 13
        Me.btn_gest_carta.Text = "Gestionar Carta"
        Me.btn_gest_carta.UseVisualStyleBackColor = True
        '
        'grb_insert_modifica
        '
        Me.grb_insert_modifica.Controls.Add(Me.txtb_password)
        Me.grb_insert_modifica.Controls.Add(Me.Label1)
        Me.grb_insert_modifica.Controls.Add(Me.btn_afegir)
        Me.grb_insert_modifica.Controls.Add(Me.btn_cancela)
        Me.grb_insert_modifica.Controls.Add(Me.cmbx_rol)
        Me.grb_insert_modifica.Controls.Add(Me.txtb_cognom)
        Me.grb_insert_modifica.Controls.Add(Me.txtb_username)
        Me.grb_insert_modifica.Controls.Add(Me.txtb_nom)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_tipus)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_descripcio)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_preu)
        Me.grb_insert_modifica.Controls.Add(Me.lbl_nom)
        Me.grb_insert_modifica.Location = New System.Drawing.Point(499, 115)
        Me.grb_insert_modifica.Name = "grb_insert_modifica"
        Me.grb_insert_modifica.Size = New System.Drawing.Size(334, 345)
        Me.grb_insert_modifica.TabIndex = 37
        Me.grb_insert_modifica.TabStop = False
        Me.grb_insert_modifica.Text = "Info"
        Me.grb_insert_modifica.Visible = False
        '
        'txtb_password
        '
        Me.txtb_password.Location = New System.Drawing.Point(174, 156)
        Me.txtb_password.Name = "txtb_password"
        Me.txtb_password.Size = New System.Drawing.Size(124, 20)
        Me.txtb_password.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Password:"
        '
        'btn_afegir
        '
        Me.btn_afegir.BackColor = System.Drawing.Color.Lime
        Me.btn_afegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_afegir.Location = New System.Drawing.Point(183, 282)
        Me.btn_afegir.Name = "btn_afegir"
        Me.btn_afegir.Size = New System.Drawing.Size(115, 45)
        Me.btn_afegir.TabIndex = 6
        Me.btn_afegir.Text = "Afegeix"
        Me.btn_afegir.UseVisualStyleBackColor = False
        '
        'btn_cancela
        '
        Me.btn_cancela.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(33, 282)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(115, 45)
        Me.btn_cancela.TabIndex = 41
        Me.btn_cancela.Text = "Cancel·la"
        Me.btn_cancela.UseVisualStyleBackColor = False
        '
        'cmbx_rol
        '
        Me.cmbx_rol.FormattingEnabled = True
        Me.cmbx_rol.Items.AddRange(New Object() {"Administrador", "Cheff", "Barman", "Cambrer"})
        Me.cmbx_rol.Location = New System.Drawing.Point(174, 195)
        Me.cmbx_rol.Name = "cmbx_rol"
        Me.cmbx_rol.Size = New System.Drawing.Size(124, 21)
        Me.cmbx_rol.TabIndex = 5
        '
        'txtb_cognom
        '
        Me.txtb_cognom.Location = New System.Drawing.Point(173, 72)
        Me.txtb_cognom.Name = "txtb_cognom"
        Me.txtb_cognom.Size = New System.Drawing.Size(125, 20)
        Me.txtb_cognom.TabIndex = 2
        '
        'txtb_username
        '
        Me.txtb_username.Location = New System.Drawing.Point(174, 115)
        Me.txtb_username.Name = "txtb_username"
        Me.txtb_username.Size = New System.Drawing.Size(124, 20)
        Me.txtb_username.TabIndex = 3
        '
        'txtb_nom
        '
        Me.txtb_nom.Location = New System.Drawing.Point(173, 32)
        Me.txtb_nom.Name = "txtb_nom"
        Me.txtb_nom.Size = New System.Drawing.Size(125, 20)
        Me.txtb_nom.TabIndex = 1
        '
        'lbl_tipus
        '
        Me.lbl_tipus.AutoSize = True
        Me.lbl_tipus.Location = New System.Drawing.Point(30, 203)
        Me.lbl_tipus.Name = "lbl_tipus"
        Me.lbl_tipus.Size = New System.Drawing.Size(26, 13)
        Me.lbl_tipus.TabIndex = 2
        Me.lbl_tipus.Text = "Rol:"
        '
        'lbl_descripcio
        '
        Me.lbl_descripcio.AutoSize = True
        Me.lbl_descripcio.Location = New System.Drawing.Point(30, 79)
        Me.lbl_descripcio.Name = "lbl_descripcio"
        Me.lbl_descripcio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_descripcio.TabIndex = 1
        Me.lbl_descripcio.Text = "Cognom:"
        '
        'lbl_preu
        '
        Me.lbl_preu.AutoSize = True
        Me.lbl_preu.Location = New System.Drawing.Point(30, 122)
        Me.lbl_preu.Name = "lbl_preu"
        Me.lbl_preu.Size = New System.Drawing.Size(55, 13)
        Me.lbl_preu.TabIndex = 1
        Me.lbl_preu.Text = "Username"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(30, 39)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(32, 13)
        Me.lbl_nom.TabIndex = 0
        Me.lbl_nom.Text = "Nom:"
        '
        'lbl_gestio_usuaris_info
        '
        Me.lbl_gestio_usuaris_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gestio_usuaris_info.Location = New System.Drawing.Point(493, 134)
        Me.lbl_gestio_usuaris_info.Name = "lbl_gestio_usuaris_info"
        Me.lbl_gestio_usuaris_info.Size = New System.Drawing.Size(353, 348)
        Me.lbl_gestio_usuaris_info.TabIndex = 38
        Me.lbl_gestio_usuaris_info.Text = resources.GetString("lbl_gestio_usuaris_info.Text")
        '
        'btn_update_user
        '
        Me.btn_update_user.Location = New System.Drawing.Point(623, 420)
        Me.btn_update_user.Name = "btn_update_user"
        Me.btn_update_user.Size = New System.Drawing.Size(97, 40)
        Me.btn_update_user.TabIndex = 39
        Me.btn_update_user.Text = "Modificar Usuari"
        Me.btn_update_user.UseVisualStyleBackColor = True
        '
        'btn_elimina_user
        '
        Me.btn_elimina_user.Location = New System.Drawing.Point(744, 420)
        Me.btn_elimina_user.Name = "btn_elimina_user"
        Me.btn_elimina_user.Size = New System.Drawing.Size(90, 40)
        Me.btn_elimina_user.TabIndex = 40
        Me.btn_elimina_user.Text = "Eliminar Usuari"
        Me.btn_elimina_user.UseVisualStyleBackColor = True
        '
        'btn_add_user
        '
        Me.btn_add_user.Location = New System.Drawing.Point(504, 420)
        Me.btn_add_user.Name = "btn_add_user"
        Me.btn_add_user.Size = New System.Drawing.Size(90, 40)
        Me.btn_add_user.TabIndex = 41
        Me.btn_add_user.Text = "Afegir Usuari"
        Me.btn_add_user.UseVisualStyleBackColor = True
        '
        'Emp_Gestio_usuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.grb_insert_modifica)
        Me.Controls.Add(Me.grb_users)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.Controls.Add(Me.btn_update_user)
        Me.Controls.Add(Me.btn_add_user)
        Me.Controls.Add(Me.btn_elimina_user)
        Me.Controls.Add(Me.lbl_gestio_usuaris_info)
        Me.Name = "Emp_Gestio_usuaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emp_Gestio_usuaris"
        Me.grb_users.ResumeLayout(False)
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        Me.grb_insert_modifica.ResumeLayout(False)
        Me.grb_insert_modifica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_users As System.Windows.Forms.GroupBox
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
    Friend WithEvents lbl_descripcio As System.Windows.Forms.Label
    Friend WithEvents lbl_preu As System.Windows.Forms.Label
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents lbl_tipus As System.Windows.Forms.Label
    Friend WithEvents txtb_cognom As System.Windows.Forms.TextBox
    Friend WithEvents txtb_username As System.Windows.Forms.TextBox
    Friend WithEvents txtb_nom As System.Windows.Forms.TextBox
    Friend WithEvents cmbx_rol As System.Windows.Forms.ComboBox
    Friend WithEvents btn_afegir As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents btn_gest_pagos As System.Windows.Forms.Button
    Friend WithEvents lbl_gestio_usuaris_info As System.Windows.Forms.Label
    Friend WithEvents btn_update_user As System.Windows.Forms.Button
    Friend WithEvents btn_elimina_user As System.Windows.Forms.Button
    Friend WithEvents txtb_password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lv_users As System.Windows.Forms.ListView
    Friend WithEvents btn_add_user As System.Windows.Forms.Button
End Class
