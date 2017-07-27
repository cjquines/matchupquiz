Public Class Form2

    Private prevHandle As IntPtr
    Private prevRC As Rect

    Public Structure PointAPI

        Public X As Integer
        Public Y As Integer

        Public Sub New(ByVal x As Integer, ByVal y As Integer)
            Me.X = x
            Me.Y = y
        End Sub

    End Structure

    Public Structure Rect
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Public Declare Function WindowFromPoint Lib "user32" (ByVal pt As PointAPI) As IntPtr
    Public Declare Function GetWindowRect Lib "user32" (ByVal handle As IntPtr, ByRef lpRect As Rect) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.BackColor = Color.Red
        PictureBox1.Cursor = Cursors.Cross
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        MessageBox.Show("Drag the PictureBox around the screen...")
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            prevHandle = IntPtr.Zero
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim pt As New PointAPI(Cursor.Position.X, Cursor.Position.Y)
            Dim handle As IntPtr = WindowFromPoint(pt)

            Label1.Text = handle.ToString("X")

            If Not handle.Equals(prevHandle) AndAlso Not prevHandle.Equals(IntPtr.Zero) Then
                ' erase previous rectanlge
                ControlPaint.DrawReversibleFrame(New Rectangle(prevRC.Left, prevRC.Top, prevRC.Right - prevRC.Left, prevRC.Bottom - prevRC.Top), Color.Black, FrameStyle.Thick)
            End If

            If Not handle.Equals(prevHandle) Then
                ' get new rectangle
                GetWindowRect(handle, prevRC)

                ' draw new rectangle
                ControlPaint.DrawReversibleFrame(New Rectangle(prevRC.Left, prevRC.Top, prevRC.Right - prevRC.Left, prevRC.Bottom - prevRC.Top), Color.Black, FrameStyle.Thick)
            End If

            ' store new handle
            prevHandle = handle
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ControlPaint.DrawReversibleFrame(New Rectangle(prevRC.Left, prevRC.Top, prevRC.Right - prevRC.Left, prevRC.Bottom - prevRC.Top), Color.Black, FrameStyle.Thick)
        End If
    End Sub

End Class