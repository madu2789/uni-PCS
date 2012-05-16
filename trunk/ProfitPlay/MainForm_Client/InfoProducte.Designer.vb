<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_producte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_producte))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.pnl_info_producte = New System.Windows.Forms.Panel
        Me.pcb_producte = New System.Windows.Forms.PictureBox
        Me.nud_cantitat = New System.Windows.Forms.NumericUpDown
        Me.lbl_cantitat = New System.Windows.Forms.Label
        Me.lbl_ingredients = New System.Windows.Forms.Label
        Me.lbl_descripcio = New System.Windows.Forms.Label
        Me.lbl_titol_producte = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnl_info_producte.SuspendLayout()
        CType(Me.pcb_producte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_cantitat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 317)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(531, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(337, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(122, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Afegir a la comanda"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(54, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(156, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar i tornar"
        '
        'pnl_info_producte
        '
        Me.pnl_info_producte.Controls.Add(Me.pcb_producte)
        Me.pnl_info_producte.Controls.Add(Me.nud_cantitat)
        Me.pnl_info_producte.Controls.Add(Me.lbl_cantitat)
        Me.pnl_info_producte.Controls.Add(Me.lbl_ingredients)
        Me.pnl_info_producte.Controls.Add(Me.lbl_descripcio)
        Me.pnl_info_producte.Controls.Add(Me.lbl_titol_producte)
        Me.pnl_info_producte.Location = New System.Drawing.Point(12, 12)
        Me.pnl_info_producte.Name = "pnl_info_producte"
        Me.pnl_info_producte.Size = New System.Drawing.Size(531, 299)
        Me.pnl_info_producte.TabIndex = 24
        '
        'pcb_producte
        '
        Me.pcb_producte.Image = CType(resources.GetObject("pcb_producte.Image"), System.Drawing.Image)
        Me.pcb_producte.Location = New System.Drawing.Point(258, 141)
        Me.pcb_producte.Name = "pcb_producte"
        Me.pcb_producte.Size = New System.Drawing.Size(263, 140)
        Me.pcb_producte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_producte.TabIndex = 14
        Me.pcb_producte.TabStop = False
        '
        'nud_cantitat
        '
        Me.nud_cantitat.Location = New System.Drawing.Point(123, 156)
        Me.nud_cantitat.Name = "nud_cantitat"
        Me.nud_cantitat.Size = New System.Drawing.Size(36, 20)
        Me.nud_cantitat.TabIndex = 13
        Me.nud_cantitat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_cantitat
        '
        Me.lbl_cantitat.AutoSize = True
        Me.lbl_cantitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantitat.Location = New System.Drawing.Point(26, 156)
        Me.lbl_cantitat.Name = "lbl_cantitat"
        Me.lbl_cantitat.Size = New System.Drawing.Size(63, 16)
        Me.lbl_cantitat.TabIndex = 10
        Me.lbl_cantitat.Text = "Quantitat:"
        '
        'lbl_ingredients
        '
        Me.lbl_ingredients.AutoSize = True
        Me.lbl_ingredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingredients.Location = New System.Drawing.Point(26, 107)
        Me.lbl_ingredients.Name = "lbl_ingredients"
        Me.lbl_ingredients.Size = New System.Drawing.Size(80, 16)
        Me.lbl_ingredients.TabIndex = 9
        Me.lbl_ingredients.Text = "Ingredients: "
        '
        'lbl_descripcio
        '
        Me.lbl_descripcio.AutoSize = True
        Me.lbl_descripcio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcio.Location = New System.Drawing.Point(10, 63)
        Me.lbl_descripcio.Name = "lbl_descripcio"
        Me.lbl_descripcio.Size = New System.Drawing.Size(272, 16)
        Me.lbl_descripcio.TabIndex = 8
        Me.lbl_descripcio.Text = "Descripció: Amb salsa bolonyesa i formatge"
        '
        'lbl_titol_producte
        '
        Me.lbl_titol_producte.AutoSize = True
        Me.lbl_titol_producte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titol_producte.Location = New System.Drawing.Point(3, 18)
        Me.lbl_titol_producte.Name = "lbl_titol_producte"
        Me.lbl_titol_producte.Size = New System.Drawing.Size(187, 20)
        Me.lbl_titol_producte.TabIndex = 7
        Me.lbl_titol_producte.Text = "Macarrons amb formatge"
        '
        'info_producte
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(555, 358)
        Me.Controls.Add(Me.pnl_info_producte)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "info_producte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informació del producte"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnl_info_producte.ResumeLayout(False)
        Me.pnl_info_producte.PerformLayout()
        CType(Me.pcb_producte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_cantitat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents pnl_info_producte As System.Windows.Forms.Panel
    Friend WithEvents pcb_producte As System.Windows.Forms.PictureBox
    Friend WithEvents nud_cantitat As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_cantitat As System.Windows.Forms.Label
    Friend WithEvents lbl_ingredients As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcio As System.Windows.Forms.Label
    Friend WithEvents lbl_titol_producte As System.Windows.Forms.Label

End Class
