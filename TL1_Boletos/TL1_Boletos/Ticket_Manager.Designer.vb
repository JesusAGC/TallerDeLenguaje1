<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket_Manager
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioBMujer = New System.Windows.Forms.RadioButton()
        Me.RadioBHombre = New System.Windows.Forms.RadioButton()
        Me.TXBNombre = New System.Windows.Forms.TextBox()
        Me.TXPApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TXBApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.CBXEstado = New System.Windows.Forms.ComboBox()
        Me.CBXMunicipio = New System.Windows.Forms.ComboBox()
        Me.TXBEdad = New System.Windows.Forms.TextBox()
        Me.CBXNumeroDeBoletos = New System.Windows.Forms.ComboBox()
        Me.DTPFechaDeSalida = New System.Windows.Forms.DateTimePicker()
        Me.BTTGenerarBoleto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PicBoxDestino = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBoxDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioBMujer)
        Me.GroupBox1.Controls.Add(Me.RadioBHombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'RadioBMujer
        '
        Me.RadioBMujer.AutoSize = True
        Me.RadioBMujer.Location = New System.Drawing.Point(7, 70)
        Me.RadioBMujer.Name = "RadioBMujer"
        Me.RadioBMujer.Size = New System.Drawing.Size(71, 24)
        Me.RadioBMujer.TabIndex = 1
        Me.RadioBMujer.Text = "Mujer"
        Me.RadioBMujer.UseVisualStyleBackColor = True
        '
        'RadioBHombre
        '
        Me.RadioBHombre.AutoSize = True
        Me.RadioBHombre.Checked = True
        Me.RadioBHombre.Location = New System.Drawing.Point(7, 35)
        Me.RadioBHombre.Name = "RadioBHombre"
        Me.RadioBHombre.Size = New System.Drawing.Size(90, 24)
        Me.RadioBHombre.TabIndex = 0
        Me.RadioBHombre.TabStop = True
        Me.RadioBHombre.Text = "Hombre"
        Me.RadioBHombre.UseVisualStyleBackColor = True
        '
        'TXBNombre
        '
        Me.TXBNombre.Location = New System.Drawing.Point(21, 41)
        Me.TXBNombre.Name = "TXBNombre"
        Me.TXBNombre.Size = New System.Drawing.Size(265, 20)
        Me.TXBNombre.TabIndex = 1
        '
        'TXPApellidoPaterno
        '
        Me.TXPApellidoPaterno.Location = New System.Drawing.Point(21, 92)
        Me.TXPApellidoPaterno.Name = "TXPApellidoPaterno"
        Me.TXPApellidoPaterno.Size = New System.Drawing.Size(265, 20)
        Me.TXPApellidoPaterno.TabIndex = 2
        '
        'TXBApellidoMaterno
        '
        Me.TXBApellidoMaterno.Location = New System.Drawing.Point(21, 150)
        Me.TXBApellidoMaterno.Name = "TXBApellidoMaterno"
        Me.TXBApellidoMaterno.Size = New System.Drawing.Size(265, 20)
        Me.TXBApellidoMaterno.TabIndex = 3
        '
        'CBXEstado
        '
        Me.CBXEstado.FormattingEnabled = True
        Me.CBXEstado.Items.AddRange(New Object() {"Coahuila", "Nuevo León"})
        Me.CBXEstado.Location = New System.Drawing.Point(472, 41)
        Me.CBXEstado.Name = "CBXEstado"
        Me.CBXEstado.Size = New System.Drawing.Size(171, 21)
        Me.CBXEstado.TabIndex = 4
        '
        'CBXMunicipio
        '
        Me.CBXMunicipio.FormattingEnabled = True
        Me.CBXMunicipio.Location = New System.Drawing.Point(472, 101)
        Me.CBXMunicipio.Name = "CBXMunicipio"
        Me.CBXMunicipio.Size = New System.Drawing.Size(171, 21)
        Me.CBXMunicipio.TabIndex = 5
        '
        'TXBEdad
        '
        Me.TXBEdad.Location = New System.Drawing.Point(205, 327)
        Me.TXBEdad.Name = "TXBEdad"
        Me.TXBEdad.Size = New System.Drawing.Size(81, 20)
        Me.TXBEdad.TabIndex = 6
        '
        'CBXNumeroDeBoletos
        '
        Me.CBXNumeroDeBoletos.FormattingEnabled = True
        Me.CBXNumeroDeBoletos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CBXNumeroDeBoletos.Location = New System.Drawing.Point(205, 365)
        Me.CBXNumeroDeBoletos.Name = "CBXNumeroDeBoletos"
        Me.CBXNumeroDeBoletos.Size = New System.Drawing.Size(81, 21)
        Me.CBXNumeroDeBoletos.TabIndex = 7
        '
        'DTPFechaDeSalida
        '
        Me.DTPFechaDeSalida.Location = New System.Drawing.Point(205, 406)
        Me.DTPFechaDeSalida.Name = "DTPFechaDeSalida"
        Me.DTPFechaDeSalida.Size = New System.Drawing.Size(298, 20)
        Me.DTPFechaDeSalida.TabIndex = 8
        '
        'BTTGenerarBoleto
        '
        Me.BTTGenerarBoleto.Location = New System.Drawing.Point(558, 386)
        Me.BTTGenerarBoleto.Name = "BTTGenerarBoleto"
        Me.BTTGenerarBoleto.Size = New System.Drawing.Size(184, 52)
        Me.BTTGenerarBoleto.TabIndex = 9
        Me.BTTGenerarBoleto.Text = "Generar Boleto"
        Me.BTTGenerarBoleto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(468, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Estado de destino"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(468, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Municipio de destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Edad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "No. Boletos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Fecha de salida"
        '
        'PicBoxDestino
        '
        Me.PicBoxDestino.Location = New System.Drawing.Point(472, 175)
        Me.PicBoxDestino.Name = "PicBoxDestino"
        Me.PicBoxDestino.Size = New System.Drawing.Size(297, 156)
        Me.PicBoxDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxDestino.TabIndex = 10
        Me.PicBoxDestino.TabStop = False
        '
        'Ticket_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBoxDestino)
        Me.Controls.Add(Me.BTTGenerarBoleto)
        Me.Controls.Add(Me.DTPFechaDeSalida)
        Me.Controls.Add(Me.CBXNumeroDeBoletos)
        Me.Controls.Add(Me.TXBEdad)
        Me.Controls.Add(Me.CBXMunicipio)
        Me.Controls.Add(Me.CBXEstado)
        Me.Controls.Add(Me.TXBApellidoMaterno)
        Me.Controls.Add(Me.TXPApellidoPaterno)
        Me.Controls.Add(Me.TXBNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ticket_Manager"
        Me.Text = "Ticket_Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicBoxDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXBNombre As TextBox
    Friend WithEvents TXPApellidoPaterno As TextBox
    Friend WithEvents TXBApellidoMaterno As TextBox
    Friend WithEvents CBXEstado As ComboBox
    Friend WithEvents CBXMunicipio As ComboBox
    Friend WithEvents RadioBMujer As RadioButton
    Friend WithEvents RadioBHombre As RadioButton
    Friend WithEvents TXBEdad As TextBox
    Friend WithEvents CBXNumeroDeBoletos As ComboBox
    Friend WithEvents DTPFechaDeSalida As DateTimePicker
    Friend WithEvents BTTGenerarBoleto As Button
    Friend WithEvents PicBoxDestino As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
