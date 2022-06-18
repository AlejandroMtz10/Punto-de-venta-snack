Public Class MenuAdmin
    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SnackDataSet.usuarios)

        Login.Txt_password.Clear()

        Try
            LblNameUsuario.Text = Login.Txt_user.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnIngredientes_Click(sender As Object, e As EventArgs) Handles BtnIngredientes.Click
        Ingredientes.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Login.Txt_user.Clear()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub BtnComidas_Click(sender As Object, e As EventArgs) Handles BtnComidas.Click
        Comidas.Show()
    End Sub

    Private Sub BtnBebidas_Click(sender As Object, e As EventArgs) Handles BtnBebidas.Click
        Bebidas.Show()
    End Sub

    Private Sub BtnBitacora_Click(sender As Object, e As EventArgs) Handles BtnBitacora.Click
        Bitacora.Show()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Ventas.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Usuarios.Show()
    End Sub

    Private Sub BtnEstatusCaja_Click(sender As Object, e As EventArgs) Handles BtnEstatusCaja.Click
        estatusCaja.Show()
    End Sub

    Private Sub BtnRealizarPedido_Click(sender As Object, e As EventArgs) Handles BtnRealizarPedido.Click
        RealizarPedido.Show()
    End Sub

    Private Sub BtnRetiros_Click(sender As Object, e As EventArgs) Handles BtnRetiros.Click
        Retiros.Show()
    End Sub
End Class