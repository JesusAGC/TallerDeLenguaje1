<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Detalles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTPDate1 = New System.Windows.Forms.DateTimePicker()
        Me.DTPDate2 = New System.Windows.Forms.DateTimePicker()
        Me.BTNEspecifico = New System.Windows.Forms.Button()
        Me.LBLBalance_Especifico = New System.Windows.Forms.Label()
        Me.LBLBalance_Total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CBODescGastos = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CantidadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.Detalles, Me.FechaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovimientoDTOBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1134, 452)
        Me.DataGridView1.TabIndex = 0
        '
        'Detalles
        '
        Me.Detalles.DataPropertyName = "Detalles"
        Me.Detalles.HeaderText = "Detalles"
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Width = 300
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(613, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Mostrar todos Los registros"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTPDate1
        '
        Me.DTPDate1.Location = New System.Drawing.Point(23, 540)
        Me.DTPDate1.Name = "DTPDate1"
        Me.DTPDate1.Size = New System.Drawing.Size(200, 20)
        Me.DTPDate1.TabIndex = 2
        '
        'DTPDate2
        '
        Me.DTPDate2.Location = New System.Drawing.Point(23, 578)
        Me.DTPDate2.Name = "DTPDate2"
        Me.DTPDate2.Size = New System.Drawing.Size(200, 20)
        Me.DTPDate2.TabIndex = 3
        '
        'BTNEspecifico
        '
        Me.BTNEspecifico.Location = New System.Drawing.Point(23, 642)
        Me.BTNEspecifico.Name = "BTNEspecifico"
        Me.BTNEspecifico.Size = New System.Drawing.Size(161, 23)
        Me.BTNEspecifico.TabIndex = 4
        Me.BTNEspecifico.Text = "Obtener datos entre fechas"
        Me.BTNEspecifico.UseVisualStyleBackColor = True
        '
        'LBLBalance_Especifico
        '
        Me.LBLBalance_Especifico.AutoSize = True
        Me.LBLBalance_Especifico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBalance_Especifico.Location = New System.Drawing.Point(300, 676)
        Me.LBLBalance_Especifico.Name = "LBLBalance_Especifico"
        Me.LBLBalance_Especifico.Size = New System.Drawing.Size(71, 24)
        Me.LBLBalance_Especifico.TabIndex = 6
        Me.LBLBalance_Especifico.Text = "$00.00"
        '
        'LBLBalance_Total
        '
        Me.LBLBalance_Total.AutoSize = True
        Me.LBLBalance_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBalance_Total.Location = New System.Drawing.Point(1088, 486)
        Me.LBLBalance_Total.Name = "LBLBalance_Total"
        Me.LBLBalance_Total.Size = New System.Drawing.Size(71, 24)
        Me.LBLBalance_Total.TabIndex = 7
        Me.LBLBalance_Total.Text = "$00.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 679)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Saldo entre las fechas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(811, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Saldo de todos los registros:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Año Actual"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(273, 575)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Mes Actual"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(382, 536)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Quincena 1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(382, 575)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Quincena 2"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 200
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'MovimientoDTOBindingSource
        '
        Me.MovimientoDTOBindingSource.DataSource = GetType(TL1_App1.DTO.MovimientoDTO)
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(613, 537)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(184, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "5 mayores gastos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(613, 579)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(184, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Gastos por descripcion"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'CBODescGastos
        '
        Me.CBODescGastos.FormattingEnabled = True
        Me.CBODescGastos.Location = New System.Drawing.Point(815, 579)
        Me.CBODescGastos.Name = "CBODescGastos"
        Me.CBODescGastos.Size = New System.Drawing.Size(234, 21)
        Me.CBODescGastos.TabIndex = 16
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 727)
        Me.Controls.Add(Me.CBODescGastos)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLBalance_Total)
        Me.Controls.Add(Me.LBLBalance_Especifico)
        Me.Controls.Add(Me.BTNEspecifico)
        Me.Controls.Add(Me.DTPDate2)
        Me.Controls.Add(Me.DTPDate1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Zona de consultas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents MovimientoDTOBindingSource As BindingSource
    Friend WithEvents DTPDate1 As DateTimePicker
    Friend WithEvents DTPDate2 As DateTimePicker
    Friend WithEvents BTNEspecifico As Button
    Friend WithEvents LBLBalance_Especifico As Label
    Friend WithEvents LBLBalance_Total As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Detalles As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents CBODescGastos As ComboBox
End Class
