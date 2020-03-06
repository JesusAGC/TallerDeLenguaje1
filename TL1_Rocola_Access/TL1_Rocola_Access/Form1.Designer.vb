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
        Me.components = New System.ComponentModel.Container()
        Me.TL1_RocolaDataSet = New TL1_Rocola_Access.TL1_RocolaDataSet()
        Me.BTNCargarDatos = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BTNAnterior = New System.Windows.Forms.Button()
        Me.BTNSiguiente = New System.Windows.Forms.Button()
        Me.BTNUltimo = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CancionesTableAdapter = New TL1_Rocola_Access.TL1_RocolaDataSetTableAdapters.CancionesTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PICAlbumArt = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CancionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TL1_RocolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICAlbumArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TL1_RocolaDataSet
        '
        Me.TL1_RocolaDataSet.DataSetName = "TL1_RocolaDataSet"
        Me.TL1_RocolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNCargarDatos
        '
        Me.BTNCargarDatos.Location = New System.Drawing.Point(35, 397)
        Me.BTNCargarDatos.Name = "BTNCargarDatos"
        Me.BTNCargarDatos.Size = New System.Drawing.Size(75, 41)
        Me.BTNCargarDatos.TabIndex = 2
        Me.BTNCargarDatos.Text = "Cargar Datos"
        Me.BTNCargarDatos.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Location = New System.Drawing.Point(128, 397)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrimero.TabIndex = 3
        Me.BtnPrimero.Text = "Primero"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'BTNAnterior
        '
        Me.BTNAnterior.Location = New System.Drawing.Point(234, 397)
        Me.BTNAnterior.Name = "BTNAnterior"
        Me.BTNAnterior.Size = New System.Drawing.Size(75, 23)
        Me.BTNAnterior.TabIndex = 4
        Me.BTNAnterior.Text = "Anterior"
        Me.BTNAnterior.UseVisualStyleBackColor = True
        '
        'BTNSiguiente
        '
        Me.BTNSiguiente.Location = New System.Drawing.Point(346, 397)
        Me.BTNSiguiente.Name = "BTNSiguiente"
        Me.BTNSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.BTNSiguiente.TabIndex = 5
        Me.BTNSiguiente.Text = "Siguiente"
        Me.BTNSiguiente.UseVisualStyleBackColor = True
        '
        'BTNUltimo
        '
        Me.BTNUltimo.Location = New System.Drawing.Point(468, 397)
        Me.BTNUltimo.Name = "BTNUltimo"
        Me.BTNUltimo.Size = New System.Drawing.Size(75, 23)
        Me.BTNUltimo.TabIndex = 6
        Me.BTNUltimo.Text = "Ultimo"
        Me.BTNUltimo.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(576, 347)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(114, 73)
        Me.BTNSalir.TabIndex = 7
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(382, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Artista"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Album"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Genero"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Nombre", True))
        Me.TextBox1.Location = New System.Drawing.Point(457, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 20)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Artista", True))
        Me.TextBox2.Location = New System.Drawing.Point(457, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(265, 20)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Album", True))
        Me.TextBox3.Location = New System.Drawing.Point(457, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(265, 20)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Año", True))
        Me.TextBox4.Location = New System.Drawing.Point(457, 179)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(265, 20)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Genero", True))
        Me.TextBox5.Location = New System.Drawing.Point(457, 212)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(265, 20)
        Me.TextBox5.TabIndex = 17
        '
        'CancionesTableAdapter
        '
        Me.CancionesTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Seleccione su canción"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TL1_Rocola_Access.My.Resources.Resources.bluebanner
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(803, 63)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PICAlbumArt
        '
        Me.PICAlbumArt.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CancionesBindingSource, "Fotografia", True))
        Me.PICAlbumArt.Location = New System.Drawing.Point(64, 76)
        Me.PICAlbumArt.Name = "PICAlbumArt"
        Me.PICAlbumArt.Size = New System.Drawing.Size(245, 215)
        Me.PICAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICAlbumArt.TabIndex = 0
        Me.PICAlbumArt.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Portada"
        '
        'CancionesBindingSource
        '
        Me.CancionesBindingSource.DataMember = "Canciones"
        Me.CancionesBindingSource.DataSource = Me.TL1_RocolaDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.BTNUltimo)
        Me.Controls.Add(Me.BTNSiguiente)
        Me.Controls.Add(Me.BTNAnterior)
        Me.Controls.Add(Me.BtnPrimero)
        Me.Controls.Add(Me.BTNCargarDatos)
        Me.Controls.Add(Me.PICAlbumArt)
        Me.Name = "Form1"
        Me.Text = "Rocola"
        CType(Me.TL1_RocolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICAlbumArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PICAlbumArt As PictureBox
    Friend WithEvents BTNCargarDatos As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents BTNAnterior As Button
    Friend WithEvents BTNSiguiente As Button
    Friend WithEvents BTNUltimo As Button
    Friend WithEvents BTNSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TL1_RocolaDataSet As TL1_RocolaDataSet
    Friend WithEvents CancionesTableAdapter As TL1_RocolaDataSetTableAdapters.CancionesTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CancionesBindingSource As BindingSource
End Class
