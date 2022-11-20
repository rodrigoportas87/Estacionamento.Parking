Public Class Form1

    Private Sub bttEntrada_Click(sender As System.Object, e As System.EventArgs) Handles bttEntrada.Click
        'Recebe Data e Hora
        lbDataEntrada.Text = DateAndTime.Today
        lbHoraEntrada.Text = DateAndTime.TimeOfDay

        'Habilita o botão Saida
        bttSaida.Enabled = True

        'Reseta o texto Data e Hora da Saida
        lbDataSaida.ResetText()
        lbHoraSaida.ResetText()

    End Sub

    Private Sub bttSaida_Click(sender As System.Object, e As System.EventArgs) Handles bttSaida.Click
        Dim duracao As Double

        If txtValor.Text <> "" Then
            lbDataSaida.Text = DateAndTime.Today
            lbHoraSaida.Text = DateAndTime.TimeOfDay

            duracao = Tempo(lbDataEntrada.Text, lbDataSaida.Text, lbHoraEntrada.Text, lbHoraSaida.Text)

            If duracao < 15 Then
                lbPagar.Text = txtValor.Text
            Else
                lbPagar.Text = Math.Round(duracao / 15 * CDbl(txtValor.Text), 2)

            End If

        Else
            Dim mensagem, titulo, botões, icone
            mensagem = " Valor não atribuido "
            titulo = "Estacionamento"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Stop

            MessageBox.Show(mensagem, titulo, botões, icone)
        End If
    End Sub
End Class
