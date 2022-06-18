<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estatusCaja
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
        Dim IdRegistroLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NumeroCajaLabel As System.Windows.Forms.Label
        Dim MontoInicialLabel As System.Windows.Forms.Label
        Dim MontoActualLabel As System.Windows.Forms.Label
        Dim MontoFinal_generadoLabel As System.Windows.Forms.Label
        Dim AtendidaPorLabel As System.Windows.Forms.Label
        Dim RetirosPreviosLabel As System.Windows.Forms.Label
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.EstatusCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstatusCajaTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.estatusCajaTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.EstatusCajaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumeroCajaTextBox = New System.Windows.Forms.TextBox()
        Me.MontoInicialTextBox = New System.Windows.Forms.TextBox()
        Me.MontoActualTextBox = New System.Windows.Forms.TextBox()
        Me.MontoFinal_generadoTextBox = New System.Windows.Forms.TextBox()
        Me.AtendidaPorTextBox = New System.Windows.Forms.TextBox()
        Me.RetirosPreviosTextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        IdRegistroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NumeroCajaLabel = New System.Windows.Forms.Label()
        MontoInicialLabel = New System.Windows.Forms.Label()
        MontoActualLabel = New System.Windows.Forms.Label()
        MontoFinal_generadoLabel = New System.Windows.Forms.Label()
        AtendidaPorLabel = New System.Windows.Forms.Label()
        RetirosPreviosLabel = New System.Windows.Forms.Label()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstatusCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstatusCajaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(980, 98)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(219, 32)
        Label2.TabIndex = 32
        Label2.Text = "Buscar por folio:"
        '
        'IdRegistroLabel
        '
        IdRegistroLabel.AutoSize = True
        IdRegistroLabel.BackColor = System.Drawing.Color.Transparent
        IdRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdRegistroLabel.Location = New System.Drawing.Point(991, 227)
        IdRegistroLabel.Name = "IdRegistroLabel"
        IdRegistroLabel.Size = New System.Drawing.Size(150, 22)
        IdRegistroLabel.TabIndex = 45
        IdRegistroLabel.Text = "Folio de registro:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(991, 284)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(65, 22)
        FechaLabel.TabIndex = 47
        FechaLabel.Text = "Fecha:"
        '
        'NumeroCajaLabel
        '
        NumeroCajaLabel.AutoSize = True
        NumeroCajaLabel.BackColor = System.Drawing.Color.Transparent
        NumeroCajaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroCajaLabel.Location = New System.Drawing.Point(991, 347)
        NumeroCajaLabel.Name = "NumeroCajaLabel"
        NumeroCajaLabel.Size = New System.Drawing.Size(145, 22)
        NumeroCajaLabel.TabIndex = 49
        NumeroCajaLabel.Text = "Número de caja:"
        '
        'MontoInicialLabel
        '
        MontoInicialLabel.AutoSize = True
        MontoInicialLabel.BackColor = System.Drawing.Color.Transparent
        MontoInicialLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoInicialLabel.Location = New System.Drawing.Point(991, 384)
        MontoInicialLabel.Name = "MontoInicialLabel"
        MontoInicialLabel.Size = New System.Drawing.Size(123, 22)
        MontoInicialLabel.TabIndex = 51
        MontoInicialLabel.Text = "Monto inicial:"
        '
        'MontoActualLabel
        '
        MontoActualLabel.AutoSize = True
        MontoActualLabel.BackColor = System.Drawing.Color.Transparent
        MontoActualLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoActualLabel.Location = New System.Drawing.Point(990, 417)
        MontoActualLabel.Name = "MontoActualLabel"
        MontoActualLabel.Size = New System.Drawing.Size(124, 22)
        MontoActualLabel.TabIndex = 53
        MontoActualLabel.Text = "Monto actual:"
        '
        'MontoFinal_generadoLabel
        '
        MontoFinal_generadoLabel.AutoSize = True
        MontoFinal_generadoLabel.BackColor = System.Drawing.Color.Transparent
        MontoFinal_generadoLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoFinal_generadoLabel.Location = New System.Drawing.Point(991, 448)
        MontoFinal_generadoLabel.Name = "MontoFinal_generadoLabel"
        MontoFinal_generadoLabel.Size = New System.Drawing.Size(191, 22)
        MontoFinal_generadoLabel.TabIndex = 55
        MontoFinal_generadoLabel.Text = "Monto final generado:"
        '
        'AtendidaPorLabel
        '
        AtendidaPorLabel.AutoSize = True
        AtendidaPorLabel.BackColor = System.Drawing.Color.Transparent
        AtendidaPorLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AtendidaPorLabel.Location = New System.Drawing.Point(995, 513)
        AtendidaPorLabel.Name = "AtendidaPorLabel"
        AtendidaPorLabel.Size = New System.Drawing.Size(121, 22)
        AtendidaPorLabel.TabIndex = 57
        AtendidaPorLabel.Text = "Atendida por:"
        '
        'RetirosPreviosLabel
        '
        RetirosPreviosLabel.AutoSize = True
        RetirosPreviosLabel.BackColor = System.Drawing.Color.Transparent
        RetirosPreviosLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RetirosPreviosLabel.Location = New System.Drawing.Point(991, 588)
        RetirosPreviosLabel.Name = "RetirosPreviosLabel"
        RetirosPreviosLabel.Size = New System.Drawing.Size(139, 22)
        RetirosPreviosLabel.TabIndex = 59
        RetirosPreviosLabel.Text = "Retiros previos:"
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstatusCajaBindingSource
        '
        Me.EstatusCajaBindingSource.DataMember = "estatusCaja"
        Me.EstatusCajaBindingSource.DataSource = Me.SnackDataSet
        '
        'EstatusCajaTableAdapter
        '
        Me.EstatusCajaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Nothing
        Me.TableAdapterManager.BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.comidasTableAdapter = Nothing
        Me.TableAdapterManager.estatusCajaTableAdapter = Me.EstatusCajaTableAdapter
        Me.TableAdapterManager.ingredientesTableAdapter = Nothing
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'EstatusCajaDataGridView
        '
        Me.EstatusCajaDataGridView.AllowUserToAddRows = False
        Me.EstatusCajaDataGridView.AllowUserToDeleteRows = False
        Me.EstatusCajaDataGridView.AutoGenerateColumns = False
        Me.EstatusCajaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.EstatusCajaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EstatusCajaDataGridView.BackgroundColor = System.Drawing.Color.Coral
        Me.EstatusCajaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EstatusCajaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstatusCajaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EstatusCajaDataGridView.DataSource = Me.EstatusCajaBindingSource
        Me.EstatusCajaDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.EstatusCajaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EstatusCajaDataGridView.Name = "EstatusCajaDataGridView"
        Me.EstatusCajaDataGridView.ReadOnly = True
        Me.EstatusCajaDataGridView.Size = New System.Drawing.Size(963, 681)
        Me.EstatusCajaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idRegistro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio de registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 116
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "numeroCaja"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Número caja"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "montoInicial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto inicial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 99
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "montoActual"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto actual"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 101
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "montoFinal_generado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monto final generado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 144
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "atendidaPor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Atendida por"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "retirosPrevios"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Retiros previos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 111
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(986, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(1026, 156)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(477, 35)
        Me.TxtBuscar.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1094, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 54)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Estado de la caja"
        '
        'IdRegistroTextBox
        '
        Me.IdRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "idRegistro", True))
        Me.IdRegistroTextBox.Enabled = False
        Me.IdRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdRegistroTextBox.Location = New System.Drawing.Point(995, 252)
        Me.IdRegistroTextBox.Name = "IdRegistroTextBox"
        Me.IdRegistroTextBox.Size = New System.Drawing.Size(369, 29)
        Me.IdRegistroTextBox.TabIndex = 46
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstatusCajaBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(995, 309)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(369, 29)
        Me.FechaDateTimePicker.TabIndex = 48
        '
        'NumeroCajaTextBox
        '
        Me.NumeroCajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "numeroCaja", True))
        Me.NumeroCajaTextBox.Enabled = False
        Me.NumeroCajaTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCajaTextBox.Location = New System.Drawing.Point(1164, 344)
        Me.NumeroCajaTextBox.Name = "NumeroCajaTextBox"
        Me.NumeroCajaTextBox.Size = New System.Drawing.Size(200, 29)
        Me.NumeroCajaTextBox.TabIndex = 50
        '
        'MontoInicialTextBox
        '
        Me.MontoInicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "montoInicial", True))
        Me.MontoInicialTextBox.Enabled = False
        Me.MontoInicialTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoInicialTextBox.Location = New System.Drawing.Point(1164, 377)
        Me.MontoInicialTextBox.Name = "MontoInicialTextBox"
        Me.MontoInicialTextBox.Size = New System.Drawing.Size(200, 29)
        Me.MontoInicialTextBox.TabIndex = 52
        '
        'MontoActualTextBox
        '
        Me.MontoActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "montoActual", True))
        Me.MontoActualTextBox.Enabled = False
        Me.MontoActualTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoActualTextBox.Location = New System.Drawing.Point(1164, 410)
        Me.MontoActualTextBox.Name = "MontoActualTextBox"
        Me.MontoActualTextBox.Size = New System.Drawing.Size(200, 29)
        Me.MontoActualTextBox.TabIndex = 54
        '
        'MontoFinal_generadoTextBox
        '
        Me.MontoFinal_generadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "montoFinal_generado", True))
        Me.MontoFinal_generadoTextBox.Enabled = False
        Me.MontoFinal_generadoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoFinal_generadoTextBox.Location = New System.Drawing.Point(995, 475)
        Me.MontoFinal_generadoTextBox.Name = "MontoFinal_generadoTextBox"
        Me.MontoFinal_generadoTextBox.Size = New System.Drawing.Size(369, 29)
        Me.MontoFinal_generadoTextBox.TabIndex = 56
        '
        'AtendidaPorTextBox
        '
        Me.AtendidaPorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "atendidaPor", True))
        Me.AtendidaPorTextBox.Enabled = False
        Me.AtendidaPorTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtendidaPorTextBox.Location = New System.Drawing.Point(995, 544)
        Me.AtendidaPorTextBox.Name = "AtendidaPorTextBox"
        Me.AtendidaPorTextBox.Size = New System.Drawing.Size(369, 29)
        Me.AtendidaPorTextBox.TabIndex = 58
        '
        'RetirosPreviosTextBox
        '
        Me.RetirosPreviosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "retirosPrevios", True))
        Me.RetirosPreviosTextBox.Enabled = False
        Me.RetirosPreviosTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetirosPreviosTextBox.Location = New System.Drawing.Point(1164, 579)
        Me.RetirosPreviosTextBox.Name = "RetirosPreviosTextBox"
        Me.RetirosPreviosTextBox.Size = New System.Drawing.Size(200, 29)
        Me.RetirosPreviosTextBox.TabIndex = 60
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.SnackPuntoVenta.My.Resources.Resources.arrow_return
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(1397, 492)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(175, 64)
        Me.BtnRegresar.TabIndex = 64
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
        Me.BtnCancelar.Location = New System.Drawing.Point(1397, 422)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(175, 64)
        Me.BtnCancelar.TabIndex = 63
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
        Me.BtnGuardar.Location = New System.Drawing.Point(1397, 352)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(175, 64)
        Me.BtnGuardar.TabIndex = 62
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
        Me.BtnAgregar.Location = New System.Drawing.Point(1397, 282)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(175, 64)
        Me.BtnAgregar.TabIndex = 61
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'estatusCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1584, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(IdRegistroLabel)
        Me.Controls.Add(Me.IdRegistroTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(NumeroCajaLabel)
        Me.Controls.Add(Me.NumeroCajaTextBox)
        Me.Controls.Add(MontoInicialLabel)
        Me.Controls.Add(Me.MontoInicialTextBox)
        Me.Controls.Add(MontoActualLabel)
        Me.Controls.Add(Me.MontoActualTextBox)
        Me.Controls.Add(MontoFinal_generadoLabel)
        Me.Controls.Add(Me.MontoFinal_generadoTextBox)
        Me.Controls.Add(AtendidaPorLabel)
        Me.Controls.Add(Me.AtendidaPorTextBox)
        Me.Controls.Add(RetirosPreviosLabel)
        Me.Controls.Add(Me.RetirosPreviosTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EstatusCajaDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "estatusCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de la caja"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstatusCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstatusCajaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents EstatusCajaBindingSource As BindingSource
    Friend WithEvents EstatusCajaTableAdapter As SnackDataSetTableAdapters.estatusCajaTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstatusCajaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdRegistroTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents NumeroCajaTextBox As TextBox
    Friend WithEvents MontoInicialTextBox As TextBox
    Friend WithEvents MontoActualTextBox As TextBox
    Friend WithEvents MontoFinal_generadoTextBox As TextBox
    Friend WithEvents AtendidaPorTextBox As TextBox
    Friend WithEvents RetirosPreviosTextBox As TextBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAgregar As Button
End Class
