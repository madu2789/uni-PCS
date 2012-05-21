<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_Pago))
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.pcb_sortir = New System.Windows.Forms.PictureBox
        Me.lbl_user = New System.Windows.Forms.Label
        Me.lbl_rol = New System.Windows.Forms.Label
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.btn_gest_pago = New System.Windows.Forms.Button
        Me.btn_gest_stock = New System.Windows.Forms.Button
        Me.btn_config_fichero = New System.Windows.Forms.Button
        Me.btn_gest_users = New System.Windows.Forms.Button
        Me.btn_gest_comandes = New System.Windows.Forms.Button
        Me.btn_gest_carta = New System.Windows.Forms.Button
        Me.lbl_importparcial = New System.Windows.Forms.Label
        Me.lbl_importtotal = New System.Windows.Forms.Label
        Me.btn_previs = New System.Windows.Forms.Button
        Me.btn_mixt = New System.Windows.Forms.Button
        Me.btn_efectiu = New System.Windows.Forms.Button
        Me.btn_tc = New System.Windows.Forms.Button
        Me.cb_taula = New System.Windows.Forms.ComboBox
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.Green
        Me.pnl_estat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Controls.Add(Me.pcb_sortir)
        Me.pnl_estat.Controls.Add(Me.lbl_user)
        Me.pnl_estat.Controls.Add(Me.lbl_rol)
        Me.pnl_estat.Location = New System.Drawing.Point(127, -2)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(717, 63)
        Me.pnl_estat.TabIndex = 34
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(560, -2)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(74, 86)
        Me.btn_estat.TabIndex = 43
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'pcb_sortir
        '
        Me.pcb_sortir.Image = CType(resources.GetObject("pcb_sortir.Image"), System.Drawing.Image)
        Me.pcb_sortir.Location = New System.Drawing.Point(640, -2)
        Me.pcb_sortir.Name = "pcb_sortir"
        Me.pcb_sortir.Size = New System.Drawing.Size(74, 63)
        Me.pcb_sortir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_sortir.TabIndex = 23
        Me.pcb_sortir.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_user.Location = New System.Drawing.Point(110, 9)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(108, 31)
        Me.lbl_user.TabIndex = 22
        Me.lbl_user.Text = "Usuari:"
        '
        'lbl_rol
        '
        Me.lbl_rol.AutoSize = True
        Me.lbl_rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rol.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_rol.Location = New System.Drawing.Point(340, 9)
        Me.lbl_rol.Name = "lbl_rol"
        Me.lbl_rol.Size = New System.Drawing.Size(67, 31)
        Me.lbl_rol.TabIndex = 0
        Me.lbl_rol.Text = "Rol:"
        '
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkGreen
        Me.pnl_plats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_plats.Controls.Add(Me.btn_gest_pago)
        Me.pnl_plats.Controls.Add(Me.btn_gest_stock)
        Me.pnl_plats.Controls.Add(Me.btn_config_fichero)
        Me.pnl_plats.Controls.Add(Me.btn_gest_users)
        Me.pnl_plats.Controls.Add(Me.btn_gest_comandes)
        Me.pnl_plats.Controls.Add(Me.btn_gest_carta)
        Me.pnl_plats.Location = New System.Drawing.Point(1, -2)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 475)
        Me.pnl_plats.TabIndex = 33
        '
        'btn_gest_pago
        '
        Me.btn_gest_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pago.Location = New System.Drawing.Point(1, 319)
        Me.btn_gest_pago.Name = "btn_gest_pago"
        Me.btn_gest_pago.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_pago.TabIndex = 19
        Me.btn_gest_pago.Text = "Gestionar Pagaments"
        Me.btn_gest_pago.UseVisualStyleBackColor = True
        '
        'btn_gest_stock
        '
        Me.btn_gest_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_stock.Location = New System.Drawing.Point(1, 253)
        Me.btn_gest_stock.Name = "btn_gest_stock"
        Me.btn_gest_stock.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_stock.TabIndex = 18
        Me.btn_gest_stock.Text = "Gestionar Stock"
        Me.btn_gest_stock.UseVisualStyleBackColor = True
        '
        'btn_config_fichero
        '
        Me.btn_config_fichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config_fichero.Location = New System.Drawing.Point(1, 383)
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
        Me.btn_gest_comandes.Location = New System.Drawing.Point(1, 187)
        Me.btn_gest_comandes.Name = "btn_gest_comandes"
        Me.btn_gest_comandes.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_comandes.TabIndex = 14
        Me.btn_gest_comandes.Text = "Gestionar Comandes"
        Me.btn_gest_comandes.UseVisualStyleBackColor = True
        '
        'btn_gest_carta
        '
        Me.btn_gest_carta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_carta.Location = New System.Drawing.Point(1, 123)
        Me.btn_gest_carta.Name = "btn_gest_carta"
        Me.btn_gest_carta.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_carta.TabIndex = 13
        Me.btn_gest_carta.Text = "Gestionar Carta"
        Me.btn_gest_carta.UseVisualStyleBackColor = True
        '
        'lbl_importparcial
        '
        Me.lbl_importparcial.AutoSize = True
        Me.lbl_importparcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importparcial.Location = New System.Drawing.Point(498, 144)
        Me.lbl_importparcial.Name = "lbl_importparcial"
        Me.lbl_importparcial.Size = New System.Drawing.Size(198, 25)
        Me.lbl_importparcial.TabIndex = 40
        Me.lbl_importparcial.Text = "Import per persona:"
        '
        'lbl_importtotal
        '
        Me.lbl_importtotal.AutoSize = True
        Me.lbl_importtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importtotal.Location = New System.Drawing.Point(175, 144)
        Me.lbl_importtotal.Name = "lbl_importtotal"
        Me.lbl_importtotal.Size = New System.Drawing.Size(124, 25)
        Me.lbl_importtotal.TabIndex = 39
        Me.lbl_importtotal.Text = "Import total:"
        '
        'btn_previs
        '
        Me.btn_previs.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previs.ForeColor = System.Drawing.Color.Indigo
        Me.btn_previs.Image = CType(resources.GetObject("btn_previs.Image"), System.Drawing.Image)
        Me.btn_previs.Location = New System.Drawing.Point(502, 341)
        Me.btn_previs.Name = "btn_previs"
        Me.btn_previs.Size = New System.Drawing.Size(233, 77)
        Me.btn_previs.TabIndex = 38
        Me.btn_previs.Text = "Previsualitzar factura"
        Me.btn_previs.UseVisualStyleBackColor = True
        '
        'btn_mixt
        '
        Me.btn_mixt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mixt.ForeColor = System.Drawing.Color.Yellow
        Me.btn_mixt.Image = CType(resources.GetObject("btn_mixt.Image"), System.Drawing.Image)
        Me.btn_mixt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_mixt.Location = New System.Drawing.Point(502, 213)
        Me.btn_mixt.Name = "btn_mixt"
        Me.btn_mixt.Size = New System.Drawing.Size(233, 77)
        Me.btn_mixt.TabIndex = 37
        Me.btn_mixt.Text = "Mixt"
        Me.btn_mixt.UseVisualStyleBackColor = True
        '
        'btn_efectiu
        '
        Me.btn_efectiu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_efectiu.ForeColor = System.Drawing.Color.Yellow
        Me.btn_efectiu.Image = CType(resources.GetObject("btn_efectiu.Image"), System.Drawing.Image)
        Me.btn_efectiu.Location = New System.Drawing.Point(179, 213)
        Me.btn_efectiu.Name = "btn_efectiu"
        Me.btn_efectiu.Size = New System.Drawing.Size(233, 77)
        Me.btn_efectiu.TabIndex = 35
        Me.btn_efectiu.Text = "Efectiu"
        Me.btn_efectiu.UseVisualStyleBackColor = True
        '
        'btn_tc
        '
        Me.btn_tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tc.ForeColor = System.Drawing.Color.Black
        Me.btn_tc.Image = CType(resources.GetObject("btn_tc.Image"), System.Drawing.Image)
        Me.btn_tc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tc.Location = New System.Drawing.Point(179, 341)
        Me.btn_tc.Name = "btn_tc"
        Me.btn_tc.Size = New System.Drawing.Size(233, 77)
        Me.btn_tc.TabIndex = 36
        Me.btn_tc.Text = "Targeta de crèdit"
        Me.btn_tc.UseVisualStyleBackColor = True
        '
        'cb_taula
        '
        Me.cb_taula.FormattingEnabled = True
        Me.cb_taula.Items.AddRange(New Object() {"Taula1", "Taula2", "Taula3", "Taula4"})
        Me.cb_taula.Location = New System.Drawing.Point(261, 107)
        Me.cb_taula.Name = "cb_taula"
        Me.cb_taula.Size = New System.Drawing.Size(121, 21)
        Me.cb_taula.TabIndex = 41
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.Location = New System.Drawing.Point(176, 110)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(58, 20)
        Me.lbl_taula.TabIndex = 42
        Me.lbl_taula.Text = "Taula:"
        '
        'Emp_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_taula)
        Me.Controls.Add(Me.cb_taula)
        Me.Controls.Add(Me.lbl_importparcial)
        Me.Controls.Add(Me.lbl_importtotal)
        Me.Controls.Add(Me.btn_previs)
        Me.Controls.Add(Me.btn_mixt)
        Me.Controls.Add(Me.btn_efectiu)
        Me.Controls.Add(Me.btn_tc)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Emp_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado_Pago"
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents pcb_sortir As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents lbl_rol As System.Windows.Forms.Label
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_gest_stock As System.Windows.Forms.Button
    Friend WithEvents btn_config_fichero As System.Windows.Forms.Button
    Friend WithEvents btn_gest_users As System.Windows.Forms.Button
    Friend WithEvents btn_gest_comandes As System.Windows.Forms.Button
    Friend WithEvents btn_gest_carta As System.Windows.Forms.Button
    Friend WithEvents lbl_importparcial As System.Windows.Forms.Label
    Friend WithEvents lbl_importtotal As System.Windows.Forms.Label
    Friend WithEvents btn_previs As System.Windows.Forms.Button
    Friend WithEvents btn_mixt As System.Windows.Forms.Button
    Friend WithEvents btn_efectiu As System.Windows.Forms.Button
    Friend WithEvents btn_tc As System.Windows.Forms.Button
    Friend WithEvents cb_taula As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents btn_gest_pago As System.Windows.Forms.Button
    Friend WithEvents btn_estat As System.Windows.Forms.Button
End Class
