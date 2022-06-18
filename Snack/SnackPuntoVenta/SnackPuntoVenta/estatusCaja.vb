Public Class estatusCaja

    Private Sub estatusCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.estatusCaja' Puede moverla o quitarla según sea necesario.
        Me.EstatusCajaTableAdapter.Fill(Me.SnackDataSet.estatusCaja)

    End Sub

    Private Sub habilitarBotones()
        BtnAgregar.Enabled = True
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnRegresar.Enabled = True
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.EstatusCajaTableAdapter.BuscarRegistro(Me.SnackDataSet.estatusCaja, TxtBuscar.Text)
                habilitarBotones()
                BtnCancelar.Enabled = False
                BtnGuardar.Enabled = False
        End Select
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        habilitarBotones()
        BtnAgregar.Enabled = False
        BtnRegresar.Enabled = False

        Me.EstatusCajaBindingSource.AddNew()
        Me.Refresh()

        IdRegistroTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        NumeroCajaTextBox.Enabled = True
        MontoInicialTextBox.Enabled = True
        MontoActualTextBox.Enabled = True
        MontoFinal_generadoTextBox.Enabled = True
        AtendidaPorTextBox.Enabled = False
        AtendidaPorTextBox.Text = Login.Txt_user.Text
        RetirosPreviosTextBox.Text = "0"
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.EstatusCajaBindingSource.EndEdit()
            Me.EstatusCajaTableAdapter.Update(Me.SnackDataSet.estatusCaja)
            Me.Refresh()
            MessageBox.Show("Cambios guardados exitosamente.")
            habilitarBotones()
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False

            IdRegistroTextBox.Enabled = False
            FechaDateTimePicker.Enabled = False
            NumeroCajaTextBox.Enabled = False
            MontoInicialTextBox.Enabled = False
            MontoActualTextBox.Enabled = False
            MontoFinal_generadoTextBox.Enabled = False
            AtendidaPorTextBox.Enabled = False
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try

            Me.EstatusCajaDataGridView.Enabled = True
            Me.EstatusCajaTableAdapter.Fill(Me.SnackDataSet.estatusCaja)

            habilitarBotones()
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False

            FechaDateTimePicker.Enabled = False
            NumeroCajaTextBox.Enabled = False
            MontoInicialTextBox.Enabled = False
            MontoActualTextBox.Enabled = False
            MontoFinal_generadoTextBox.Enabled = False
            AtendidaPorTextBox.Enabled = False
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class