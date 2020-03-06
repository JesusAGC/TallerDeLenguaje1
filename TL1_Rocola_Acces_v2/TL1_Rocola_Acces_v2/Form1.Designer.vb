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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ArtistaLabel As System.Windows.Forms.Label
        Dim AlbumLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNCargarDatos = New System.Windows.Forms.Button()
        Me.PICAlbumArt = New System.Windows.Forms.PictureBox()
        Me.CancionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CancionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ArtistaTextBox = New System.Windows.Forms.TextBox()
        Me.AlbumTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.CancionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TL1_RocolaDataSet = New TL1_Rocola_Acces_v2.TL1_RocolaDataSet()
        Me.CancionesTableAdapter = New TL1_Rocola_Acces_v2.TL1_RocolaDataSetTableAdapters.CancionesTableAdapter()
        Me.TableAdapterManager = New TL1_Rocola_Acces_v2.TL1_RocolaDataSetTableAdapters.TableAdapterManager()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ArtistaLabel = New System.Windows.Forms.Label()
        AlbumLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICAlbumArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CancionesBindingNavigator.SuspendLayout()
        CType(Me.CancionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TL1_RocolaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 25)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Seleccione su canción"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TL1_Rocola_Acces_v2.My.Resources.Resources.bluebanner
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(803, 63)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(643, 351)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(114, 73)
        Me.BTNSalir.TabIndex = 27
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'BTNCargarDatos
        '
        Me.BTNCargarDatos.Location = New System.Drawing.Point(54, 367)
        Me.BTNCargarDatos.Name = "BTNCargarDatos"
        Me.BTNCargarDatos.Size = New System.Drawing.Size(126, 41)
        Me.BTNCargarDatos.TabIndex = 22
        Me.BTNCargarDatos.Text = "Cargar Datos"
        Me.BTNCargarDatos.UseVisualStyleBackColor = True
        '
        'PICAlbumArt
        '
        Me.PICAlbumArt.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CancionesBindingSource, "Fotografia", True))
        Me.PICAlbumArt.Location = New System.Drawing.Point(35, 97)
        Me.PICAlbumArt.Name = "PICAlbumArt"
        Me.PICAlbumArt.Size = New System.Drawing.Size(245, 215)
        Me.PICAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICAlbumArt.TabIndex = 21
        Me.PICAlbumArt.TabStop = False
        '
        'CancionesBindingNavigator
        '
        Me.CancionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CancionesBindingNavigator.BindingSource = Me.CancionesBindingSource
        Me.CancionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CancionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CancionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CancionesBindingNavigatorSaveItem})
        Me.CancionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CancionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CancionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CancionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CancionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CancionesBindingNavigator.Name = "CancionesBindingNavigator"
        Me.CancionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CancionesBindingNavigator.Size = New System.Drawing.Size(799, 25)
        Me.CancionesBindingNavigator.TabIndex = 40
        Me.CancionesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CancionesBindingNavigatorSaveItem
        '
        Me.CancionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CancionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CancionesBindingNavigatorSaveItem.Name = "CancionesBindingNavigatorSaveItem"
        Me.CancionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CancionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(339, 117)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 13)
        IdLabel.TabIndex = 40
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(442, 114)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(256, 20)
        Me.IdTextBox.TabIndex = 41
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(339, 143)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(54, 13)
        NombreLabel.TabIndex = 42
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(442, 140)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(256, 20)
        Me.NombreTextBox.TabIndex = 43
        '
        'ArtistaLabel
        '
        ArtistaLabel.AutoSize = True
        ArtistaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArtistaLabel.Location = New System.Drawing.Point(339, 169)
        ArtistaLabel.Name = "ArtistaLabel"
        ArtistaLabel.Size = New System.Drawing.Size(47, 13)
        ArtistaLabel.TabIndex = 44
        ArtistaLabel.Text = "Artista:"
        '
        'ArtistaTextBox
        '
        Me.ArtistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Artista", True))
        Me.ArtistaTextBox.Location = New System.Drawing.Point(442, 166)
        Me.ArtistaTextBox.Name = "ArtistaTextBox"
        Me.ArtistaTextBox.Size = New System.Drawing.Size(256, 20)
        Me.ArtistaTextBox.TabIndex = 45
        '
        'AlbumLabel
        '
        AlbumLabel.AutoSize = True
        AlbumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlbumLabel.Location = New System.Drawing.Point(339, 195)
        AlbumLabel.Name = "AlbumLabel"
        AlbumLabel.Size = New System.Drawing.Size(45, 13)
        AlbumLabel.TabIndex = 46
        AlbumLabel.Text = "Album:"
        '
        'AlbumTextBox
        '
        Me.AlbumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Album", True))
        Me.AlbumTextBox.Location = New System.Drawing.Point(442, 192)
        Me.AlbumTextBox.Name = "AlbumTextBox"
        Me.AlbumTextBox.Size = New System.Drawing.Size(256, 20)
        Me.AlbumTextBox.TabIndex = 47
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AñoLabel.Location = New System.Drawing.Point(339, 221)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(33, 13)
        AñoLabel.TabIndex = 48
        AñoLabel.Text = "Año:"
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(442, 218)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(256, 20)
        Me.AñoTextBox.TabIndex = 49
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GeneroLabel.Location = New System.Drawing.Point(339, 247)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(52, 13)
        GeneroLabel.TabIndex = 50
        GeneroLabel.Text = "Genero:"
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Genero", True))
        Me.GeneroTextBox.Location = New System.Drawing.Point(442, 244)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(256, 20)
        Me.GeneroTextBox.TabIndex = 51
        '
        'CancionesBindingSource
        '
        Me.CancionesBindingSource.DataMember = "Canciones"
        Me.CancionesBindingSource.DataSource = Me.TL1_RocolaDataSet
        '
        'TL1_RocolaDataSet
        '
        Me.TL1_RocolaDataSet.DataSetName = "TL1_RocolaDataSet"
        Me.TL1_RocolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CancionesTableAdapter
        '
        Me.CancionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionesTableAdapter = Me.CancionesTableAdapter
        Me.TableAdapterManager.UpdateOrder = TL1_Rocola_Acces_v2.TL1_RocolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 450)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ArtistaLabel)
        Me.Controls.Add(Me.ArtistaTextBox)
        Me.Controls.Add(AlbumLabel)
        Me.Controls.Add(Me.AlbumTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroTextBox)
        Me.Controls.Add(Me.CancionesBindingNavigator)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.BTNCargarDatos)
        Me.Controls.Add(Me.PICAlbumArt)
        Me.Name = "Form1"
        Me.Text = "Rocola"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICAlbumArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CancionesBindingNavigator.ResumeLayout(False)
        Me.CancionesBindingNavigator.PerformLayout()
        CType(Me.CancionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TL1_RocolaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNSalir As Button
    Friend WithEvents BTNCargarDatos As Button
    Friend WithEvents PICAlbumArt As PictureBox
    Friend WithEvents TL1_RocolaDataSet As TL1_RocolaDataSet
    Friend WithEvents CancionesBindingSource As BindingSource
    Friend WithEvents CancionesTableAdapter As TL1_RocolaDataSetTableAdapters.CancionesTableAdapter
    Friend WithEvents TableAdapterManager As TL1_RocolaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CancionesBindingNavigator As BindingNavigator
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
    Friend WithEvents CancionesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ArtistaTextBox As TextBox
    Friend WithEvents AlbumTextBox As TextBox
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents GeneroTextBox As TextBox
End Class
