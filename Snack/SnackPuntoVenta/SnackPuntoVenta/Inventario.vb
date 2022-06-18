Public Class Inventario

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.ingredientes' Puede moverla o quitarla según sea necesario.
        Me.IngredientesTableAdapter.Fill(Me.SnackDataSet.ingredientes)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        Me.BebidasTableAdapter.Fill(Me.SnackDataSet.Bebidas)
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class