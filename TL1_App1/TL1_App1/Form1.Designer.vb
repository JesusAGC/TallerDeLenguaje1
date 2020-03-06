<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TXBCantidadDeMovimiento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPGasto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txbfinal = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TXBDetallesMovimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBODescripcion = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXBCantidadDeMovimiento
        '
        Me.TXBCantidadDeMovimiento.Location = New System.Drawing.Point(95, 52)
        Me.TXBCantidadDeMovimiento.Name = "TXBCantidadDeMovimiento"
        Me.TXBCantidadDeMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.TXBCantidadDeMovimiento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'DTPGasto
        '
        Me.DTPGasto.Location = New System.Drawing.Point(126, 147)
        Me.DTPGasto.Name = "DTPGasto"
        Me.DTPGasto.Size = New System.Drawing.Size(200, 20)
        Me.DTPGasto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de Gasto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar Movimiento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBTipoMovimiento
        '
        Me.CBTipoMovimiento.FormattingEnabled = True
        Me.CBTipoMovimiento.Location = New System.Drawing.Point(95, 13)
        Me.CBTipoMovimiento.Name = "CBTipoMovimiento"
        Me.CBTipoMovimiento.Size = New System.Drawing.Size(121, 21)
        Me.CBTipoMovimiento.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tipo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(379, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 385)
        Me.DataGridView1.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(544, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Obtener saldo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txbfinal
        '
        Me.txbfinal.Enabled = False
        Me.txbfinal.Location = New System.Drawing.Point(215, 446)
        Me.txbfinal.Name = "txbfinal"
        Me.txbfinal.Size = New System.Drawing.Size(100, 20)
        Me.txbfinal.TabIndex = 22
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(500, 456)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Mostrar Registros"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(885, 456)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Salir de la app"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TXBDetallesMovimiento
        '
        Me.TXBDetallesMovimiento.Location = New System.Drawing.Point(95, 197)
        Me.TXBDetallesMovimiento.Multiline = True
        Me.TXBDetallesMovimiento.Name = "TXBDetallesMovimiento"
        Me.TXBDetallesMovimiento.Size = New System.Drawing.Size(252, 153)
        Me.TXBDetallesMovimiento.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Detalles"
        '
        'CBODescripcion
        '
        Me.CBODescripcion.FormattingEnabled = True
        Me.CBODescripcion.Location = New System.Drawing.Point(104, 95)
        Me.CBODescripcion.Name = "CBODescripcion"
        Me.CBODescripcion.Size = New System.Drawing.Size(222, 21)
        Me.CBODescripcion.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 491)
        Me.Controls.Add(Me.CBODescripcion)
        Me.Controls.Add(Me.TXBDetallesMovimiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txbfinal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CBTipoMovimiento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTPGasto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXBCantidadDeMovimiento)
        Me.Name = "Form1"
        Me.Text = "Zona de trabajo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXBCantidadDeMovimiento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPGasto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CBTipoMovimiento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txbfinal As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TXBDetallesMovimiento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBODescripcion As ComboBox
End Class
