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
        Dim IdLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim DesarrolladorLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.BTN_Cargar = New System.Windows.Forms.Button()
        Me.VG_DBDataSet = New TL1_APP_Access_v2.VG_DBDataSet()
        Me.JuegosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuegosTableAdapter = New TL1_APP_Access_v2.VG_DBDataSetTableAdapters.JuegosTableAdapter()
        Me.TableAdapterManager = New TL1_APP_Access_v2.VG_DBDataSetTableAdapters.TableAdapterManager()
        Me.JuegosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.JuegosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.DesarrolladorTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        DesarrolladorLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VG_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuegosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuegosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JuegosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(37, 253)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 13)
        IdLabel.TabIndex = 76
        IdLabel.Text = "Id:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(37, 279)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(43, 13)
        TituloLabel.TabIndex = 78
        TituloLabel.Text = "Titulo:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(37, 305)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(52, 13)
        GeneroLabel.TabIndex = 80
        GeneroLabel.Text = "Genero:"
        '
        'DesarrolladorLabel
        '
        DesarrolladorLabel.AutoSize = True
        DesarrolladorLabel.Location = New System.Drawing.Point(37, 331)
        DesarrolladorLabel.Name = "DesarrolladorLabel"
        DesarrolladorLabel.Size = New System.Drawing.Size(86, 13)
        DesarrolladorLabel.TabIndex = 82
        DesarrolladorLabel.Text = "Desarrollador:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(37, 357)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(33, 13)
        AñoLabel.TabIndex = 84
        AñoLabel.Text = "Año:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TL1_APP_Access_v2.My.Resources.Resources.Blockbuster_logo_svg
        Me.PictureBox2.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(278, 132)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.JuegosBindingSource, "Portada", True))
        Me.PictureBox1.Location = New System.Drawing.Point(582, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 323)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(831, 534)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(101, 23)
        Me.BTN_Salir.TabIndex = 73
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Cargar
        '
        Me.BTN_Cargar.Location = New System.Drawing.Point(86, 534)
        Me.BTN_Cargar.Name = "BTN_Cargar"
        Me.BTN_Cargar.Size = New System.Drawing.Size(125, 23)
        Me.BTN_Cargar.TabIndex = 68
        Me.BTN_Cargar.Text = "Cargar Datos"
        Me.BTN_Cargar.UseVisualStyleBackColor = True
        '
        'VG_DBDataSet
        '
        Me.VG_DBDataSet.DataSetName = "VG_DBDataSet"
        Me.VG_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JuegosBindingSource
        '
        Me.JuegosBindingSource.DataMember = "Juegos"
        Me.JuegosBindingSource.DataSource = Me.VG_DBDataSet
        '
        'JuegosTableAdapter
        '
        Me.JuegosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JuegosTableAdapter = Me.JuegosTableAdapter
        Me.TableAdapterManager.UpdateOrder = TL1_APP_Access_v2.VG_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JuegosBindingNavigator
        '
        Me.JuegosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JuegosBindingNavigator.BindingSource = Me.JuegosBindingSource
        Me.JuegosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JuegosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JuegosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JuegosBindingNavigatorSaveItem})
        Me.JuegosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JuegosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JuegosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JuegosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JuegosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JuegosBindingNavigator.Name = "JuegosBindingNavigator"
        Me.JuegosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JuegosBindingNavigator.Size = New System.Drawing.Size(978, 25)
        Me.JuegosBindingNavigator.TabIndex = 76
        Me.JuegosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'JuegosBindingNavigatorSaveItem
        '
        Me.JuegosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JuegosBindingNavigatorSaveItem.Image = CType(resources.GetObject("JuegosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JuegosBindingNavigatorSaveItem.Name = "JuegosBindingNavigatorSaveItem"
        Me.JuegosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.JuegosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(128, 250)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(262, 20)
        Me.IdTextBox.TabIndex = 77
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(128, 276)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(262, 20)
        Me.TituloTextBox.TabIndex = 79
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Genero", True))
        Me.GeneroTextBox.Location = New System.Drawing.Point(128, 302)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(262, 20)
        Me.GeneroTextBox.TabIndex = 81
        '
        'DesarrolladorTextBox
        '
        Me.DesarrolladorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Desarrollador", True))
        Me.DesarrolladorTextBox.Location = New System.Drawing.Point(128, 328)
        Me.DesarrolladorTextBox.Name = "DesarrolladorTextBox"
        Me.DesarrolladorTextBox.Size = New System.Drawing.Size(262, 20)
        Me.DesarrolladorTextBox.TabIndex = 83
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JuegosBindingSource, "Año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(128, 354)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(262, 20)
        Me.AñoTextBox.TabIndex = 85
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(978, 580)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroTextBox)
        Me.Controls.Add(DesarrolladorLabel)
        Me.Controls.Add(Me.DesarrolladorTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(Me.JuegosBindingNavigator)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Cargar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Cátalogo de juegos"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VG_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuegosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuegosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JuegosBindingNavigator.ResumeLayout(False)
        Me.JuegosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents BTN_Cargar As Button
    Friend WithEvents VG_DBDataSet As VG_DBDataSet
    Friend WithEvents JuegosBindingSource As BindingSource
    Friend WithEvents JuegosTableAdapter As VG_DBDataSetTableAdapters.JuegosTableAdapter
    Friend WithEvents TableAdapterManager As VG_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JuegosBindingNavigator As BindingNavigator
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
    Friend WithEvents JuegosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents GeneroTextBox As TextBox
    Friend WithEvents DesarrolladorTextBox As TextBox
    Friend WithEvents AñoTextBox As TextBox
End Class
