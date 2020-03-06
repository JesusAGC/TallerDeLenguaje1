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
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.BTN_Ultimo = New System.Windows.Forms.Button()
        Me.BTN_Siguiente = New System.Windows.Forms.Button()
        Me.BTN_Anterior = New System.Windows.Forms.Button()
        Me.BTN_Primero = New System.Windows.Forms.Button()
        Me.BTN_Cargar = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JuegosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VG_DBDataSet = New TL1_App_Access_v1.VG_DBDataSet()
        Me.JuegosTableAdapter = New TL1_App_Access_v1.VG_DBDataSetTableAdapters.JuegosTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.JuegosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VG_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(717, 487)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(87, 23)
        Me.BTN_Salir.TabIndex = 55
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Ultimo
        '
        Me.BTN_Ultimo.Location = New System.Drawing.Point(453, 487)
        Me.BTN_Ultimo.Name = "BTN_Ultimo"
        Me.BTN_Ultimo.Size = New System.Drawing.Size(87, 23)
        Me.BTN_Ultimo.TabIndex = 54
        Me.BTN_Ultimo.Text = "Ultimo"
        Me.BTN_Ultimo.UseVisualStyleBackColor = True
        '
        'BTN_Siguiente
        '
        Me.BTN_Siguiente.Location = New System.Drawing.Point(358, 487)
        Me.BTN_Siguiente.Name = "BTN_Siguiente"
        Me.BTN_Siguiente.Size = New System.Drawing.Size(87, 23)
        Me.BTN_Siguiente.TabIndex = 53
        Me.BTN_Siguiente.Text = "Siguiente"
        Me.BTN_Siguiente.UseVisualStyleBackColor = True
        '
        'BTN_Anterior
        '
        Me.BTN_Anterior.Location = New System.Drawing.Point(264, 487)
        Me.BTN_Anterior.Name = "BTN_Anterior"
        Me.BTN_Anterior.Size = New System.Drawing.Size(87, 23)
        Me.BTN_Anterior.TabIndex = 52
        Me.BTN_Anterior.Text = "Anterior"
        Me.BTN_Anterior.UseVisualStyleBackColor = True
        '
        'BTN_Primero
        '
        Me.BTN_Primero.Location = New System.Drawing.Point(169, 487)
        Me.BTN_Primero.Name = "BTN_Primero"
        Me.BTN_Primero.Size = New System.Drawing.Size(87, 23)
        Me.BTN_Primero.TabIndex = 51
        Me.BTN_Primero.Text = "Primero"
        Me.BTN_Primero.UseVisualStyleBackColor = True
        '
        'BTN_Cargar
        '
        Me.BTN_Cargar.Location = New System.Drawing.Point(55, 487)
        Me.BTN_Cargar.Name = "BTN_Cargar"
        Me.BTN_Cargar.Size = New System.Drawing.Size(107, 23)
        Me.BTN_Cargar.TabIndex = 50
        Me.BTN_Cargar.Text = "Cargar Datos"
        Me.BTN_Cargar.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Año", True))
        Me.TextBox5.Location = New System.Drawing.Point(188, 282)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(369, 20)
        Me.TextBox5.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Año"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Desarrollador", True))
        Me.TextBox4.Location = New System.Drawing.Point(188, 256)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(369, 20)
        Me.TextBox4.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Desarrollador"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Genero", True))
        Me.TextBox3.Location = New System.Drawing.Point(188, 230)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(369, 20)
        Me.TextBox3.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Género"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Titulo", True))
        Me.TextBox2.Location = New System.Drawing.Point(188, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(369, 20)
        Me.TextBox2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Título"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Id", True))
        Me.TextBox1.Location = New System.Drawing.Point(188, 178)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(369, 20)
        Me.TextBox1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID"
        '
        'JuegosBindingSource
        '
        Me.JuegosBindingSource.DataMember = "Juegos"
        Me.JuegosBindingSource.DataSource = Me.VG_DBDataSet
        '
        'VG_DBDataSet
        '
        Me.VG_DBDataSet.DataSetName = "VG_DBDataSet"
        Me.VG_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JuegosTableAdapter
        '
        Me.JuegosTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TL1_App_Access_v1.My.Resources.Resources.Blockbuster_logo_svg
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(365, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.JuegosBindingSource, "Portada", True))
        Me.PictureBox1.Location = New System.Drawing.Point(765, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 323)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1120, 553)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Ultimo)
        Me.Controls.Add(Me.BTN_Siguiente)
        Me.Controls.Add(Me.BTN_Anterior)
        Me.Controls.Add(Me.BTN_Primero)
        Me.Controls.Add(Me.BTN_Cargar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Cátalogo de juegos"
        CType(Me.JuegosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VG_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents BTN_Ultimo As Button
    Friend WithEvents BTN_Siguiente As Button
    Friend WithEvents BTN_Anterior As Button
    Friend WithEvents BTN_Primero As Button
    Friend WithEvents BTN_Cargar As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VG_DBDataSet As VG_DBDataSet
    Friend WithEvents JuegosBindingSource As BindingSource
    Friend WithEvents JuegosTableAdapter As VG_DBDataSetTableAdapters.JuegosTableAdapter
    Friend WithEvents PictureBox2 As PictureBox
End Class
