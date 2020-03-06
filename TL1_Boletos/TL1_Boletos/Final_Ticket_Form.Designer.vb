<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Final_Ticket_Form
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
        Me.PBXImagen_Final = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBNombre = New System.Windows.Forms.Label()
        Me.LBSexo = New System.Windows.Forms.Label()
        Me.LBEdad = New System.Windows.Forms.Label()
        Me.LBNumBoletos = New System.Windows.Forms.Label()
        Me.LBFechaDeSalida = New System.Windows.Forms.Label()
        Me.LBDestino = New System.Windows.Forms.Label()
        Me.LBPrecio = New System.Windows.Forms.Label()
        Me.LBTotal = New System.Windows.Forms.Label()
        Me.ExitB = New System.Windows.Forms.Button()
        CType(Me.PBXImagen_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBXImagen_Final
        '
        Me.PBXImagen_Final.Location = New System.Drawing.Point(452, 157)
        Me.PBXImagen_Final.Name = "PBXImagen_Final"
        Me.PBXImagen_Final.Size = New System.Drawing.Size(325, 195)
        Me.PBXImagen_Final.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXImagen_Final.TabIndex = 1
        Me.PBXImagen_Final.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TL1_Boletos.My.Resources.Images.gruposenda
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grupo Senda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Luis Echeverría y Libertad Sn, Bellavista, Saltillo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefóno: 01 844 417 2212 "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Edad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "No. Boletos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha de salida:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Destino:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Precio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Total:"
        '
        'LBNombre
        '
        Me.LBNombre.AutoSize = True
        Me.LBNombre.Location = New System.Drawing.Point(96, 176)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(19, 13)
        Me.LBNombre.TabIndex = 13
        Me.LBNombre.Text = "    "
        '
        'LBSexo
        '
        Me.LBSexo.AutoSize = True
        Me.LBSexo.Location = New System.Drawing.Point(96, 200)
        Me.LBSexo.Name = "LBSexo"
        Me.LBSexo.Size = New System.Drawing.Size(16, 13)
        Me.LBSexo.TabIndex = 14
        Me.LBSexo.Text = "   "
        '
        'LBEdad
        '
        Me.LBEdad.AutoSize = True
        Me.LBEdad.Location = New System.Drawing.Point(96, 222)
        Me.LBEdad.Name = "LBEdad"
        Me.LBEdad.Size = New System.Drawing.Size(16, 13)
        Me.LBEdad.TabIndex = 15
        Me.LBEdad.Text = "   "
        '
        'LBNumBoletos
        '
        Me.LBNumBoletos.AutoSize = True
        Me.LBNumBoletos.Location = New System.Drawing.Point(110, 244)
        Me.LBNumBoletos.Name = "LBNumBoletos"
        Me.LBNumBoletos.Size = New System.Drawing.Size(16, 13)
        Me.LBNumBoletos.TabIndex = 16
        Me.LBNumBoletos.Text = "   "
        '
        'LBFechaDeSalida
        '
        Me.LBFechaDeSalida.AutoSize = True
        Me.LBFechaDeSalida.Location = New System.Drawing.Point(133, 268)
        Me.LBFechaDeSalida.Name = "LBFechaDeSalida"
        Me.LBFechaDeSalida.Size = New System.Drawing.Size(16, 13)
        Me.LBFechaDeSalida.TabIndex = 17
        Me.LBFechaDeSalida.Text = "   "
        '
        'LBDestino
        '
        Me.LBDestino.AutoSize = True
        Me.LBDestino.Location = New System.Drawing.Point(133, 290)
        Me.LBDestino.Name = "LBDestino"
        Me.LBDestino.Size = New System.Drawing.Size(16, 13)
        Me.LBDestino.TabIndex = 18
        Me.LBDestino.Text = "   "
        '
        'LBPrecio
        '
        Me.LBPrecio.AutoSize = True
        Me.LBPrecio.Location = New System.Drawing.Point(133, 315)
        Me.LBPrecio.Name = "LBPrecio"
        Me.LBPrecio.Size = New System.Drawing.Size(16, 13)
        Me.LBPrecio.TabIndex = 19
        Me.LBPrecio.Text = "   "
        '
        'LBTotal
        '
        Me.LBTotal.AutoSize = True
        Me.LBTotal.Location = New System.Drawing.Point(133, 339)
        Me.LBTotal.Name = "LBTotal"
        Me.LBTotal.Size = New System.Drawing.Size(16, 13)
        Me.LBTotal.TabIndex = 20
        Me.LBTotal.Text = "   "
        '
        'ExitB
        '
        Me.ExitB.Location = New System.Drawing.Point(288, 390)
        Me.ExitB.Name = "ExitB"
        Me.ExitB.Size = New System.Drawing.Size(75, 23)
        Me.ExitB.TabIndex = 21
        Me.ExitB.Text = "Salir"
        Me.ExitB.UseVisualStyleBackColor = True
        '
        'Final_Ticket_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitB)
        Me.Controls.Add(Me.LBTotal)
        Me.Controls.Add(Me.LBPrecio)
        Me.Controls.Add(Me.LBDestino)
        Me.Controls.Add(Me.LBFechaDeSalida)
        Me.Controls.Add(Me.LBNumBoletos)
        Me.Controls.Add(Me.LBEdad)
        Me.Controls.Add(Me.LBSexo)
        Me.Controls.Add(Me.LBNombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBXImagen_Final)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Final_Ticket_Form"
        Me.Text = "Final_Ticket_Form"
        CType(Me.PBXImagen_Final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PBXImagen_Final As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LBNombre As Label
    Friend WithEvents LBSexo As Label
    Friend WithEvents LBEdad As Label
    Friend WithEvents LBNumBoletos As Label
    Friend WithEvents LBFechaDeSalida As Label
    Friend WithEvents LBDestino As Label
    Friend WithEvents LBPrecio As Label
    Friend WithEvents LBTotal As Label
    Friend WithEvents ExitB As Button
End Class
