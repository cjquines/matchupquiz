Public Class Main
    ' Should support click name -> InputBox to change it
    ' Also, a separate form for settings
    'e.KeyCode.ToString()

    Private running As Boolean
    Private ans1, ans2, qnumber, qtimer, score1, score2, status As Integer

    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" (hwnd As IntPtr) As Boolean

    Private Sub redraw()
        lblScore1.Text = score1.ToString
        Select Case ans1
            Case -1
                lblScore1.ForeColor = Splash.cwrong
            Case 0
                lblScore1.ForeColor = Splash.cfg
            Case 1
                lblScore1.ForeColor = Splash.cwait
            Case 2
                lblScore1.ForeColor = Splash.cright
        End Select
        lblScore2.Text = score2.ToString
        Select Case ans2
            Case -1
                lblScore2.ForeColor = Splash.cwrong
            Case 0
                lblScore2.ForeColor = Splash.cfg
            Case 1
                lblScore2.ForeColor = Splash.cwait
            Case 2
                lblScore2.ForeColor = Splash.cright
        End Select
        If status = -1 Then
            lblStatus.Text = ""
        ElseIf status = 0 Then
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
        If qtimer < 0 Then
            lblTimer.Text = "--"
        Else
            lblTimer.Text = qtimer.ToString
        End If
        If running Then
            tmrQuestion.Enabled = True
        Else
            tmrQuestion.Enabled = False
        End If
    End Sub

    Private Sub newRound()
        running = False
        ans1 = 0
        ans2 = 0
        qnumber = 0
        qtimer = -1
        score1 = 0
        score2 = 0
        status = -1
        redraw()
    End Sub

    Private Sub newQuestion()
        Console.WriteLine(Splash.timeq)
        SetForegroundWindow(Splash.proghandle)
        SendKeys.SendWait("{RIGHT}")
        SetForegroundWindow(Me.Handle)
        running = True
        ans1 = 0
        ans2 = 0
        qnumber += 1
        qtimer = Splash.timeq
        status = 0
        redraw()
    End Sub

    Private Sub checkWin()
        If (score1 > Splash.numq \ 2) Or
            (score2 > Splash.numq \ 2) Or
            (qnumber >= Splash.numq And score1 <> score2) Then
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
            If Splash.keys1.Contains(e.KeyCode) And ans1 > -1 Then
                ans1 = 1
                running = False
                redraw()
            ElseIf Splash.keys2.Contains(e.KeyCode) And ans2 > -1 Then
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
            ans1 = -1
            ans2 = 2
            score2 += 1
            status = 2
            checkWin()
            redraw()
        End If
    End Sub

    Private Sub tmrQuestion_Tick(sender As Object, e As EventArgs) Handles tmrQuestion.Tick
        If qtimer = 0 Then
            running = False
            ans1 = -1
            ans2 = -1
            status = 3
        Else
            qtimer -= 1
        End If
        redraw()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.BackColor = Splash.cbg
        lblPlayer1.ForeColor = Splash.cfg
        lblPlayer2.ForeColor = Splash.cfg
        lblStatus.ForeColor = Splash.cfg
        lblTimer.ForeColor = Splash.cfg
        newRound()
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Splash.Show()
    End Sub
End Class