<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNoVer = New System.Windows.Forms.Button()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.Txt_user = New System.Windows.Forms.TextBox()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SnackPuntoVenta.My.Resources.Resources.NombreLocal
        Me.PictureBox2.Location = New System.Drawing.Point(290, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(602, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 350)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'BtnNoVer
        '
        Me.BtnNoVer.BackColor = System.Drawing.Color.Transparent
        Me.BtnNoVer.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Ojo_bloqueado
        Me.BtnNoVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNoVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNoVer.Location = New System.Drawing.Point(530, 394)
        Me.BtnNoVer.Name = "BtnNoVer"
        Me.BtnNoVer.Size = New System.Drawing.Size(45, 45)
        Me.BtnNoVer.TabIndex = 45
        Me.BtnNoVer.UseVisualStyleBackColor = False
        Me.BtnNoVer.Visible = False
        '
        'BtnVer
        '
        Me.BtnVer.BackColor = System.Drawing.Color.Transparent
        Me.BtnVer.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Ojo
        Me.BtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVer.Location = New System.Drawing.Point(530, 394)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(45, 45)
        Me.BtnVer.TabIndex = 44
        Me.BtnVer.UseVisualStyleBackColor = False
        '
        'Txt_user
        '
        Me.Txt_user.BackColor = System.Drawing.Color.White
        Me.Txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_user.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_user.ForeColor = System.Drawing.Color.Black
        Me.Txt_user.Location = New System.Drawing.Point(151, 291)
        Me.Txt_user.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_user.Name = "Txt_user"
        Me.Txt_user.Size = New System.Drawing.Size(374, 44)
        Me.Txt_user.TabIndex = 40
        '
        'Txt_password
        '
        Me.Txt_password.BackColor = System.Drawing.Color.White
        Me.Txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_password.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_password.ForeColor = System.Drawing.Color.Black
        Me.Txt_password.Location = New System.Drawing.Point(151, 395)
        Me.Txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(374, 44)
        Me.Txt_password.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(78, 346)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 35)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(78, 249)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 35)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Usuario"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.SnackPuntoVenta.My.Resources.Resources.salir2
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(236, 544)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(225, 55)
        Me.BtnSalir.TabIndex = 46
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIngresar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Image = Global.SnackPuntoVenta.My.Resources.Resources.iniciarSesion2
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresar.Location = New System.Drawing.Point(603, 544)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(225, 55)
        Me.BtnIngresar.TabIndex = 47
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
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
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNoVer)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.Txt_user)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnNoVer As Button
    Friend WithEvents BtnVer As Button
    Friend WithEvents Txt_user As TextBox
    Friend WithEvents Txt_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As SnackDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
End Class
