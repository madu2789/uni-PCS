<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_anula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_anula))
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
        Me.grb_anular = New System.Windows.Forms.GroupBox
        Me.cb_llista_taules = New System.Windows.Forms.ComboBox
        Me.lbl_instr_anula = New System.Windows.Forms.Label
        Me.container2 = New System.Windows.Forms.ToolStripContainer
        Me.llista_resta_productes = New System.Windows.Forms.ToolStrip
        Me.lbl_productes_no_espera = New System.Windows.Forms.Label
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.llista_productes_eliminar = New System.Windows.Forms.ToolStrip
        Me.lbl_anular = New System.Windows.Forms.Label
        Me.pnl_estat.SuspendLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_plats.SuspendLayout()
        Me.grb_anular.SuspendLayout()
        Me.container2.ContentPanel.SuspendLayout()
        Me.container2.SuspendLayout()
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
        Me.pnl_estat.Location = New System.Drawing.Point(144, -7)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(704, 66)
        Me.pnl_estat.TabIndex = 38
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
        Me.lbl_taula.Size = New System.Drawing.Size(108, 31)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Usuari:"
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
        Me.pnl_plats.Location = New System.Drawing.Point(1, -7)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(143, 485)
        Me.pnl_plats.TabIndex = 37
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
        'grb_anular
        '
        Me.grb_anular.Controls.Add(Me.cb_llista_taules)
        Me.grb_anular.Controls.Add(Me.lbl_instr_anula)
        Me.grb_anular.Controls.Add(Me.container2)
        Me.grb_anular.Controls.Add(Me.lbl_productes_no_espera)
        Me.grb_anular.Controls.Add(Me.ToolStripContainer1)
        Me.grb_anular.Controls.Add(Me.lbl_anular)
        Me.grb_anular.Location = New System.Drawing.Point(150, 72)
        Me.grb_anular.Name = "grb_anular"
        Me.grb_anular.Size = New System.Drawing.Size(682, 388)
        Me.grb_anular.TabIndex = 39
        Me.grb_anular.TabStop = False
        Me.grb_anular.Text = "Anular"
        '
        'cb_llista_taules
        '
        Me.cb_llista_taules.FormattingEnabled = True
        Me.cb_llista_taules.Location = New System.Drawing.Point(10, 246)
        Me.cb_llista_taules.Name = "cb_llista_taules"
        Me.cb_llista_taules.Size = New System.Drawing.Size(244, 21)
        Me.cb_llista_taules.TabIndex = 36
        '
        'lbl_instr_anula
        '
        Me.lbl_instr_anula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instr_anula.Location = New System.Drawing.Point(6, 48)
        Me.lbl_instr_anula.Name = "lbl_instr_anula"
        Me.lbl_instr_anula.Size = New System.Drawing.Size(248, 192)
        Me.lbl_instr_anula.TabIndex = 35
        Me.lbl_instr_anula.Text = "Instruccions:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sel.lecciona el ID de la taula per mostrar les comandes de aques" & _
            "ta taula." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fes click sobre un producte en espera per veure les opcions disponi" & _
            "bles."
        '
        'container2
        '
        '
        'container2.ContentPanel
        '
        Me.container2.ContentPanel.Controls.Add(Me.llista_resta_productes)
        Me.container2.ContentPanel.Size = New System.Drawing.Size(170, 305)
        Me.container2.Location = New System.Drawing.Point(486, 52)
        Me.container2.Name = "container2"
        Me.container2.Size = New System.Drawing.Size(170, 330)
        Me.container2.TabIndex = 34
        Me.container2.Text = "ToolStripContainer2"
        '
        'container2.TopToolStripPanel
        '
        Me.container2.TopToolStripPanel.Padding = New System.Windows.Forms.Padding(0, 0, 25, 25)
        '
        'llista_resta_productes
        '
        Me.llista_resta_productes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.llista_resta_productes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.llista_resta_productes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.llista_resta_productes.Location = New System.Drawing.Point(0, 0)
        Me.llista_resta_productes.Name = "llista_resta_productes"
        Me.llista_resta_productes.Padding = New System.Windows.Forms.Padding(0)
        Me.llista_resta_productes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.llista_resta_productes.Size = New System.Drawing.Size(170, 305)
        Me.llista_resta_productes.TabIndex = 3
        Me.llista_resta_productes.Text = "ToolStrip1"
        '
        'lbl_productes_no_espera
        '
        Me.lbl_productes_no_espera.AutoSize = True
        Me.lbl_productes_no_espera.Location = New System.Drawing.Point(511, 23)
        Me.lbl_productes_no_espera.Name = "lbl_productes_no_espera"
        Me.lbl_productes_no_espera.Size = New System.Drawing.Size(101, 13)
        Me.lbl_productes_no_espera.TabIndex = 33
        Me.lbl_productes_no_espera.Text = "Resta de Productes"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.llista_productes_eliminar)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(170, 305)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(260, 52)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(170, 330)
        Me.ToolStripContainer1.TabIndex = 32
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Padding = New System.Windows.Forms.Padding(0, 0, 25, 25)
        '
        'llista_productes_eliminar
        '
        Me.llista_productes_eliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.llista_productes_eliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.llista_productes_eliminar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.llista_productes_eliminar.Location = New System.Drawing.Point(0, 0)
        Me.llista_productes_eliminar.Name = "llista_productes_eliminar"
        Me.llista_productes_eliminar.Padding = New System.Windows.Forms.Padding(0)
        Me.llista_productes_eliminar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.llista_productes_eliminar.Size = New System.Drawing.Size(170, 305)
        Me.llista_productes_eliminar.TabIndex = 2
        Me.llista_productes_eliminar.Text = "ToolStrip1"
        '
        'lbl_anular
        '
        Me.lbl_anular.AutoSize = True
        Me.lbl_anular.Location = New System.Drawing.Point(293, 23)
        Me.lbl_anular.Name = "lbl_anular"
        Me.lbl_anular.Size = New System.Drawing.Size(108, 13)
        Me.lbl_anular.TabIndex = 1
        Me.lbl_anular.Text = "Productes en espera:"
        '
        'Emp_anula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.grb_anular)
        Me.Controls.Add(Me.pnl_estat)
        Me.Controls.Add(Me.pnl_plats)
        Me.Name = "Emp_anula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emp_anula"
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.pcb_sortir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_plats.ResumeLayout(False)
        Me.grb_anular.ResumeLayout(False)
        Me.grb_anular.PerformLayout()
        Me.container2.ContentPanel.ResumeLayout(False)
        Me.container2.ContentPanel.PerformLayout()
        Me.container2.ResumeLayout(False)
        Me.container2.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents grb_anular As System.Windows.Forms.GroupBox
    Friend WithEvents container2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents llista_resta_productes As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_productes_no_espera As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents llista_productes_eliminar As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_anular As System.Windows.Forms.Label
    Friend WithEvents lbl_instr_anula As System.Windows.Forms.Label
    Friend WithEvents cb_llista_taules As System.Windows.Forms.ComboBox
End Class
