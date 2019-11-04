Public Class Inicio
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        Instrucciones.Show()
        Me.Hide()
    End Sub

End Class
