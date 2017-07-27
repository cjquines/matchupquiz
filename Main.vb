Public Class Main
    ' # Program flow:
    ' - Click timer:
    ' -- Increment question number
    ' -- Start timer
    ' - Listen for keypress from either player
    ' - If keypress:
    ' -- Stop timer
    ' -- If clicked score, answer is correct:
    ' --- Add one to score
    ' --- Gray out other score
    ' --- If win, green winning score, stop
    ' --- Else wait for click timer again
    ' -- If clicked timer, answer is wrong:
    ' --- gray out score
    ' --- start timer
    ' --- Listen for keypress from remaining player
    ' - If time runs out:
    ' -- Stop timer
    ' -- gray out both scores
    ' -- Wait for click timer again
    ' Should support click name -> InputBox to change it
    ' Also, a separate form for settings

    Public proghandle As IntPtr
    Private score1, score2, qnumber As Integer

    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" (hwnd As IntPtr) As Boolean

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proghandle = Splash.proghandle
    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click
        'If timer stopped and guess is wrong, continue
        'If timer stopped and both done, next
        SetForegroundWindow(proghandle)
        SendKeys.SendWait("{RIGHT}")
        SetForegroundWindow(Me.Handle)
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Splash.Show()
    End Sub
End Class