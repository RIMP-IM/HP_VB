Public Class Instrucciones

    Dim PosText As Integer = 0
    Private Sub SiguienteBtn_Click(sender As Object, e As EventArgs) Handles SiguienteBtn.Click
        Select Case PosText
            Case 0
                PosText += 1

                DescripcionLbl.Text = "Las condiciones de victoria son las siguientes:" & vbCrLf
                DescripcionLbl.Text = DescripcionLbl.Text & "-Llevar una de las piezas al lado opuesto del tablero." & vbCrLf
                DescripcionLbl.Text = DescripcionLbl.Text & "-Capturar todas las piezas del oponente." & vbCrLf
                DescripcionLbl.Text = DescripcionLbl.Text & "-Dejar al contrincate sin movimientos posibles." & vbCrLf

                'DescripcionLbl.Refresh()
                'Refresh()
            Case 1
                'Juego.Show()
                Me.Close()
        End Select
    End Sub

End Class