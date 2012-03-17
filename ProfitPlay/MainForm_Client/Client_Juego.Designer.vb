<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Juego))
        Me.pnl_jocs = New System.Windows.Forms.Panel
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btn_donar = New System.Windows.Forms.Button
        Me.btn_demanar = New System.Windows.Forms.Button
        Me.grpb_menu_joc = New System.Windows.Forms.GroupBox
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.pnl_jocs.SuspendLayout()
        Me.grpb_menu_joc.SuspendLayout()
        Me.pnl_plats.SuspendLayout()
        Me.pnl_estat.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_jocs
        '
        Me.pnl_jocs.BackColor = System.Drawing.Color.Firebrick
        Me.pnl_jocs.Controls.Add(Me.Button4)
        Me.pnl_jocs.Controls.Add(Me.Button1)
        Me.pnl_jocs.Controls.Add(Me.Button2)
        Me.pnl_jocs.Location = New System.Drawing.Point(705, 37)
        Me.pnl_jocs.Name = "pnl_jocs"
        Me.pnl_jocs.Size = New System.Drawing.Size(135, 408)
        Me.pnl_jocs.TabIndex = 26
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(0, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 55)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Joc 1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 55)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Joc 3"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 55)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Joc 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_donar
        '
        Me.btn_donar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_donar.ForeColor = System.Drawing.Color.Blue
        Me.btn_donar.Image = CType(resources.GetObject("btn_donar.Image"), System.Drawing.Image)
        Me.btn_donar.Location = New System.Drawing.Point(40, 195)
        Me.btn_donar.Name = "btn_donar"
        Me.btn_donar.Size = New System.Drawing.Size(233, 99)
        Me.btn_donar.TabIndex = 29
        Me.btn_donar.Text = "Donar punts"
        Me.btn_donar.UseVisualStyleBackColor = True
        '
        'btn_demanar
        '
        Me.btn_demanar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_demanar.ForeColor = System.Drawing.Color.Blue
        Me.btn_demanar.Image = CType(resources.GetObject("btn_demanar.Image"), System.Drawing.Image)
        Me.btn_demanar.Location = New System.Drawing.Point(40, 58)
        Me.btn_demanar.Name = "btn_demanar"
        Me.btn_demanar.Size = New System.Drawing.Size(233, 99)
        Me.btn_demanar.TabIndex = 27
        Me.btn_demanar.Text = "Demanar ajuda"
        Me.btn_demanar.UseVisualStyleBackColor = True
        '
        'grpb_menu_joc
        '
        Me.grpb_menu_joc.Controls.Add(Me.btn_donar)
        Me.grpb_menu_joc.Controls.Add(Me.btn_demanar)
        Me.grpb_menu_joc.Location = New System.Drawing.Point(260, 83)
        Me.grpb_menu_joc.Name = "grpb_menu_joc"
        Me.grpb_menu_joc.Size = New System.Drawing.Size(305, 322)
        Me.grpb_menu_joc.TabIndex = 30
        Me.grpb_menu_joc.TabStop = False
        Me.grpb_menu_joc.Text = "Opcions joc"
        '
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkBlue
        Me.pnl_plats.Controls.Add(Me.btn_menu_anular)
        Me.pnl_plats.Controls.Add(Me.btn_veurecarta)
        Me.pnl_plats.Controls.Add(Me.btn_Pagar)
        Me.pnl_plats.Controls.Add(Me.Button3)
        Me.pnl_plats.Location = New System.Drawing.Point(-2, -19)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(153, 473)
        Me.pnl_plats.TabIndex = 33
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Image = Global.MainForm_Client.My.Resources.Resources.carta
        Me.btn_menu_anular.Location = New System.Drawing.Point(5, 375)
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
        Me.btn_veurecarta.Location = New System.Drawing.Point(5, 85)
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
        Me.btn_Pagar.Location = New System.Drawing.Point(5, 279)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(145, 95)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar i sortir"
        Me.btn_Pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.MainForm_Client.My.Resources.Resources.juego
        Me.Button3.Location = New System.Drawing.Point(5, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 95)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Jugar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbl_punts
        '
        Me.lbl_punts.AutoSize = True
        Me.lbl_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_punts.ForeColor = System.Drawing.Color.Magenta
        Me.lbl_punts.Location = New System.Drawing.Point(341, 22)
        Me.lbl_punts.Name = "lbl_punts"
        Me.lbl_punts.Size = New System.Drawing.Size(98, 31)
        Me.lbl_punts.TabIndex = 0
        Me.lbl_punts.Text = "Punts:"
        '
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
        Me.pnl_estat.Controls.Add(Me.btn_estat)
        Me.pnl_estat.Controls.Add(Me.lbl_taula)
        Me.pnl_estat.Controls.Add(Me.lbl_punts)
        Me.pnl_estat.Location = New System.Drawing.Point(154, -9)
        Me.pnl_estat.Name = "pnl_estat"
        Me.pnl_estat.Size = New System.Drawing.Size(686, 72)
        Me.pnl_estat.TabIndex = 32
        '
        'btn_estat
        '
        Me.btn_estat.AutoSize = True
        Me.btn_estat.Image = Global.MainForm_Client.My.Resources.Resources.cuenta
        Me.btn_estat.Location = New System.Drawing.Point(599, 3)
        Me.btn_estat.Name = "btn_estat"
        Me.btn_estat.Size = New System.Drawing.Size(88, 86)
        Me.btn_estat.TabIndex = 23
        Me.btn_estat.UseVisualStyleBackColor = True
        '
        'Client_Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.grpb_menu_joc)
        Me.Controls.Add(Me.pnl_estat)
        Me.Controls.Add(Me.pnl_jocs)
        Me.Name = "Client_Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.pnl_jocs.ResumeLayout(False)
        Me.grpb_menu_joc.ResumeLayout(False)
        Me.pnl_plats.ResumeLayout(False)
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_jocs As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_donar As System.Windows.Forms.Button
    Friend WithEvents btn_demanar As System.Windows.Forms.Button
    Friend WithEvents grpb_menu_joc As System.Windows.Forms.GroupBox
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents btn_estat As System.Windows.Forms.Button
End Class
