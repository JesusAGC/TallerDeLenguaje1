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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBRangoDeEdad = New System.Windows.Forms.ComboBox()
        Me.TXBPeso = New System.Windows.Forms.TextBox()
        Me.TXBEstatura = New System.Windows.Forms.TextBox()
        Me.TXBNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBXMedicamentosP = New System.Windows.Forms.CheckBox()
        Me.CBXDrogas = New System.Windows.Forms.CheckBox()
        Me.CBXTabaco = New System.Windows.Forms.CheckBox()
        Me.CBXAlcohol = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LBNacionalidad = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estatura (En metros)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Peso (En kilogramos)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rango de Edad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBRangoDeEdad)
        Me.GroupBox1.Controls.Add(Me.TXBPeso)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXBEstatura)
        Me.GroupBox1.Controls.Add(Me.TXBNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 254)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del paciente"
        '
        'CBRangoDeEdad
        '
        Me.CBRangoDeEdad.FormattingEnabled = True
        Me.CBRangoDeEdad.Location = New System.Drawing.Point(18, 214)
        Me.CBRangoDeEdad.Name = "CBRangoDeEdad"
        Me.CBRangoDeEdad.Size = New System.Drawing.Size(164, 21)
        Me.CBRangoDeEdad.TabIndex = 6
        '
        'TXBPeso
        '
        Me.TXBPeso.Location = New System.Drawing.Point(18, 154)
        Me.TXBPeso.Name = "TXBPeso"
        Me.TXBPeso.Size = New System.Drawing.Size(164, 20)
        Me.TXBPeso.TabIndex = 8
        '
        'TXBEstatura
        '
        Me.TXBEstatura.Location = New System.Drawing.Point(18, 99)
        Me.TXBEstatura.Name = "TXBEstatura"
        Me.TXBEstatura.Size = New System.Drawing.Size(164, 20)
        Me.TXBEstatura.TabIndex = 7
        '
        'TXBNombre
        '
        Me.TXBNombre.Location = New System.Drawing.Point(18, 44)
        Me.TXBNombre.Name = "TXBNombre"
        Me.TXBNombre.Size = New System.Drawing.Size(164, 20)
        Me.TXBNombre.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 59)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mujer"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Hombre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBXMedicamentosP)
        Me.GroupBox3.Controls.Add(Me.CBXDrogas)
        Me.GroupBox3.Controls.Add(Me.CBXTabaco)
        Me.GroupBox3.Controls.Add(Me.CBXAlcohol)
        Me.GroupBox3.Location = New System.Drawing.Point(438, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 100)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "¿Usted consume alguna de estas sustancias?"
        '
        'CBXMedicamentosP
        '
        Me.CBXMedicamentosP.AutoSize = True
        Me.CBXMedicamentosP.Location = New System.Drawing.Point(144, 19)
        Me.CBXMedicamentosP.Name = "CBXMedicamentosP"
        Me.CBXMedicamentosP.Size = New System.Drawing.Size(149, 17)
        Me.CBXMedicamentosP.TabIndex = 3
        Me.CBXMedicamentosP.Text = "Medicamentos preescritos"
        Me.CBXMedicamentosP.UseVisualStyleBackColor = True
        '
        'CBXDrogas
        '
        Me.CBXDrogas.AutoSize = True
        Me.CBXDrogas.Location = New System.Drawing.Point(16, 65)
        Me.CBXDrogas.Name = "CBXDrogas"
        Me.CBXDrogas.Size = New System.Drawing.Size(57, 17)
        Me.CBXDrogas.TabIndex = 2
        Me.CBXDrogas.Text = "Dogas"
        Me.CBXDrogas.UseVisualStyleBackColor = True
        '
        'CBXTabaco
        '
        Me.CBXTabaco.AutoSize = True
        Me.CBXTabaco.Location = New System.Drawing.Point(16, 42)
        Me.CBXTabaco.Name = "CBXTabaco"
        Me.CBXTabaco.Size = New System.Drawing.Size(63, 17)
        Me.CBXTabaco.TabIndex = 1
        Me.CBXTabaco.Text = "Tabaco"
        Me.CBXTabaco.UseVisualStyleBackColor = True
        '
        'CBXAlcohol
        '
        Me.CBXAlcohol.AutoSize = True
        Me.CBXAlcohol.Location = New System.Drawing.Point(16, 19)
        Me.CBXAlcohol.Name = "CBXAlcohol"
        Me.CBXAlcohol.Size = New System.Drawing.Size(61, 17)
        Me.CBXAlcohol.TabIndex = 0
        Me.CBXAlcohol.Text = "Alcohol"
        Me.CBXAlcohol.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(515, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(515, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Calculador de Indice de Masa Corporal (IMC)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LBNacionalidad)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(249, 132)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nacionalidad"
        '
        'LBNacionalidad
        '
        Me.LBNacionalidad.FormattingEnabled = True
        Me.LBNacionalidad.Items.AddRange(New Object() {"Mexicana", "Estadounidense", "Española", "Inglesa"})
        Me.LBNacionalidad.Location = New System.Drawing.Point(6, 14)
        Me.LBNacionalidad.Name = "LBNacionalidad"
        Me.LBNacionalidad.Size = New System.Drawing.Size(237, 108)
        Me.LBNacionalidad.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBRangoDeEdad As ComboBox
    Friend WithEvents TXBPeso As TextBox
    Friend WithEvents TXBEstatura As TextBox
    Friend WithEvents TXBNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBXMedicamentosP As CheckBox
    Friend WithEvents CBXDrogas As CheckBox
    Friend WithEvents CBXTabaco As CheckBox
    Friend WithEvents CBXAlcohol As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LBNacionalidad As ListBox
End Class
