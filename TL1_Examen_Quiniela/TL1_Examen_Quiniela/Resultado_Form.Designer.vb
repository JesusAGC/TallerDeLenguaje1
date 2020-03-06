<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultado_Form
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLResultado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLAciertos = New System.Windows.Forms.Label()
        Me.LBLTextoPremio = New System.Windows.Forms.Label()
        Me.LBLCantidadPremio = New System.Windows.Forms.Label()
        Me.picResultado = New System.Windows.Forms.PictureBox()
        Me.BTNSalida = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TL1_Examen_Quiniela.My.Resources.Resources.LIGAMX
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(639, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tu resultado es:"
        '
        'LBLResultado
        '
        Me.LBLResultado.AutoSize = True
        Me.LBLResultado.Location = New System.Drawing.Point(294, 208)
        Me.LBLResultado.Name = "LBLResultado"
        Me.LBLResultado.Size = New System.Drawing.Size(31, 15)
        Me.LBLResultado.TabIndex = 2
        Me.LBLResultado.Text = "........"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Aciertos:"
        '
        'LBLAciertos
        '
        Me.LBLAciertos.AutoSize = True
        Me.LBLAciertos.Location = New System.Drawing.Point(294, 246)
        Me.LBLAciertos.Name = "LBLAciertos"
        Me.LBLAciertos.Size = New System.Drawing.Size(31, 15)
        Me.LBLAciertos.TabIndex = 4
        Me.LBLAciertos.Text = "........"
        '
        'LBLTextoPremio
        '
        Me.LBLTextoPremio.AutoSize = True
        Me.LBLTextoPremio.Location = New System.Drawing.Point(183, 284)
        Me.LBLTextoPremio.Name = "LBLTextoPremio"
        Me.LBLTextoPremio.Size = New System.Drawing.Size(49, 15)
        Me.LBLTextoPremio.TabIndex = 5
        Me.LBLTextoPremio.Text = "              "
        '
        'LBLCantidadPremio
        '
        Me.LBLCantidadPremio.AutoSize = True
        Me.LBLCantidadPremio.Location = New System.Drawing.Point(294, 284)
        Me.LBLCantidadPremio.Name = "LBLCantidadPremio"
        Me.LBLCantidadPremio.Size = New System.Drawing.Size(61, 15)
        Me.LBLCantidadPremio.TabIndex = 6
        Me.LBLCantidadPremio.Text = "                  "
        '
        'picResultado
        '
        Me.picResultado.Location = New System.Drawing.Point(122, 321)
        Me.picResultado.Name = "picResultado"
        Me.picResultado.Size = New System.Drawing.Size(385, 194)
        Me.picResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picResultado.TabIndex = 7
        Me.picResultado.TabStop = False
        '
        'BTNSalida
        '
        Me.BTNSalida.Location = New System.Drawing.Point(252, 554)
        Me.BTNSalida.Name = "BTNSalida"
        Me.BTNSalida.Size = New System.Drawing.Size(87, 27)
        Me.BTNSalida.TabIndex = 8
        Me.BTNSalida.Text = "Salir"
        Me.BTNSalida.UseVisualStyleBackColor = True
        '
        'Resultado_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(635, 606)
        Me.Controls.Add(Me.BTNSalida)
        Me.Controls.Add(Me.picResultado)
        Me.Controls.Add(Me.LBLCantidadPremio)
        Me.Controls.Add(Me.LBLTextoPremio)
        Me.Controls.Add(Me.LBLAciertos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Resultado_Form"
        Me.Text = "Resultado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLResultado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLAciertos As Label
    Friend WithEvents LBLTextoPremio As Label
    Friend WithEvents LBLCantidadPremio As Label
    Friend WithEvents picResultado As PictureBox
    Friend WithEvents BTNSalida As Button
End Class
