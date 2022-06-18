<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNameUsuario = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnRetiros = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnIngredientes = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnRealizarPedido = New System.Windows.Forms.Button()
        Me.BtnBebidas = New System.Windows.Forms.Button()
        Me.BtnComidas = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnBitacora = New System.Windows.Forms.Button()
        Me.BtnEstatusCaja = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.LblNameUsuario)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 122)
        Me.Panel1.TabIndex = 1
        '
        'LblNameUsuario
        '
        Me.LblNameUsuario.AutoSize = True
        Me.LblNameUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblNameUsuario.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNameUsuario.Location = New System.Drawing.Point(317, 41)
        Me.LblNameUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNameUsuario.Name = "LblNameUsuario"
        Me.LblNameUsuario.Size = New System.Drawing.Size(120, 40)
        Me.LblNameUsuario.TabIndex = 5
        Me.LblNameUsuario.Text = "Label1"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.PictureBox2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(188, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(112, 122)
        Me.Panel8.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.SnackPuntoVenta.My.Resources.Resources.user_square
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 122)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.BtnRetiros)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(188, 122)
        Me.Panel7.TabIndex = 1
        '
        'BtnRetiros
        '
        Me.BtnRetiros.BackColor = System.Drawing.Color.Coral
        Me.BtnRetiros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRetiros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRetiros.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetiros.Image = Global.SnackPuntoVenta.My.Resources.Resources.Billete
        Me.BtnRetiros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRetiros.Location = New System.Drawing.Point(0, 0)
        Me.BtnRetiros.Name = "BtnRetiros"
        Me.BtnRetiros.Size = New System.Drawing.Size(188, 122)
        Me.BtnRetiros.TabIndex = 7
        Me.BtnRetiros.Text = "Retirar Dinero"
        Me.BtnRetiros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRetiros.UseVisualStyleBackColor = False
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
        Me.Panel2.Size = New System.Drawing.Size(188, 406)
        Me.Panel2.TabIndex = 2
        '
        'BtnSalir
        '
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.SnackPuntoVenta.My.Resources.Resources.Apagar
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(0, 305)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(188, 102)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.Image = Global.SnackPuntoVenta.My.Resources.Resources.Salir
        Me.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(0, 203)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(188, 102)
        Me.BtnCerrarSesion.TabIndex = 1
        Me.BtnCerrarSesion.Text = "Cerrar Sesion"
        Me.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(188, 203)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(26, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnIngredientes
        '
        Me.BtnIngredientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngredientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIngredientes.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngredientes.Image = Global.SnackPuntoVenta.My.Resources.Resources.cheese
        Me.BtnIngredientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngredientes.Location = New System.Drawing.Point(0, 0)
        Me.BtnIngredientes.Name = "BtnIngredientes"
        Me.BtnIngredientes.Size = New System.Drawing.Size(301, 102)
        Me.BtnIngredientes.TabIndex = 3
        Me.BtnIngredientes.Text = "Ingredientes"
        Me.BtnIngredientes.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.Panel4.Controls.Add(Me.BtnRealizarPedido)
        Me.Panel4.Controls.Add(Me.BtnBebidas)
        Me.Panel4.Controls.Add(Me.BtnComidas)
        Me.Panel4.Controls.Add(Me.BtnIngredientes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(188, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(301, 406)
        Me.Panel4.TabIndex = 3
        '
        'BtnRealizarPedido
        '
        Me.BtnRealizarPedido.BackColor = System.Drawing.Color.Transparent
        Me.BtnRealizarPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRealizarPedido.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRealizarPedido.Image = Global.SnackPuntoVenta.My.Resources.Resources.cubiertos
        Me.BtnRealizarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRealizarPedido.Location = New System.Drawing.Point(0, 306)
        Me.BtnRealizarPedido.Name = "BtnRealizarPedido"
        Me.BtnRealizarPedido.Size = New System.Drawing.Size(301, 102)
        Me.BtnRealizarPedido.TabIndex = 6
        Me.BtnRealizarPedido.Text = "Realizar Pedido"
        Me.BtnRealizarPedido.UseVisualStyleBackColor = False
        '
        'BtnBebidas
        '
        Me.BtnBebidas.BackColor = System.Drawing.Color.Transparent
        Me.BtnBebidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBebidas.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBebidas.Image = Global.SnackPuntoVenta.My.Resources.Resources.bottle_f
        Me.BtnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBebidas.Location = New System.Drawing.Point(0, 204)
        Me.BtnBebidas.Name = "BtnBebidas"
        Me.BtnBebidas.Size = New System.Drawing.Size(301, 102)
        Me.BtnBebidas.TabIndex = 5
        Me.BtnBebidas.Text = "Bebidas"
        Me.BtnBebidas.UseVisualStyleBackColor = False
        '
        'BtnComidas
        '
        Me.BtnComidas.BackColor = System.Drawing.Color.Transparent
        Me.BtnComidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnComidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComidas.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComidas.Image = Global.SnackPuntoVenta.My.Resources.Resources.chips_bag
        Me.BtnComidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComidas.Location = New System.Drawing.Point(0, 102)
        Me.BtnComidas.Name = "BtnComidas"
        Me.BtnComidas.Size = New System.Drawing.Size(301, 102)
        Me.BtnComidas.TabIndex = 4
        Me.BtnComidas.Text = "Comidas"
        Me.BtnComidas.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.Panel5.Controls.Add(Me.BtnBitacora)
        Me.Panel5.Controls.Add(Me.BtnEstatusCaja)
        Me.Panel5.Controls.Add(Me.BtnUsuarios)
        Me.Panel5.Controls.Add(Me.BtnVentas)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(489, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(301, 406)
        Me.Panel5.TabIndex = 4
        '
        'BtnBitacora
        '
        Me.BtnBitacora.BackColor = System.Drawing.Color.Transparent
        Me.BtnBitacora.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBitacora.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBitacora.Image = Global.SnackPuntoVenta.My.Resources.Resources.Reloj
        Me.BtnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBitacora.Location = New System.Drawing.Point(0, 306)
        Me.BtnBitacora.Name = "BtnBitacora"
        Me.BtnBitacora.Size = New System.Drawing.Size(301, 102)
        Me.BtnBitacora.TabIndex = 7
        Me.BtnBitacora.Text = "  Historial de                    movimientos"
        Me.BtnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBitacora.UseVisualStyleBackColor = False
        '
        'BtnEstatusCaja
        '
        Me.BtnEstatusCaja.BackColor = System.Drawing.Color.Transparent
        Me.BtnEstatusCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEstatusCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEstatusCaja.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEstatusCaja.Image = Global.SnackPuntoVenta.My.Resources.Resources.money_dollar_circle_line
        Me.BtnEstatusCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEstatusCaja.Location = New System.Drawing.Point(0, 204)
        Me.BtnEstatusCaja.Name = "BtnEstatusCaja"
        Me.BtnEstatusCaja.Size = New System.Drawing.Size(301, 102)
        Me.BtnEstatusCaja.TabIndex = 6
        Me.BtnEstatusCaja.Text = "Estatus Caja"
        Me.BtnEstatusCaja.UseVisualStyleBackColor = False
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUsuarios.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Image = Global.SnackPuntoVenta.My.Resources.Resources.users
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 102)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(301, 102)
        Me.BtnUsuarios.TabIndex = 5
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVentas.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = Global.SnackPuntoVenta.My.Resources.Resources.ventas2
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(301, 102)
        Me.BtnVentas.TabIndex = 4
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = False
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
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Horizon
        Me.ClientSize = New System.Drawing.Size(789, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblNameUsuario As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents BtnIngredientes As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnRealizarPedido As Button
    Friend WithEvents BtnBebidas As Button
    Friend WithEvents BtnComidas As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnBitacora As Button
    Friend WithEvents BtnEstatusCaja As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As SnackDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnRetiros As Button
End Class
