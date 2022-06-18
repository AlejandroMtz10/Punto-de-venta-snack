<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredientes
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
        Dim Label2 As System.Windows.Forms.Label
        Dim FolioILabel As System.Windows.Forms.Label
        Dim IngredienteLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim DisponiblesLabel As System.Windows.Forms.Label
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.IngredientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngredientesTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.ingredientesTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.IngredientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.FolioITextBox = New System.Windows.Forms.TextBox()
        Me.IngredienteTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DisponiblesTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        FolioILabel = New System.Windows.Forms.Label()
        IngredienteLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        DisponiblesLabel = New System.Windows.Forms.Label()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(749, 92)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(215, 26)
        Label2.TabIndex = 33
        Label2.Text = "Buscar ingrediente:"
        '
        'FolioILabel
        '
        FolioILabel.AutoSize = True
        FolioILabel.BackColor = System.Drawing.Color.Transparent
        FolioILabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FolioILabel.Location = New System.Drawing.Point(797, 204)
        FolioILabel.Name = "FolioILabel"
        FolioILabel.Size = New System.Drawing.Size(198, 24)
        FolioILabel.TabIndex = 23
        FolioILabel.Text = "Folio del ingrediente:"
        '
        'IngredienteLabel
        '
        IngredienteLabel.AutoSize = True
        IngredienteLabel.BackColor = System.Drawing.Color.Transparent
        IngredienteLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IngredienteLabel.Location = New System.Drawing.Point(797, 266)
        IngredienteLabel.Name = "IngredienteLabel"
        IngredienteLabel.Size = New System.Drawing.Size(118, 24)
        IngredienteLabel.TabIndex = 26
        IngredienteLabel.Text = "Ingrediente:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.BackColor = System.Drawing.Color.Transparent
        TipoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(797, 328)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(121, 24)
        TipoLabel.TabIndex = 28
        TipoLabel.Text = "Descripción:"
        '
        'DisponiblesLabel
        '
        DisponiblesLabel.AutoSize = True
        DisponiblesLabel.BackColor = System.Drawing.Color.Transparent
        DisponiblesLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DisponiblesLabel.Location = New System.Drawing.Point(797, 390)
        DisponiblesLabel.Name = "DisponiblesLabel"
        DisponiblesLabel.Size = New System.Drawing.Size(117, 24)
        DisponiblesLabel.TabIndex = 30
        DisponiblesLabel.Text = "Disponibles:"
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngredientesBindingSource
        '
        Me.IngredientesBindingSource.DataMember = "ingredientes"
        Me.IngredientesBindingSource.DataSource = Me.SnackDataSet
        '
        'IngredientesTableAdapter
        '
        Me.IngredientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Nothing
        Me.TableAdapterManager.BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.comidasTableAdapter = Nothing
        Me.TableAdapterManager.estatusCajaTableAdapter = Nothing
        Me.TableAdapterManager.ingredientesTableAdapter = Me.IngredientesTableAdapter
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'IngredientesDataGridView
        '
        Me.IngredientesDataGridView.AllowUserToAddRows = False
        Me.IngredientesDataGridView.AllowUserToDeleteRows = False
        Me.IngredientesDataGridView.AutoGenerateColumns = False
        Me.IngredientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.IngredientesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.IngredientesDataGridView.BackgroundColor = System.Drawing.Color.Coral
        Me.IngredientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IngredientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngredientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.IngredientesDataGridView.DataSource = Me.IngredientesBindingSource
        Me.IngredientesDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.IngredientesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.IngredientesDataGridView.Name = "IngredientesDataGridView"
        Me.IngredientesDataGridView.ReadOnly = True
        Me.IngredientesDataGridView.Size = New System.Drawing.Size(727, 631)
        Me.IngredientesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FolioI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio del alimento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 139
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ingrediente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ingrediente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 111
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 113
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "disponibles"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Disponibles"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 112
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(770, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(810, 144)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(427, 35)
        Me.TxtBuscar.TabIndex = 32
        '
        'FolioITextBox
        '
        Me.FolioITextBox.BackColor = System.Drawing.Color.White
        Me.FolioITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientesBindingSource, "FolioI", True))
        Me.FolioITextBox.Enabled = False
        Me.FolioITextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolioITextBox.Location = New System.Drawing.Point(822, 231)
        Me.FolioITextBox.Name = "FolioITextBox"
        Me.FolioITextBox.Size = New System.Drawing.Size(392, 32)
        Me.FolioITextBox.TabIndex = 25
        '
        'IngredienteTextBox
        '
        Me.IngredienteTextBox.BackColor = System.Drawing.Color.White
        Me.IngredienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientesBindingSource, "ingrediente", True))
        Me.IngredienteTextBox.Enabled = False
        Me.IngredienteTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredienteTextBox.Location = New System.Drawing.Point(822, 293)
        Me.IngredienteTextBox.Name = "IngredienteTextBox"
        Me.IngredienteTextBox.Size = New System.Drawing.Size(392, 32)
        Me.IngredienteTextBox.TabIndex = 27
        '
        'TipoTextBox
        '
        Me.TipoTextBox.BackColor = System.Drawing.Color.White
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientesBindingSource, "tipo", True))
        Me.TipoTextBox.Enabled = False
        Me.TipoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoTextBox.Location = New System.Drawing.Point(822, 355)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(392, 32)
        Me.TipoTextBox.TabIndex = 29
        '
        'DisponiblesTextBox
        '
        Me.DisponiblesTextBox.BackColor = System.Drawing.Color.White
        Me.DisponiblesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientesBindingSource, "disponibles", True))
        Me.DisponiblesTextBox.Enabled = False
        Me.DisponiblesTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisponiblesTextBox.Location = New System.Drawing.Point(822, 417)
        Me.DisponiblesTextBox.Name = "DisponiblesTextBox"
        Me.DisponiblesTextBox.Size = New System.Drawing.Size(392, 32)
        Me.DisponiblesTextBox.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(904, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 44)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ingredientes"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.SnackPuntoVenta.My.Resources.Resources.arrow_return
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(1039, 541)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(175, 64)
        Me.BtnRegresar.TabIndex = 56
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.SnackPuntoVenta.My.Resources.Resources.cancel_line
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(1039, 471)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(175, 64)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.SnackPuntoVenta.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(822, 541)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(175, 64)
        Me.BtnGuardar.TabIndex = 54
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.SnackPuntoVenta.My.Resources.Resources.edit
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(822, 471)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(175, 64)
        Me.BtnModificar.TabIndex = 53
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.ClientSize = New System.Drawing.Size(1284, 631)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(FolioILabel)
        Me.Controls.Add(Me.FolioITextBox)
        Me.Controls.Add(IngredienteLabel)
        Me.Controls.Add(Me.IngredienteTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(DisponiblesLabel)
        Me.Controls.Add(Me.DisponiblesTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IngredientesDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ingredientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredientes"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents IngredientesBindingSource As BindingSource
    Friend WithEvents IngredientesTableAdapter As SnackDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IngredientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents FolioITextBox As TextBox
    Friend WithEvents IngredienteTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents DisponiblesTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
End Class
