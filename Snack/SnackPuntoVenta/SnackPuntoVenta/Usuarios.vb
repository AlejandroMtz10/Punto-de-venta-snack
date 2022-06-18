Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SnackDataSet.usuarios)
        habilitarBotones()
    End Sub

    Private Sub habilitarBotones()
        BtnAgregar.Enabled = True
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnRegresar.Enabled = True
    End Sub

    Private Sub deshabilitarBotones()
        BtnAgregar.Enabled = False
        BtnCancelar.Enabled = True
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        BtnRegresar.Enabled = False
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.UsuariosTableAdapter.BuscarUsuario(Me.SnackDataSet.usuarios, TxtBuscar.Text)
                habilitarBotones()
        End Select
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        deshabilitarBotones()
        UsuarioTextBox.Enabled = True
        PassTextBox.Enabled = True
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        deshabilitarBotones()
        FolioUsuarioTextBox.Enabled = True
        NombreTextBox.Enabled = True
        ApellidosTextBox.Enabled = True
        TipoComboBox.Enabled = True
        UsuarioTextBox.Enabled = True
        PassTextBox.Enabled = True
        PassTextBox.PasswordChar = ""
        Me.UsuariosBindingSource.AddNew()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            FolioUsuarioTextBox.Enabled = False
            NombreTextBox.Enabled = False
            ApellidosTextBox.Enabled = False
            TipoComboBox.Enabled = False
            UsuarioTextBox.Enabled = False
            PassTextBox.Enabled = False
            Me.UsuariosDataGridView.Enabled = True
            Me.UsuariosTableAdapter.Fill(Me.SnackDataSet.usuarios)
            habilitarBotones()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Me.Validate()
            Me.UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SnackDataSet)
            MessageBox.Show("Cambios guardados exitosamente.")
            habilitarBotones()

            FolioUsuarioTextBox.Enabled = False
            NombreTextBox.Enabled = False
            ApellidosTextBox.Enabled = False
            TipoComboBox.Enabled = False
            UsuarioTextBox.Enabled = False
            PassTextBox.Enabled = False
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class