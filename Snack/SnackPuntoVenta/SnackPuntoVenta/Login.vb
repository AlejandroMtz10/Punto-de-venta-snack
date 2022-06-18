Public Class Login
    Private Sub BtnIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SnackDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SnackDataSet.usuarios)
    End Sub
    'Metodo para ingresar nTotal hace un conteo de coincidencia con el nombre del usuario y la contraseña para acceder
    'Y con los valores de usuario y contraseña se extrae el tipo de usuario para darle el acceso a su menú correspondiente
    Private Sub ingresar()
        Dim nTotal As Byte
        Dim TipoUsuario As String
        nTotal = UsuariosTableAdapter.LoginUsuario(Txt_user.Text, Txt_password.Text)
        TipoUsuario = UsuariosTableAdapter.ValidarUsuario(Txt_user.Text, Txt_password.Text)

        If nTotal = 1 Then
            If TipoUsuario = "Administrador" Then
                Me.Hide()
                estatusCaja.ShowDialog()
                MenuAdmin.Show()
            ElseIf TipoUsuario = "Estandar" Then
                Me.Hide()
                estatusCaja.ShowDialog()
                MenuEstandar.Show()
            End If
        Else
            MessageBox.Show("El usuario o la contraseña son invalidos.")
            Txt_password.Clear()
        End If

    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles BtnVer.Click
        If (BtnVer.Visible = True And BtnVer.Enabled = True) Then
            BtnVer.Visible = False
            BtnVer.Enabled = False
            BtnNoVer.Visible = True
            BtnNoVer.Enabled = True
            Txt_password.PasswordChar = ""
        End If
    End Sub

    Private Sub BtnVer1_Click(sender As Object, e As EventArgs) Handles BtnNoVer.Click
        If (BtnNoVer.Visible = True And BtnNoVer.Enabled = True) Then
            BtnNoVer.Visible = False
            BtnNoVer.Enabled = False
            BtnVer.Visible = True
            BtnVer.Enabled = True
            Txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ingresar()
    End Sub

    Private Sub Txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_password.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ingresar()
        End Select
    End Sub
End Class
