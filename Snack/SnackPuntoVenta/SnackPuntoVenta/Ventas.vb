Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.estatusCaja' Puede moverla o quitarla según sea necesario.
        Me.EstatusCajaTableAdapter.Fill(Me.SnackDataSet.estatusCaja)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.SnackDataSet.Ventas)
    End Sub
    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.VentasTableAdapter.BuscarVenta(Me.SnackDataSet.Ventas, TxtBuscar.Text)
        End Select
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim nResp As Byte

            nResp = MessageBox.Show("Estas seguro de eliminar este registro",
                 "ITSA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If nResp = 6 Then
                Me.VentasTableAdapter.Delete(FolioVentaTextBox.Text)
                MessageBox.Show("La venta se elimino exitosamente.")
                Me.VentasTableAdapter.Fill(Me.SnackDataSet.Ventas)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class