Public Class SuministrarInventario
    Dim validarIng, validarBe As Integer

    Private Sub SuministrarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        Me.BebidasTableAdapter.Fill(Me.SnackDataSet.Bebidas)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.ingredientes' Puede moverla o quitarla según sea necesario.
        Me.IngredientesTableAdapter.Fill(Me.SnackDataSet.ingredientes)

    End Sub

    Public Sub cleanTxts()
        TxtIngrediente.Clear()
        TxtCantidadI.Clear()
        TxtBebida.Clear()
        TxtCantidadB.Clear()
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TxtCantidadI_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TxtCantidadI.KeyDown
        validarIng = Val(Me.IngredientesTableAdapter.ValidarIngredientes(TxtIngrediente.Text))
        Select Case e.KeyCode
            Case Keys.Enter
                If validarIng = 1 Then
                    Me.IngredientesTableAdapter.AumentarStockI(Val(TxtCantidadI.Text), TxtIngrediente.Text)
                    Me.Validate()
                    Me.IngredientesBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.SnackDataSet)
                    Me.Refresh()
                    MessageBox.Show("El stock del ingrediente se aumento correctamente")
                    Inventario.Close()
                    Inventario.Show()
                    cleanTxts()
                    Me.Show()
                Else
                    MsgBox("El ingrediente no existe o verifique que este bien escrito el nombre del ingrediente.", vbCritical, "Ingredientes")
                End If

        End Select
    End Sub

    Private Sub TxtCantidadB_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TxtCantidadB.KeyDown
        validarBe = Val(Me.BebidasTableAdapter.ValidarBebida(TxtBebida.Text))
        Select Case e.KeyCode
            Case Keys.Enter
                If validarBe = 1 Then
                    Me.BebidasTableAdapter.AumentarStockB(Val(TxtCantidadB.Text), TxtBebida.Text)
                    Me.Validate()
                    Me.BebidasBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.SnackDataSet)
                    Me.Refresh()
                    MessageBox.Show("El stock de la bebida se aumento correctamente")
                    Inventario.Close()
                    Inventario.Show()
                    cleanTxts()
                    Me.Show()
                Else
                    MsgBox("El ingrediente no existe o verifique que este bien escrito el nombre de la bebida.", vbCritical, "Bebidas")
                End If
        End Select
    End Sub
End Class