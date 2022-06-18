<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.BebidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BebidasTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.BebidasTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.IngredientesTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.ingredientesTableAdapter()
        Me.IngredientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BebidasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingredientes = New System.Windows.Forms.Label()
        Me.IngredientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BebidasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BebidasBindingSource
        '
        Me.BebidasBindingSource.DataMember = "Bebidas"
        Me.BebidasBindingSource.DataSource = Me.SnackDataSet
        '
        'BebidasTableAdapter
        '
        Me.BebidasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Me.BebidasTableAdapter
        Me.TableAdapterManager.BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.comidasTableAdapter = Nothing
        Me.TableAdapterManager.estatusCajaTableAdapter = Nothing
        Me.TableAdapterManager.ingredientesTableAdapter = Me.IngredientesTableAdapter
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'IngredientesTableAdapter
        '
        Me.IngredientesTableAdapter.ClearBeforeFill = True
        '
        'IngredientesBindingSource
        '
        Me.IngredientesBindingSource.DataMember = "ingredientes"
        Me.IngredientesBindingSource.DataSource = Me.SnackDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(752, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Bebidas"
        '
        'BebidasDataGridView
        '
        Me.BebidasDataGridView.AllowUserToAddRows = False
        Me.BebidasDataGridView.AllowUserToDeleteRows = False
        Me.BebidasDataGridView.AutoGenerateColumns = False
        Me.BebidasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BebidasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BebidasDataGridView.BackgroundColor = System.Drawing.Color.Coral
        Me.BebidasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BebidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BebidasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8})
        Me.BebidasDataGridView.DataSource = Me.BebidasBindingSource
        Me.BebidasDataGridView.Location = New System.Drawing.Point(569, 140)
        Me.BebidasDataGridView.Name = "BebidasDataGridView"
        Me.BebidasDataGridView.ReadOnly = True
        Me.BebidasDataGridView.Size = New System.Drawing.Size(450, 368)
        Me.BebidasDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bebida"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "disponibles"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Disponibles"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 112
        '
        'Ingredientes
        '
        Me.Ingredientes.AutoSize = True
        Me.Ingredientes.BackColor = System.Drawing.Color.Transparent
        Me.Ingredientes.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingredientes.Location = New System.Drawing.Point(240, 91)
        Me.Ingredientes.Name = "Ingredientes"
        Me.Ingredientes.Size = New System.Drawing.Size(156, 31)
        Me.Ingredientes.TabIndex = 10
        Me.Ingredientes.Text = "Ingredientes"
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
        Me.IngredientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.IngredientesDataGridView.DataSource = Me.IngredientesBindingSource
        Me.IngredientesDataGridView.Location = New System.Drawing.Point(77, 140)
        Me.IngredientesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientesDataGridView.Name = "IngredientesDataGridView"
        Me.IngredientesDataGridView.ReadOnly = True
        Me.IngredientesDataGridView.Size = New System.Drawing.Size(450, 368)
        Me.IngredientesDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ingrediente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ingrediente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 111
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "disponibles"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Disponibles"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 112
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1097, 31)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.Regresar
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(100, 23)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1097, 530)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BebidasDataGridView)
        Me.Controls.Add(Me.Ingredientes)
        Me.Controls.Add(Me.IngredientesDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BebidasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents BebidasBindingSource As BindingSource
    Friend WithEvents BebidasTableAdapter As SnackDataSetTableAdapters.BebidasTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IngredientesTableAdapter As SnackDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents IngredientesBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents BebidasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Ingredientes As Label
    Friend WithEvents IngredientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
End Class
