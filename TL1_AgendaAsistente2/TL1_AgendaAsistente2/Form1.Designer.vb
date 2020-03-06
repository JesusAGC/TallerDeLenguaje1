<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CalleYNumeroLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim TelCasaLabel As System.Windows.Forms.Label
        Dim TelCelLabel As System.Windows.Forms.Label
        Dim EmailPersonalLabel As System.Windows.Forms.Label
        Dim EmailTrabajoLabel As System.Windows.Forms.Label
        Me.AgendaDataSet = New TL1_AgendaAsistente2.AgendaDataSet()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaTableAdapter = New TL1_AgendaAsistente2.AgendaDataSetTableAdapters.personaTableAdapter()
        Me.TableAdapterManager = New TL1_AgendaAsistente2.AgendaDataSetTableAdapters.TableAdapterManager()
        Me.PersonaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PersonaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.CalleYNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.TelCasaTextBox = New System.Windows.Forms.TextBox()
        Me.TelCelTextBox = New System.Windows.Forms.TextBox()
        Me.EmailPersonalTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTrabajoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CalleYNumeroLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        TelCasaLabel = New System.Windows.Forms.Label()
        TelCelLabel = New System.Windows.Forms.Label()
        EmailPersonalLabel = New System.Windows.Forms.Label()
        EmailTrabajoLabel = New System.Windows.Forms.Label()
        CType(Me.AgendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonaBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AgendaDataSet
        '
        Me.AgendaDataSet.DataSetName = "AgendaDataSet"
        Me.AgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "persona"
        Me.PersonaBindingSource.DataSource = Me.AgendaDataSet
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.personaTableAdapter = Me.PersonaTableAdapter
        Me.TableAdapterManager.UpdateOrder = TL1_AgendaAsistente2.AgendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PersonaBindingNavigator
        '
        Me.PersonaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PersonaBindingNavigator.BindingSource = Me.PersonaBindingSource
        Me.PersonaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PersonaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PersonaBindingNavigatorSaveItem})
        Me.PersonaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonaBindingNavigator.Name = "PersonaBindingNavigator"
        Me.PersonaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonaBindingNavigator.Size = New System.Drawing.Size(1076, 25)
        Me.PersonaBindingNavigator.TabIndex = 0
        Me.PersonaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PersonaBindingNavigatorSaveItem
        '
        Me.PersonaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PersonaBindingNavigatorSaveItem.Image = CType(resources.GetObject("PersonaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PersonaBindingNavigatorSaveItem.Name = "PersonaBindingNavigatorSaveItem"
        Me.PersonaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PersonaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(37, 92)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(123, 89)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(266, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(37, 118)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(123, 115)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(266, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(37, 144)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "Apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(123, 141)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(266, 20)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'CalleYNumeroLabel
        '
        CalleYNumeroLabel.AutoSize = True
        CalleYNumeroLabel.Location = New System.Drawing.Point(37, 170)
        CalleYNumeroLabel.Name = "CalleYNumeroLabel"
        CalleYNumeroLabel.Size = New System.Drawing.Size(80, 13)
        CalleYNumeroLabel.TabIndex = 7
        CalleYNumeroLabel.Text = "Calle YNumero:"
        '
        'CalleYNumeroTextBox
        '
        Me.CalleYNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "CalleYNumero", True))
        Me.CalleYNumeroTextBox.Location = New System.Drawing.Point(123, 167)
        Me.CalleYNumeroTextBox.Name = "CalleYNumeroTextBox"
        Me.CalleYNumeroTextBox.Size = New System.Drawing.Size(266, 20)
        Me.CalleYNumeroTextBox.TabIndex = 8
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(37, 196)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 9
        ColoniaLabel.Text = "Colonia:"
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "Colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(123, 193)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(266, 20)
        Me.ColoniaTextBox.TabIndex = 10
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(37, 222)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 11
        CiudadLabel.Text = "Ciudad:"
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(123, 219)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(266, 20)
        Me.CiudadTextBox.TabIndex = 12
        '
        'TelCasaLabel
        '
        TelCasaLabel.AutoSize = True
        TelCasaLabel.Location = New System.Drawing.Point(37, 248)
        TelCasaLabel.Name = "TelCasaLabel"
        TelCasaLabel.Size = New System.Drawing.Size(52, 13)
        TelCasaLabel.TabIndex = 13
        TelCasaLabel.Text = "Tel Casa:"
        '
        'TelCasaTextBox
        '
        Me.TelCasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "TelCasa", True))
        Me.TelCasaTextBox.Location = New System.Drawing.Point(123, 245)
        Me.TelCasaTextBox.Name = "TelCasaTextBox"
        Me.TelCasaTextBox.Size = New System.Drawing.Size(266, 20)
        Me.TelCasaTextBox.TabIndex = 14
        '
        'TelCelLabel
        '
        TelCelLabel.AutoSize = True
        TelCelLabel.Location = New System.Drawing.Point(37, 274)
        TelCelLabel.Name = "TelCelLabel"
        TelCelLabel.Size = New System.Drawing.Size(43, 13)
        TelCelLabel.TabIndex = 15
        TelCelLabel.Text = "Tel Cel:"
        '
        'TelCelTextBox
        '
        Me.TelCelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "TelCel", True))
        Me.TelCelTextBox.Location = New System.Drawing.Point(123, 271)
        Me.TelCelTextBox.Name = "TelCelTextBox"
        Me.TelCelTextBox.Size = New System.Drawing.Size(266, 20)
        Me.TelCelTextBox.TabIndex = 16
        '
        'EmailPersonalLabel
        '
        EmailPersonalLabel.AutoSize = True
        EmailPersonalLabel.Location = New System.Drawing.Point(37, 300)
        EmailPersonalLabel.Name = "EmailPersonalLabel"
        EmailPersonalLabel.Size = New System.Drawing.Size(79, 13)
        EmailPersonalLabel.TabIndex = 17
        EmailPersonalLabel.Text = "Email Personal:"
        '
        'EmailPersonalTextBox
        '
        Me.EmailPersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "EmailPersonal", True))
        Me.EmailPersonalTextBox.Location = New System.Drawing.Point(123, 297)
        Me.EmailPersonalTextBox.Name = "EmailPersonalTextBox"
        Me.EmailPersonalTextBox.Size = New System.Drawing.Size(266, 20)
        Me.EmailPersonalTextBox.TabIndex = 18
        '
        'EmailTrabajoLabel
        '
        EmailTrabajoLabel.AutoSize = True
        EmailTrabajoLabel.Location = New System.Drawing.Point(37, 326)
        EmailTrabajoLabel.Name = "EmailTrabajoLabel"
        EmailTrabajoLabel.Size = New System.Drawing.Size(74, 13)
        EmailTrabajoLabel.TabIndex = 19
        EmailTrabajoLabel.Text = "Email Trabajo:"
        '
        'EmailTrabajoTextBox
        '
        Me.EmailTrabajoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "EmailTrabajo", True))
        Me.EmailTrabajoTextBox.Location = New System.Drawing.Point(123, 323)
        Me.EmailTrabajoTextBox.Name = "EmailTrabajoTextBox"
        Me.EmailTrabajoTextBox.Size = New System.Drawing.Size(266, 20)
        Me.EmailTrabajoTextBox.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PersonaBindingSource, "Fotografia", True))
        Me.PictureBox1.Location = New System.Drawing.Point(614, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 367)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cargar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(733, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 523)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(CalleYNumeroLabel)
        Me.Controls.Add(Me.CalleYNumeroTextBox)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(TelCasaLabel)
        Me.Controls.Add(Me.TelCasaTextBox)
        Me.Controls.Add(TelCelLabel)
        Me.Controls.Add(Me.TelCelTextBox)
        Me.Controls.Add(EmailPersonalLabel)
        Me.Controls.Add(Me.EmailPersonalTextBox)
        Me.Controls.Add(EmailTrabajoLabel)
        Me.Controls.Add(Me.EmailTrabajoTextBox)
        Me.Controls.Add(Me.PersonaBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AgendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonaBindingNavigator.ResumeLayout(False)
        Me.PersonaBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AgendaDataSet As AgendaDataSet
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As AgendaDataSetTableAdapters.personaTableAdapter
    Friend WithEvents TableAdapterManager As AgendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PersonaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents CalleYNumeroTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents TelCasaTextBox As TextBox
    Friend WithEvents TelCelTextBox As TextBox
    Friend WithEvents EmailPersonalTextBox As TextBox
    Friend WithEvents EmailTrabajoTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
