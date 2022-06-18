<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim EventoLabel As System.Windows.Forms.Label
        Dim TablaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HostnameLabel As System.Windows.Forms.Label
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.BitacoraTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.BitacoraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.EventoTextBox = New System.Windows.Forms.TextBox()
        Me.TablaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HostnameTextBox = New System.Windows.Forms.TextBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        EventoLabel = New System.Windows.Forms.Label()
        TablaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        HostnameLabel = New System.Windows.Forms.Label()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(762, 86)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(246, 32)
        Label2.TabIndex = 32
        Label2.Text = "Buscar por campo:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(771, 215)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(204, 24)
        IdLabel.TabIndex = 34
        IdLabel.Text = "Folio del movimiento:"
        '
        'EventoLabel
        '
        EventoLabel.AutoSize = True
        EventoLabel.BackColor = System.Drawing.Color.Transparent
        EventoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EventoLabel.Location = New System.Drawing.Point(771, 277)
        EventoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EventoLabel.Name = "EventoLabel"
        EventoLabel.Size = New System.Drawing.Size(81, 24)
        EventoLabel.TabIndex = 36
        EventoLabel.Text = "Evento:"
        '
        'TablaLabel
        '
        TablaLabel.AutoSize = True
        TablaLabel.BackColor = System.Drawing.Color.Transparent
        TablaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TablaLabel.Location = New System.Drawing.Point(771, 342)
        TablaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TablaLabel.Name = "TablaLabel"
        TablaLabel.Size = New System.Drawing.Size(209, 24)
        TablaLabel.TabIndex = 38
        TablaLabel.Text = "Campo de realización:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(771, 404)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(73, 24)
        FechaLabel.TabIndex = 40
        FechaLabel.Text = "Fecha:"
        '
        'HostnameLabel
        '
        HostnameLabel.AutoSize = True
        HostnameLabel.BackColor = System.Drawing.Color.Transparent
        HostnameLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HostnameLabel.Location = New System.Drawing.Point(771, 466)
        HostnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HostnameLabel.Name = "HostnameLabel"
        HostnameLabel.Size = New System.Drawing.Size(108, 24)
        HostnameLabel.TabIndex = 42
        HostnameLabel.Text = "Hostname:"
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BitacoraBindingSource
        '
        Me.BitacoraBindingSource.DataMember = "Bitacora"
        Me.BitacoraBindingSource.DataSource = Me.SnackDataSet
        '
        'BitacoraTableAdapter
        '
        Me.BitacoraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Nothing
        Me.TableAdapterManager.BitacoraTableAdapter = Me.BitacoraTableAdapter
        Me.TableAdapterManager.comidasTableAdapter = Nothing
        Me.TableAdapterManager.estatusCajaTableAdapter = Nothing
        Me.TableAdapterManager.ingredientesTableAdapter = Nothing
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'BitacoraDataGridView
        '
        Me.BitacoraDataGridView.AllowUserToAddRows = False
        Me.BitacoraDataGridView.AllowUserToDeleteRows = False
        Me.BitacoraDataGridView.AutoGenerateColumns = False
        Me.BitacoraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BitacoraDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BitacoraDataGridView.BackgroundColor = System.Drawing.Color.Coral
        Me.BitacoraDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BitacoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BitacoraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BitacoraDataGridView.DataSource = Me.BitacoraBindingSource
        Me.BitacoraDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.BitacoraDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BitacoraDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BitacoraDataGridView.Name = "BitacoraDataGridView"
        Me.BitacoraDataGridView.ReadOnly = True
        Me.BitacoraDataGridView.Size = New System.Drawing.Size(723, 630)
        Me.BitacoraDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio del movimiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "evento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Evento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 74
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tabla"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Campo de realización"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 145
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 69
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "hostname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hostname"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 93
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(765, 131)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(805, 131)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(367, 35)
        Me.TxtBuscar.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(740, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 54)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Historial de movimientos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(821, 242)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(404, 32)
        Me.IdTextBox.TabIndex = 35
        '
        'EventoTextBox
        '
        Me.EventoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraBindingSource, "evento", True))
        Me.EventoTextBox.Enabled = False
        Me.EventoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventoTextBox.Location = New System.Drawing.Point(821, 304)
        Me.EventoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EventoTextBox.Name = "EventoTextBox"
        Me.EventoTextBox.Size = New System.Drawing.Size(404, 32)
        Me.EventoTextBox.TabIndex = 37
        '
        'TablaTextBox
        '
        Me.TablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraBindingSource, "tabla", True))
        Me.TablaTextBox.Enabled = False
        Me.TablaTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaTextBox.Location = New System.Drawing.Point(821, 369)
        Me.TablaTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TablaTextBox.Name = "TablaTextBox"
        Me.TablaTextBox.Size = New System.Drawing.Size(404, 32)
        Me.TablaTextBox.TabIndex = 39
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BitacoraBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(821, 431)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(404, 32)
        Me.FechaDateTimePicker.TabIndex = 41
        '
        'HostnameTextBox
        '
        Me.HostnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraBindingSource, "hostname", True))
        Me.HostnameTextBox.Enabled = False
        Me.HostnameTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HostnameTextBox.Location = New System.Drawing.Point(821, 493)
        Me.HostnameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HostnameTextBox.Name = "HostnameTextBox"
        Me.HostnameTextBox.Size = New System.Drawing.Size(404, 32)
        Me.HostnameTextBox.TabIndex = 43
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.SnackPuntoVenta.My.Resources.Resources.arrow_return
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(1095, 554)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(175, 64)
        Me.BtnRegresar.TabIndex = 53
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1282, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(EventoLabel)
        Me.Controls.Add(Me.EventoTextBox)
        Me.Controls.Add(TablaLabel)
        Me.Controls.Add(Me.TablaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(HostnameLabel)
        Me.Controls.Add(Me.HostnameTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BitacoraDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de movimientos"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents BitacoraBindingSource As BindingSource
    Friend WithEvents BitacoraTableAdapter As SnackDataSetTableAdapters.BitacoraTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BitacoraDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents EventoTextBox As TextBox
    Friend WithEvents TablaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents HostnameTextBox As TextBox
    Friend WithEvents BtnRegresar As Button
End Class
