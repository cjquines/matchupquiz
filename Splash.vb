Public Class Splash
    Public proghandle As IntPtr
    Private prevhandle As IntPtr
    Private prevrect As Rect

    Declare Auto Function GetParent Lib "USER32.DLL" (hwnd As IntPtr) As IntPtr
    Declare Auto Function GetWindowRect Lib "USER32.DLL" (hwnd As IntPtr, ByRef lpRect As Rect) As Integer
    Declare Auto Function GetWindowText Lib "USER32.DLL" (hwnd As IntPtr,
        lpString As System.Text.StringBuilder, nMaxCount As Integer) As Integer
    Declare Auto Function WindowFromPoint Lib "USER32.DLL" (pt As PointAPI) As IntPtr

    Public Structure PointAPI
        Public X, Y As Integer
        Public Sub New(x As Integer, y As Integer)
            Me.X = x
            Me.Y = y
        End Sub
    End Structure

    Public Structure Rect
        Public Left, Top, Right, Bottom As Integer
    End Structure

    Private Function recurseParent(hwnd As IntPtr)
        If GetParent(hwnd).Equals(IntPtr.Zero) Then
            Return hwnd
        Else
            Return recurseParent(GetParent(hwnd))
        End If
    End Function

    Private Sub drawWindowFrame()
        ControlPaint.DrawReversibleFrame(
            New Rectangle(prevrect.Left, prevrect.Top, prevrect.Right - prevrect.Left, prevrect.Bottom - prevrect.Top),
            Color.Black, FrameStyle.Thick)
    End Sub

    Private Sub imgFindProg_MouseDown(sender As Object, e As MouseEventArgs) Handles imgFindProg.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            prevhandle = IntPtr.Zero
        End If
    End Sub

    Private Sub imgFindProg_MouseMove(sender As Object, e As MouseEventArgs) Handles imgFindProg.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim point As New PointAPI(Cursor.Position.X, Cursor.Position.Y)
            Dim caption As New System.Text.StringBuilder(1024)
            proghandle = recurseParent(WindowFromPoint(point))
            GetWindowText(proghandle, caption, caption.Capacity)
            lblWindow.Text = caption.ToString()

            If Not proghandle.Equals(prevhandle) Then
                If Not prevhandle.Equals(IntPtr.Zero) Then
                    drawWindowFrame()
                End If
                GetWindowRect(proghandle, prevrect)
                drawWindowFrame()
            End If

            prevhandle = proghandle
        End If
    End Sub

    Private Sub imgFindProg_MouseUp(sender As Object, e As MouseEventArgs) Handles imgFindProg.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drawWindowFrame()
        End If
    End Sub
End Class