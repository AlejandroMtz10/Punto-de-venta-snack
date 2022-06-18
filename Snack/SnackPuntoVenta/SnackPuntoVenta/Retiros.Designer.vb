<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retiros
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
        Dim MontoActualLabel As System.Windows.Forms.Label
        Dim TipoRetiroLabel As System.Windows.Forms.Label
        Dim IdRetiroLabel As System.Windows.Forms.Label
        Dim IdRegistroLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim PersonaLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.RetirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetirosTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.RetirosTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.EstatusCajaTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.estatusCajaTableAdapter()
        Me.EstatusCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetirosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoActualTextBox = New System.Windows.Forms.TextBox()
        Me.TipoRetiroComboBox = New System.Windows.Forms.ComboBox()
        Me.IdRetiroTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PersonaTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        MontoActualLabel = New System.Windows.Forms.Label()
        TipoRetiroLabel = New System.Windows.Forms.Label()
        IdRetiroLabel = New System.Windows.Forms.Label()
        IdRegistroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        PersonaLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstatusCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetirosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MontoActualLabel
        '
        MontoActualLabel.AutoSize = True
        MontoActualLabel.BackColor = System.Drawing.Color.Transparent
        MontoActualLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        MontoActualLabel.Location = New System.Drawing.Point(753, 213)
        MontoActualLabel.Name = "MontoActualLabel"
        MontoActualLabel.Size = New System.Drawing.Size(226, 24)
        MontoActualLabel.TabIndex = 61
        MontoActualLabel.Text = "Monto actual de la caja:"
        '
        'TipoRetiroLabel
        '
        TipoRetiroLabel.AutoSize = True
        TipoRetiroLabel.BackColor = System.Drawing.Color.Transparent
        TipoRetiroLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoRetiroLabel.Location = New System.Drawing.Point(753, 553)
        TipoRetiroLabel.Name = "TipoRetiroLabel"
        TipoRetiroLabel.Size = New System.Drawing.Size(137, 24)
        TipoRetiroLabel.TabIndex = 59
        TipoRetiroLabel.Text = "Tipo de retiro:"
        '
        'IdRetiroLabel
        '
        IdRetiroLabel.AutoSize = True
        IdRetiroLabel.BackColor = System.Drawing.Color.Transparent
        IdRetiroLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdRetiroLabel.Location = New System.Drawing.Point(753, 264)
        IdRetiroLabel.Name = "IdRetiroLabel"
        IdRetiroLabel.Size = New System.Drawing.Size(148, 24)
        IdRetiroLabel.TabIndex = 49
        IdRetiroLabel.Text = "Folio del retiro:"
        '
        'IdRegistroLabel
        '
        IdRegistroLabel.AutoSize = True
        IdRegistroLabel.BackColor = System.Drawing.Color.Transparent
        IdRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdRegistroLabel.Location = New System.Drawing.Point(753, 310)
        IdRegistroLabel.Name = "IdRegistroLabel"
        IdRegistroLabel.Size = New System.Drawing.Size(172, 24)
        IdRegistroLabel.TabIndex = 51
        IdRegistroLabel.Text = "Folio del  registro:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(753, 346)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(73, 24)
        FechaLabel.TabIndex = 53
        FechaLabel.Text = "Fecha:"
        '
        'PersonaLabel
        '
        PersonaLabel.AutoSize = True
        PersonaLabel.BackColor = System.Drawing.Color.Transparent
        PersonaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PersonaLabel.Location = New System.Drawing.Point(753, 417)
        PersonaLabel.Name = "PersonaLabel"
        PersonaLabel.Size = New System.Drawing.Size(90, 24)
        PersonaLabel.TabIndex = 55
        PersonaLabel.Text = "Persona:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.BackColor = System.Drawing.Color.Transparent
        MontoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoLabel.Location = New System.Drawing.Point(753, 503)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(76, 24)
        MontoLabel.TabIndex = 57
        MontoLabel.Text = "Monto:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(732, 95)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(327, 32)
        Label2.TabIndex = 47
        Label2.Text = "Buscar retiro por su folio:"
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetirosBindingSource
        '
        Me.RetirosBindingSource.DataMember = "Retiros"
        Me.RetirosBindingSource.DataSource = Me.SnackDataSet
        '
        'RetirosTableAdapter
        '
        Me.RetirosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Nothing
        Me.TableAdapterManager.BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.comidasTableAdapter = Nothing
        Me.TableAdapterManager.estatusCajaTableAdapter = Me.EstatusCajaTableAdapter
        Me.TableAdapterManager.ingredientesTableAdapter = Nothing
        Me.TableAdapterManager.RetirosTableAdapter = Me.RetirosTableAdapter
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'EstatusCajaTableAdapter
        '
        Me.EstatusCajaTableAdapter.ClearBeforeFill = True
        '
        'EstatusCajaBindingSource
        '
        Me.EstatusCajaBindingSource.DataMember = "estatusCaja"
        Me.EstatusCajaBindingSource.DataSource = Me.SnackDataSet
        '
        'RetirosDataGridView
        '
        Me.RetirosDataGridView.AllowUserToAddRows = False
        Me.RetirosDataGridView.AllowUserToDeleteRows = False
        Me.RetirosDataGridView.AutoGenerateColumns = False
        Me.RetirosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RetirosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RetirosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RetirosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RetirosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RetirosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.RetirosDataGridView.DataSource = Me.RetirosBindingSource
        Me.RetirosDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.RetirosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.RetirosDataGridView.Name = "RetirosDataGridView"
        Me.RetirosDataGridView.ReadOnly = True
        Me.RetirosDataGridView.Size = New System.Drawing.Size(700, 761)
        Me.RetirosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idRetiro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio del retiro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idRegistro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio del registro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 112
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 64
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Persona"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Persona"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto retirado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 104
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tipoRetiro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo de retiro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 96
        '
        'MontoActualTextBox
        '
        Me.MontoActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "montoActual", True))
        Me.MontoActualTextBox.Enabled = False
        Me.MontoActualTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.MontoActualTextBox.Location = New System.Drawing.Point(985, 205)
        Me.MontoActualTextBox.Name = "MontoActualTextBox"
        Me.MontoActualTextBox.Size = New System.Drawing.Size(164, 32)
        Me.MontoActualTextBox.TabIndex = 62
        '
        'TipoRetiroComboBox
        '
        Me.TipoRetiroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirosBindingSource, "tipoRetiro", True))
        Me.TipoRetiroComboBox.Enabled = False
        Me.TipoRetiroComboBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoRetiroComboBox.FormattingEnabled = True
        Me.TipoRetiroComboBox.Items.AddRange(New Object() {"Retiro Final", "Retiro Parcial"})
        Me.TipoRetiroComboBox.Location = New System.Drawing.Point(925, 545)
        Me.TipoRetiroComboBox.Name = "TipoRetiroComboBox"
        Me.TipoRetiroComboBox.Size = New System.Drawing.Size(224, 32)
        Me.TipoRetiroComboBox.TabIndex = 60
        '
        'IdRetiroTextBox
        '
        Me.IdRetiroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirosBindingSource, "idRetiro", True))
        Me.IdRetiroTextBox.Enabled = False
        Me.IdRetiroTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdRetiroTextBox.Location = New System.Drawing.Point(925, 257)
        Me.IdRetiroTextBox.Name = "IdRetiroTextBox"
        Me.IdRetiroTextBox.Size = New System.Drawing.Size(224, 32)
        Me.IdRetiroTextBox.TabIndex = 50
        '
        'IdRegistroTextBox
        '
        Me.IdRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirosBindingSource, "idRegistro", True))
        Me.IdRegistroTextBox.Enabled = False
        Me.IdRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdRegistroTextBox.Location = New System.Drawing.Point(925, 303)
        Me.IdRegistroTextBox.Name = "IdRegistroTextBox"
        Me.IdRegistroTextBox.Size = New System.Drawing.Size(224, 32)
        Me.IdRegistroTextBox.TabIndex = 52
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RetirosBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(757, 371)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(392, 32)
        Me.FechaDateTimePicker.TabIndex = 54
        '
        'PersonaTextBox
        '
        Me.PersonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirosBindingSource, "Persona", True))
        Me.PersonaTextBox.Enabled = False
        Me.PersonaTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaTextBox.Location = New System.Drawing.Point(757, 442)
        Me.PersonaTextBox.Name = "PersonaTextBox"
        Me.PersonaTextBox.Size = New System.Drawing.Size(392, 32)
        Me.PersonaTextBox.TabIndex = 56
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RetirosBindingSource, "Monto", True))
        Me.MontoTextBox.Enabled = False
        Me.MontoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTextBox.Location = New System.Drawing.Point(925, 495)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(224, 32)
        Me.MontoTextBox.TabIndex = 58
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(738, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(778, 144)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(371, 35)
        Me.TxtBuscar.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(873, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 54)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Retiros"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.SnackPuntoVenta.My.Resources.Resources.arrow_return
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(951, 671)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(175, 64)
        Me.BtnRegresar.TabIndex = 68
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
        Me.BtnCancelar.Location = New System.Drawing.Point(770, 671)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(175, 64)
        Me.BtnCancelar.TabIndex = 67
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
        Me.BtnGuardar.Location = New System.Drawing.Point(951, 601)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(175, 64)
        Me.BtnGuardar.TabIndex = 66
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = Global.SnackPuntoVenta.My.Resources.Resources.agregar
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(770, 601)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(175, 64)
        Me.BtnAgregar.TabIndex = 65
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Retiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Horizon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1188, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(MontoActualLabel)
        Me.Controls.Add(Me.MontoActualTextBox)
        Me.Controls.Add(TipoRetiroLabel)
        Me.Controls.Add(Me.TipoRetiroComboBox)
        Me.Controls.Add(IdRetiroLabel)
        Me.Controls.Add(Me.IdRetiroTextBox)
        Me.Controls.Add(IdRegistroLabel)
        Me.Controls.Add(Me.IdRegistroTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(PersonaLabel)
        Me.Controls.Add(Me.PersonaTextBox)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.MontoTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RetirosDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Name = "Retiros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiros"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstatusCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetirosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents RetirosBindingSource As BindingSource
    Friend WithEvents RetirosTableAdapter As SnackDataSetTableAdapters.RetirosTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstatusCajaTableAdapter As SnackDataSetTableAdapters.estatusCajaTableAdapter
    Friend WithEvents EstatusCajaBindingSource As BindingSource
    Friend WithEvents RetirosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents MontoActualTextBox As TextBox
    Friend WithEvents TipoRetiroComboBox As ComboBox
    Friend WithEvents IdRetiroTextBox As TextBox
    Friend WithEvents IdRegistroTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents PersonaTextBox As TextBox
    Friend WithEvents MontoTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAgregar As Button
End Class
