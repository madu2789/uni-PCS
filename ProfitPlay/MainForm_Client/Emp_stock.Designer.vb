<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_stock))
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
        Me.btn_segundos = New System.Windows.Forms.Button
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ts_productes_stock = New System.Windows.Forms.ToolStrip
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_compres = New System.Windows.Forms.Button
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
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
        Me.pnl_estat.Location = New System.Drawing.Point(145, -8)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(700, 64)
        Me.pnl_estat.TabIndex = 34
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(538, -2)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(76, 93)
        Me.btn_estat.TabIndex = 39
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'pcb_sortir
        '
        Me.pcb_sortir.Image = CType(resources.GetObject("pcb_sortir.Image"), System.Drawing.Image)
        Me.pcb_sortir.Location = New System.Drawing.Point(620, 5)
        Me.pcb_sortir.Name = "pcb_sortir"
        Me.pcb_sortir.Size = New System.Drawing.Size(78, 57)
        Me.pcb_sortir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_sortir.TabIndex = 23
        Me.pcb_sortir.TabStop = False
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_taula.Location = New System.Drawing.Point(112, 15)
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
        Me.lbl_punts.Location = New System.Drawing.Point(340, 15)
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
        Me.pnl_plats.Location = New System.Drawing.Point(1, -8)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 479)
        Me.pnl_plats.TabIndex = 33
        '
        'btn_gest_pagos
        '
        Me.btn_gest_pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_pagos.Location = New System.Drawing.Point(1, 321)
        Me.btn_gest_pagos.Name = "btn_gest_pagos"
        Me.btn_gest_pagos.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_pagos.TabIndex = 24
        Me.btn_gest_pagos.Text = "Gestionar Pagaments"
        Me.btn_gest_pagos.UseVisualStyleBackColor = True
        '
        'btn_gest_stock
        '
        Me.btn_gest_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_stock.Location = New System.Drawing.Point(1, 255)
        Me.btn_gest_stock.Name = "btn_gest_stock"
        Me.btn_gest_stock.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_stock.TabIndex = 18
        Me.btn_gest_stock.Text = "Gestionar Stock"
        Me.btn_gest_stock.UseVisualStyleBackColor = True
        '
        'btn_config_fichero
        '
        Me.btn_config_fichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config_fichero.Location = New System.Drawing.Point(1, 387)
        Me.btn_config_fichero.Name = "btn_config_fichero"
        Me.btn_config_fichero.Size = New System.Drawing.Size(135, 85)
        Me.btn_config_fichero.TabIndex = 17
        Me.btn_config_fichero.Text = "Configurar interesos"
        Me.btn_config_fichero.UseVisualStyleBackColor = True
        '
        'btn_gest_users
        '
        Me.btn_gest_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_users.Location = New System.Drawing.Point(1, 57)
        Me.btn_gest_users.Name = "btn_gest_users"
        Me.btn_gest_users.Size = New System.Drawing.Size(135, 60)
        Me.btn_gest_users.TabIndex = 11
        Me.btn_gest_users.Text = "Gestionar Usuaris"
        Me.btn_gest_users.UseVisualStyleBackColor = True
        '
        'btn_gest_comandes
        '
        Me.btn_gest_comandes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gest_comandes.Location = New System.Drawing.Point(1, 189)
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
        'btn_segundos
        '
        Me.btn_segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_segundos.Location = New System.Drawing.Point(182, 400)
        Me.btn_segundos.Name = "btn_segundos"
        Me.btn_segundos.Size = New System.Drawing.Size(318, 60)
        Me.btn_segundos.TabIndex = 37
        Me.btn_segundos.Text = "Comprar segons demanda"
        Me.btn_segundos.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ts_productes_stock)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(318, 274)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(182, 88)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(318, 299)
        Me.ToolStripContainer1.TabIndex = 38
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ts_productes_stock
        '
        Me.ts_productes_stock.AutoSize = False
        Me.ts_productes_stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ts_productes_stock.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ts_productes_stock.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ts_productes_stock.Location = New System.Drawing.Point(0, 0)
        Me.ts_productes_stock.Name = "ts_productes_stock"
        Me.ts_productes_stock.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ts_productes_stock.Size = New System.Drawing.Size(318, 274)
        Me.ts_productes_stock.TabIndex = 2
        Me.ts_productes_stock.Text = "Stock de Ingredients"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(522, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 60)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Fes click sobre un ingredient per veure el seu stock actual." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(522, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 188)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'btn_compres
        '
        Me.btn_compres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compres.Location = New System.Drawing.Point(522, 400)
        Me.btn_compres.Name = "btn_compres"
        Me.btn_compres.Size = New System.Drawing.Size(310, 60)
        Me.btn_compres.TabIndex = 41
        Me.btn_compres.Text = "Veure Compres"
        Me.btn_compres.UseVisualStyleBackColor = True
        '
        'Emp_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.btn_compres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.btn_segundos)
        Me.Controls.Add(Me.pnl_estat)
        Me.Controls.Add(Me.pnl_plats)
        Me.MaximizeBox = False
        Me.Name = "Emp_stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado_stock"
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
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
    Friend WithEvents btn_segundos As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ts_productes_stock As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_compres As System.Windows.Forms.Button
End Class
