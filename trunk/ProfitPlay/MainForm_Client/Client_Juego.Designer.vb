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
        Me.lbl_instr = New System.Windows.Forms.Label
        Me.btn_fica_punts = New System.Windows.Forms.Button
        Me.pnl_plats = New System.Windows.Forms.Panel
        Me.btn_menu_anular = New System.Windows.Forms.Button
        Me.btn_veurecarta = New System.Windows.Forms.Button
        Me.btn_Pagar = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.lbl_punts = New System.Windows.Forms.Label
        Me.lbl_taula = New System.Windows.Forms.Label
        Me.pnl_estat = New System.Windows.Forms.Panel
        Me.btn_estat = New System.Windows.Forms.Button
        Me.lbl_p1 = New System.Windows.Forms.Label
        Me.lbl_p2 = New System.Windows.Forms.Label
        Me.lbl_p3 = New System.Windows.Forms.Label
        Me.lbl_p4 = New System.Windows.Forms.Label
        Me.p1_a = New System.Windows.Forms.CheckBox
        Me.p1_b = New System.Windows.Forms.CheckBox
        Me.p2_b = New System.Windows.Forms.CheckBox
        Me.p2_a = New System.Windows.Forms.CheckBox
        Me.p3_b = New System.Windows.Forms.CheckBox
        Me.p3_a = New System.Windows.Forms.CheckBox
        Me.p4_b = New System.Windows.Forms.CheckBox
        Me.p4_a = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl_jocs.SuspendLayout()
        Me.pnl_plats.SuspendLayout()
        Me.pnl_estat.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_jocs
        '
        Me.pnl_jocs.BackColor = System.Drawing.Color.Firebrick
        Me.pnl_jocs.Controls.Add(Me.lbl_instr)
        Me.pnl_jocs.Controls.Add(Me.btn_fica_punts)
        Me.pnl_jocs.Location = New System.Drawing.Point(676, 49)
        Me.pnl_jocs.Name = "pnl_jocs"
        Me.pnl_jocs.Size = New System.Drawing.Size(164, 433)
        Me.pnl_jocs.TabIndex = 26
        '
        'lbl_instr
        '
        Me.lbl_instr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instr.Location = New System.Drawing.Point(8, 19)
        Me.lbl_instr.Name = "lbl_instr"
        Me.lbl_instr.Size = New System.Drawing.Size(148, 310)
        Me.lbl_instr.TabIndex = 28
        Me.lbl_instr.Text = "Respon a les preguntes que i prem el botó sumar punts." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Només podràs jugar un cop" & _
            " per cada vegada que vinguis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si encertes totes guanyaras un descompte." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_fica_punts
        '
        Me.btn_fica_punts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fica_punts.ForeColor = System.Drawing.Color.Blue
        Me.btn_fica_punts.Image = CType(resources.GetObject("btn_fica_punts.Image"), System.Drawing.Image)
        Me.btn_fica_punts.Location = New System.Drawing.Point(8, 332)
        Me.btn_fica_punts.Name = "btn_fica_punts"
        Me.btn_fica_punts.Size = New System.Drawing.Size(153, 85)
        Me.btn_fica_punts.TabIndex = 27
        Me.btn_fica_punts.Text = "Sumar punts"
        Me.btn_fica_punts.UseVisualStyleBackColor = True
        '
        'pnl_plats
        '
        Me.pnl_plats.BackColor = System.Drawing.Color.DarkBlue
        Me.pnl_plats.Controls.Add(Me.PictureBox1)
        Me.pnl_plats.Controls.Add(Me.btn_menu_anular)
        Me.pnl_plats.Controls.Add(Me.btn_veurecarta)
        Me.pnl_plats.Controls.Add(Me.btn_Pagar)
        Me.pnl_plats.Controls.Add(Me.Button3)
        Me.pnl_plats.Location = New System.Drawing.Point(-2, -11)
        Me.pnl_plats.Name = "pnl_plats"
        Me.pnl_plats.Size = New System.Drawing.Size(153, 493)
        Me.pnl_plats.TabIndex = 33
        '
        'btn_menu_anular
        '
        Me.btn_menu_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_anular.Image = Global.MainForm_Client.My.Resources.Resources.carta
        Me.btn_menu_anular.Location = New System.Drawing.Point(5, 382)
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
        Me.btn_veurecarta.Location = New System.Drawing.Point(5, 79)
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
        Me.btn_Pagar.Location = New System.Drawing.Point(5, 281)
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
        Me.Button3.Location = New System.Drawing.Point(5, 180)
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
        Me.lbl_punts.Location = New System.Drawing.Point(341, 29)
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
        Me.lbl_taula.Location = New System.Drawing.Point(111, 29)
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
        Me.pnl_estat.Location = New System.Drawing.Point(154, -20)
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
        'lbl_p1
        '
        Me.lbl_p1.AutoSize = True
        Me.lbl_p1.Location = New System.Drawing.Point(206, 68)
        Me.lbl_p1.Name = "lbl_p1"
        Me.lbl_p1.Size = New System.Drawing.Size(39, 13)
        Me.lbl_p1.TabIndex = 34
        Me.lbl_p1.Text = "Label1"
        '
        'lbl_p2
        '
        Me.lbl_p2.AutoSize = True
        Me.lbl_p2.Location = New System.Drawing.Point(206, 169)
        Me.lbl_p2.Name = "lbl_p2"
        Me.lbl_p2.Size = New System.Drawing.Size(39, 13)
        Me.lbl_p2.TabIndex = 35
        Me.lbl_p2.Text = "Label2"
        '
        'lbl_p3
        '
        Me.lbl_p3.AutoSize = True
        Me.lbl_p3.Location = New System.Drawing.Point(206, 270)
        Me.lbl_p3.Name = "lbl_p3"
        Me.lbl_p3.Size = New System.Drawing.Size(39, 13)
        Me.lbl_p3.TabIndex = 36
        Me.lbl_p3.Text = "Label3"
        '
        'lbl_p4
        '
        Me.lbl_p4.AutoSize = True
        Me.lbl_p4.Location = New System.Drawing.Point(206, 371)
        Me.lbl_p4.Name = "lbl_p4"
        Me.lbl_p4.Size = New System.Drawing.Size(39, 13)
        Me.lbl_p4.TabIndex = 37
        Me.lbl_p4.Text = "Label4"
        '
        'p1_a
        '
        Me.p1_a.AutoSize = True
        Me.p1_a.Location = New System.Drawing.Point(531, 88)
        Me.p1_a.Name = "p1_a"
        Me.p1_a.Size = New System.Drawing.Size(81, 17)
        Me.p1_a.TabIndex = 47
        Me.p1_a.Text = "CheckBox1"
        Me.p1_a.UseVisualStyleBackColor = True
        '
        'p1_b
        '
        Me.p1_b.AutoSize = True
        Me.p1_b.Location = New System.Drawing.Point(531, 111)
        Me.p1_b.Name = "p1_b"
        Me.p1_b.Size = New System.Drawing.Size(81, 17)
        Me.p1_b.TabIndex = 48
        Me.p1_b.Text = "CheckBox2"
        Me.p1_b.UseVisualStyleBackColor = True
        '
        'p2_b
        '
        Me.p2_b.AutoSize = True
        Me.p2_b.Location = New System.Drawing.Point(531, 212)
        Me.p2_b.Name = "p2_b"
        Me.p2_b.Size = New System.Drawing.Size(81, 17)
        Me.p2_b.TabIndex = 50
        Me.p2_b.Text = "CheckBox3"
        Me.p2_b.UseVisualStyleBackColor = True
        '
        'p2_a
        '
        Me.p2_a.AutoSize = True
        Me.p2_a.Location = New System.Drawing.Point(531, 189)
        Me.p2_a.Name = "p2_a"
        Me.p2_a.Size = New System.Drawing.Size(81, 17)
        Me.p2_a.TabIndex = 49
        Me.p2_a.Text = "CheckBox4"
        Me.p2_a.UseVisualStyleBackColor = True
        '
        'p3_b
        '
        Me.p3_b.AutoSize = True
        Me.p3_b.Location = New System.Drawing.Point(531, 313)
        Me.p3_b.Name = "p3_b"
        Me.p3_b.Size = New System.Drawing.Size(81, 17)
        Me.p3_b.TabIndex = 52
        Me.p3_b.Text = "CheckBox5"
        Me.p3_b.UseVisualStyleBackColor = True
        '
        'p3_a
        '
        Me.p3_a.AutoSize = True
        Me.p3_a.Location = New System.Drawing.Point(531, 290)
        Me.p3_a.Name = "p3_a"
        Me.p3_a.Size = New System.Drawing.Size(81, 17)
        Me.p3_a.TabIndex = 51
        Me.p3_a.Text = "CheckBox6"
        Me.p3_a.UseVisualStyleBackColor = True
        '
        'p4_b
        '
        Me.p4_b.AutoSize = True
        Me.p4_b.Location = New System.Drawing.Point(531, 414)
        Me.p4_b.Name = "p4_b"
        Me.p4_b.Size = New System.Drawing.Size(81, 17)
        Me.p4_b.TabIndex = 54
        Me.p4_b.Text = "CheckBox7"
        Me.p4_b.UseVisualStyleBackColor = True
        '
        'p4_a
        '
        Me.p4_a.AutoSize = True
        Me.p4_a.Location = New System.Drawing.Point(531, 391)
        Me.p4_a.Name = "p4_a"
        Me.p4_a.Size = New System.Drawing.Size(81, 17)
        Me.p4_a.TabIndex = 53
        Me.p4_a.Text = "CheckBox8"
        Me.p4_a.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Client_Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(844, 472)
        Me.Controls.Add(Me.p4_b)
        Me.Controls.Add(Me.p4_a)
        Me.Controls.Add(Me.p3_b)
        Me.Controls.Add(Me.p3_a)
        Me.Controls.Add(Me.p2_b)
        Me.Controls.Add(Me.p2_a)
        Me.Controls.Add(Me.p1_b)
        Me.Controls.Add(Me.p1_a)
        Me.Controls.Add(Me.lbl_p4)
        Me.Controls.Add(Me.lbl_p3)
        Me.Controls.Add(Me.lbl_p2)
        Me.Controls.Add(Me.lbl_p1)
        Me.Controls.Add(Me.pnl_plats)
        Me.Controls.Add(Me.pnl_estat)
        Me.Controls.Add(Me.pnl_jocs)
        Me.Name = "Client_Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.pnl_jocs.ResumeLayout(False)
        Me.pnl_plats.ResumeLayout(False)
        Me.pnl_estat.ResumeLayout(False)
        Me.pnl_estat.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_jocs As System.Windows.Forms.Panel
    Friend WithEvents btn_fica_punts As System.Windows.Forms.Button
    Friend WithEvents pnl_plats As System.Windows.Forms.Panel
    Friend WithEvents btn_menu_anular As System.Windows.Forms.Button
    Friend WithEvents btn_veurecarta As System.Windows.Forms.Button
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbl_punts As System.Windows.Forms.Label
    Friend WithEvents lbl_taula As System.Windows.Forms.Label
    Friend WithEvents pnl_estat As System.Windows.Forms.Panel
    Friend WithEvents btn_estat As System.Windows.Forms.Button
    Friend WithEvents lbl_p1 As System.Windows.Forms.Label
    Friend WithEvents lbl_p2 As System.Windows.Forms.Label
    Friend WithEvents lbl_p3 As System.Windows.Forms.Label
    Friend WithEvents lbl_p4 As System.Windows.Forms.Label
    Friend WithEvents p1_a As System.Windows.Forms.CheckBox
    Friend WithEvents p1_b As System.Windows.Forms.CheckBox
    Friend WithEvents p2_b As System.Windows.Forms.CheckBox
    Friend WithEvents p2_a As System.Windows.Forms.CheckBox
    Friend WithEvents p3_b As System.Windows.Forms.CheckBox
    Friend WithEvents p3_a As System.Windows.Forms.CheckBox
    Friend WithEvents p4_b As System.Windows.Forms.CheckBox
    Friend WithEvents p4_a As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_instr As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
