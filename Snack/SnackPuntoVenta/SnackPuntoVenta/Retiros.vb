Public Class Retiros
    Private Sub Retiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.estatusCaja' Puede moverla o quitarla según sea necesario.
        Me.EstatusCajaTableAdapter.Fill(Me.SnackDataSet.estatusCaja)
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.Retiros' Puede moverla o quitarla según sea necesario.
        Me.RetirosTableAdapter.Fill(Me.SnackDataSet.Retiros)

        Me.EstatusCajaBindingSource.MoveLast()
        Me.Refresh()

        deshabilitarBotones()
        BtnAgregar.Enabled = True
        BtnRegresar.Enabled = True
    End Sub
    Private Sub habilitarBotones()
        BtnAgregar.Enabled = True
        BtnRegresar.Enabled = True
        BtnCancelar.Enabled = True
        BtnGuardar.Enabled = True
    End Sub

    Private Sub deshabilitarBotones()
        BtnAgregar.Enabled = False
        BtnCancelar.Enabled = False
        BtnRegresar.Enabled = False
        BtnGuardar.Enabled = False
    End Sub
    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.RetirosTableAdapter.BuscarRetiro(Me.SnackDataSet.Retiros, TxtBuscar.Text)
                habilitarBotones()
        End Select
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        IdRegistroTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        PersonaTextBox.Enabled = False

        MontoTextBox.Enabled = True
        TipoRetiroComboBox.Enabled = True

        Me.RetirosBindingSource.AddNew()

        habilitarBotones()
        PersonaTextBox.Text = Login.Txt_user.Text
        BtnAgregar.Enabled = False
        BtnRegresar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            EstatusCajaTableAdapter.Retiros(Val(MontoTextBox.Text), IdRegistroTextBox.Text)
            Me.Validate()
            Me.RetirosBindingSource.EndEdit()
            Me.EstatusCajaBindingSource.EndEdit()
            Me.EstatusCajaTableAdapter.Update(Me.SnackDataSet)
            Me.RetirosTableAdapter.Update(Me.SnackDataSet)
            Me.Refresh()
            MessageBox.Show("Cambios guardados exitosamente.")
            deshabilitarBotones()
            BtnAgregar.Enabled = True
            BtnRegresar.Enabled = True
            estatusCaja.EstatusCajaTableAdapter.Fill(Me.SnackDataSet.estatusCaja)

            IdRegistroTextBox.Enabled = False
            FechaDateTimePicker.Enabled = False
            PersonaTextBox.Enabled = False
            MontoTextBox.Enabled = False
            TipoRetiroComboBox.Enabled = False
            estatusCaja.Show()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.RetirosDataGridView.Enabled = True
            Me.RetirosTableAdapter.Fill(Me.SnackDataSet.Retiros)
            deshabilitarBotones()
            BtnAgregar.Enabled = True
            BtnRegresar.Enabled = True
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        IdRegistroTextBox.Enabled = False
        FechaDateTimePicker.Enabled = False
        PersonaTextBox.Enabled = False
        MontoTextBox.Enabled = False
        TipoRetiroComboBox.Enabled = False
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        Me.Refresh()
    End Sub
End Class