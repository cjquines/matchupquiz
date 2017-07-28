Public Class Splash
    ' add button to reset configs
    ' input validation
    ' work on UI

    Public cbg, cfg, cright, cwait, cwrong As Color
    Public keys1(5), keys2(5) As Keys
    Public timeq, numq As Integer
    Public proghandle As IntPtr
    Public player1, player2 As String

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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If proghandle.Equals(IntPtr.Zero) Then
            MsgBox("No program selected.")
        Else
            Main.bgdraw()
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Public Sub redraw()
        btnKeys10.Text = keys1(0).ToString()
        btnKeys11.Text = keys1(1).ToString()
        btnKeys12.Text = keys1(2).ToString()
        btnKeys13.Text = keys1(3).ToString()
        btnKeys14.Text = keys1(4).ToString()
        btnKeys20.Text = keys2(0).ToString()
        btnKeys21.Text = keys2(1).ToString()
        btnKeys22.Text = keys2(2).ToString()
        btnKeys23.Text = keys2(3).ToString()
        btnKeys24.Text = keys2(4).ToString()
        recBG.BackColor = cbg
        recFG.BackColor = cfg
        recRight.BackColor = cright
        recWait.BackColor = cwait
        recWrong.BackColor = cwrong
        txtPlayer1.Text = player1
        txtPlayer2.Text = player2
        txtNum.Text = numq
        txtTime.Text = timeq
    End Sub

    Private Sub colorReset()
        cbg = Color.White
        cfg = Color.Black
        cright = Color.Green
        cwait = Color.Yellow
        cwrong = Color.Gray
    End Sub

    Private Sub keysReset()
        keys1(0) = Keys.F
        keys1(1) = Keys.None
        keys1(2) = Keys.None
        keys1(3) = Keys.None
        keys1(4) = Keys.None
        keys2(0) = Keys.J
        keys2(1) = Keys.None
        keys2(2) = Keys.None
        keys2(3) = Keys.None
        keys2(4) = Keys.None
    End Sub

    Private Sub playerReset()
        player1 = "Player1"
        player2 = "Player2"
    End Sub

    Private Sub qsReset()
        timeq = 45
        numq = 5
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colorReset()
        keysReset()
        qsReset()
        playerReset()
        redraw()
    End Sub

    Private Sub txtPlayer1_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer1.TextChanged
        player1 = txtPlayer1.Text ' validate
    End Sub

    Private Sub txtPlayer2_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer2.TextChanged
        player2 = txtPlayer2.Text ' validate
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        numq = Val(txtNum.Text) ' check if integer >:(
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        timeq = Val(txtTime.Text) ' check if integer >:(
    End Sub

    Private Sub btnKeys10_Click(sender As Object, e As EventArgs) Handles btnKeys10.Click
        btnKeys10.Text = "..."
    End Sub

    Private Sub btnKeys10_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys10.KeyDown
        keys1(0) = e.KeyCode
        btnKeys10.Text = keys1(0).ToString()
    End Sub

    Private Sub btnKeys11_Click(sender As Object, e As EventArgs) Handles btnKeys11.Click
        btnKeys11.Text = "..."
    End Sub

    Private Sub btnKeys11_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys11.KeyDown
        keys1(1) = e.KeyCode
        btnKeys11.Text = keys1(1).ToString()
    End Sub

    Private Sub btnKeys12_Click(sender As Object, e As EventArgs) Handles btnKeys12.Click
        btnKeys12.Text = "..."
    End Sub

    Private Sub btnKeys12_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys12.KeyDown
        keys1(2) = e.KeyCode
        btnKeys12.Text = keys1(2).ToString()
    End Sub

    Private Sub btnKeys13_Click(sender As Object, e As EventArgs) Handles btnKeys13.Click
        btnKeys13.Text = "..."
    End Sub

    Private Sub btnKeys13_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys13.KeyDown
        keys1(3) = e.KeyCode
        btnKeys13.Text = keys1(3).ToString()
    End Sub

    Private Sub btnKeys14_Click(sender As Object, e As EventArgs) Handles btnKeys14.Click
        btnKeys14.Text = "..."
    End Sub

    Private Sub btnKeys14_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys14.KeyDown
        keys1(4) = e.KeyCode
        btnKeys14.Text = keys1(4).ToString()
    End Sub

    Private Sub btnKeys20_Click(sender As Object, e As EventArgs) Handles btnKeys20.Click
        btnKeys20.Text = "..."
    End Sub

    Private Sub btnKeys20_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys20.KeyDown
        keys2(0) = e.KeyCode
        btnKeys20.Text = keys2(0).ToString()
    End Sub

    Private Sub btnkeys21_Click(sender As Object, e As EventArgs) Handles btnKeys21.Click
        btnKeys21.Text = "..."
    End Sub

    Private Sub btnkeys21_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys21.KeyDown
        keys2(1) = e.KeyCode
        btnKeys21.Text = keys2(1).ToString()
    End Sub

    Private Sub btnkeys22_Click(sender As Object, e As EventArgs) Handles btnKeys22.Click
        btnKeys22.Text = "..."
    End Sub

    Private Sub btnkeys22_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys22.KeyDown
        keys2(2) = e.KeyCode
        btnKeys22.Text = keys2(2).ToString()
    End Sub

    Private Sub btnkeys23_Click(sender As Object, e As EventArgs) Handles btnKeys23.Click
        btnKeys23.Text = "..."
    End Sub

    Private Sub btnkeys23_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys23.KeyDown
        keys2(3) = e.KeyCode
        btnKeys23.Text = keys2(3).ToString()
    End Sub

    Private Sub btnkeys24_Click(sender As Object, e As EventArgs) Handles btnKeys24.Click
        btnKeys24.Text = "..."
    End Sub

    Private Sub btnkeys24_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys24.KeyDown
        keys2(4) = e.KeyCode
        btnKeys24.Text = keys2(4).ToString()
    End Sub

    Private Sub recBG_Click(sender As Object, e As EventArgs) Handles recBG.Click
        clrDialog.ShowDialog()
        cbg = clrDialog.Color
        recBG.BackColor = cbg
    End Sub

    Private Sub recFG_Click(sender As Object, e As EventArgs) Handles recFG.Click
        clrDialog.ShowDialog()
        cfg = clrDialog.Color
        recFG.BackColor = cfg
    End Sub

    Private Sub recRight_Click(sender As Object, e As EventArgs) Handles recRight.Click
        clrDialog.ShowDialog()
        cright = clrDialog.Color
        recRight.BackColor = cright
    End Sub

    Private Sub recWait_Click(sender As Object, e As EventArgs) Handles recWait.Click
        clrDialog.ShowDialog()
        cwait = clrDialog.Color
        recWait.BackColor = cwait
    End Sub

    Private Sub recWrong_Click(sender As Object, e As EventArgs) Handles recWrong.Click
        clrDialog.ShowDialog()
        cwrong = clrDialog.Color
        recWrong.BackColor = cwrong
    End Sub
End Class