Public Class Main
    Public proghandle As IntPtr

    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" (hwnd As IntPtr) As Boolean

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proghandle = Splash.proghandle
    End Sub

    Private Sub btnTmp_Click(sender As Object, e As EventArgs) Handles btnTmp.Click
        SetForegroundWindow(proghandle)
        SendKeys.SendWait("{RIGHT}")
        SetForegroundWindow(Me.Handle)
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Splash.Show()
    End Sub
End Class