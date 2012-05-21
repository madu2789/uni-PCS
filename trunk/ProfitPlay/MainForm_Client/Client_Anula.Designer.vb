<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Anula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Anula))
        Me.grb_anular = New System.Windows.Forms.GroupBox
        Me.container2 = New System.Windows.Forms.ToolStripContainer
        Me.llista_resta_productes = New System.Windows.Forms.ToolStrip
        Me.lbl_productes_no_espera = New System.Windows.Forms.Label
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.llista_productes_eliminar = New System.Windows.Forms.ToolStrip
        Me.lbl_anular = New System.Windows.Forms.Label
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.btn_jugar = New System.Windows.Forms.Button
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.grb_anular.SuspendLayout()
        Me.container2.ContentPanel.SuspendLayout()
        Me.container2.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.pnl_plats.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_estat.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_anular
        '
        Me.grb_anular.Controls.Add(Me.container2)
        Me.grb_anular.Controls.Add(Me.lbl_productes_no_espera)
        Me.grb_anular.Controls.Add(Me.ToolStripContainer1)
        Me.grb_anular.Controls.Add(Me.lbl_anular)
        Me.grb_anular.Location = New System.Drawing.Point(178, 73)
        Me.grb_anular.Name = "grb_anular"
        Me.grb_anular.Size = New System.Drawing.Size(500, 382)
        Me.grb_anular.TabIndex = 33
        Me.grb_anular.TabStop = False
        Me.grb_anular.Text = "Anular"
        '
        'container2
        '
        '
        'container2.ContentPanel
        '
        Me.container2.ContentPanel.Controls.Add(Me.llista_resta_productes)
        Me.container2.ContentPanel.Size = New System.Drawing.Size(170, 294)
        Me.container2.Location = New System.Drawing.Point(288, 52)
        Me.container2.Name = "container2"
        Me.container2.Size = New System.Drawing.Size(170, 319)
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
        Me.llista_resta_productes.Size = New System.Drawing.Size(170, 294)
        Me.llista_resta_productes.TabIndex = 3
        Me.llista_resta_productes.Text = "ToolStrip1"
        '
        'lbl_productes_no_espera
        '
        Me.lbl_productes_no_espera.AutoSize = True
        Me.lbl_productes_no_espera.Location = New System.Drawing.Point(313, 23)
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(170, 294)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(54, 52)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(170, 319)
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
        Me.llista_productes_eliminar.Size = New System.Drawing.Size(170, 294)
        Me.llista_productes_eliminar.TabIndex = 2
        Me.llista_productes_eliminar.Text = "ToolStrip1"
        '
        'lbl_anular
        '
        Me.lbl_anular.AutoSize = True
        Me.lbl_anular.Location = New System.Drawing.Point(87, 23)
        Me.lbl_anular.Name = "lbl_anular"
        Me.lbl_anular.Size = New System.Drawing.Size(108, 13)
        Me.lbl_anular.TabIndex = 1
        Me.lbl_anular.Text = "Productes en espera:"
        '
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkBlue
        Me.pnl_plats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_plats.Controls.Add(Me.PictureBox1)
        Me.pnl_plats.Controls.Add(Me.btn_menu_anular)
        Me.pnl_plats.Controls.Add(Me.btn_veurecarta)
        Me.pnl_plats.Controls.Add(Me.btn_Pagar)
        Me.pnl_plats.Controls.Add(Me.btn_jugar)
        Me.pnl_plats.Location = New System.Drawing.Point(-8, -18)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(159, 473)
        Me.pnl_plats.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Image = Global.MainForm_Client.My.Resources.Resources.carta
        Me.btn_menu_anular.Location = New System.Drawing.Point(8, 371)
        Me.btn_menu_anular.Name = "btn_menu_anular"
        Me.btn_menu_anular.Size = New System.Drawing.Size(145, 95)
        Me.btn_menu_anular.TabIndex = 17
        Me.btn_menu_anular.Text = "Comanda"
        Me.btn_menu_anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_menu_anular.UseVisualStyleBackColor = True
        '
        'btn_veurecarta
        '
        Me.btn_veurecarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_veurecarta.Image = Global.MainForm_Client.My.Resources.Resources.cubiertos
        Me.btn_veurecarta.Location = New System.Drawing.Point(8, 77)
        Me.btn_veurecarta.Name = "btn_veurecarta"
        Me.btn_veurecarta.Size = New System.Drawing.Size(145, 95)
        Me.btn_veurecarta.TabIndex = 11
        Me.btn_veurecarta.Text = "Veure Carta"
        Me.btn_veurecarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_veurecarta.UseVisualStyleBackColor = True
        '
        'btn_Pagar
        '
        Me.btn_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pagar.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_Pagar.Location = New System.Drawing.Point(8, 273)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(145, 95)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar i sortir"
        Me.btn_Pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'btn_jugar
        '
        Me.btn_jugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jugar.Image = Global.MainForm_Client.My.Resources.Resources.juego
        Me.btn_jugar.Location = New System.Drawing.Point(8, 175)
        Me.btn_jugar.Name = "btn_jugar"
        Me.btn_jugar.Size = New System.Drawing.Size(145, 95)
        Me.btn_jugar.TabIndex = 13
        Me.btn_jugar.Text = "Jugar"
        Me.btn_jugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_jugar.UseVisualStyleBackColor = True
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnl_estat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Location = New System.Drawing.Point(126, -16)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(707, 83)
        Me.pnl_estat.TabIndex = 34
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(604, 4)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(96, 86)
        Me.btn_estat.TabIndex = 35
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_taula.Location = New System.Drawing.Point(99, 26)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(161, 31)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Taula: XXX"
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_punts.Location = New System.Drawing.Point(333, 26)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(106, 31)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Punts: "
        '
        'Client_Anula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.grb_anular)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Client_Anula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client_Anula"
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
        Me.pnl_plats.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_anular As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents llista_productes_eliminar As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_anular As System.Windows.Forms.Label
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents btn_jugar As System.Windows.Forms.Button
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents container2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents lbl_productes_no_espera As System.Windows.Forms.Label
    Friend WithEvents llista_resta_productes As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
