<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform_client
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
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.wb_pantalla_principal = New System.Windows.Forms.WebBrowser
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.btn_jugar = New System.Windows.Forms.Button
        Me.btn_estat = New System.Windows.Forms.Button
        Me.pnl_plats.SuspendLayout()
        Me.pnl_estat.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_punts.Location = New System.Drawing.Point(341, 22)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(114, 31)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Punts:  "
        '
<<<<<<< .mine
=======
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = CType(resources.GetObject("btn_estat.Image"), System.Drawing.Image)
        Me.btn_estat.Location = New System.Drawing.Point(591, 12)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(55, 57)
        Me.btn_estat.TabIndex = 1
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'btn_Pagar
        '
        Me.btn_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pagar.Location = New System.Drawing.Point(-2, 157)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(135, 74)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar i sortir"
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'btn_jugar
        '
        Me.btn_jugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jugar.Location = New System.Drawing.Point(0, 96)
        Me.btn_jugar.Name = "btn_jugar"
        Me.btn_jugar.Size = New System.Drawing.Size(135, 55)
        Me.btn_jugar.TabIndex = 13
        Me.btn_jugar.Text = "Jugar"
        Me.btn_jugar.UseVisualStyleBackColor = True
        '
        'btn_veurecarta
        '
        Me.btn_veurecarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_veurecarta.Location = New System.Drawing.Point(0, 35)
        Me.btn_veurecarta.Name = "btn_veurecarta"
        Me.btn_veurecarta.Size = New System.Drawing.Size(135, 55)
        Me.btn_veurecarta.TabIndex = 11
        Me.btn_veurecarta.Text = "Veure Carta"
        Me.btn_veurecarta.UseVisualStyleBackColor = True
        '
>>>>>>> .r53
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkBlue
        Me.pnl_plats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_plats.Controls.Add(Me.btn_menu_anular)
        Me.pnl_plats.Controls.Add(Me.btn_veurecarta)
        Me.pnl_plats.Controls.Add(Me.btn_Pagar)
        Me.pnl_plats.Controls.Add(Me.btn_jugar)
        Me.pnl_plats.Location = New System.Drawing.Point(-1, -13)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(159, 473)
        Me.pnl_plats.TabIndex = 16
        '
<<<<<<< .mine
=======
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Location = New System.Drawing.Point(0, 278)
        Me.btn_menu_anular.Name = "btn_menu_anular"
        Me.btn_menu_anular.Size = New System.Drawing.Size(135, 85)
        Me.btn_menu_anular.TabIndex = 17
        Me.btn_menu_anular.Text = "Solicitar anular comanda"
        Me.btn_menu_anular.UseVisualStyleBackColor = True
        '
>>>>>>> .r53
        'lbl_taula
        '
        Me.lbl_taula.AutoSize = True
        Me.lbl_taula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_taula.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_taula.Location = New System.Drawing.Point(110, 21)
        Me.lbl_taula.Name = "lbl_taula"
        Me.lbl_taula.Size = New System.Drawing.Size(161, 31)
        Me.lbl_taula.TabIndex = 22
        Me.lbl_taula.Text = "Taula: XXX"
        '
        'pnl_estat
        '
        Me.pnl_estat.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnl_estat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Location = New System.Drawing.Point(133, -13)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(707, 69)
        Me.pnl_estat.TabIndex = 31
        '
        'wb_pantalla_principal
        '
        Me.wb_pantalla_principal.Location = New System.Drawing.Point(158, 62)
        Me.wb_pantalla_principal.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_pantalla_principal.Name = "wb_pantalla_principal"
        Me.wb_pantalla_principal.Size = New System.Drawing.Size(682, 398)
        Me.wb_pantalla_principal.TabIndex = 32
        Me.wb_pantalla_principal.Url = New System.Uri("http://www.restalo.es", System.UriKind.Absolute)
        Me.wb_pantalla_principal.WebBrowserShortcutsEnabled = False
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Image = Global.MainForm_Client.My.Resources.Resources.carta
        Me.btn_menu_anular.Location = New System.Drawing.Point(5, 371)
        Me.btn_menu_anular.Name = "btn_menu_anular"
        Me.btn_menu_anular.Size = New System.Drawing.Size(145, 95)
        Me.btn_menu_anular.TabIndex = 17
        Me.btn_menu_anular.Text = "Comanda"
        Me.btn_menu_anular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_menu_anular.UseVisualStyleBackColor = True
        '
        'btn_veurecarta
        '
        Me.btn_veurecarta.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_veurecarta.Image = Global.MainForm_Client.My.Resources.Resources.cubiertos
        Me.btn_veurecarta.Location = New System.Drawing.Point(4, 68)
        Me.btn_veurecarta.Name = "btn_veurecarta"
        Me.btn_veurecarta.Size = New System.Drawing.Size(145, 95)
        Me.btn_veurecarta.TabIndex = 11
        Me.btn_veurecarta.Text = "Veure Carta"
        Me.btn_veurecarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_veurecarta.UseVisualStyleBackColor = True
        '
        'btn_Pagar
        '
        Me.btn_Pagar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pagar.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_Pagar.Location = New System.Drawing.Point(4, 270)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(145, 95)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar i sortir"
        Me.btn_Pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'btn_jugar
        '
        Me.btn_jugar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jugar.Image = Global.MainForm_Client.My.Resources.Resources.juego
        Me.btn_jugar.Location = New System.Drawing.Point(4, 169)
        Me.btn_jugar.Name = "btn_jugar"
        Me.btn_jugar.Size = New System.Drawing.Size(145, 95)
        Me.btn_jugar.TabIndex = 13
        Me.btn_jugar.Text = "Jugar"
        Me.btn_jugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_jugar.UseVisualStyleBackColor = True
        '
        'btn_estat
        '
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.juego_little
        Me.btn_estat.Location = New System.Drawing.Point(594, 13)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(88, 50)
        Me.btn_estat.TabIndex = 1
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'Mainform_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.wb_pantalla_principal)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.Name = "Mainform_client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mainform_client"
        Me.pnl_plats.ResumeLayout(False)
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents btn_jugar As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents wb_pantalla_principal As System.Windows.Forms.WebBrowser
End Class
