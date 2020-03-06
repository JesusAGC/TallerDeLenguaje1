<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgendaSQL
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
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TxtEmailTrabajo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEmailPersonal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTelCel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCalleYNumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Limpiar = New System.Windows.Forms.Button()
        Me.BTN_Buscar = New System.Windows.Forms.Button()
        Me.BTN_Agregar = New System.Windows.Forms.Button()
        Me.BTN_Modificar = New System.Windows.Forms.Button()
        Me.BTN_Eliminar = New System.Windows.Forms.Button()
        Me.BTM_CargarFoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(727, 79)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(257, 323)
        Me.PicFoto.TabIndex = 55
        Me.PicFoto.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(875, 520)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 54
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TxtEmailTrabajo
        '
        Me.TxtEmailTrabajo.Location = New System.Drawing.Point(256, 317)
        Me.TxtEmailTrabajo.Name = "TxtEmailTrabajo"
        Me.TxtEmailTrabajo.Size = New System.Drawing.Size(317, 20)
        Me.TxtEmailTrabajo.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(132, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Email del trabajo"
        '
        'TxtEmailPersonal
        '
        Me.TxtEmailPersonal.Location = New System.Drawing.Point(256, 291)
        Me.TxtEmailPersonal.Name = "TxtEmailPersonal"
        Me.TxtEmailPersonal.Size = New System.Drawing.Size(317, 20)
        Me.TxtEmailPersonal.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(132, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Email Personal"
        '
        'TxtTelCel
        '
        Me.TxtTelCel.Location = New System.Drawing.Point(256, 265)
        Me.TxtTelCel.Name = "TxtTelCel"
        Me.TxtTelCel.Size = New System.Drawing.Size(317, 20)
        Me.TxtTelCel.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Teléfono celular"
        '
        'TxtTelCasa
        '
        Me.TxtTelCasa.Location = New System.Drawing.Point(256, 239)
        Me.TxtTelCasa.Name = "TxtTelCasa"
        Me.TxtTelCasa.Size = New System.Drawing.Size(317, 20)
        Me.TxtTelCasa.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(132, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Teléfono de casa"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(256, 213)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(317, 20)
        Me.TxtCiudad.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Ciudad"
        '
        'TxtColonia
        '
        Me.TxtColonia.Location = New System.Drawing.Point(256, 187)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(317, 20)
        Me.TxtColonia.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Colonia"
        '
        'TxtCalleYNumero
        '
        Me.TxtCalleYNumero.Location = New System.Drawing.Point(256, 161)
        Me.TxtCalleYNumero.Name = "TxtCalleYNumero"
        Me.TxtCalleYNumero.Size = New System.Drawing.Size(317, 20)
        Me.TxtCalleYNumero.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Calle y Numero"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(256, 135)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(317, 20)
        Me.TxtApellido.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Apellido"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(256, 109)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(317, 20)
        Me.TxtNombre.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nombre"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(256, 83)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(317, 20)
        Me.TxtID.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID"
        '
        'BTN_Limpiar
        '
        Me.BTN_Limpiar.Location = New System.Drawing.Point(146, 467)
        Me.BTN_Limpiar.Name = "BTN_Limpiar"
        Me.BTN_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Limpiar.TabIndex = 56
        Me.BTN_Limpiar.Text = "Limpiar"
        Me.BTN_Limpiar.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Location = New System.Drawing.Point(227, 467)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 57
        Me.BTN_Buscar.Text = "Buscar"
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'BTN_Agregar
        '
        Me.BTN_Agregar.Location = New System.Drawing.Point(308, 467)
        Me.BTN_Agregar.Name = "BTN_Agregar"
        Me.BTN_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Agregar.TabIndex = 58
        Me.BTN_Agregar.Text = "Agregar"
        Me.BTN_Agregar.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Location = New System.Drawing.Point(389, 467)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Modificar.TabIndex = 59
        Me.BTN_Modificar.Text = "Modificar"
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.Location = New System.Drawing.Point(470, 467)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Eliminar.TabIndex = 60
        Me.BTN_Eliminar.Text = "Eliminar"
        Me.BTN_Eliminar.UseVisualStyleBackColor = True
        '
        'BTM_CargarFoto
        '
        Me.BTM_CargarFoto.Location = New System.Drawing.Point(821, 408)
        Me.BTM_CargarFoto.Name = "BTM_CargarFoto"
        Me.BTM_CargarFoto.Size = New System.Drawing.Size(75, 23)
        Me.BTM_CargarFoto.TabIndex = 62
        Me.BTM_CargarFoto.Text = "Cargar Foto"
        Me.BTM_CargarFoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\J Glezz\source\repos\Agend" &
    "aSQL_1\Agenda.mdb"""
        '
        'FrmAgendaSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 567)
        Me.Controls.Add(Me.BTM_CargarFoto)
        Me.Controls.Add(Me.BTN_Eliminar)
        Me.Controls.Add(Me.BTN_Modificar)
        Me.Controls.Add(Me.BTN_Agregar)
        Me.Controls.Add(Me.BTN_Buscar)
        Me.Controls.Add(Me.BTN_Limpiar)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TxtEmailTrabajo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtEmailPersonal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTelCel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTelCasa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtColonia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCalleYNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAgendaSQL"
        Me.Text = "Agenda"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents TxtEmailTrabajo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEmailPersonal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtTelCel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTelCasa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtColonia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCalleYNumero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Limpiar As Button
    Friend WithEvents BTN_Buscar As Button
    Friend WithEvents BTN_Agregar As Button
    Friend WithEvents BTN_Modificar As Button
    Friend WithEvents BTN_Eliminar As Button
    Friend WithEvents BTM_CargarFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Cnx As OleDb.OleDbConnection
End Class
