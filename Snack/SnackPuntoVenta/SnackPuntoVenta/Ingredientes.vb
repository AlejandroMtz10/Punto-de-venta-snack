﻿Public Class Ingredientes
    Private Sub Ingredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.ingredientes' Puede moverla o quitarla según sea necesario.
        Me.IngredientesTableAdapter.Fill(Me.SnackDataSet.ingredientes)
        habilitarBotones()
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False
    End Sub
    Private Sub habilitarBotones()
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = True
        BtnCancelar.Enabled = True
        BtnRegresar.Enabled = True
    End Sub
    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.IngredientesTableAdapter.BuscarIngrediente(Me.SnackDataSet.ingredientes, TxtBuscar.Text)
                habilitarBotones()
                BtnCancelar.Enabled = False
                BtnGuardar.Enabled = False
        End Select
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.IngredientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SnackDataSet)
            MessageBox.Show("Cambios guardados exitosamente.")
            habilitarBotones()
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            DisponiblesTextBox.Enabled = False

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        habilitarBotones()
        BtnModificar.Enabled = False
        BtnRegresar.Enabled = False
        DisponiblesTextBox.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.IngredientesDataGridView.Enabled = True
            Me.IngredientesTableAdapter.Fill(Me.SnackDataSet.ingredientes)
            habilitarBotones()
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            DisponiblesTextBox.Enabled = False
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class