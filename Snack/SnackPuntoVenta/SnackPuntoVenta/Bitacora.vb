Public Class Bitacora
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Bitacora' Puede moverla o quitarla según sea necesario.
        Me.BitacoraTableAdapter.Fill(Me.SnackDataSet.Bitacora)
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.BitacoraTableAdapter.BuscarEvento(Me.SnackDataSet.Bitacora, TxtBuscar.Text)
        End Select
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class