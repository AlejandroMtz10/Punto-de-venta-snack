<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarPedido
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
        Dim TotalLabel As System.Windows.Forms.Label
        Dim CompradorLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Dim FolioVentaLabel As System.Windows.Forms.Label
        Dim MontoActualLabel As System.Windows.Forms.Label
        Dim MontoFinal_generadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarPedido))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarUnArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisminuirComplementosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JalapeñosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CebollasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TomatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DolaresAPesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActuzliarLaCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuministrarInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblPrecioAgua = New System.Windows.Forms.Label()
        Me.LblAgua = New System.Windows.Forms.Label()
        Me.BtnAgua = New System.Windows.Forms.Button()
        Me.LblPrecioSprite = New System.Windows.Forms.Label()
        Me.LblSprite = New System.Windows.Forms.Label()
        Me.BtnSprite = New System.Windows.Forms.Button()
        Me.LblPrecioFresca = New System.Windows.Forms.Label()
        Me.LblFresca = New System.Windows.Forms.Label()
        Me.BtnFresca = New System.Windows.Forms.Button()
        Me.LblPrecioFantaFresa = New System.Windows.Forms.Label()
        Me.LblFantaFresa = New System.Windows.Forms.Label()
        Me.BtnFantaF = New System.Windows.Forms.Button()
        Me.LblPrecioFantaNaranja = New System.Windows.Forms.Label()
        Me.LblFantaNaranja = New System.Windows.Forms.Label()
        Me.BtnFantaN = New System.Windows.Forms.Button()
        Me.LblPrecioDrPepper = New System.Windows.Forms.Label()
        Me.LblDrPepper = New System.Windows.Forms.Label()
        Me.BtnDrPepper = New System.Windows.Forms.Button()
        Me.LblPrecioCocaCola = New System.Windows.Forms.Label()
        Me.LblCocaCola = New System.Windows.Forms.Label()
        Me.BtnCocaCola = New System.Windows.Forms.Button()
        Me.LblFritoQueso = New System.Windows.Forms.Label()
        Me.LblFritosQueso = New System.Windows.Forms.Label()
        Me.BtnFritosQueso = New System.Windows.Forms.Button()
        Me.LblFrito = New System.Windows.Forms.Label()
        Me.LblFritos = New System.Windows.Forms.Label()
        Me.BtnFritos = New System.Windows.Forms.Button()
        Me.LblPapaQueso = New System.Windows.Forms.Label()
        Me.LblPapasQueso = New System.Windows.Forms.Label()
        Me.LblOrdenPapa = New System.Windows.Forms.Label()
        Me.LblOrdenPapas = New System.Windows.Forms.Label()
        Me.LblNachos = New System.Windows.Forms.Label()
        Me.LblNacho = New System.Windows.Forms.Label()
        Me.LblHotDog = New System.Windows.Forms.Label()
        Me.LblHotDogs = New System.Windows.Forms.Label()
        Me.BtnPapasQueso = New System.Windows.Forms.Button()
        Me.BtnOrdenPapasSolas = New System.Windows.Forms.Button()
        Me.BtnNachos = New System.Windows.Forms.Button()
        Me.BtnHotDog = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListPedido = New System.Windows.Forms.ListBox()
        Me.BtnAgregarVenta = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SnackDataSet = New SnackPuntoVenta.SnackDataSet()
        Me.BebidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BebidasTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.BebidasTableAdapter()
        Me.TableAdapterManager = New SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager()
        Me.ComidasTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.comidasTableAdapter()
        Me.EstatusCajaTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.estatusCajaTableAdapter()
        Me.IngredientesTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.ingredientesTableAdapter()
        Me.VentasTableAdapter = New SnackPuntoVenta.SnackDataSetTableAdapters.VentasTableAdapter()
        Me.ComidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstatusCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngredientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPagoCon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCambio = New System.Windows.Forms.TextBox()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.CompradorTextBox = New System.Windows.Forms.TextBox()
        Me.VendedorTextBox = New System.Windows.Forms.TextBox()
        Me.FolioVentaTextBox = New System.Windows.Forms.TextBox()
        Me.MontoActualTextBox = New System.Windows.Forms.TextBox()
        Me.MontoFinal_generadoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnCambio = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        TotalLabel = New System.Windows.Forms.Label()
        CompradorLabel = New System.Windows.Forms.Label()
        VendedorLabel = New System.Windows.Forms.Label()
        FolioVentaLabel = New System.Windows.Forms.Label()
        MontoActualLabel = New System.Windows.Forms.Label()
        MontoFinal_generadoLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstatusCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.BackColor = System.Drawing.Color.Transparent
        TotalLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        TotalLabel.Location = New System.Drawing.Point(23, 333)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(57, 22)
        TotalLabel.TabIndex = 21
        TotalLabel.Text = "Total:"
        '
        'CompradorLabel
        '
        CompradorLabel.AutoSize = True
        CompradorLabel.BackColor = System.Drawing.Color.Transparent
        CompradorLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        CompradorLabel.Location = New System.Drawing.Point(23, 264)
        CompradorLabel.Name = "CompradorLabel"
        CompradorLabel.Size = New System.Drawing.Size(110, 22)
        CompradorLabel.TabIndex = 19
        CompradorLabel.Text = "Comprador:"
        '
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.BackColor = System.Drawing.Color.Transparent
        VendedorLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        VendedorLabel.Location = New System.Drawing.Point(23, 228)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(92, 22)
        VendedorLabel.TabIndex = 17
        VendedorLabel.Text = "Vendedor:"
        '
        'FolioVentaLabel
        '
        FolioVentaLabel.AutoSize = True
        FolioVentaLabel.BackColor = System.Drawing.Color.Transparent
        FolioVentaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        FolioVentaLabel.Location = New System.Drawing.Point(23, 194)
        FolioVentaLabel.Name = "FolioVentaLabel"
        FolioVentaLabel.Size = New System.Drawing.Size(130, 22)
        FolioVentaLabel.TabIndex = 15
        FolioVentaLabel.Text = "Folio de venta:"
        '
        'MontoActualLabel
        '
        MontoActualLabel.AutoSize = True
        MontoActualLabel.BackColor = System.Drawing.Color.Transparent
        MontoActualLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        MontoActualLabel.Location = New System.Drawing.Point(29, 665)
        MontoActualLabel.Name = "MontoActualLabel"
        MontoActualLabel.Size = New System.Drawing.Size(124, 22)
        MontoActualLabel.TabIndex = 22
        MontoActualLabel.Text = "Monto actual:"
        '
        'MontoFinal_generadoLabel
        '
        MontoFinal_generadoLabel.AutoSize = True
        MontoFinal_generadoLabel.BackColor = System.Drawing.Color.Transparent
        MontoFinal_generadoLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        MontoFinal_generadoLabel.Location = New System.Drawing.Point(29, 722)
        MontoFinal_generadoLabel.Name = "MontoFinal_generadoLabel"
        MontoFinal_generadoLabel.Size = New System.Drawing.Size(191, 22)
        MontoFinal_generadoLabel.TabIndex = 23
        MontoFinal_generadoLabel.Text = "Monto final generado:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.CancelarCompraToolStripMenuItem, Me.CancelarUnArtículoToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.DisminuirComplementosToolStripMenuItem, Me.DolaresAPesosToolStripMenuItem, Me.ActuzliarLaCajaToolStripMenuItem, Me.SuministrarInventarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1444, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.Regresar
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.RegresarToolStripMenuItem.Text = "Regresar Al Menú"
        '
        'CancelarCompraToolStripMenuItem
        '
        Me.CancelarCompraToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.cancel
        Me.CancelarCompraToolStripMenuItem.Name = "CancelarCompraToolStripMenuItem"
        Me.CancelarCompraToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.CancelarCompraToolStripMenuItem.Text = "Cancelar Compra"
        '
        'CancelarUnArtículoToolStripMenuItem
        '
        Me.CancelarUnArtículoToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.cancel_line
        Me.CancelarUnArtículoToolStripMenuItem.Name = "CancelarUnArtículoToolStripMenuItem"
        Me.CancelarUnArtículoToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.CancelarUnArtículoToolStripMenuItem.Text = "Cancelar un Artículo"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.ventas
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.Inventario
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'DisminuirComplementosToolStripMenuItem
        '
        Me.DisminuirComplementosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JalapeñosToolStripMenuItem, Me.CebollasToolStripMenuItem, Me.TomatesToolStripMenuItem})
        Me.DisminuirComplementosToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.math_minus_box
        Me.DisminuirComplementosToolStripMenuItem.Name = "DisminuirComplementosToolStripMenuItem"
        Me.DisminuirComplementosToolStripMenuItem.Size = New System.Drawing.Size(172, 20)
        Me.DisminuirComplementosToolStripMenuItem.Text = "Disminuir complementos"
        '
        'JalapeñosToolStripMenuItem
        '
        Me.JalapeñosToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.Jalapeño
        Me.JalapeñosToolStripMenuItem.Name = "JalapeñosToolStripMenuItem"
        Me.JalapeñosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.JalapeñosToolStripMenuItem.Text = "Jalapeños"
        '
        'CebollasToolStripMenuItem
        '
        Me.CebollasToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.cebolla
        Me.CebollasToolStripMenuItem.Name = "CebollasToolStripMenuItem"
        Me.CebollasToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CebollasToolStripMenuItem.Text = "Cebollas"
        '
        'TomatesToolStripMenuItem
        '
        Me.TomatesToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.tomate
        Me.TomatesToolStripMenuItem.Name = "TomatesToolStripMenuItem"
        Me.TomatesToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.TomatesToolStripMenuItem.Text = "Tomates"
        '
        'DolaresAPesosToolStripMenuItem
        '
        Me.DolaresAPesosToolStripMenuItem.Image = CType(resources.GetObject("DolaresAPesosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DolaresAPesosToolStripMenuItem.Name = "DolaresAPesosToolStripMenuItem"
        Me.DolaresAPesosToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.DolaresAPesosToolStripMenuItem.Text = "Dolares a Pesos"
        '
        'ActuzliarLaCajaToolStripMenuItem
        '
        Me.ActuzliarLaCajaToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.refresh_ccw
        Me.ActuzliarLaCajaToolStripMenuItem.Name = "ActuzliarLaCajaToolStripMenuItem"
        Me.ActuzliarLaCajaToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ActuzliarLaCajaToolStripMenuItem.Text = "Actuzliar la caja"
        '
        'SuministrarInventarioToolStripMenuItem
        '
        Me.SuministrarInventarioToolStripMenuItem.Image = Global.SnackPuntoVenta.My.Resources.Resources.math_plus_box
        Me.SuministrarInventarioToolStripMenuItem.Name = "SuministrarInventarioToolStripMenuItem"
        Me.SuministrarInventarioToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.SuministrarInventarioToolStripMenuItem.Text = "Suministrar inventario"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Horizon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LblPrecioAgua)
        Me.Panel1.Controls.Add(Me.LblAgua)
        Me.Panel1.Controls.Add(Me.BtnAgua)
        Me.Panel1.Controls.Add(Me.LblPrecioSprite)
        Me.Panel1.Controls.Add(Me.LblSprite)
        Me.Panel1.Controls.Add(Me.BtnSprite)
        Me.Panel1.Controls.Add(Me.LblPrecioFresca)
        Me.Panel1.Controls.Add(Me.LblFresca)
        Me.Panel1.Controls.Add(Me.BtnFresca)
        Me.Panel1.Controls.Add(Me.LblPrecioFantaFresa)
        Me.Panel1.Controls.Add(Me.LblFantaFresa)
        Me.Panel1.Controls.Add(Me.BtnFantaF)
        Me.Panel1.Controls.Add(Me.LblPrecioFantaNaranja)
        Me.Panel1.Controls.Add(Me.LblFantaNaranja)
        Me.Panel1.Controls.Add(Me.BtnFantaN)
        Me.Panel1.Controls.Add(Me.LblPrecioDrPepper)
        Me.Panel1.Controls.Add(Me.LblDrPepper)
        Me.Panel1.Controls.Add(Me.BtnDrPepper)
        Me.Panel1.Controls.Add(Me.LblPrecioCocaCola)
        Me.Panel1.Controls.Add(Me.LblCocaCola)
        Me.Panel1.Controls.Add(Me.BtnCocaCola)
        Me.Panel1.Controls.Add(Me.LblFritoQueso)
        Me.Panel1.Controls.Add(Me.LblFritosQueso)
        Me.Panel1.Controls.Add(Me.BtnFritosQueso)
        Me.Panel1.Controls.Add(Me.LblFrito)
        Me.Panel1.Controls.Add(Me.LblFritos)
        Me.Panel1.Controls.Add(Me.BtnFritos)
        Me.Panel1.Controls.Add(Me.LblPapaQueso)
        Me.Panel1.Controls.Add(Me.LblPapasQueso)
        Me.Panel1.Controls.Add(Me.LblOrdenPapa)
        Me.Panel1.Controls.Add(Me.LblOrdenPapas)
        Me.Panel1.Controls.Add(Me.LblNachos)
        Me.Panel1.Controls.Add(Me.LblNacho)
        Me.Panel1.Controls.Add(Me.LblHotDog)
        Me.Panel1.Controls.Add(Me.LblHotDogs)
        Me.Panel1.Controls.Add(Me.BtnPapasQueso)
        Me.Panel1.Controls.Add(Me.BtnOrdenPapasSolas)
        Me.Panel1.Controls.Add(Me.BtnNachos)
        Me.Panel1.Controls.Add(Me.BtnHotDog)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 812)
        Me.Panel1.TabIndex = 2
        '
        'LblPrecioAgua
        '
        Me.LblPrecioAgua.AutoSize = True
        Me.LblPrecioAgua.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioAgua.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioAgua.Location = New System.Drawing.Point(442, 771)
        Me.LblPrecioAgua.Name = "LblPrecioAgua"
        Me.LblPrecioAgua.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioAgua.TabIndex = 53
        Me.LblPrecioAgua.Text = "00"
        '
        'LblAgua
        '
        Me.LblAgua.AutoSize = True
        Me.LblAgua.BackColor = System.Drawing.Color.Transparent
        Me.LblAgua.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgua.Location = New System.Drawing.Point(432, 748)
        Me.LblAgua.Name = "LblAgua"
        Me.LblAgua.Size = New System.Drawing.Size(42, 17)
        Me.LblAgua.TabIndex = 54
        Me.LblAgua.Text = "Agua"
        '
        'BtnAgua
        '
        Me.BtnAgua.BackColor = System.Drawing.Color.White
        Me.BtnAgua.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Agua
        Me.BtnAgua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgua.Location = New System.Drawing.Point(398, 612)
        Me.BtnAgua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgua.Name = "BtnAgua"
        Me.BtnAgua.Size = New System.Drawing.Size(125, 125)
        Me.BtnAgua.TabIndex = 52
        Me.BtnAgua.UseVisualStyleBackColor = False
        '
        'LblPrecioSprite
        '
        Me.LblPrecioSprite.AutoSize = True
        Me.LblPrecioSprite.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioSprite.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioSprite.Location = New System.Drawing.Point(296, 771)
        Me.LblPrecioSprite.Name = "LblPrecioSprite"
        Me.LblPrecioSprite.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioSprite.TabIndex = 50
        Me.LblPrecioSprite.Text = "00"
        '
        'LblSprite
        '
        Me.LblSprite.AutoSize = True
        Me.LblSprite.BackColor = System.Drawing.Color.Transparent
        Me.LblSprite.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSprite.Location = New System.Drawing.Point(280, 748)
        Me.LblSprite.Name = "LblSprite"
        Me.LblSprite.Size = New System.Drawing.Size(47, 17)
        Me.LblSprite.TabIndex = 51
        Me.LblSprite.Text = "Sprite"
        '
        'BtnSprite
        '
        Me.BtnSprite.BackColor = System.Drawing.Color.White
        Me.BtnSprite.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Sprite
        Me.BtnSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSprite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSprite.Location = New System.Drawing.Point(244, 612)
        Me.BtnSprite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSprite.Name = "BtnSprite"
        Me.BtnSprite.Size = New System.Drawing.Size(125, 125)
        Me.BtnSprite.TabIndex = 49
        Me.BtnSprite.UseVisualStyleBackColor = False
        '
        'LblPrecioFresca
        '
        Me.LblPrecioFresca.AutoSize = True
        Me.LblPrecioFresca.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioFresca.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioFresca.Location = New System.Drawing.Point(135, 771)
        Me.LblPrecioFresca.Name = "LblPrecioFresca"
        Me.LblPrecioFresca.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioFresca.TabIndex = 47
        Me.LblPrecioFresca.Text = "00"
        '
        'LblFresca
        '
        Me.LblFresca.AutoSize = True
        Me.LblFresca.BackColor = System.Drawing.Color.Transparent
        Me.LblFresca.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFresca.Location = New System.Drawing.Point(119, 748)
        Me.LblFresca.Name = "LblFresca"
        Me.LblFresca.Size = New System.Drawing.Size(52, 17)
        Me.LblFresca.TabIndex = 48
        Me.LblFresca.Text = "Fresca"
        '
        'BtnFresca
        '
        Me.BtnFresca.BackColor = System.Drawing.Color.White
        Me.BtnFresca.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Fresca
        Me.BtnFresca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFresca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFresca.Location = New System.Drawing.Point(88, 612)
        Me.BtnFresca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFresca.Name = "BtnFresca"
        Me.BtnFresca.Size = New System.Drawing.Size(125, 125)
        Me.BtnFresca.TabIndex = 46
        Me.BtnFresca.UseVisualStyleBackColor = False
        '
        'LblPrecioFantaFresa
        '
        Me.LblPrecioFantaFresa.AutoSize = True
        Me.LblPrecioFantaFresa.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioFantaFresa.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioFantaFresa.Location = New System.Drawing.Point(512, 579)
        Me.LblPrecioFantaFresa.Name = "LblPrecioFantaFresa"
        Me.LblPrecioFantaFresa.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioFantaFresa.TabIndex = 44
        Me.LblPrecioFantaFresa.Text = "00"
        '
        'LblFantaFresa
        '
        Me.LblFantaFresa.AutoSize = True
        Me.LblFantaFresa.BackColor = System.Drawing.Color.Transparent
        Me.LblFantaFresa.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFantaFresa.Location = New System.Drawing.Point(483, 547)
        Me.LblFantaFresa.Name = "LblFantaFresa"
        Me.LblFantaFresa.Size = New System.Drawing.Size(85, 17)
        Me.LblFantaFresa.TabIndex = 45
        Me.LblFantaFresa.Text = "Fanta Fresa"
        '
        'BtnFantaF
        '
        Me.BtnFantaF.BackColor = System.Drawing.Color.White
        Me.BtnFantaF.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Fanta_Fresa
        Me.BtnFantaF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFantaF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFantaF.Location = New System.Drawing.Point(462, 408)
        Me.BtnFantaF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFantaF.Name = "BtnFantaF"
        Me.BtnFantaF.Size = New System.Drawing.Size(125, 125)
        Me.BtnFantaF.TabIndex = 43
        Me.BtnFantaF.UseVisualStyleBackColor = False
        '
        'LblPrecioFantaNaranja
        '
        Me.LblPrecioFantaNaranja.AutoSize = True
        Me.LblPrecioFantaNaranja.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioFantaNaranja.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioFantaNaranja.Location = New System.Drawing.Point(368, 579)
        Me.LblPrecioFantaNaranja.Name = "LblPrecioFantaNaranja"
        Me.LblPrecioFantaNaranja.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioFantaNaranja.TabIndex = 41
        Me.LblPrecioFantaNaranja.Text = "00"
        '
        'LblFantaNaranja
        '
        Me.LblFantaNaranja.AutoSize = True
        Me.LblFantaNaranja.BackColor = System.Drawing.Color.Transparent
        Me.LblFantaNaranja.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFantaNaranja.Location = New System.Drawing.Point(328, 547)
        Me.LblFantaNaranja.Name = "LblFantaNaranja"
        Me.LblFantaNaranja.Size = New System.Drawing.Size(98, 17)
        Me.LblFantaNaranja.TabIndex = 42
        Me.LblFantaNaranja.Text = "Fanta Naranja"
        '
        'BtnFantaN
        '
        Me.BtnFantaN.BackColor = System.Drawing.Color.White
        Me.BtnFantaN.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Fanta
        Me.BtnFantaN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFantaN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFantaN.Location = New System.Drawing.Point(316, 408)
        Me.BtnFantaN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFantaN.Name = "BtnFantaN"
        Me.BtnFantaN.Size = New System.Drawing.Size(125, 125)
        Me.BtnFantaN.TabIndex = 40
        Me.BtnFantaN.UseVisualStyleBackColor = False
        '
        'LblPrecioDrPepper
        '
        Me.LblPrecioDrPepper.AutoSize = True
        Me.LblPrecioDrPepper.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioDrPepper.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioDrPepper.Location = New System.Drawing.Point(214, 579)
        Me.LblPrecioDrPepper.Name = "LblPrecioDrPepper"
        Me.LblPrecioDrPepper.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioDrPepper.TabIndex = 38
        Me.LblPrecioDrPepper.Text = "00"
        '
        'LblDrPepper
        '
        Me.LblDrPepper.AutoSize = True
        Me.LblDrPepper.BackColor = System.Drawing.Color.Transparent
        Me.LblDrPepper.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrPepper.Location = New System.Drawing.Point(189, 547)
        Me.LblDrPepper.Name = "LblDrPepper"
        Me.LblDrPepper.Size = New System.Drawing.Size(75, 17)
        Me.LblDrPepper.TabIndex = 39
        Me.LblDrPepper.Text = "Dr.Pepper"
        '
        'BtnDrPepper
        '
        Me.BtnDrPepper.BackColor = System.Drawing.Color.White
        Me.BtnDrPepper.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.DrPepper
        Me.BtnDrPepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDrPepper.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDrPepper.Location = New System.Drawing.Point(167, 408)
        Me.BtnDrPepper.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDrPepper.Name = "BtnDrPepper"
        Me.BtnDrPepper.Size = New System.Drawing.Size(125, 125)
        Me.BtnDrPepper.TabIndex = 37
        Me.BtnDrPepper.UseVisualStyleBackColor = False
        '
        'LblPrecioCocaCola
        '
        Me.LblPrecioCocaCola.AutoSize = True
        Me.LblPrecioCocaCola.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioCocaCola.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioCocaCola.Location = New System.Drawing.Point(68, 579)
        Me.LblPrecioCocaCola.Name = "LblPrecioCocaCola"
        Me.LblPrecioCocaCola.Size = New System.Drawing.Size(24, 17)
        Me.LblPrecioCocaCola.TabIndex = 35
        Me.LblPrecioCocaCola.Text = "00"
        '
        'LblCocaCola
        '
        Me.LblCocaCola.AutoSize = True
        Me.LblCocaCola.BackColor = System.Drawing.Color.Transparent
        Me.LblCocaCola.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCocaCola.Location = New System.Drawing.Point(42, 547)
        Me.LblCocaCola.Name = "LblCocaCola"
        Me.LblCocaCola.Size = New System.Drawing.Size(84, 17)
        Me.LblCocaCola.TabIndex = 36
        Me.LblCocaCola.Text = "Coca - Cola"
        '
        'BtnCocaCola
        '
        Me.BtnCocaCola.BackColor = System.Drawing.Color.White
        Me.BtnCocaCola.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Coca_Cola_
        Me.BtnCocaCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCocaCola.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCocaCola.Location = New System.Drawing.Point(23, 408)
        Me.BtnCocaCola.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCocaCola.Name = "BtnCocaCola"
        Me.BtnCocaCola.Size = New System.Drawing.Size(125, 125)
        Me.BtnCocaCola.TabIndex = 34
        Me.BtnCocaCola.UseVisualStyleBackColor = False
        '
        'LblFritoQueso
        '
        Me.LblFritoQueso.AutoSize = True
        Me.LblFritoQueso.BackColor = System.Drawing.Color.Transparent
        Me.LblFritoQueso.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFritoQueso.Location = New System.Drawing.Point(368, 373)
        Me.LblFritoQueso.Name = "LblFritoQueso"
        Me.LblFritoQueso.Size = New System.Drawing.Size(24, 17)
        Me.LblFritoQueso.TabIndex = 32
        Me.LblFritoQueso.Text = "00"
        '
        'LblFritosQueso
        '
        Me.LblFritosQueso.AutoSize = True
        Me.LblFritosQueso.BackColor = System.Drawing.Color.Transparent
        Me.LblFritosQueso.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFritosQueso.Location = New System.Drawing.Point(322, 344)
        Me.LblFritosQueso.Name = "LblFritosQueso"
        Me.LblFritosQueso.Size = New System.Drawing.Size(117, 17)
        Me.LblFritosQueso.TabIndex = 33
        Me.LblFritosQueso.Text = "Fritos con queso"
        '
        'BtnFritosQueso
        '
        Me.BtnFritosQueso.BackColor = System.Drawing.Color.White
        Me.BtnFritosQueso.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.FritosQueso
        Me.BtnFritosQueso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFritosQueso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFritosQueso.Location = New System.Drawing.Point(316, 208)
        Me.BtnFritosQueso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFritosQueso.Name = "BtnFritosQueso"
        Me.BtnFritosQueso.Size = New System.Drawing.Size(125, 125)
        Me.BtnFritosQueso.TabIndex = 31
        Me.BtnFritosQueso.UseVisualStyleBackColor = False
        '
        'LblFrito
        '
        Me.LblFrito.AutoSize = True
        Me.LblFrito.BackColor = System.Drawing.Color.Transparent
        Me.LblFrito.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrito.Location = New System.Drawing.Point(214, 373)
        Me.LblFrito.Name = "LblFrito"
        Me.LblFrito.Size = New System.Drawing.Size(24, 17)
        Me.LblFrito.TabIndex = 29
        Me.LblFrito.Text = "00"
        '
        'LblFritos
        '
        Me.LblFritos.AutoSize = True
        Me.LblFritos.BackColor = System.Drawing.Color.Transparent
        Me.LblFritos.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFritos.Location = New System.Drawing.Point(197, 344)
        Me.LblFritos.Name = "LblFritos"
        Me.LblFritos.Size = New System.Drawing.Size(47, 17)
        Me.LblFritos.TabIndex = 30
        Me.LblFritos.Text = "Fritos"
        '
        'BtnFritos
        '
        Me.BtnFritos.BackColor = System.Drawing.Color.White
        Me.BtnFritos.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.potato_chips
        Me.BtnFritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFritos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFritos.Location = New System.Drawing.Point(161, 208)
        Me.BtnFritos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFritos.Name = "BtnFritos"
        Me.BtnFritos.Size = New System.Drawing.Size(125, 125)
        Me.BtnFritos.TabIndex = 28
        Me.BtnFritos.UseVisualStyleBackColor = False
        '
        'LblPapaQueso
        '
        Me.LblPapaQueso.AutoSize = True
        Me.LblPapaQueso.BackColor = System.Drawing.Color.Transparent
        Me.LblPapaQueso.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPapaQueso.Location = New System.Drawing.Point(512, 180)
        Me.LblPapaQueso.Name = "LblPapaQueso"
        Me.LblPapaQueso.Size = New System.Drawing.Size(24, 17)
        Me.LblPapaQueso.TabIndex = 26
        Me.LblPapaQueso.Text = "00"
        '
        'LblPapasQueso
        '
        Me.LblPapasQueso.AutoSize = True
        Me.LblPapasQueso.BackColor = System.Drawing.Color.Transparent
        Me.LblPapasQueso.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPapasQueso.Location = New System.Drawing.Point(469, 151)
        Me.LblPapasQueso.Name = "LblPapasQueso"
        Me.LblPapasQueso.Size = New System.Drawing.Size(116, 17)
        Me.LblPapasQueso.TabIndex = 27
        Me.LblPapasQueso.Text = "Papas con queso"
        '
        'LblOrdenPapa
        '
        Me.LblOrdenPapa.AutoSize = True
        Me.LblOrdenPapa.BackColor = System.Drawing.Color.Transparent
        Me.LblOrdenPapa.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrdenPapa.Location = New System.Drawing.Point(368, 180)
        Me.LblOrdenPapa.Name = "LblOrdenPapa"
        Me.LblOrdenPapa.Size = New System.Drawing.Size(24, 17)
        Me.LblOrdenPapa.TabIndex = 24
        Me.LblOrdenPapa.Text = "00"
        '
        'LblOrdenPapas
        '
        Me.LblOrdenPapas.AutoSize = True
        Me.LblOrdenPapas.BackColor = System.Drawing.Color.Transparent
        Me.LblOrdenPapas.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrdenPapas.Location = New System.Drawing.Point(301, 151)
        Me.LblOrdenPapas.Name = "LblOrdenPapas"
        Me.LblOrdenPapas.Size = New System.Drawing.Size(158, 17)
        Me.LblOrdenPapas.TabIndex = 25
        Me.LblOrdenPapas.Text = "Orden de papas (solas)"
        '
        'LblNachos
        '
        Me.LblNachos.AutoSize = True
        Me.LblNachos.BackColor = System.Drawing.Color.Transparent
        Me.LblNachos.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNachos.Location = New System.Drawing.Point(214, 180)
        Me.LblNachos.Name = "LblNachos"
        Me.LblNachos.Size = New System.Drawing.Size(24, 17)
        Me.LblNachos.TabIndex = 22
        Me.LblNachos.Text = "00"
        '
        'LblNacho
        '
        Me.LblNacho.AutoSize = True
        Me.LblNacho.BackColor = System.Drawing.Color.Transparent
        Me.LblNacho.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNacho.Location = New System.Drawing.Point(197, 151)
        Me.LblNacho.Name = "LblNacho"
        Me.LblNacho.Size = New System.Drawing.Size(56, 17)
        Me.LblNacho.TabIndex = 23
        Me.LblNacho.Text = "Nachos"
        '
        'LblHotDog
        '
        Me.LblHotDog.AutoSize = True
        Me.LblHotDog.BackColor = System.Drawing.Color.Transparent
        Me.LblHotDog.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHotDog.Location = New System.Drawing.Point(68, 180)
        Me.LblHotDog.Name = "LblHotDog"
        Me.LblHotDog.Size = New System.Drawing.Size(24, 17)
        Me.LblHotDog.TabIndex = 20
        Me.LblHotDog.Text = "00"
        '
        'LblHotDogs
        '
        Me.LblHotDogs.AutoSize = True
        Me.LblHotDogs.BackColor = System.Drawing.Color.Transparent
        Me.LblHotDogs.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHotDogs.Location = New System.Drawing.Point(47, 151)
        Me.LblHotDogs.Name = "LblHotDogs"
        Me.LblHotDogs.Size = New System.Drawing.Size(72, 17)
        Me.LblHotDogs.TabIndex = 21
        Me.LblHotDogs.Text = "Hot-Dogs"
        '
        'BtnPapasQueso
        '
        Me.BtnPapasQueso.BackColor = System.Drawing.Color.White
        Me.BtnPapasQueso.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.papas_fritas
        Me.BtnPapasQueso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPapasQueso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPapasQueso.Location = New System.Drawing.Point(462, 14)
        Me.BtnPapasQueso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPapasQueso.Name = "BtnPapasQueso"
        Me.BtnPapasQueso.Size = New System.Drawing.Size(125, 125)
        Me.BtnPapasQueso.TabIndex = 19
        Me.BtnPapasQueso.UseVisualStyleBackColor = False
        '
        'BtnOrdenPapasSolas
        '
        Me.BtnOrdenPapasSolas.BackColor = System.Drawing.Color.White
        Me.BtnOrdenPapasSolas.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.papas_fritas__1_
        Me.BtnOrdenPapasSolas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOrdenPapasSolas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOrdenPapasSolas.Location = New System.Drawing.Point(316, 14)
        Me.BtnOrdenPapasSolas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOrdenPapasSolas.Name = "BtnOrdenPapasSolas"
        Me.BtnOrdenPapasSolas.Size = New System.Drawing.Size(125, 125)
        Me.BtnOrdenPapasSolas.TabIndex = 18
        Me.BtnOrdenPapasSolas.UseVisualStyleBackColor = False
        '
        'BtnNachos
        '
        Me.BtnNachos.BackColor = System.Drawing.Color.White
        Me.BtnNachos.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.nachos
        Me.BtnNachos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNachos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNachos.Location = New System.Drawing.Point(167, 14)
        Me.BtnNachos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNachos.Name = "BtnNachos"
        Me.BtnNachos.Size = New System.Drawing.Size(125, 125)
        Me.BtnNachos.TabIndex = 17
        Me.BtnNachos.UseVisualStyleBackColor = False
        '
        'BtnHotDog
        '
        Me.BtnHotDog.BackColor = System.Drawing.Color.White
        Me.BtnHotDog.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.hot_dog
        Me.BtnHotDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHotDog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHotDog.Location = New System.Drawing.Point(23, 14)
        Me.BtnHotDog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHotDog.Name = "BtnHotDog"
        Me.BtnHotDog.Size = New System.Drawing.Size(125, 125)
        Me.BtnHotDog.TabIndex = 16
        Me.BtnHotDog.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Controls.Add(Me.ListPedido)
        Me.Panel2.Controls.Add(Me.BtnAgregarVenta)
        Me.Panel2.Controls.Add(Me.TxtTotal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(610, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(390, 812)
        Me.Panel2.TabIndex = 8
        '
        'ListPedido
        '
        Me.ListPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListPedido.DisplayMember = "FolioAD"
        Me.ListPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListPedido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPedido.FormattingEnabled = True
        Me.ListPedido.ItemHeight = 19
        Me.ListPedido.Location = New System.Drawing.Point(0, 0)
        Me.ListPedido.Name = "ListPedido"
        Me.ListPedido.Size = New System.Drawing.Size(390, 684)
        Me.ListPedido.TabIndex = 0
        Me.ListPedido.ValueMember = "FolioAD"
        '
        'BtnAgregarVenta
        '
        Me.BtnAgregarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregarVenta.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarVenta.Location = New System.Drawing.Point(95, 756)
        Me.BtnAgregarVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarVenta.Name = "BtnAgregarVenta"
        Me.BtnAgregarVenta.Size = New System.Drawing.Size(197, 46)
        Me.BtnAgregarVenta.TabIndex = 13
        Me.BtnAgregarVenta.Text = "Agregar Venta"
        Me.BtnAgregarVenta.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(95, 702)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(268, 35)
        Me.TxtTotal.TabIndex = 12
        Me.TxtTotal.Text = "0.00"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 713)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total"
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
        Me.TableAdapterManager.comidasTableAdapter = Me.ComidasTableAdapter
        Me.TableAdapterManager.estatusCajaTableAdapter = Me.EstatusCajaTableAdapter
        Me.TableAdapterManager.ingredientesTableAdapter = Me.IngredientesTableAdapter
        Me.TableAdapterManager.RetirosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SnackPuntoVenta.SnackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'ComidasTableAdapter
        '
        Me.ComidasTableAdapter.ClearBeforeFill = True
        '
        'EstatusCajaTableAdapter
        '
        Me.EstatusCajaTableAdapter.ClearBeforeFill = True
        '
        'IngredientesTableAdapter
        '
        Me.IngredientesTableAdapter.ClearBeforeFill = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'ComidasBindingSource
        '
        Me.ComidasBindingSource.DataMember = "comidas"
        Me.ComidasBindingSource.DataSource = Me.SnackDataSet
        '
        'EstatusCajaBindingSource
        '
        Me.EstatusCajaBindingSource.DataMember = "estatusCaja"
        Me.EstatusCajaBindingSource.DataSource = Me.SnackDataSet
        '
        'IngredientesBindingSource
        '
        Me.IngredientesBindingSource.DataMember = "ingredientes"
        Me.IngredientesBindingSource.DataSource = Me.SnackDataSet
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.SnackDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Pago con:"
        '
        'TxtPagoCon
        '
        Me.TxtPagoCon.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPagoCon.Location = New System.Drawing.Point(172, 291)
        Me.TxtPagoCon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPagoCon.Name = "TxtPagoCon"
        Me.TxtPagoCon.Size = New System.Drawing.Size(246, 29)
        Me.TxtPagoCon.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cambio:"
        '
        'TxtCambio
        '
        Me.TxtCambio.Enabled = False
        Me.TxtCambio.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCambio.Location = New System.Drawing.Point(172, 361)
        Me.TxtCambio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCambio.Name = "TxtCambio"
        Me.TxtCambio.Size = New System.Drawing.Size(246, 29)
        Me.TxtCambio.TabIndex = 13
        '
        'BtnPagar
        '
        Me.BtnPagar.BackColor = System.Drawing.Color.Coral
        Me.BtnPagar.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.metodo_de_pago
        Me.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPagar.Enabled = False
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPagar.Location = New System.Drawing.Point(53, 436)
        Me.BtnPagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(149, 150)
        Me.BtnPagar.TabIndex = 14
        Me.BtnPagar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 606)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Pagar"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Total", True))
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TotalTextBox.Location = New System.Drawing.Point(172, 325)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(246, 29)
        Me.TotalTextBox.TabIndex = 22
        '
        'CompradorTextBox
        '
        Me.CompradorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Comprador", True))
        Me.CompradorTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CompradorTextBox.Location = New System.Drawing.Point(172, 256)
        Me.CompradorTextBox.Name = "CompradorTextBox"
        Me.CompradorTextBox.Size = New System.Drawing.Size(246, 29)
        Me.CompradorTextBox.TabIndex = 20
        '
        'VendedorTextBox
        '
        Me.VendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Vendedor", True))
        Me.VendedorTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.VendedorTextBox.Location = New System.Drawing.Point(172, 221)
        Me.VendedorTextBox.Name = "VendedorTextBox"
        Me.VendedorTextBox.Size = New System.Drawing.Size(246, 29)
        Me.VendedorTextBox.TabIndex = 18
        '
        'FolioVentaTextBox
        '
        Me.FolioVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "FolioVenta", True))
        Me.FolioVentaTextBox.Enabled = False
        Me.FolioVentaTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FolioVentaTextBox.Location = New System.Drawing.Point(172, 187)
        Me.FolioVentaTextBox.Name = "FolioVentaTextBox"
        Me.FolioVentaTextBox.Size = New System.Drawing.Size(246, 29)
        Me.FolioVentaTextBox.TabIndex = 16
        '
        'MontoActualTextBox
        '
        Me.MontoActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "montoActual", True))
        Me.MontoActualTextBox.Enabled = False
        Me.MontoActualTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MontoActualTextBox.Location = New System.Drawing.Point(71, 690)
        Me.MontoActualTextBox.Name = "MontoActualTextBox"
        Me.MontoActualTextBox.Size = New System.Drawing.Size(325, 29)
        Me.MontoActualTextBox.TabIndex = 23
        '
        'MontoFinal_generadoTextBox
        '
        Me.MontoFinal_generadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusCajaBindingSource, "montoFinal_generado", True))
        Me.MontoFinal_generadoTextBox.Enabled = False
        Me.MontoFinal_generadoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MontoFinal_generadoTextBox.Location = New System.Drawing.Point(71, 750)
        Me.MontoFinal_generadoTextBox.Name = "MontoFinal_generadoTextBox"
        Me.MontoFinal_generadoTextBox.Size = New System.Drawing.Size(325, 29)
        Me.MontoFinal_generadoTextBox.TabIndex = 24
        '
        'BtnCambio
        '
        Me.BtnCambio.BackColor = System.Drawing.Color.Coral
        Me.BtnCambio.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.cambio
        Me.BtnCambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCambio.Enabled = False
        Me.BtnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCambio.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambio.Location = New System.Drawing.Point(229, 435)
        Me.BtnCambio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCambio.Name = "BtnCambio"
        Me.BtnCambio.Size = New System.Drawing.Size(149, 150)
        Me.BtnCambio.TabIndex = 14
        Me.BtnCambio.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 606)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Cambio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 40)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tomar orden."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SnackPuntoVenta.My.Resources.Resources.NombreLocal
        Me.PictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = Global.SnackPuntoVenta.My.Resources.Resources.Orange_Coral
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(MontoFinal_generadoLabel)
        Me.Panel4.Controls.Add(Me.BtnCambio)
        Me.Panel4.Controls.Add(Me.MontoFinal_generadoTextBox)
        Me.Panel4.Controls.Add(MontoActualLabel)
        Me.Panel4.Controls.Add(Me.MontoActualTextBox)
        Me.Panel4.Controls.Add(FolioVentaLabel)
        Me.Panel4.Controls.Add(Me.FolioVentaTextBox)
        Me.Panel4.Controls.Add(VendedorLabel)
        Me.Panel4.Controls.Add(Me.VendedorTextBox)
        Me.Panel4.Controls.Add(CompradorLabel)
        Me.Panel4.Controls.Add(Me.CompradorTextBox)
        Me.Panel4.Controls.Add(TotalLabel)
        Me.Panel4.Controls.Add(Me.TotalTextBox)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.BtnPagar)
        Me.Panel4.Controls.Add(Me.TxtCambio)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtPagoCon)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(1000, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(444, 812)
        Me.Panel4.TabIndex = 9
        '
        'RealizarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1444, 836)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealizarPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarPedido"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SnackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstatusCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarUnArtículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisminuirComplementosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JalapeñosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CebollasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TomatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DolaresAPesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActuzliarLaCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuministrarInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblPrecioAgua As Label
    Friend WithEvents LblAgua As Label
    Friend WithEvents BtnAgua As Button
    Friend WithEvents LblPrecioSprite As Label
    Friend WithEvents LblSprite As Label
    Friend WithEvents BtnSprite As Button
    Friend WithEvents LblPrecioFresca As Label
    Friend WithEvents LblFresca As Label
    Friend WithEvents BtnFresca As Button
    Friend WithEvents LblPrecioFantaFresa As Label
    Friend WithEvents LblFantaFresa As Label
    Friend WithEvents BtnFantaF As Button
    Friend WithEvents LblPrecioFantaNaranja As Label
    Friend WithEvents LblFantaNaranja As Label
    Friend WithEvents BtnFantaN As Button
    Friend WithEvents LblPrecioDrPepper As Label
    Friend WithEvents LblDrPepper As Label
    Friend WithEvents BtnDrPepper As Button
    Friend WithEvents LblPrecioCocaCola As Label
    Friend WithEvents LblCocaCola As Label
    Friend WithEvents BtnCocaCola As Button
    Friend WithEvents LblFritoQueso As Label
    Friend WithEvents LblFritosQueso As Label
    Friend WithEvents BtnFritosQueso As Button
    Friend WithEvents LblFrito As Label
    Friend WithEvents LblFritos As Label
    Friend WithEvents BtnFritos As Button
    Friend WithEvents LblPapaQueso As Label
    Friend WithEvents LblPapasQueso As Label
    Friend WithEvents LblOrdenPapa As Label
    Friend WithEvents LblOrdenPapas As Label
    Friend WithEvents LblNachos As Label
    Friend WithEvents LblNacho As Label
    Friend WithEvents LblHotDog As Label
    Friend WithEvents LblHotDogs As Label
    Friend WithEvents BtnPapasQueso As Button
    Friend WithEvents BtnOrdenPapasSolas As Button
    Friend WithEvents BtnNachos As Button
    Friend WithEvents BtnHotDog As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListPedido As ListBox
    Friend WithEvents BtnAgregarVenta As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SnackDataSet As SnackDataSet
    Friend WithEvents BebidasBindingSource As BindingSource
    Friend WithEvents BebidasTableAdapter As SnackDataSetTableAdapters.BebidasTableAdapter
    Friend WithEvents TableAdapterManager As SnackDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComidasTableAdapter As SnackDataSetTableAdapters.comidasTableAdapter
    Friend WithEvents ComidasBindingSource As BindingSource
    Friend WithEvents EstatusCajaTableAdapter As SnackDataSetTableAdapters.estatusCajaTableAdapter
    Friend WithEvents EstatusCajaBindingSource As BindingSource
    Friend WithEvents IngredientesTableAdapter As SnackDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents IngredientesBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As SnackDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPagoCon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCambio As TextBox
    Friend WithEvents BtnPagar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents CompradorTextBox As TextBox
    Friend WithEvents VendedorTextBox As TextBox
    Friend WithEvents FolioVentaTextBox As TextBox
    Friend WithEvents MontoActualTextBox As TextBox
    Friend WithEvents MontoFinal_generadoTextBox As TextBox
    Friend WithEvents BtnCambio As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
End Class
