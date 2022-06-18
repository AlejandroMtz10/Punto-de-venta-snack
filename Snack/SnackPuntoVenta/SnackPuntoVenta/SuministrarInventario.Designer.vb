<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuministrarInventario
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
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.IngredientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngredientesTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.ingredientesTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.BebidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BebidasTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.BebidasTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantidadB = New System.Windows.Forms.TextBox()
        Me.TxtBebida = New System.Windows.Forms.TextBox()
        Me.TxtCantidadI = New System.Windows.Forms.TextBox()
        Me.TxtIngrediente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'BebidasBindingSource
        '
        Me.BebidasBindingSource.DataMember = "Bebidas"
        Me.BebidasBindingSource.DataSource = Me.SnackDataSet
        '
        'BebidasTableAdapter
        '
        Me.BebidasTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 30)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.Regresar
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(367, 43)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Suministrar inventario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(523, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 31)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "de bebidas."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 31)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "de ingredientes."
        '
        'TxtCantidadB
        '
        Me.TxtCantidadB.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadB.Location = New System.Drawing.Point(529, 420)
        Me.TxtCantidadB.Name = "TxtCantidadB"
        Me.TxtCantidadB.Size = New System.Drawing.Size(355, 39)
        Me.TxtCantidadB.TabIndex = 44
        '
        'TxtBebida
        '
        Me.TxtBebida.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBebida.Location = New System.Drawing.Point(529, 291)
        Me.TxtBebida.Name = "TxtBebida"
        Me.TxtBebida.Size = New System.Drawing.Size(355, 39)
        Me.TxtBebida.TabIndex = 43
        '
        'TxtCantidadI
        '
        Me.TxtCantidadI.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadI.Location = New System.Drawing.Point(37, 420)
        Me.TxtCantidadI.Name = "TxtCantidadI"
        Me.TxtCantidadI.Size = New System.Drawing.Size(355, 39)
        Me.TxtCantidadI.TabIndex = 42
        '
        'TxtIngrediente
        '
        Me.TxtIngrediente.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIngrediente.Location = New System.Drawing.Point(37, 291)
        Me.TxtIngrediente.Name = "TxtIngrediente"
        Me.TxtIngrediente.Size = New System.Drawing.Size(355, 39)
        Me.TxtIngrediente.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 31)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Bebida:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(523, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 31)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Cantidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 31)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Ingrediente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 31)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(523, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 31)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Incrementar la disponibilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 31)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Incrementar la disponibilidad"
        '
        'SuministrarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.BlueCoral
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(915, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCantidadB)
        Me.Controls.Add(Me.TxtBebida)
        Me.Controls.Add(Me.TxtCantidadI)
        Me.Controls.Add(Me.TxtIngrediente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuministrarInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuministrarInventario"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents IngredientesBindingSource As BindingSource
    Friend WithEvents IngredientesTableAdapter As SnackDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BebidasTableAdapter As SnackDataSetTableAdapters.BebidasTableAdapter
    Friend WithEvents BebidasBindingSource As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCantidadB As TextBox
    Friend WithEvents TxtBebida As TextBox
    Friend WithEvents TxtCantidadI As TextBox
    Friend WithEvents TxtIngrediente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
