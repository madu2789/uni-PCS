<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compres_Pendents
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
        Me.lv_compres_espera = New System.Windows.Forms.ListView
        Me.lv_compres_rebudes = New System.Windows.Forms.ListView
        Me.btn_compres_fet = New System.Windows.Forms.Button
        Me.lbl_compres_espera = New System.Windows.Forms.Label
        Me.lbl_compres_rebudes = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lv_compres_espera
        '
        Me.lv_compres_espera.Location = New System.Drawing.Point(12, 54)
        Me.lv_compres_espera.Name = "lv_compres_espera"
        Me.lv_compres_espera.Size = New System.Drawing.Size(180, 220)
        Me.lv_compres_espera.TabIndex = 0
        Me.lv_compres_espera.UseCompatibleStateImageBehavior = False
        Me.lv_compres_espera.View = System.Windows.Forms.View.List
        '
        'lv_compres_rebudes
        '
        Me.lv_compres_rebudes.Location = New System.Drawing.Point(209, 54)
        Me.lv_compres_rebudes.Name = "lv_compres_rebudes"
        Me.lv_compres_rebudes.Size = New System.Drawing.Size(180, 220)
        Me.lv_compres_rebudes.TabIndex = 1
        Me.lv_compres_rebudes.UseCompatibleStateImageBehavior = False
        Me.lv_compres_rebudes.View = System.Windows.Forms.View.List
        '
        'btn_compres_fet
        '
        Me.btn_compres_fet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compres_fet.Location = New System.Drawing.Point(121, 292)
        Me.btn_compres_fet.Name = "btn_compres_fet"
        Me.btn_compres_fet.Size = New System.Drawing.Size(164, 41)
        Me.btn_compres_fet.TabIndex = 2
        Me.btn_compres_fet.Text = "Fet"
        Me.btn_compres_fet.UseVisualStyleBackColor = True
        '
        'lbl_compres_espera
        '
        Me.lbl_compres_espera.AutoSize = True
        Me.lbl_compres_espera.Location = New System.Drawing.Point(53, 21)
        Me.lbl_compres_espera.Name = "lbl_compres_espera"
        Me.lbl_compres_espera.Size = New System.Drawing.Size(99, 13)
        Me.lbl_compres_espera.TabIndex = 3
        Me.lbl_compres_espera.Text = "Compres en Espera"
        '
        'lbl_compres_rebudes
        '
        Me.lbl_compres_rebudes.AutoSize = True
        Me.lbl_compres_rebudes.Location = New System.Drawing.Point(246, 21)
        Me.lbl_compres_rebudes.Name = "lbl_compres_rebudes"
        Me.lbl_compres_rebudes.Size = New System.Drawing.Size(94, 13)
        Me.lbl_compres_rebudes.TabIndex = 4
        Me.lbl_compres_rebudes.Text = "Compres Rebudes"
        '
        'Compres_Pendents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 345)
        Me.Controls.Add(Me.lbl_compres_rebudes)
        Me.Controls.Add(Me.lbl_compres_espera)
        Me.Controls.Add(Me.btn_compres_fet)
        Me.Controls.Add(Me.lv_compres_rebudes)
        Me.Controls.Add(Me.lv_compres_espera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Compres_Pendents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compres_Pendents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_compres_espera As System.Windows.Forms.ListView
    Friend WithEvents lv_compres_rebudes As System.Windows.Forms.ListView
    Friend WithEvents btn_compres_fet As System.Windows.Forms.Button
    Friend WithEvents lbl_compres_espera As System.Windows.Forms.Label
    Friend WithEvents lbl_compres_rebudes As System.Windows.Forms.Label
End Class
