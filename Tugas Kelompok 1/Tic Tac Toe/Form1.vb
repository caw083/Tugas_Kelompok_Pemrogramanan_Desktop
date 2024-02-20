Imports System.Formats.Asn1.AsnWriter
Imports System.Reflection

Public Class Form1

    Dim roundVar As Integer = 1
    Dim scoreXVar As Integer = 0
    Dim scoreOVar As Integer = 0
    Dim currPlay As String = "X"

    Private Sub Button()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub

    Private Sub CloseButton()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim WhereButtonClicked = DirectCast(sender, Button)
        If WhereButtonClicked.Text = "" Then
            WhereButtonClicked.Text = currPlay
            If currPlay = "X" Then
                currPlay = "O"
            Else
                currPlay = "X"
            End If
        End If
        WhereButtonClicked.Enabled = False
        ChangePlayerButton()
    End Sub

    Private Sub Button_Enter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter, Button6.MouseEnter, Button7.MouseEnter, Button8.MouseEnter, Button9.MouseEnter
        Dim WhereButtonEntered As Button = DirectCast(sender, Button)
        ' Change button color when mouse enters
        WhereButtonEntered.BackColor = Color.Wheat
        WhereButtonEntered.FlatAppearance.BorderColor = Color.Cyan
        WhereButtonEntered.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Button_Leave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave, Button7.MouseLeave, Button8.MouseLeave, Button9.MouseLeave
        Dim WhereButtonLeft As Button = DirectCast(sender, Button)
        ' Change button color back to default when mouse leaves
        WhereButtonLeft.BackColor = DefaultBackColor
        WhereButtonLeft.FlatAppearance.BorderColor = DefaultForeColor
        WhereButtonLeft.FlatAppearance.BorderSize = 0
    End Sub


    Private Sub changeRound()
        If roundVar = 3 Then
            CheckTheWinner()
        Else
            Timer_Count.Text = 10
            Countdown_player.Start()
            roundVar += 1
            Round_Label.Text = "Round : " + roundVar.ToString()
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Countdown_player.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Countdown_player.Tick
        Countdown_player.Interval = 1000
        Timer_Count.Text = Val(Timer_Count.Text) - 1

        If Val(Timer_Count.Text) = 0 Then
            Countdown_player.Stop()
            If currPlay = "X" Then
                scoreOVar = scoreOVar + 1
                MessageBox.Show("Waktu Habis, Pemenang set ini adalah O", "Round " + roundVar.ToString)
                currPlay = "O"
            Else
                scoreXVar = scoreXVar + 1
                MessageBox.Show("Waktu Habis, Pemenang set ini adalah X", "Round " + roundVar.ToString)
                currPlay = "X"
            End If


            ResetScoreLabel()

            Button()

            ChangePlayer()

            changeRound()

        End If
    End Sub

    Private Sub ResetScoreLabel()
        Score_Y_Player.Text = scoreOVar
        Score_X_Player.Text = scoreXVar
    End Sub

    Private Sub CheckTheWinner()
        Countdown_player.Stop()
        If scoreXVar > scoreOVar Then
            MessageBox.Show("Pemenang dalam game tic tak toe ini adalah X")

        ElseIf scoreXVar = scoreOVar Then
            MessageBox.Show("Pemenang dalam game tic tak toe ini adalah tidak ada dan seri")

        ElseIf scoreXVar < scoreOVar Then
            MessageBox.Show("Pemenang dalam game tic tak toe ini adalah 0")

        End If
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin main lagi?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            roundVar = 0
            changeRound()
            Button()
            scoreOVar = 0
            scoreXVar = 0
            ResetScoreLabel()
        Else
            Countdown_player.Stop()
            Application.Exit()
        End If

    End Sub

    Private Sub ChangePlayerButton()
        ChangePlayer()
        Countdown_player.Stop()

        Score()

        Timer_Count.Text = 10
        Countdown_player.Start()
    End Sub

    Private Sub ChangePlayer()
        Giliran_Pemain_text.Text = currPlay
    End Sub

    Private Sub Score()
        Dim winner As String = ""
        If (scoreXVar = 2) Then
            Countdown_player.Stop()
            MessageBox.Show("Pemenang dalam game tic tak toe ini adalah X")
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin main lagi?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                roundVar = 0
                changeRound()
                Button()
                scoreOVar = 0
                scoreXVar = 0
                ResetScoreLabel()
            Else
                Countdown_player.Stop()
                Application.Exit()
            End If
            If (scoreOVar = 2) Then
                MessageBox.Show("Pemenang dalam game tic tak toe ini adalah O")
                Dim results As DialogResult = MessageBox.Show("Apakah Anda yakin ingin main lagi?", "Konfirmasi", MessageBoxButtons.YesNo)
                If results = DialogResult.Yes Then
                    roundVar = 0
                    changeRound()
                    Button()
                    scoreOVar = 0
                    scoreXVar = 0
                    ResetScoreLabel()
                Else
                    Countdown_player.Stop()
                    Application.Exit()
                End If

            End If
        End If


        If roundVar <= 3 Then
            If ((Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Or
           (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Or
           (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Or
           (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Or
           (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Or
           (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Or
           (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Or
           (Button7.Text = "X" And Button5.Text = "X" And Button3.Text = "X")) Then


                scoreXVar += 1
                ResetScoreLabel()

                winner = "X"
                ShowMSG(winner)

                Button()

                currPlay = "O"
                ChangePlayerButton()
                changeRound()

            End If


            If ((Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Or
                (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Or
                (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Or
                (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Or
                (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Or
                (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Or
                (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Or
                (Button7.Text = "O" And Button5.Text = "O" And Button3.Text = "O")) Then


                scoreOVar += 1
                ResetScoreLabel()

                winner = "O"
                ShowMSG(winner)


                Button()

                currPlay = "X"
                ChangePlayerButton()
                changeRound()
            End If

            If Not (Button1.Text = "" Or Button2.Text = "" Or Button3.Text = "" Or Button4.Text = "" Or Button5.Text = "" Or Button6.Text = "" Or Button7.Text = "" Or Button8.Text = "" Or Button9.Text = "") Then
                ' All buttons are filled and no winning combination is achieved, it's a draw
                ShowDrawMSG()
                Button()
                changeRound()


                If currPlay = "X" Then
                    currPlay = "O"
                Else
                    currPlay = "X"
                End If

                ChangePlayerButton()
            End If


        Else
            CheckTheWinner()
        End If




    End Sub

    Private Sub ShowDrawMSG()
        MessageBox.Show("It's a draw!", "Round " + roundVar.ToString, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ShowMSG(winner As String)
        MessageBox.Show("Pemenang adalah " + winner, "Round " + roundVar.ToString)
    End Sub

End Class
