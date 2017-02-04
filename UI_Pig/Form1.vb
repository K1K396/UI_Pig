Public Class Form1

    Dim acumulado As Integer
    Dim turnosJugador As Integer
    Dim turnosPC As Integer


    Public Sub turnoPC()
        turnosPC = 0
        acumulado = 0
        Dim turnos As Integer

        Randomize()
        Dim random As Integer = CInt(Int((3 * Rnd()) + 1))
        If random = 1 Then
            turnos = turnosJugador + 1
        ElseIf random = 2 And turnosJugador > 1 Then
            turnos = turnosJugador - 1
        ElseIf random = 3 Then
            turnos = turnosJugador
        End If

        While turnosPC <= turnos
            Randomize()
            Dim numero As Integer = CInt(Int((6 * Rnd()) + 1))
            txtDado.Text = numero

            If numero = 1 Then
                'turnosPC = turnosJugador + 1
                MsgBox("Ha salido un 1.  El turno pasa al Jugador.", MsgBoxStyle.Information, "Fin del turno")
                acumulado = 0
                txtAcumulado.Text = acumulado
                txtDado.Text = 0
                Exit While

            ElseIf numero <> 1 Then
                turnosPC = turnosPC + 1
                acumulado = acumulado + numero
                txtAcumulado.Text = acumulado

            End If

        End While

        If turnosPC = turnosJugador Then
            MsgBox("Termino mi turno", MsgBoxStyle.Information, "PC")
            txtPC.Text = Val(txtPC.Text) + Val(txtAcumulado.Text)
            txtAcumulado.Text = "0"
            txtDado.Text = "0"
        End If

        If Val(txtPC.Text) >= 100 Then
            MsgBox("100pts! ¡Mas suerte la proxima!", MsgBoxStyle.Information, "Fin del juego")
            txtAcumulado.Text = "0"
            txtDado.Text = "0"
            txtJugador.Text = "0"
            txtPC.Text = "0"
        End If
        txtAcumulado.Text = "0"
        txtDado.Text = "0"
        turnosPC = 0
        acumulado = 0
        'btnTirar.Visible = True
        'btnFinTurno.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblJugador.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAcumulado.Click

    End Sub

    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        Randomize()
        Dim numero As Integer = CInt(Int((Rnd() * 6) + 1))
        turnosJugador = turnosJugador + 1
        txtDado.Text = numero

        If numero = 1 Then
            MsgBox("Ha salido un 1.  El turno pasa a la PC.", MsgBoxStyle.Information, "Fin del turno")
            acumulado = 0
            txtAcumulado.Text = acumulado
            numero = 0
            txtDado.Text = 0
            turnoPC()
            'btnTirar.Visible = False
            'btnFinTurno.Visible = False
        ElseIf numero <> 1 Then
            acumulado = acumulado + numero
            txtAcumulado.Text = acumulado
        End If
        turnosJugador = turnosJugador + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAcumulado.Text = "0"
        txtDado.Text = "0"
        txtJugador.Text = "0"
        txtPC.Text = "0"
    End Sub

    Private Sub btnFinTurno_Click(sender As Object, e As EventArgs) Handles btnFinTurno.Click
        txtJugador.Text = Val(txtJugador.Text) + Val(txtAcumulado.Text)

        If Val(txtJugador.Text) >= 100 Then
            MsgBox("100pts! ¡Felicidades!", MsgBoxStyle.Information, "Fin del juego")
            txtAcumulado.Text = "0"
            txtDado.Text = "0"
            txtJugador.Text = "0"
        ElseIf Val(txtJugador.Text) < 100 Then
            MsgBox("Termino mi turno", MsgBoxStyle.Information, "Jugador")
            txtAcumulado.Text = "0"
            txtDado.Text = "0"
            turnoPC()
        End If
    End Sub
End Class
