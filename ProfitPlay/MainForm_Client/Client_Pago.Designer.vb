<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Pago))
        Me.btn_mixt = New System.Windows.Forms.Button
        Me.btn_efectiu = New System.Windows.Forms.Button
        Me.btn_tc = New System.Windows.Forms.Button
        Me.btn_previs = New System.Windows.Forms.Button
        Me.lbl_importtotal = New System.Windows.Forms.Label
        Me.lbl_importparcial = New System.Windows.Forms.Label
        Me.pnl_menu = New System.Windows.Forms.Panel
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.btn_jugar = New System.Windows.Forms.Button
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.pnl_menu.SuspendLayout()
        Me.pnl_estat.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_mixt
        '
        Me.btn_mixt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mixt.ForeColor = System.Drawing.Color.Yellow
        Me.btn_mixt.Image = CType(resources.GetObject("btn_mixt.Image"), System.Drawing.Image)
        Me.btn_mixt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_mixt.Location = New System.Drawing.Point(510, 165)
        Me.btn_mixt.Name = "btn_mixt"
        Me.btn_mixt.Size = New System.Drawing.Size(233, 77)
        Me.btn_mixt.TabIndex = 24
        Me.btn_mixt.Text = "Mixt"
        Me.btn_mixt.UseVisualStyleBackColor = True
        '
        'btn_efectiu
        '
        Me.btn_efectiu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_efectiu.ForeColor = System.Drawing.Color.Yellow
        Me.btn_efectiu.Image = CType(resources.GetObject("btn_efectiu.Image"), System.Drawing.Image)
        Me.btn_efectiu.Location = New System.Drawing.Point(187, 165)
        Me.btn_efectiu.Name = "btn_efectiu"
        Me.btn_efectiu.Size = New System.Drawing.Size(233, 77)
        Me.btn_efectiu.TabIndex = 22
        Me.btn_efectiu.Text = "Efectiu"
        Me.btn_efectiu.UseVisualStyleBackColor = True
        '
        'btn_tc
        '
        Me.btn_tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tc.ForeColor = System.Drawing.Color.Black
        Me.btn_tc.Image = CType(resources.GetObject("btn_tc.Image"), System.Drawing.Image)
        Me.btn_tc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tc.Location = New System.Drawing.Point(187, 293)
        Me.btn_tc.Name = "btn_tc"
        Me.btn_tc.Size = New System.Drawing.Size(233, 77)
        Me.btn_tc.TabIndex = 23
        Me.btn_tc.Text = "Targeta de crèdit"
        Me.btn_tc.UseVisualStyleBackColor = True
        '
        'btn_previs
        '
        Me.btn_previs.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previs.ForeColor = System.Drawing.Color.Indigo
        Me.btn_previs.Image = CType(resources.GetObject("btn_previs.Image"), System.Drawing.Image)
        Me.btn_previs.Location = New System.Drawing.Point(510, 293)
        Me.btn_previs.Name = "btn_previs"
        Me.btn_previs.Size = New System.Drawing.Size(233, 77)
        Me.btn_previs.TabIndex = 25
        Me.btn_previs.Text = "Previsualitzar factura"
        Me.btn_previs.UseVisualStyleBackColor = True
        '
        'lbl_importtotal
        '
        Me.lbl_importtotal.AutoSize = True
        Me.lbl_importtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importtotal.Location = New System.Drawing.Point(183, 96)
        Me.lbl_importtotal.Name = "lbl_importtotal"
        Me.lbl_importtotal.Size = New System.Drawing.Size(172, 25)
        Me.lbl_importtotal.TabIndex = 26
        Me.lbl_importtotal.Text = "Import total: XXX"
        '
        'lbl_importparcial
        '
        Me.lbl_importparcial.AutoSize = True
        Me.lbl_importparcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importparcial.Location = New System.Drawing.Point(506, 96)
        Me.lbl_importparcial.Name = "lbl_importparcial"
        Me.lbl_importparcial.Size = New System.Drawing.Size(246, 25)
        Me.lbl_importparcial.TabIndex = 27
        Me.lbl_importparcial.Text = "Import per persona: XXX"
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.DarkBlue
        Me.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_menu.Controls.Add(Me.btn_menu_anular)
        Me.pnl_menu.Controls.Add(Me.btn_veurecarta)
        Me.pnl_menu.Controls.Add(Me.btn_Pagar)
        Me.pnl_menu.Controls.Add(Me.btn_jugar)
        Me.pnl_menu.Location = New System.Drawing.Point(1, -10)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(159, 473)
        Me.pnl_menu.TabIndex = 29
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Image = Global.MainForm_Client.My.Resources.Resources.carta
        Me.btn_menu_anular.Location = New System.Drawing.Point(5, 368)
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
        Me.btn_veurecarta.Location = New System.Drawing.Point(5, 69)
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
        Me.btn_Pagar.Location = New System.Drawing.Point(5, 268)
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
        Me.btn_jugar.Location = New System.Drawing.Point(5, 168)
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
        Me.pnl_estat.Location = New System.Drawing.Point(134, -10)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(707, 76)
        Me.pnl_estat.TabIndex = 30
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(605, 7)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(105, 86)
        Me.btn_estat.TabIndex = 31
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_taula.Location = New System.Drawing.Point(122, 17)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(161, 31)
        Me.lbl_taula.TabIndex = 30
        Me.lbl_taula.Text = "Taula: XXX"
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_punts.Location = New System.Drawing.Point(369, 17)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(106, 31)
        Me.lbl_punts.TabIndex = 29
        Me.lbl_punts.Text = "Punts: "
        '
        'Client_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.pnl_menu)
        Me.Controls.Add(Me.pnl_estat)
        Me.Controls.Add(Me.lbl_importparcial)
        Me.Controls.Add(Me.lbl_importtotal)
        Me.Controls.Add(Me.btn_previs)
        Me.Controls.Add(Me.btn_mixt)
        Me.Controls.Add(Me.btn_efectiu)
        Me.Controls.Add(Me.btn_tc)
        Me.Name = "Client_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.pnl_menu.ResumeLayout(False)
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_mixt As System.Windows.Forms.Button
    Friend WithEvents btn_efectiu As System.Windows.Forms.Button
    Friend WithEvents btn_tc As System.Windows.Forms.Button
    Friend WithEvents btn_previs As System.Windows.Forms.Button
    Friend WithEvents lbl_importtotal As System.Windows.Forms.Label
    Friend WithEvents lbl_importparcial As System.Windows.Forms.Label
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents btn_jugar As System.Windows.Forms.Button
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents btn_estat As System.Windows.Forms.Button
End Class
