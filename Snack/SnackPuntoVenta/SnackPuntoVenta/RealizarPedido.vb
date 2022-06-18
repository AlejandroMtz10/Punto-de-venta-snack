Public Class RealizarPedido

    Dim Cantidad, i As Integer
    Dim cadenaCantidad As String

    'Se guarda el stock en estas variables
    Dim sCocaCola, sDrPepper, sFantaN, sFantaF, sSprite, sFresca, sAgua As Integer

    Dim hotdog = 0, nachos = 0, papasSolas = 0, papasQueso = 0, fritos = 0, fritosQueso = 0
    Dim cocaCola = 0, drPepper = 0, fantaN = 0, fantaF = 0, fresca = 0, sprite = 0, agua = 0

    'Para obtener los ingredientes
    Dim gCatsup = "Catsup", bFritos = "Fritos", gMayonesa = "Mayonesa", gMostaza = "Mostaza", bNachos = "Nachos", bPan = "Pan para hot dog", bPapas = "Papas Francesas", bQueso = "Queso Chedar", pSalchicha = "Salchichas"



    Dim gLeche = "Leche", lJalapeno = "Chiles jalapeño en rodajas", cebolla = "Cebollas blancas", tomate = "Tomates"

    Private Sub CebollasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CebollasToolStripMenuItem.Click
        IngredientesTableAdapter.ReducirIngredientes(cebolla)
        Me.Validate()
        Me.IngredientesBindingSource.EndEdit()
        Me.IngredientesTableAdapter.Update(Me.SnackDataSet.ingredientes)
        Me.Refresh()
    End Sub

    Private Sub TomatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TomatesToolStripMenuItem.Click
        IngredientesTableAdapter.ReducirIngredientes(tomate)
        Me.Validate()
        Me.IngredientesBindingSource.EndEdit()
        Me.IngredientesTableAdapter.Update(Me.SnackDataSet.ingredientes)
        Me.Refresh()
    End Sub

    Private Sub DolaresAPesosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DolaresAPesosToolStripMenuItem.Click
        Conversion.Show()
    End Sub

    Private Sub JalapeñosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JalapeñosToolStripMenuItem.Click
        IngredientesTableAdapter.ReducirIngredientes(lJalapeno)
        Me.Validate()
        Me.IngredientesBindingSource.EndEdit()
        Me.IngredientesTableAdapter.Update(Me.SnackDataSet.ingredientes)
        Me.Refresh()
    End Sub

    Private Sub ActuzliarLaCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActuzliarLaCajaToolStripMenuItem.Click
        actualizarCaja()
    End Sub

    Private Sub SuministrarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuministrarInventarioToolStripMenuItem.Click
        SuministrarInventario.Show()
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Dim sCatsup, sFritos, sMayonesa, sMostaza, sNachos, sPanHot, sPapas, sQueso, sSalchichas As Integer
    Dim sLeche, sJalapeno, sCebolla, sTomate As Integer

    Private Sub RealizarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.SnackDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.ingredientes' Puede moverla o quitarla según sea necesario.
        Me.IngredientesTableAdapter.Fill(Me.SnackDataSet.ingredientes)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.estatusCaja' Puede moverla o quitarla según sea necesario.
        Me.EstatusCajaTableAdapter.Fill(Me.SnackDataSet.estatusCaja)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.comidas' Puede moverla o quitarla según sea necesario.
        Me.ComidasTableAdapter.Fill(Me.SnackDataSet.comidas)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        Me.BebidasTableAdapter.Fill(Me.SnackDataSet.Bebidas)

        'Para obtener los precios de los platillos desde la base de datos
        LblHotDog.Text = ComidasTableAdapter.PrecioComida(LblHotDogs.Text)
        LblNachos.Text = ComidasTableAdapter.PrecioComida(LblNacho.Text)
        LblOrdenPapa.Text = ComidasTableAdapter.PrecioComida(LblOrdenPapas.Text)
        LblFrito.Text = ComidasTableAdapter.PrecioComida(LblFritos.Text)
        LblFritoQueso.Text = ComidasTableAdapter.PrecioComida(LblFritosQueso.Text)
        LblPapaQueso.Text = ComidasTableAdapter.PrecioComida(LblPapasQueso.Text)

        'Para obtener los precios de las bebidas desde la base de datos
        LblPrecioCocaCola.Text = BebidasTableAdapter.PrecioBebidas(LblCocaCola.Text)
        LblPrecioDrPepper.Text = BebidasTableAdapter.PrecioBebidas(LblDrPepper.Text)
        LblPrecioFantaNaranja.Text = BebidasTableAdapter.PrecioBebidas(LblFantaNaranja.Text)
        LblPrecioFantaFresa.Text = BebidasTableAdapter.PrecioBebidas(LblFantaFresa.Text)
        LblPrecioFresca.Text = BebidasTableAdapter.PrecioBebidas(LblFresca.Text)
        LblPrecioSprite.Text = BebidasTableAdapter.PrecioBebidas(LblSprite.Text)
        LblPrecioAgua.Text = BebidasTableAdapter.PrecioBebidas(LblAgua.Text)
        limpiarTxts()

        inventarioBebidas()
        inventarioIngredientes()
        actualizarCaja()

    End Sub

    Public Sub limpiarTxts()
        ListPedido.Items.Clear()
        TotalTextBox.Clear()
        TxtPagoCon.Clear()
        TxtCambio.Clear()
        CompradorTextBox.Clear()
        FolioVentaTextBox.Clear()
    End Sub

    Public Sub contadoresEnCero()
        hotdog = 0
        nachos = 0
        papasSolas = 0
        papasQueso = 0
        fritos = 0
        fritosQueso = 0

        cocaCola = 0
        drPepper = 0
        fantaN = 0
        fantaF = 0
        fresca = 0
        sprite = 0
        agua = 0
    End Sub

    'Metodo para revisar el inventario de las bebidas y mandar una alerta cuando sea bajo o este vacia alguna bebida
    Public Sub inventarioBebidas()
        sCocaCola = Val(BebidasTableAdapter.StockBebidas(LblCocaCola.Text))
        sDrPepper = Val(BebidasTableAdapter.StockBebidas(LblDrPepper.Text))
        sFantaN = Val(BebidasTableAdapter.StockBebidas(LblFantaNaranja.Text))
        sFantaF = Val(BebidasTableAdapter.StockBebidas(LblFantaFresa.Text))
        sFresca = Val(BebidasTableAdapter.StockBebidas(LblFresca.Text))
        sSprite = Val(BebidasTableAdapter.StockBebidas(LblSprite.Text))
        sAgua = Val(BebidasTableAdapter.StockBebidas(LblAgua.Text))

        If sCocaCola = 0 Then
            MsgBox("No hay latas de Coca - Cola, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sCocaCola >= 1 And sCocaCola <= 5 Then
            MsgBox("Quedan pocas latas de Coca - Cola, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sDrPepper = 0 Then
            MsgBox("No hay latas de Dr.Pepper, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sDrPepper >= 1 And sDrPepper <= 5 Then
            MsgBox("Quedan pocas latas de Dr.Pepper, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sFantaN = 0 Then
            MsgBox("No hay latas de Fanta de Naranja, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sFantaN >= 1 And sFantaN <= 5 Then
            MsgBox("Quedan pocas latas de Fanta de Naranja, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sFantaF = 0 Then
            MsgBox("No hay latas de Fanta de Fresa, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sFantaF >= 1 And sFantaF <= 5 Then
            MsgBox("Quedan pocas latas de Fanta de Fresa, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sFresca = 0 Then
            MsgBox("No hay botellas de Fresca, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sFresca >= 1 And sFresca <= 5 Then
            MsgBox("Quedan pocas botellas de Fresca, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sSprite = 0 Then
            MsgBox("No hay latas de Sprite, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sSprite >= 1 And sSprite <= 5 Then
            MsgBox("Quedan pocas latas de Sprite, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sAgua = 0 Then
            MsgBox("No hay botellas de Agua, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sAgua >= 1 And sAgua <= 5 Then
            MsgBox("Quedan pocas botellas de Agua, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
    End Sub

    Public Sub inventarioIngredientes()
        sLeche = Val(IngredientesTableAdapter.StockIngrediente(gLeche))
        sCatsup = Val(IngredientesTableAdapter.StockIngrediente(gCatsup))
        sFritos = Val(IngredientesTableAdapter.StockIngrediente(bFritos))
        sMayonesa = Val(IngredientesTableAdapter.StockIngrediente(gMayonesa))
        sMostaza = Val(IngredientesTableAdapter.StockIngrediente(gMostaza))
        sNachos = Val(IngredientesTableAdapter.StockIngrediente(bNachos))
        sPanHot = Val(IngredientesTableAdapter.StockIngrediente(bPan))
        sSalchichas = Val(IngredientesTableAdapter.StockIngrediente(pSalchicha))
        sPapas = Val(IngredientesTableAdapter.StockIngrediente(bPapas))
        sQueso = Val(IngredientesTableAdapter.StockIngrediente(bQueso))
        sJalapeno = Val(IngredientesTableAdapter.StockIngrediente(lJalapeno))
        sCebolla = Val(IngredientesTableAdapter.StockIngrediente(cebolla))
        sTomate = Val(IngredientesTableAdapter.StockIngrediente(tomate))

        If sCatsup = 0 Then
            MsgBox("No hay catsup, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sCatsup = 1 Then
            MsgBox("Quedan poca catsup, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If

        If sFritos = 0 Then
            MsgBox("No hay bolsas de fritos, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sFritos >= 1 And sFritos <= 10 Then
            MsgBox("Quedan pocas bolsas de fritos, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sMayonesa = 0 Then
            MsgBox("No hay mayonesa, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sMayonesa = 1 Then
            MsgBox("Quedan poca mayonesa, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sMostaza = 0 Then
            MsgBox("No hay mostaza, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sMostaza = 1 Then
            MsgBox("Quedan poca mostaza, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sNachos = 0 Then
            MsgBox("No hay nachos, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sNachos = 1 Then
            MsgBox("Quedan poca nachos, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sPanHot = 0 Then
            MsgBox("No hay bolsas de pan para hot dog, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sPanHot >= 1 And sPanHot <= 3 Then
            MsgBox("Quedan pocas bolsas de pan para hot dog, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sPapas = 0 Then
            MsgBox("No hay bolsas de papas, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sPapas >= 1 And sPapas <= 3 Then
            MsgBox("Quedan pocas bolsas de papas, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sQueso = 0 Then
            MsgBox("No hay latas de queso chedar, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sQueso >= 1 And sQueso <= 3 Then
            MsgBox("Quedan pocas latas de queso chedar, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sSalchichas = 0 Then
            MsgBox("No hay paquetes de salchichas, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sSalchichas >= 1 And sSalchichas <= 2 Then
            MsgBox("Quedan pocos paquetes de salchichas, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sLeche = 0 Then
            MsgBox("No hay galones de leche, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sLeche = 1 Then
            MsgBox("Quedan pocos galones de leche, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sJalapeno = 0 Then
            MsgBox("No hay latas de jalapeño, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sJalapeno >= 1 And sJalapeno <= 3 Then
            MsgBox("Quedan pocas latas de jalapeño, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
        If sCebolla = 0 Then
            MsgBox("No hay cebollas, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        ElseIf sCebolla >= 1 And sCebolla <= 4 Then
            MsgBox("Quedan pocas cebollas, rellene el inventario.", vbExclamation, "Rellene el inventario.")
        End If
    End Sub

    'Botnes para las comidas
    Private Sub BtnHotDog_Click(sender As Object, e As EventArgs) Handles BtnHotDog.Click
        sCatsup = Val(IngredientesTableAdapter.StockIngrediente(gCatsup))
        sMayonesa = Val(IngredientesTableAdapter.StockIngrediente(gMayonesa))
        sMostaza = Val(IngredientesTableAdapter.StockIngrediente(gMostaza))
        sPanHot = Val(IngredientesTableAdapter.StockIngrediente(bPan))
        sSalchichas = Val(IngredientesTableAdapter.StockIngrediente(pSalchicha))

        cadenaCantidad = InputBox("Cantidad de hot-dogs a comprar: ", "Hot-Dogs.")
        Cantidad = Val(cadenaCantidad)
        If 1 < sCatsup And 1 < sMayonesa And 1 < sMostaza And 1 < sPanHot And 1 < sSalchichas Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblHotDogs.Text & "                 " & LblHotDog.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblHotDog.Text)
                hotdog = hotdog + 1
            Next
        Else
            MsgBox("No hay suficientes ingredientes para hacer un hot dog, rellene el inventario.", vbExclamation, "Hot - dog no disponible.")
        End If
    End Sub

    Private Sub BtnNachos_Click(sender As Object, e As EventArgs) Handles BtnNachos.Click
        sNachos = Val(IngredientesTableAdapter.StockIngrediente(bNachos))
        sQueso = Val(IngredientesTableAdapter.StockIngrediente(bQueso))
        sLeche = Val(IngredientesTableAdapter.StockIngrediente(gLeche))

        cadenaCantidad = InputBox("Cantidad de platillos de nachos a comprar: ", "Nachos.")
        Cantidad = Val(cadenaCantidad)

        If sNachos > 0 And sQueso > 0 And sLeche > 0 Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblNacho.Text & "                  " & LblNachos.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblNachos.Text)
                nachos = nachos + 1
            Next
        Else
            MsgBox("No hay suficientes ingredientes para hacer nachos, rellene el inventario.", vbExclamation, "Nachos no disponible.")
        End If
    End Sub

    Private Sub BtnOrdenPapasSolas_Click(sender As Object, e As EventArgs) Handles BtnOrdenPapasSolas.Click
        sPapas = Val(IngredientesTableAdapter.StockIngrediente(bPapas))

        cadenaCantidad = InputBox("Numero de ordenes de papas solas: ", "Ordenes de papas.")
        Cantidad = Val(cadenaCantidad)

        If 1 < sPapas Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblOrdenPapas.Text & "             " & LblOrdenPapa.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblOrdenPapa.Text)
                papasSolas = papasSolas + 1
            Next
        Else
            MsgBox("No hay suficientes papas para una orden, rellene el inventario.", vbExclamation, "Orden de papas no disponible.")
        End If
    End Sub

    Private Sub BtnPapasQueso_Click(sender As Object, e As EventArgs) Handles BtnPapasQueso.Click
        sQueso = Val(IngredientesTableAdapter.StockIngrediente(bQueso))
        sLeche = Val(IngredientesTableAdapter.StockIngrediente(gLeche))
        sPapas = Val(IngredientesTableAdapter.StockIngrediente(bPapas))

        cadenaCantidad = InputBox("Numero de ordenes de papas con queso: ", "Ordenes de papas con queso.")
        Cantidad = Val(cadenaCantidad)
        If 1 < sQueso And 1 < sLeche And 1 < sPapas Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblPapasQueso.Text & "           " & LblPapaQueso.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPapaQueso.Text)
                papasQueso = papasQueso + 1
            Next
        Else
            MsgBox("No hay suficientes ingredientes para hacer papas con queso, rellene el inventario.", vbExclamation, "Papas con queso no disponibles no disponible.")
        End If
    End Sub

    Private Sub BtnFritos_Click(sender As Object, e As EventArgs) Handles BtnFritos.Click
        sFritos = Val(IngredientesTableAdapter.StockIngrediente(bFritos))

        cadenaCantidad = InputBox("Numero de bolsas de fritos: ", "Fritos.")
        Cantidad = Val(cadenaCantidad)

        If 1 < sFritos Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblFritos.Text & "          " & LblFrito.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblFrito.Text)
                fritos = fritos + 1
            Next
        Else
            MsgBox("No hay fritos, rellene el inventario.", vbExclamation, "Fritos no disponible.")
        End If
    End Sub

    Private Sub BtnFritosQueso_Click(sender As Object, e As EventArgs) Handles BtnFritosQueso.Click
        sQueso = Val(IngredientesTableAdapter.StockIngrediente(bQueso))
        sLeche = Val(IngredientesTableAdapter.StockIngrediente(gLeche))
        sFritos = Val(IngredientesTableAdapter.StockIngrediente(bFritos))

        cadenaCantidad = InputBox("Numero de ordenes de fritos con queso: ", "Fritos con queso.")
        Cantidad = Val(cadenaCantidad)

        If 1 < sFritos And 1 < sQueso And 1 < sLeche Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblFritosQueso.Text & "             " & LblFritoQueso.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblFritoQueso.Text)
                fritosQueso = fritosQueso + 1
            Next
        Else
            MsgBox("No hay ingredientes para hacer fritos con queso, rellene el inventario.", vbExclamation, "Fritos con queso no disponibles.")
        End If
    End Sub

    'Botones para las bebidas
    Private Sub BtnCocaCola_Click(sender As Object, e As EventArgs) Handles BtnCocaCola.Click
        sCocaCola = Val(BebidasTableAdapter.StockBebidas(LblCocaCola.Text))
        cadenaCantidad = InputBox("Número de latas: ", "Coca - Cola.")
        Cantidad = Val(cadenaCantidad)
        If Cantidad <= sCocaCola Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblCocaCola.Text & "          " & LblPrecioCocaCola.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioCocaCola.Text)
                cocaCola = cocaCola + 1
            Next
        Else
            MsgBox("No hay Coca - Cola disponible, rellene el inventario.", vbExclamation, "Coca - Cola no disponible.")
        End If
    End Sub

    Private Sub BtnDrPepper_Click(sender As Object, e As EventArgs) Handles BtnDrPepper.Click
        sDrPepper = Val(BebidasTableAdapter.StockBebidas(LblDrPepper.Text))
        cadenaCantidad = InputBox("Número de latas: ", "Dr.Pepper.")
        Cantidad = Val(cadenaCantidad)

        If Cantidad <= sDrPepper Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblDrPepper.Text & "         " & LblPrecioDrPepper.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioDrPepper.Text)
                drPepper = drPepper + 1
            Next
        Else
            MsgBox("No hay Dr.Pepper disponible, rellene el inventario.", vbExclamation, "Dr.Pepper no disponible.")
        End If

    End Sub

    Private Sub BtnFantaN_Click(sender As Object, e As EventArgs) Handles BtnFantaN.Click
        sFantaN = Val(BebidasTableAdapter.StockBebidas(LblFantaNaranja.Text))
        cadenaCantidad = InputBox("Número de latas: ", "Fanta de Naranja.")
        Cantidad = Val(cadenaCantidad)
        If Cantidad <= sFantaN Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblFantaNaranja.Text & "       " & LblPrecioFantaNaranja.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioFantaNaranja.Text)
                fantaN = fantaN + 1
            Next
        Else
            MsgBox("No hay Fanta de naranja disponible, rellene el inventario.", vbExclamation, "Fanta de naranja no disponible.")
        End If
    End Sub

    Private Sub BtnFantaF_Click(sender As Object, e As EventArgs) Handles BtnFantaF.Click
        sFantaF = Val(BebidasTableAdapter.StockBebidas(LblFantaFresa.Text))
        cadenaCantidad = InputBox("Número de latas: ", "Fanta de Fresa.")
        Cantidad = Val(cadenaCantidad)

        If Cantidad <= sFantaF Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblFantaFresa.Text & "      " & LblPrecioFantaFresa.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioFantaFresa.Text)
                fantaF = fantaF + 1
            Next
        Else
            MsgBox("No hay Fanta de fresa disponible, rellene el inventario.", vbExclamation, "Fanta de fresa no disponible.")
        End If
    End Sub

    Private Sub BtnFresca_Click(sender As Object, e As EventArgs) Handles BtnFresca.Click
        sFresca = Val(BebidasTableAdapter.StockBebidas(LblFresca.Text))
        cadenaCantidad = InputBox("Número de botellas: ", "Fresca.")
        Cantidad = Val(cadenaCantidad)
        If Cantidad <= sFresca Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblFresca.Text & "           " & LblPrecioFresca.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioFresca.Text)
                fresca = fresca + 1
            Next
        Else
            MsgBox("No hay Fresca disponible, rellene el inventario.", vbExclamation, "Fresca no disponible.")
        End If
    End Sub

    Private Sub BtnSprite_Click(sender As Object, e As EventArgs) Handles BtnSprite.Click
        sSprite = Val(BebidasTableAdapter.StockBebidas(LblSprite.Text))
        cadenaCantidad = InputBox("Número de latas: ", "Sprite.")
        Cantidad = Val(cadenaCantidad)
        If Cantidad <= sSprite Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblSprite.Text & "         " & LblPrecioSprite.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioSprite.Text)
                sprite = sprite + 1
            Next
        Else
            MsgBox("No hay Sprite disponible, rellene el inventario.", vbExclamation, "Sprite no disponible.")
        End If
    End Sub
    Private Sub BtnAgua_Click(sender As Object, e As EventArgs) Handles BtnAgua.Click
        sAgua = Val(BebidasTableAdapter.StockBebidas(LblAgua.Text))
        cadenaCantidad = InputBox("Número de botellas: ", "Agua.")
        Cantidad = Val(cadenaCantidad)
        If Cantidad <= sAgua Then
            For i = 1 To Cantidad
                ListPedido.Items.Add(LblAgua.Text & "         " & LblPrecioAgua.Text)
                TxtTotal.Text = Val(TxtTotal.Text) + Val(LblPrecioAgua.Text)
                agua = agua + 1
            Next
        Else
            MsgBox("No hay botellas de agua disponibles, rellene el inventario.", vbExclamation, "Botellas de agua no disponible.")
        End If
    End Sub

    Private Sub BtnAgregarVenta_Click(sender As Object, e As EventArgs) Handles BtnAgregarVenta.Click
        Me.VentasBindingSource.AddNew()
        Me.Refresh()
        TotalTextBox.Text = TxtTotal.Text
        VendedorTextBox.Enabled = False
        VendedorTextBox.Text = Login.Txt_user.Text
        TxtPagoCon.Clear()
        TxtCambio.Clear()
        CompradorTextBox.Focus()
        BtnAgregarVenta.Enabled = False
        BtnCambio.Enabled = True
    End Sub

    Private Sub BtnCambio_Click(sender As Object, e As EventArgs) Handles BtnCambio.Click
        If Val(TxtPagoCon.Text) >= Val(TotalTextBox.Text) Then
            TxtCambio.Text = Val(TxtPagoCon.Text) - Val(TotalTextBox.Text)
            BtnCambio.Enabled = False
            BtnPagar.Enabled = True
        Else
            MsgBox("Ingrese una cantidad mayor o igual a la del total", vbExclamation, "Falta dinero.")
            TxtCambio.Focus()
        End If
    End Sub

    Private Sub CancelarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarCompraToolStripMenuItem.Click
        MessageBox.Show("Se cancelara la compra.")
        contadoresEnCero()
        ListPedido.Items.Clear()
        TxtTotal.Clear()
    End Sub

    Public Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        Dim respuesta As Integer
        Dim salchicha, pan, catsup, mayonesa, mostaza As Integer
        Dim leche, queso, nacho, papas As Integer


        MontoActualTextBox.Text = Val(MontoActualTextBox.Text) + Val(TotalTextBox.Text)
        MontoFinal_generadoTextBox.Text = Val(MontoFinal_generadoTextBox.Text) + Val(TotalTextBox.Text)

        If hotdog >= 1 Then
            For i = 1 To hotdog
                salchicha = salchicha + 1
                pan = pan + 1
                catsup = catsup + 75
                mayonesa = mayonesa + 75
                mostaza = mostaza + 75
                If salchicha = 50 Then
                    IngredientesTableAdapter.ReducirIngredientes(pSalchicha)
                    salchicha = 0
                End If
                If pan = 8 Then
                    IngredientesTableAdapter.ReducirIngredientes(bPan)
                    pan = 0
                End If
                If mayonesa >= 3500 Then
                    IngredientesTableAdapter.ReducirIngredientes(gMayonesa)
                    mayonesa = 0
                End If
                If mostaza >= 3500 Then
                    IngredientesTableAdapter.ReducirIngredientes(gMostaza)
                    mostaza = 0
                End If
                If catsup >= 3500 Then
                    IngredientesTableAdapter.ReducirIngredientes(gCatsup)
                    catsup = 0
                End If
            Next
        End If

        If nachos >= 1 Then
            For i = 1 To nachos
                leche = leche + 237 'ml
                queso = queso + 80 'gr
                nacho = nacho + 200 'gr

                If queso >= 3000 Then
                    IngredientesTableAdapter.ReducirIngredientes(bQueso)
                    queso = 0
                End If

                If nacho >= 1000 Then
                    IngredientesTableAdapter.ReducirIngredientes(bNachos)
                    nacho = 0
                End If
            Next
        End If

        If papasSolas >= 1 Then
            For i = 1 To papasSolas
                papas = papas + 350 'gr
                If papas >= 2000 Then
                    IngredientesTableAdapter.ReducirIngredientes(bPapas)
                    papas = 0
                End If
            Next
        End If

        If papasQueso >= 1 Then
            For i = 1 To papasQueso
                papas = papas + 250 'gr
                queso = queso + 80 'gr
                leche = leche + 237 'ml

                If queso >= 3000 Then
                    IngredientesTableAdapter.ReducirIngredientes(bQueso)
                    queso = 0
                End If

                If papas >= 2000 Then
                    IngredientesTableAdapter.ReducirIngredientes(bPapas)
                    papas = 0
                End If

                If leche >= 3780 Then
                    IngredientesTableAdapter.ReducirIngredientes(gLeche)
                    leche = 0
                End If
            Next
        End If

        If fritosQueso >= 1 Then
            For i = 1 To fritosQueso
                queso = queso + 80 'gr
                leche = leche + 237 'ml

                If leche >= 3780 Then
                    IngredientesTableAdapter.ReducirIngredientes(gLeche)
                    leche = 0
                End If

                If queso >= 3000 Then
                    IngredientesTableAdapter.ReducirIngredientes(bQueso)
                    queso = 0
                End If
            Next
            For i = 1 To fritosQueso
                IngredientesTableAdapter.ReducirIngredientes(bFritos)
            Next
        End If

        If fritos >= 1 Then
            For i = 1 To fritos
                IngredientesTableAdapter.ReducirIngredientes(bFritos)
            Next
        End If


        If cocaCola >= 1 Then
            BebidasTableAdapter.DisminuirStock(cocaCola, LblCocaCola.Text)
        End If

        If drPepper >= 1 Then
            BebidasTableAdapter.DisminuirStock(drPepper, LblDrPepper.Text)
        End If

        If agua >= 1 Then
            BebidasTableAdapter.DisminuirStock(agua, LblAgua.Text)
        End If

        If fantaN >= 1 Then
            BebidasTableAdapter.DisminuirStock(fantaN, LblFantaNaranja.Text)
        End If

        If fantaF >= 1 Then
            BebidasTableAdapter.DisminuirStock(fantaF, LblFantaFresa.Text)
        End If

        If fresca >= 1 Then
            BebidasTableAdapter.DisminuirStock(fresca, LblFresca.Text)
        End If

        If sprite >= 1 Then
            BebidasTableAdapter.DisminuirStock(sprite, LblSprite.Text)
        End If

        respuesta = MsgBox("Confirme la venta por favor.", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmar venta")

        If respuesta = vbYes Then

            MessageBox.Show("Venta realizada.")
            Me.Validate()
            Me.BebidasBindingSource.EndEdit()
            Me.BebidasTableAdapter.Update(Me.SnackDataSet)
            Me.VentasBindingSource.EndEdit()
            Me.VentasTableAdapter.Update(Me.SnackDataSet.Ventas)
            Me.EstatusCajaBindingSource.EndEdit()
            Me.EstatusCajaTableAdapter.Update(Me.SnackDataSet.estatusCaja)
            Me.IngredientesBindingSource.EndEdit()
            Me.IngredientesTableAdapter.Update(Me.SnackDataSet.ingredientes)
            Me.Refresh()
            contadoresEnCero()
            BtnAgregarVenta.Enabled = True
            TxtTotal.Clear()
            limpiarTxts()

        Else

            contadoresEnCero()
            MessageBox.Show("Venta cancelada.")
            Me.BebidasBindingSource.CancelEdit()
            Me.VentasBindingSource.CancelEdit()
            Me.EstatusCajaBindingSource.CancelEdit()
            Me.Refresh()
            BtnAgregarVenta.Enabled = True
            TxtTotal.Clear()
            limpiarTxts()

        End If
        inventarioBebidas()
        inventarioIngredientes()
        BtnCambio.Enabled = False
    End Sub

    Private Sub CancelarUnArtículoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarUnArtículoToolStripMenuItem.Click
        If ListPedido.SelectedItem = LblHotDogs.Text & "                 " & LblHotDog.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblHotDog.Text)
            hotdog = hotdog - 1
        End If

        If ListPedido.SelectedItem = LblNacho.Text & "                  " & LblNachos.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblNachos.Text)
            nachos = nachos - 1
        End If


        If ListPedido.SelectedItem = LblOrdenPapas.Text & "             " & LblOrdenPapa.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblOrdenPapa.Text)
            papasSolas = papasSolas - 1
        End If

        If ListPedido.SelectedItem = LblPapasQueso.Text & "           " & LblPapaQueso.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPapaQueso.Text)
            papasQueso = papasQueso - 1
        End If

        If ListPedido.SelectedItem = LblFritos.Text & "          " & LblFrito.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblFrito.Text)
            fritos = fritos - 1
        End If

        If ListPedido.SelectedItem = LblFritosQueso.Text & "             " & LblFritoQueso.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblFritoQueso.Text)
            fritosQueso = fritosQueso - 1
        End If

        If ListPedido.SelectedItem = LblCocaCola.Text & "          " & LblPrecioCocaCola.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioCocaCola.Text)
            cocaCola = cocaCola - 1
        End If

        If ListPedido.SelectedItem = LblDrPepper.Text & "         " & LblPrecioDrPepper.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioDrPepper.Text)
            drPepper = drPepper - 1
        End If

        If ListPedido.SelectedItem = LblFantaNaranja.Text & "       " & LblPrecioFantaNaranja.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioFantaNaranja.Text)
            fantaN = fantaN - 1
        End If

        If ListPedido.SelectedItem = LblFantaFresa.Text & "      " & LblPrecioFantaFresa.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioFantaFresa.Text)
            fantaF = fantaF - 1
        End If

        If ListPedido.SelectedItem = LblFresca.Text & "           " & LblPrecioFresca.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioFresca.Text)
            fresca = fresca - 1
        End If

        If ListPedido.SelectedItem = LblSprite.Text & "         " & LblPrecioSprite.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioSprite.Text)
            sprite = sprite - 1
        End If


        If ListPedido.SelectedItem = LblAgua.Text & "         " & LblPrecioAgua.Text Then
            ListPedido.Items.RemoveAt(ListPedido.SelectedIndex)
            TxtTotal.Text = Val(TxtTotal.Text) - Val(LblPrecioAgua.Text)
            agua = agua - 1
        End If

    End Sub


    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Ventas.Show()
        Ventas.Refresh()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Inventario.Show()
    End Sub

    'Metodo para actualizar la caja y para poner el ultimo registro de la tabla del estatus de caja
    'y los totales de las ventas se agreguen al monto de la caja en los campos monto actual y generado
    Private Sub actualizarCaja()
        Me.EstatusCajaBindingSource.MoveLast()
        Me.Refresh()
    End Sub

End Class