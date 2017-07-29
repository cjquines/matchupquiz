<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tmrQuestion = New System.Windows.Forms.Timer(Me.components)
        Me.hlpProvider = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpProvider.SetHelpString(Me.lblTimer, "When stopped, click to start question/round. When waiting, click to indicate wron" & _
        "g answer.")
        Me.lblTimer.Location = New System.Drawing.Point(449, -2)
        Me.lblTimer.Name = "lblTimer"
        Me.hlpProvider.SetShowHelp(Me.lblTimer, True)
        Me.lblTimer.Size = New System.Drawing.Size(118, 73)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.Text = "00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1
        '
        Me.lblPlayer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPlayer1.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpProvider.SetHelpString(Me.lblPlayer1, "Click to change player 1's name")
        Me.lblPlayer1.Location = New System.Drawing.Point(79, 9)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.hlpProvider.SetShowHelp(Me.lblPlayer1, True)
        Me.lblPlayer1.Size = New System.Drawing.Size(348, 86)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "Christopher"
        Me.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlayer2
        '
        Me.lblPlayer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPlayer2.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpProvider.SetHelpString(Me.lblPlayer2, "Click to change player 2's name")
        Me.lblPlayer2.Location = New System.Drawing.Point(584, 9)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.hlpProvider.SetShowHelp(Me.lblPlayer2, True)
        Me.lblPlayer2.Size = New System.Drawing.Size(351, 86)
        Me.lblPlayer2.TabIndex = 2
        Me.lblPlayer2.Text = "Christopher"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScore1
        '
        Me.lblScore1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblScore1.Font = New System.Drawing.Font("Segoe UI Light", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpProvider.SetHelpString(Me.lblScore1, "When waiting, click to increase score")
        Me.lblScore1.Location = New System.Drawing.Point(1, -11)
        Me.lblScore1.Name = "lblScore1"
        Me.hlpProvider.SetShowHelp(Me.lblScore1, True)
        Me.lblScore1.Size = New System.Drawing.Size(104, 128)
        Me.lblScore1.TabIndex = 2
        Me.lblScore1.Text = "0"
        Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore2
        '
        Me.lblScore2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblScore2.Font = New System.Drawing.Font("Segoe UI Light", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpProvider.SetHelpString(Me.lblScore2, "When waiting, click to increase score")
        Me.lblScore2.Location = New System.Drawing.Point(916, -12)
        Me.lblScore2.Name = "lblScore2"
        Me.hlpProvider.SetShowHelp(Me.lblScore2, True)
        Me.lblScore2.Size = New System.Drawing.Size(104, 128)
        Me.lblScore2.TabIndex = 2
        Me.lblScore2.Text = "0"
        Me.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpProvider.SetHelpString(Me.lblStatus, "Click to open settings window")
        Me.lblStatus.Location = New System.Drawing.Point(400, 73)
        Me.lblStatus.Name = "lblStatus"
        Me.hlpProvider.SetShowHelp(Me.lblStatus, True)
        Me.lblStatus.Size = New System.Drawing.Size(212, 34)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Christopher is correct"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrQuestion
        '
        Me.tmrQuestion.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 117)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblTimer)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "matchupquiz"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrQuestion As System.Windows.Forms.Timer
    Friend WithEvents hlpProvider As System.Windows.Forms.HelpProvider
End Class
