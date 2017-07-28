Imports System.Text.RegularExpressions

Public Class Splash
    Public cbg, cfg, cright, cwait, cwrong As Color
    Public keys1(5), keys2(5) As Keys
    Public timeq, numq As Integer
    Public proghandle As IntPtr
    Public player1, player2 As String

    Private prevhandle As IntPtr
    Private progname As String
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
            Dim caption As New System.Text.StringBuilder(50)
            proghandle = recurseParent(WindowFromPoint(point))
            GetWindowText(proghandle, caption, caption.Capacity)
            progname = caption.ToString()
            lblWindow.Text = progname
            lblWindow.ForeColor = SystemColors.ControlText

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
            lblWindow.Text = "No program selected."
            lblWindow.ForeColor = Color.FromArgb(183, 28, 28)
            tmrError.Enabled = True
        Else
            tmrError.Enabled = False
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
        lblWindow.Text = progname
        lblWindow.ForeColor = SystemColors.ControlText
        recBG.BackColor = cbg
        recFG.BackColor = cfg
        recRight.BackColor = cright
        recWait.BackColor = cwait
        recWrong.BackColor = cwrong
        tmrError.Enabled = False
        txtPlayer1.Text = player1
        txtPlayer2.Text = player2
        txtNum.Text = numq
        txtTime.Text = timeq
    End Sub

    Private Sub colorReset()
        cbg = Color.White
        cfg = Color.FromArgb(33, 33, 33)
        cright = Color.FromArgb(56, 142, 60)
        cwait = Color.FromArgb(251, 192, 45)
        cwrong = Color.FromArgb(117, 117, 117)
    End Sub

    Private Sub keys1Reset()
        keys1(0) = Keys.F
        keys1(1) = Keys.None
        keys1(2) = Keys.None
        keys1(3) = Keys.None
        keys1(4) = Keys.None
    End Sub

    Private Sub keys2Reset()
        keys2(0) = Keys.J
        keys2(1) = Keys.None
        keys2(2) = Keys.None
        keys2(3) = Keys.None
        keys2(4) = Keys.None
    End Sub

    Private Sub playerReset()
        player1 = "Player 1"
        player2 = "Player 2"
    End Sub

    Private Sub qsReset()
        timeq = 45
        numq = 3
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colorReset()
        keys1Reset()
        keys2Reset()
        qsReset()
        playerReset()
        progname = "Drag the X to a window..."
        redraw()
    End Sub

    Private Sub txtPlayer1_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer1.TextChanged
        If Regex.IsMatch(txtPlayer1.Text, "^[\w\d\s]+$") Then
            player1 = txtPlayer1.Text
        Else
            lblWindow.Text = "Alphanumeric characters and spaces only."
            lblWindow.ForeColor = Color.FromArgb(183, 28, 28)
            tmrError.Enabled = True
            txtPlayer1.Text = player1
        End If
    End Sub

    Private Sub txtPlayer2_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer2.TextChanged
        If Regex.IsMatch(txtPlayer2.Text, "^[\w\d\s]+$") Then
            player2 = txtPlayer2.Text
        Else
            lblWindow.Text = "Alphanumeric characters and spaces only."
            lblWindow.ForeColor = Color.FromArgb(183, 28, 28)
            tmrError.Enabled = True
            txtPlayer2.Text = player2
        End If
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        If Regex.IsMatch(txtTime.Text, "^[\d]+$") Then
            timeq = Val(txtTime.Text)
        Else
            lblWindow.Text = "Numerals only."
            lblWindow.ForeColor = Color.FromArgb(183, 28, 28)
            tmrError.Enabled = True
            txtTime.Text = timeq.ToString()
        End If
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        If Regex.IsMatch(txtNum.Text, "^[\d]+$") Then
            numq = Val(txtNum.Text)
        Else
            lblWindow.Text = "Numerals only."
            lblWindow.ForeColor = Color.FromArgb(183, 28, 28)
            tmrError.Enabled = True
            txtNum.Text = numq.ToString()
        End If
    End Sub

    Private Sub btnKeys10_Click(sender As Object, e As EventArgs) Handles btnKeys10.Click
        btnKeys10.Text = "..."
    End Sub

    Private Sub btnKeys10_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys10.KeyDown
        keys1(0) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnKeys11_Click(sender As Object, e As EventArgs) Handles btnKeys11.Click
        btnKeys11.Text = "..."
    End Sub

    Private Sub btnKeys11_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys11.KeyDown
        keys1(1) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnKeys12_Click(sender As Object, e As EventArgs) Handles btnKeys12.Click
        btnKeys12.Text = "..."
    End Sub

    Private Sub btnKeys12_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys12.KeyDown
        keys1(2) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnKeys13_Click(sender As Object, e As EventArgs) Handles btnKeys13.Click
        btnKeys13.Text = "..."
    End Sub

    Private Sub btnKeys13_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys13.KeyDown
        keys1(3) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnKeys14_Click(sender As Object, e As EventArgs) Handles btnKeys14.Click
        btnKeys14.Text = "..."
    End Sub

    Private Sub btnKeys14_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys14.KeyDown
        keys1(4) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnKeys20_Click(sender As Object, e As EventArgs) Handles btnKeys20.Click
        btnKeys20.Text = "..."
    End Sub

    Private Sub btnKeys20_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys20.KeyDown
        keys2(0) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnkeys21_Click(sender As Object, e As EventArgs) Handles btnKeys21.Click
        btnKeys21.Text = "..."
    End Sub

    Private Sub btnkeys21_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys21.KeyDown
        keys2(1) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnkeys22_Click(sender As Object, e As EventArgs) Handles btnKeys22.Click
        btnKeys22.Text = "..."
    End Sub

    Private Sub btnkeys22_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys22.KeyDown
        keys2(2) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnkeys23_Click(sender As Object, e As EventArgs) Handles btnKeys23.Click
        btnKeys23.Text = "..."
    End Sub

    Private Sub btnkeys23_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys23.KeyDown
        keys2(3) = e.KeyCode
        redraw()
    End Sub

    Private Sub btnkeys24_Click(sender As Object, e As EventArgs) Handles btnKeys24.Click
        btnKeys24.Text = "..."
    End Sub

    Private Sub btnkeys24_KeyDown(sender As Object, e As KeyEventArgs) Handles btnKeys24.KeyDown
        keys2(4) = e.KeyCode
        redraw()
    End Sub

    Private Sub recBG_Click(sender As Object, e As EventArgs) Handles recBG.Click
        clrDialog.ShowDialog()
        cbg = clrDialog.Color
        redraw()
    End Sub

    Private Sub recFG_Click(sender As Object, e As EventArgs) Handles recFG.Click
        clrDialog.ShowDialog()
        cfg = clrDialog.Color
        redraw()
    End Sub

    Private Sub recRight_Click(sender As Object, e As EventArgs) Handles recRight.Click
        clrDialog.ShowDialog()
        cright = clrDialog.Color
        redraw()
    End Sub

    Private Sub recWait_Click(sender As Object, e As EventArgs) Handles recWait.Click
        clrDialog.ShowDialog()
        cwait = clrDialog.Color
        redraw()
    End Sub

    Private Sub recWrong_Click(sender As Object, e As EventArgs) Handles recWrong.Click
        clrDialog.ShowDialog()
        cwrong = clrDialog.Color
        redraw()
    End Sub

    Private Sub btnColorReset_Click(sender As Object, e As EventArgs) Handles btnColorReset.Click
        colorReset()
        redraw()
    End Sub

    Private Sub btnQsReset_Click(sender As Object, e As EventArgs) Handles btnQsReset.Click
        qsReset()
        redraw()
    End Sub

    Private Sub btnPlayerReset_Click(sender As Object, e As EventArgs) Handles btnPlayerReset.Click
        playerReset()
        redraw()
    End Sub

    Private Sub btnKeys1Reset_Click(sender As Object, e As EventArgs) Handles btnKeys1Reset.Click
        keys1Reset()
        redraw()
    End Sub

    Private Sub btnKeys2Reset_Click(sender As Object, e As EventArgs) Handles btnKeys2Reset.Click
        keys2Reset()
        redraw()
    End Sub

    Private Sub tmrError_Tick(sender As Object, e As EventArgs) Handles tmrError.Tick
        tmrError.Enabled = False
        redraw()
    End Sub
End Class