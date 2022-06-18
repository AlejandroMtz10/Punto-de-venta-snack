Public Class Conversion
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TxtTipoCambio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTipoCambio.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If TxtDolares.Text = "" Then
                    MessageBox.Show("No debe dejar el campo vacío, dólares.")
                    TxtDolares.Focus()
                ElseIf TxtTipoCambio.Text = ""
                    MessageBox.Show("No debe dejar el campo vacío, tipo de cambio.")
                    TxtTipoCambio.Focus()
                Else
                    LblPesos.Text = Val(TxtDolares.Text) * Val(TxtTipoCambio.Text)
                End If
        End Select
    End Sub
End Class