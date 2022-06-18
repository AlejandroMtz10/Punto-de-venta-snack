<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comidas
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
        Dim FolioCLabel As System.Windows.Forms.Label
        Dim ComidaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.ComidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComidasTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.comidasTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.ComidasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolioCTextBox = New System.Windows.Forms.TextBox()
        Me.ComidaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        FolioCLabel = New System.Windows.Forms.Label()
        ComidaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComidasBindingSource
        '
        Me.ComidasBindingSource.DataMember = "comidas"
        Me.ComidasBindingSource.DataSource = Me.SnackDataSet
        '
        'ComidasTableAdapter
        '
        Me.ComidasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Nothing
        Me.TableAdapterManager.BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.comidasTableAdapter = Me.ComidasTableAdapter
        Me.TableAdapterManager.estatusCajaTableAdapter = Nothing
        Me.TableAdapterManager.ingredientesTableAdapter = Nothing
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ComidasDataGridView
        '
        Me.ComidasDataGridView.AllowUserToAddRows = False
        Me.ComidasDataGridView.AllowUserToDeleteRows = False
        Me.ComidasDataGridView.AutoGenerateColumns = False
        Me.ComidasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ComidasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ComidasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComidasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ComidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComidasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ComidasDataGridView.DataSource = Me.ComidasBindingSource
        Me.ComidasDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.ComidasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ComidasDataGridView.Name = "ComidasDataGridView"
        Me.ComidasDataGridView.ReadOnly = True
        Me.ComidasDataGridView.Size = New System.Drawing.Size(355, 661)
        Me.ComidasDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FolioC"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio de la comida"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 89
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "comida"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Comida"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 78
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 71
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(415, 198)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(409, 140)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(206, 32)
        Label2.TabIndex = 28
        Label2.Text = "Buscar comida:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(455, 198)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(477, 35)
        Me.TxtBuscar.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(574, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 54)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Comidas"
        '
        'FolioCLabel
        '
        FolioCLabel.AutoSize = True
        FolioCLabel.BackColor = System.Drawing.Color.Transparent
        FolioCLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FolioCLabel.Location = New System.Drawing.Point(385, 304)
        FolioCLabel.Name = "FolioCLabel"
        FolioCLabel.Size = New System.Drawing.Size(239, 31)
        FolioCLabel.TabIndex = 30
        FolioCLabel.Text = "Folio de la comida:"
        '
        'FolioCTextBox
        '
        Me.FolioCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidasBindingSource, "FolioC", True))
        Me.FolioCTextBox.Enabled = False
        Me.FolioCTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolioCTextBox.Location = New System.Drawing.Point(391, 338)
        Me.FolioCTextBox.Name = "FolioCTextBox"
        Me.FolioCTextBox.Size = New System.Drawing.Size(401, 39)
        Me.FolioCTextBox.TabIndex = 31
        '
        'ComidaLabel
        '
        ComidaLabel.AutoSize = True
        ComidaLabel.BackColor = System.Drawing.Color.Transparent
        ComidaLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComidaLabel.Location = New System.Drawing.Point(385, 380)
        ComidaLabel.Name = "ComidaLabel"
        ComidaLabel.Size = New System.Drawing.Size(116, 31)
        ComidaLabel.TabIndex = 32
        ComidaLabel.Text = "Comida:"
        '
        'ComidaTextBox
        '
        Me.ComidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidasBindingSource, "comida", True))
        Me.ComidaTextBox.Enabled = False
        Me.ComidaTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComidaTextBox.Location = New System.Drawing.Point(391, 414)
        Me.ComidaTextBox.Name = "ComidaTextBox"
        Me.ComidaTextBox.Size = New System.Drawing.Size(401, 39)
        Me.ComidaTextBox.TabIndex = 33
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.BackColor = System.Drawing.Color.Transparent
        PrecioLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.Location = New System.Drawing.Point(385, 456)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(98, 31)
        PrecioLabel.TabIndex = 34
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidasBindingSource, "precio", True))
        Me.PrecioTextBox.Enabled = False
        Me.PrecioTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTextBox.Location = New System.Drawing.Point(391, 490)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(401, 39)
        Me.PrecioTextBox.TabIndex = 35
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.SnackPuntoVenta.My.Resources.Resources.arrow_return
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(868, 501)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(175, 64)
        Me.BtnRegresar.TabIndex = 52
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
        Me.BtnCancelar.Location = New System.Drawing.Point(868, 431)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(175, 64)
        Me.BtnCancelar.TabIndex = 51
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
        Me.BtnGuardar.Location = New System.Drawing.Point(868, 361)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(175, 64)
        Me.BtnGuardar.TabIndex = 50
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
        Me.BtnModificar.Location = New System.Drawing.Point(868, 291)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(175, 64)
        Me.BtnModificar.TabIndex = 49
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'Comidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Horizon
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(FolioCLabel)
        Me.Controls.Add(Me.FolioCTextBox)
        Me.Controls.Add(ComidaLabel)
        Me.Controls.Add(Me.ComidaTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComidasDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Comidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comidas"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents ComidasBindingSource As BindingSource
    Friend WithEvents ComidasTableAdapter As SnackDataSetTableAdapters.comidasTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComidasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FolioCTextBox As TextBox
    Friend WithEvents ComidaTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
End Class
