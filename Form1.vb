Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    ' Get a handle to an application window.
    Declare Auto Function FindWindow Lib "USER32.DLL" ( _
        ByVal lpClassName As String, _
        ByVal lpWindowName As String) As IntPtr

    ' Activate an application window.
    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" _
        (ByVal hWnd As IntPtr) As Boolean

    ' Send a series of key presses to the Calculator application.
    Private Sub button1_Click(ByVal sender As Object, _
        ByVal e As EventArgs) Handles Button1.Click

        ' Get a handle to the Calculator application. The window class
        ' and window name were obtained using the Spy++ tool.
        Dim calculatorHandle As IntPtr = FindWindow("SUMATRA_PDF_FRAME", "IOI_Training___DP_v3.pdf - SumatraPDF")

        ' Verify that Calculator is a running process.
        If calculatorHandle = IntPtr.Zero Then
            MsgBox("Calculator is not running.")
            Return
        End If

        ' Make Calculator the foreground application and send it 
        ' a set of calculations.
        SetForegroundWindow(calculatorHandle)
        SendKeys.SendWait("{RIGHT}")

        SetForegroundWindow(Me.Handle)
    End Sub
End Class
