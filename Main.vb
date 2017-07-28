Public Class Main
    ' Should support click name -> InputBox to change it
    ' Also, a separate form for settings
    'e.KeyCode.ToString()

    Public proghandle As IntPtr
    Private running As Boolean
    Private ans1, ans2, qtimer, qnumber, score1, score2, status As Integer

    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" (hwnd As IntPtr) As Boolean

    Private Sub redraw()
        If running Then
            tmrQuestion.Enabled = True
        Else
            tmrQuestion.Enabled = False
        End If
        If qtimer < 0 Then
            lblTimer.Text = "--"
        Else
            lblTimer.Text = qtimer.ToString
        End If
        lblScore1.Text = score1.ToString
        lblScore2.Text = score2.ToString
        Select Case ans1
            Case -1
                lblScore1.ForeColor = Color.Gray
            Case 0
                lblScore1.ForeColor = Color.Black
            Case 1
                lblScore1.ForeColor = Color.Yellow
            Case 2
                lblScore1.ForeColor = Color.Green
        End Select
        Select Case ans2
            Case -1
                lblScore2.ForeColor = Color.Gray
            Case 0
                lblScore2.ForeColor = Color.Black
            Case 1
                lblScore2.ForeColor = Color.Yellow
            Case 2
                lblScore2.ForeColor = Color.Green
        End Select
        If status = 0 Then
            lblStatus.Text = "Question " + qnumber.ToString
        ElseIf status = 1 Then
            lblStatus.Text = lblPlayer1.Text + " is correct"
        ElseIf status = 2 Then
            lblStatus.Text = lblPlayer2.Text + " is correct"
        ElseIf status = 3 Then
            lblStatus.Text = "Time out"
        ElseIf status = 4 Then
            lblStatus.Text = lblPlayer1.Text + " wins"
        ElseIf status = 5 Then
            lblStatus.Text = lblPlayer2.Text + " wins"
        End If
    End Sub

    Private Sub newRound()
        running = False
        ans1 = 0
        ans2 = 0
        status = 0
        score1 = 0
        score2 = 0
        qnumber = 0
        qtimer = -1
        redraw()
    End Sub

    Private Sub newQuestion()
        SetForegroundWindow(proghandle)
        SendKeys.SendWait("{RIGHT}")
        SetForegroundWindow(Me.Handle)
        qtimer = 45
        qnumber += 1
        status = 0
        ans1 = 0
        ans2 = 0
        running = True
        redraw()
    End Sub

    Private Sub checkWin()
        If (score1 > 5 \ 2) Or
            (score2 > 5 \ 2) Or
            (qnumber >= 5 And score1 <> score2) Then
            qtimer = -1
            If score1 > score2 Then
                ans1 = 2
                ans2 = 0
                status = 4
            Else
                ans1 = 0
                ans2 = 2
                status = 5
            End If
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proghandle = Splash.proghandle
        newRound()
    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click
        If running Then
            running = False
        ElseIf ans1 = 1 Then
            ans1 = -1
            running = True
        ElseIf ans2 = 1 Then
            ans2 = -1
            running = True
        ElseIf status >= 4 Then
            newRound()
        Else
            newQuestion()
        End If
        redraw()
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If running Then
            If e.KeyCode = Keys.F And ans1 > -1 Then
                ans1 = 1
                running = False
                redraw()
            ElseIf e.KeyCode = Keys.J And ans2 > -1 Then
                ans2 = 1
                running = False
                redraw()
            End If
        End If
    End Sub

    Private Sub lblScore1_Click(sender As Object, e As EventArgs) Handles lblScore1.Click
        If ans1 = 1 Then
            ans1 = 2
            ans2 = -1
            score1 += 1
            status = 1
            checkWin()
            redraw()
        End If
    End Sub

    Private Sub lblScore2_Click(sender As Object, e As EventArgs) Handles lblScore2.Click
        If ans2 = 1 Then
            ans2 = 2
            ans1 = -1
            score2 += 1
            status = 2
            checkWin()
            redraw()
        End If
    End Sub

    Private Sub tmrQuestion_Tick(sender As Object, e As EventArgs) Handles tmrQuestion.Tick
        qtimer -= 1
        If qtimer = 0 Then
            running = False
            status = 3
            ans1 = -1
            ans2 = -1
        End If
        redraw()
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Splash.Show()
    End Sub
End Class