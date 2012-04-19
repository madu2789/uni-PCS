<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_Stock))
        Me.btn_compra_stock = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lv_plats = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_compra_stock
        '
        Me.btn_compra_stock.Location = New System.Drawing.Point(205, 297)
        Me.btn_compra_stock.Name = "btn_compra_stock"
        Me.btn_compra_stock.Size = New System.Drawing.Size(89, 35)
        Me.btn_compra_stock.TabIndex = 1
        Me.btn_compra_stock.Text = "Fixar Quantitat"
        Me.btn_compra_stock.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 282)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'lv_plats
        '
        Me.lv_plats.Location = New System.Drawing.Point(12, 12)
        Me.lv_plats.Name = "lv_plats"
        Me.lv_plats.Size = New System.Drawing.Size(181, 321)
        Me.lv_plats.TabIndex = 4
        Me.lv_plats.UseCompatibleStateImageBehavior = False
        Me.lv_plats.View = System.Windows.Forms.View.List
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Fet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Control_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 345)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lv_plats)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_compra_stock)
        Me.Name = "Control_Stock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular Compra"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_compra_stock As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lv_plats As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
