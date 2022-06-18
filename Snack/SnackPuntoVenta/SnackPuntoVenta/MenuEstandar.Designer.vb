<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuEstandar
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
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNameUsuario = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIngredientes = New System.Windows.Forms.Button()
        Me.BtnComidas = New System.Windows.Forms.Button()
        Me.BtnBebidas = New System.Windows.Forms.Button()
        Me.BtnRealizarPedido = New System.Windows.Forms.Button()
        Me.BtnEstatusCaja = New System.Windows.Forms.Button()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SnackDataSet
        '
        Me.SnackDataSet.DataSetName = "SnackDataSet"
        Me.SnackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SnackDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Nothing
        Me.TableAdapterManager.BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.comidasTableAdapter = Nothing
        Me.TableAdapterManager.estatusCajaTableAdapter = Nothing
        Me.TableAdapterManager.ingredientesTableAdapter = Nothing
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.LblNameUsuario)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 440)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 110)
        Me.Panel1.TabIndex = 1
        '
        'LblNameUsuario
        '
        Me.LblNameUsuario.AutoSize = True
        Me.LblNameUsuario.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNameUsuario.Location = New System.Drawing.Point(260, 37)
        Me.LblNameUsuario.Name = "LblNameUsuario"
        Me.LblNameUsuario.Size = New System.Drawing.Size(120, 40)
        Me.LblNameUsuario.TabIndex = 3
        Me.LblNameUsuario.Text = "Label1"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(144, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(110, 110)
        Me.Panel5.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.SnackPuntoVenta.My.Resources.Resources.user_square
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(144, 110)
        Me.Panel4.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnCerrarSesion)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 440)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 200)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(50, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.Image = Global.SnackPuntoVenta.My.Resources.Resources.Salir
        Me.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(0, 200)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(250, 120)
        Me.BtnCerrarSesion.TabIndex = 2
        Me.BtnCerrarSesion.Text = "Cerrar Sesion"
        Me.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.SnackPuntoVenta.My.Resources.Resources.Apagar
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(0, 320)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(250, 120)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnIngredientes
        '
        Me.BtnIngredientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngredientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIngredientes.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngredientes.Image = Global.SnackPuntoVenta.My.Resources.Resources.cheese
        Me.BtnIngredientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngredientes.Location = New System.Drawing.Point(250, 0)
        Me.BtnIngredientes.Name = "BtnIngredientes"
        Me.BtnIngredientes.Size = New System.Drawing.Size(446, 88)
        Me.BtnIngredientes.TabIndex = 4
        Me.BtnIngredientes.Text = "Ingredientes"
        Me.BtnIngredientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngredientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIngredientes.UseVisualStyleBackColor = False
        '
        'BtnComidas
        '
        Me.BtnComidas.BackColor = System.Drawing.Color.Transparent
        Me.BtnComidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnComidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComidas.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComidas.Image = Global.SnackPuntoVenta.My.Resources.Resources.chips_bag
        Me.BtnComidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComidas.Location = New System.Drawing.Point(250, 88)
        Me.BtnComidas.Name = "BtnComidas"
        Me.BtnComidas.Size = New System.Drawing.Size(446, 88)
        Me.BtnComidas.TabIndex = 5
        Me.BtnComidas.Text = "Comidas"
        Me.BtnComidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnComidas.UseVisualStyleBackColor = False
        '
        'BtnBebidas
        '
        Me.BtnBebidas.BackColor = System.Drawing.Color.Transparent
        Me.BtnBebidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBebidas.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBebidas.Image = Global.SnackPuntoVenta.My.Resources.Resources.bottle_f
        Me.BtnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBebidas.Location = New System.Drawing.Point(250, 176)
        Me.BtnBebidas.Name = "BtnBebidas"
        Me.BtnBebidas.Size = New System.Drawing.Size(446, 88)
        Me.BtnBebidas.TabIndex = 6
        Me.BtnBebidas.Text = "Bebidas"
        Me.BtnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBebidas.UseVisualStyleBackColor = False
        '
        'BtnRealizarPedido
        '
        Me.BtnRealizarPedido.BackColor = System.Drawing.Color.Transparent
        Me.BtnRealizarPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRealizarPedido.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRealizarPedido.Image = Global.SnackPuntoVenta.My.Resources.Resources.cubiertos
        Me.BtnRealizarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRealizarPedido.Location = New System.Drawing.Point(250, 264)
        Me.BtnRealizarPedido.Name = "BtnRealizarPedido"
        Me.BtnRealizarPedido.Size = New System.Drawing.Size(446, 88)
        Me.BtnRealizarPedido.TabIndex = 7
        Me.BtnRealizarPedido.Text = "Realizar Pedido"
        Me.BtnRealizarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRealizarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRealizarPedido.UseVisualStyleBackColor = False
        '
        'BtnEstatusCaja
        '
        Me.BtnEstatusCaja.BackColor = System.Drawing.Color.Transparent
        Me.BtnEstatusCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEstatusCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEstatusCaja.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEstatusCaja.Image = Global.SnackPuntoVenta.My.Resources.Resources.money_dollar_circle_line
        Me.BtnEstatusCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEstatusCaja.Location = New System.Drawing.Point(250, 352)
        Me.BtnEstatusCaja.Name = "BtnEstatusCaja"
        Me.BtnEstatusCaja.Size = New System.Drawing.Size(446, 88)
        Me.BtnEstatusCaja.TabIndex = 8
        Me.BtnEstatusCaja.Text = "Estatus Caja"
        Me.BtnEstatusCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEstatusCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEstatusCaja.UseVisualStyleBackColor = False
        '
        'MenuEstandar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Horizon
        Me.ClientSize = New System.Drawing.Size(696, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnEstatusCaja)
        Me.Controls.Add(Me.BtnRealizarPedido)
        Me.Controls.Add(Me.BtnBebidas)
        Me.Controls.Add(Me.BtnComidas)
        Me.Controls.Add(Me.BtnIngredientes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuEstandar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As SnackDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblNameUsuario As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnIngredientes As Button
    Friend WithEvents BtnComidas As Button
    Friend WithEvents BtnBebidas As Button
    Friend WithEvents BtnRealizarPedido As Button
    Friend WithEvents BtnEstatusCaja As Button
End Class
