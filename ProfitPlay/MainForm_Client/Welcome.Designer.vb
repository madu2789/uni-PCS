<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.lbl_welcome = New System.Windows.Forms.Label
        Me.btn_enter = New System.Windows.Forms.Button
        Me.gpb_empleat = New System.Windows.Forms.GroupBox
        Me.txtb_password = New System.Windows.Forms.TextBox
        Me.txtb_login = New System.Windows.Forms.TextBox
        Me.lbl_login = New System.Windows.Forms.Label
        Me.lbl_password = New System.Windows.Forms.Label
        Me.gpb_client = New System.Windows.Forms.GroupBox
        Me.num_comensals = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_nombre_mesa = New System.Windows.Forms.Label
        Me.txtb_nomTaula = New System.Windows.Forms.TextBox
        Me.lbl_benvinguts = New System.Windows.Forms.Label
        Me.lbl_bienvenidos = New System.Windows.Forms.Label
        Me.pcb_client = New System.Windows.Forms.PictureBox
        Me.pcb_empleat = New System.Windows.Forms.PictureBox
        Me.gpb_empleat.SuspendLayout()
        Me.gpb_client.SuspendLayout()
        CType(Me.num_comensals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_client, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_empleat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcome.Location = New System.Drawing.Point(372, 50)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(280, 65)
        Me.lbl_welcome.TabIndex = 0
        Me.lbl_welcome.Text = "Welcome!"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(558, 339)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(123, 36)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "Entra"
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'gpb_empleat
        '
        Me.gpb_empleat.Controls.Add(Me.txtb_password)
        Me.gpb_empleat.Controls.Add(Me.txtb_login)
        Me.gpb_empleat.Controls.Add(Me.lbl_login)
        Me.gpb_empleat.Controls.Add(Me.lbl_password)
        Me.gpb_empleat.Location = New System.Drawing.Point(68, 209)
        Me.gpb_empleat.Name = "gpb_empleat"
        Me.gpb_empleat.Size = New System.Drawing.Size(239, 155)
        Me.gpb_empleat.TabIndex = 2
        Me.gpb_empleat.TabStop = False
        Me.gpb_empleat.Text = "Empleat"
        Me.gpb_empleat.Visible = False
        '
        'txtb_password
        '
        Me.txtb_password.Location = New System.Drawing.Point(125, 84)
        Me.txtb_password.Name = "txtb_password"
        Me.txtb_password.Size = New System.Drawing.Size(100, 20)
        Me.txtb_password.TabIndex = 3
        '
        'txtb_login
        '
        Me.txtb_login.Location = New System.Drawing.Point(125, 34)
        Me.txtb_login.Name = "txtb_login"
        Me.txtb_login.Size = New System.Drawing.Size(100, 20)
        Me.txtb_login.TabIndex = 2
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(25, 37)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(33, 13)
        Me.lbl_login.TabIndex = 0
        Me.lbl_login.Text = "Login"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(25, 87)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(53, 13)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Password"
        '
        'gpb_client
        '
        Me.gpb_client.Controls.Add(Me.num_comensals)
        Me.gpb_client.Controls.Add(Me.Label4)
        Me.gpb_client.Controls.Add(Me.lbl_nombre_mesa)
        Me.gpb_client.Controls.Add(Me.txtb_nomTaula)
        Me.gpb_client.Location = New System.Drawing.Point(68, 38)
        Me.gpb_client.Name = "gpb_client"
        Me.gpb_client.Size = New System.Drawing.Size(239, 129)
        Me.gpb_client.TabIndex = 3
        Me.gpb_client.TabStop = False
        Me.gpb_client.Text = "Client"
        '
        'num_comensals
        '
        Me.num_comensals.Location = New System.Drawing.Point(160, 77)
        Me.num_comensals.Name = "num_comensals"
        Me.num_comensals.Size = New System.Drawing.Size(61, 20)
        Me.num_comensals.TabIndex = 6
        Me.num_comensals.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número de comensales?"
        '
        'lbl_nombre_mesa
        '
        Me.lbl_nombre_mesa.AutoSize = True
        Me.lbl_nombre_mesa.Location = New System.Drawing.Point(25, 31)
        Me.lbl_nombre_mesa.Name = "lbl_nombre_mesa"
        Me.lbl_nombre_mesa.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre_mesa.TabIndex = 2
        Me.lbl_nombre_mesa.Text = "Nombre"
        '
        'txtb_nomTaula
        '
        Me.txtb_nomTaula.Location = New System.Drawing.Point(121, 31)
        Me.txtb_nomTaula.Name = "txtb_nomTaula"
        Me.txtb_nomTaula.Size = New System.Drawing.Size(100, 20)
        Me.txtb_nomTaula.TabIndex = 4
        '
        'lbl_benvinguts
        '
        Me.lbl_benvinguts.AutoSize = True
        Me.lbl_benvinguts.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_benvinguts.Location = New System.Drawing.Point(372, 123)
        Me.lbl_benvinguts.Name = "lbl_benvinguts"
        Me.lbl_benvinguts.Size = New System.Drawing.Size(334, 65)
        Me.lbl_benvinguts.TabIndex = 4
        Me.lbl_benvinguts.Text = "Benvinguts!"
        '
        'lbl_bienvenidos
        '
        Me.lbl_bienvenidos.AutoSize = True
        Me.lbl_bienvenidos.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenidos.Location = New System.Drawing.Point(372, 197)
        Me.lbl_bienvenidos.Name = "lbl_bienvenidos"
        Me.lbl_bienvenidos.Size = New System.Drawing.Size(359, 65)
        Me.lbl_bienvenidos.TabIndex = 5
        Me.lbl_bienvenidos.Text = "Bienvenidos!"
        '
        'pcb_client
        '
        Me.pcb_client.Image = CType(resources.GetObject("pcb_client.Image"), System.Drawing.Image)
        Me.pcb_client.Location = New System.Drawing.Point(24, 197)
        Me.pcb_client.Name = "pcb_client"
        Me.pcb_client.Size = New System.Drawing.Size(324, 178)
        Me.pcb_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_client.TabIndex = 7
        Me.pcb_client.TabStop = False
        '
        'pcb_empleat
        '
        Me.pcb_empleat.Image = CType(resources.GetObject("pcb_empleat.Image"), System.Drawing.Image)
        Me.pcb_empleat.Location = New System.Drawing.Point(24, 15)
        Me.pcb_empleat.Name = "pcb_empleat"
        Me.pcb_empleat.Size = New System.Drawing.Size(324, 173)
        Me.pcb_empleat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_empleat.TabIndex = 8
        Me.pcb_empleat.TabStop = False
        Me.pcb_empleat.Visible = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(718, 405)
        Me.Controls.Add(Me.lbl_bienvenidos)
        Me.Controls.Add(Me.lbl_benvinguts)
        Me.Controls.Add(Me.gpb_client)
        Me.Controls.Add(Me.gpb_empleat)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.pcb_empleat)
        Me.Controls.Add(Me.pcb_client)
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benvinguda"
        Me.gpb_empleat.ResumeLayout(False)
        Me.gpb_empleat.PerformLayout()
        Me.gpb_client.ResumeLayout(False)
        Me.gpb_client.PerformLayout()
        CType(Me.num_comensals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_client, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_empleat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_welcome As System.Windows.Forms.Label
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents gpb_empleat As System.Windows.Forms.GroupBox
    Friend WithEvents gpb_client As System.Windows.Forms.GroupBox
    Friend WithEvents txtb_nomTaula As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre_mesa As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtb_password As System.Windows.Forms.TextBox
    Friend WithEvents txtb_login As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_login As System.Windows.Forms.Label
    Friend WithEvents lbl_benvinguts As System.Windows.Forms.Label
    Friend WithEvents lbl_bienvenidos As System.Windows.Forms.Label
    Friend WithEvents pcb_client As System.Windows.Forms.PictureBox
    Friend WithEvents pcb_empleat As System.Windows.Forms.PictureBox
    Friend WithEvents num_comensals As System.Windows.Forms.NumericUpDown

End Class
