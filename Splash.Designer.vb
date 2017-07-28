<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.imgFindProg = New System.Windows.Forms.PictureBox()
        Me.lblWindow = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.recWrong = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recWait = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recRight = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFG = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBG = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.clrDialog = New System.Windows.Forms.ColorDialog()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnKeys11 = New System.Windows.Forms.Button()
        Me.btnKeys12 = New System.Windows.Forms.Button()
        Me.btnKeys13 = New System.Windows.Forms.Button()
        Me.btnKeys14 = New System.Windows.Forms.Button()
        Me.btnKeys10 = New System.Windows.Forms.Button()
        Me.btnKeys21 = New System.Windows.Forms.Button()
        Me.btnKeys22 = New System.Windows.Forms.Button()
        Me.btnKeys23 = New System.Windows.Forms.Button()
        Me.btnKeys24 = New System.Windows.Forms.Button()
        Me.btnKeys20 = New System.Windows.Forms.Button()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.btnColorReset = New System.Windows.Forms.Button()
        Me.btnQsReset = New System.Windows.Forms.Button()
        Me.btnPlayerReset = New System.Windows.Forms.Button()
        Me.btnKeys1Reset = New System.Windows.Forms.Button()
        Me.btnKeys2Reset = New System.Windows.Forms.Button()
        Me.lblGuide1 = New System.Windows.Forms.Label()
        Me.lblGuide2 = New System.Windows.Forms.Label()
        Me.lblGuide3 = New System.Windows.Forms.Label()
        Me.lblGuide4 = New System.Windows.Forms.Label()
        Me.lblGuide5 = New System.Windows.Forms.Label()
        Me.lblGuide6 = New System.Windows.Forms.Label()
        Me.lblGuide7 = New System.Windows.Forms.Label()
        Me.lblGuide8 = New System.Windows.Forms.Label()
        Me.lblGuide9 = New System.Windows.Forms.Label()
        Me.lblGuide10 = New System.Windows.Forms.Label()
        Me.lblGuide11 = New System.Windows.Forms.Label()
        Me.tmrError = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgFindProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFindProg
        '
        Me.imgFindProg.Cursor = System.Windows.Forms.Cursors.Cross
        Me.imgFindProg.Image = Global.matchupquiz.My.Resources.Resources.findprog
        Me.imgFindProg.Location = New System.Drawing.Point(12, 12)
        Me.imgFindProg.Name = "imgFindProg"
        Me.imgFindProg.Size = New System.Drawing.Size(36, 36)
        Me.imgFindProg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFindProg.TabIndex = 0
        Me.imgFindProg.TabStop = False
        '
        'lblWindow
        '
        Me.lblWindow.AutoSize = True
        Me.lblWindow.Location = New System.Drawing.Point(54, 24)
        Me.lblWindow.Name = "lblWindow"
        Me.lblWindow.Size = New System.Drawing.Size(56, 13)
        Me.lblWindow.TabIndex = 1
        Me.lblWindow.Text = "lblWindow"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 256)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(371, 36)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Button1"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recWrong, Me.recWait, Me.recRight, Me.recFG, Me.recBG})
        Me.ShapeContainer1.Size = New System.Drawing.Size(396, 304)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'recWrong
        '
        Me.recWrong.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recWrong.Location = New System.Drawing.Point(197, 227)
        Me.recWrong.Name = "recWrong"
        Me.recWrong.Size = New System.Drawing.Size(50, 21)
        '
        'recWait
        '
        Me.recWait.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recWait.Location = New System.Drawing.Point(75, 227)
        Me.recWait.Name = "recWait"
        Me.recWait.Size = New System.Drawing.Size(50, 21)
        '
        'recRight
        '
        Me.recRight.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recRight.Location = New System.Drawing.Point(331, 196)
        Me.recRight.Name = "recRight"
        Me.recRight.Size = New System.Drawing.Size(50, 21)
        '
        'recFG
        '
        Me.recFG.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFG.Location = New System.Drawing.Point(197, 196)
        Me.recFG.Name = "recFG"
        Me.recFG.Size = New System.Drawing.Size(50, 21)
        '
        'recBG
        '
        Me.recBG.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBG.Location = New System.Drawing.Point(75, 196)
        Me.recBG.Name = "recBG"
        Me.recBG.Size = New System.Drawing.Size(50, 21)
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(263, 54)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(121, 20)
        Me.txtTime.TabIndex = 2
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(263, 82)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(121, 20)
        Me.txtNum.TabIndex = 3
        '
        'btnKeys11
        '
        Me.btnKeys11.Location = New System.Drawing.Point(121, 137)
        Me.btnKeys11.Name = "btnKeys11"
        Me.btnKeys11.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys11.TabIndex = 7
        Me.btnKeys11.Text = "None"
        Me.btnKeys11.UseVisualStyleBackColor = True
        '
        'btnKeys12
        '
        Me.btnKeys12.Location = New System.Drawing.Point(168, 137)
        Me.btnKeys12.Name = "btnKeys12"
        Me.btnKeys12.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys12.TabIndex = 9
        Me.btnKeys12.Text = "None"
        Me.btnKeys12.UseVisualStyleBackColor = True
        '
        'btnKeys13
        '
        Me.btnKeys13.Location = New System.Drawing.Point(215, 137)
        Me.btnKeys13.Name = "btnKeys13"
        Me.btnKeys13.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys13.TabIndex = 11
        Me.btnKeys13.Text = "None"
        Me.btnKeys13.UseVisualStyleBackColor = True
        '
        'btnKeys14
        '
        Me.btnKeys14.Location = New System.Drawing.Point(262, 137)
        Me.btnKeys14.Name = "btnKeys14"
        Me.btnKeys14.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys14.TabIndex = 13
        Me.btnKeys14.Text = "None"
        Me.btnKeys14.UseVisualStyleBackColor = True
        '
        'btnKeys10
        '
        Me.btnKeys10.Location = New System.Drawing.Point(74, 137)
        Me.btnKeys10.Name = "btnKeys10"
        Me.btnKeys10.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys10.TabIndex = 4
        Me.btnKeys10.Text = "None"
        Me.btnKeys10.UseVisualStyleBackColor = True
        '
        'btnKeys21
        '
        Me.btnKeys21.Location = New System.Drawing.Point(121, 166)
        Me.btnKeys21.Name = "btnKeys21"
        Me.btnKeys21.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys21.TabIndex = 8
        Me.btnKeys21.Text = "None"
        Me.btnKeys21.UseVisualStyleBackColor = True
        '
        'btnKeys22
        '
        Me.btnKeys22.Location = New System.Drawing.Point(168, 166)
        Me.btnKeys22.Name = "btnKeys22"
        Me.btnKeys22.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys22.TabIndex = 10
        Me.btnKeys22.Text = "None"
        Me.btnKeys22.UseVisualStyleBackColor = True
        '
        'btnKeys23
        '
        Me.btnKeys23.Location = New System.Drawing.Point(215, 166)
        Me.btnKeys23.Name = "btnKeys23"
        Me.btnKeys23.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys23.TabIndex = 12
        Me.btnKeys23.Text = "None"
        Me.btnKeys23.UseVisualStyleBackColor = True
        '
        'btnKeys24
        '
        Me.btnKeys24.Location = New System.Drawing.Point(262, 166)
        Me.btnKeys24.Name = "btnKeys24"
        Me.btnKeys24.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys24.TabIndex = 14
        Me.btnKeys24.Text = "None"
        Me.btnKeys24.UseVisualStyleBackColor = True
        '
        'btnKeys20
        '
        Me.btnKeys20.Location = New System.Drawing.Point(74, 166)
        Me.btnKeys20.Name = "btnKeys20"
        Me.btnKeys20.Size = New System.Drawing.Size(41, 23)
        Me.btnKeys20.TabIndex = 5
        Me.btnKeys20.Text = "None"
        Me.btnKeys20.UseVisualStyleBackColor = True
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(74, 54)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayer1.TabIndex = 0
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(74, 82)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(121, 20)
        Me.txtPlayer2.TabIndex = 1
        '
        'btnColorReset
        '
        Me.btnColorReset.Location = New System.Drawing.Point(259, 227)
        Me.btnColorReset.Name = "btnColorReset"
        Me.btnColorReset.Size = New System.Drawing.Size(124, 23)
        Me.btnColorReset.TabIndex = 19
        Me.btnColorReset.Text = "Reset"
        Me.btnColorReset.UseVisualStyleBackColor = True
        '
        'btnQsReset
        '
        Me.btnQsReset.Location = New System.Drawing.Point(201, 108)
        Me.btnQsReset.Name = "btnQsReset"
        Me.btnQsReset.Size = New System.Drawing.Size(183, 23)
        Me.btnQsReset.TabIndex = 16
        Me.btnQsReset.Text = "Reset"
        Me.btnQsReset.UseVisualStyleBackColor = True
        '
        'btnPlayerReset
        '
        Me.btnPlayerReset.Location = New System.Drawing.Point(12, 108)
        Me.btnPlayerReset.Name = "btnPlayerReset"
        Me.btnPlayerReset.Size = New System.Drawing.Size(183, 23)
        Me.btnPlayerReset.TabIndex = 15
        Me.btnPlayerReset.Text = "Reset"
        Me.btnPlayerReset.UseVisualStyleBackColor = True
        '
        'btnKeys1Reset
        '
        Me.btnKeys1Reset.Location = New System.Drawing.Point(309, 137)
        Me.btnKeys1Reset.Name = "btnKeys1Reset"
        Me.btnKeys1Reset.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys1Reset.TabIndex = 17
        Me.btnKeys1Reset.Text = "Reset"
        Me.btnKeys1Reset.UseVisualStyleBackColor = True
        '
        'btnKeys2Reset
        '
        Me.btnKeys2Reset.Location = New System.Drawing.Point(309, 166)
        Me.btnKeys2Reset.Name = "btnKeys2Reset"
        Me.btnKeys2Reset.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys2Reset.TabIndex = 18
        Me.btnKeys2Reset.Text = "Reset"
        Me.btnKeys2Reset.UseVisualStyleBackColor = True
        '
        'lblGuide1
        '
        Me.lblGuide1.AutoSize = True
        Me.lblGuide1.Location = New System.Drawing.Point(9, 57)
        Me.lblGuide1.Name = "lblGuide1"
        Me.lblGuide1.Size = New System.Drawing.Size(45, 13)
        Me.lblGuide1.TabIndex = 12
        Me.lblGuide1.Text = "Player 1"
        '
        'lblGuide2
        '
        Me.lblGuide2.AutoSize = True
        Me.lblGuide2.Location = New System.Drawing.Point(9, 85)
        Me.lblGuide2.Name = "lblGuide2"
        Me.lblGuide2.Size = New System.Drawing.Size(45, 13)
        Me.lblGuide2.TabIndex = 12
        Me.lblGuide2.Text = "Player 2"
        '
        'lblGuide3
        '
        Me.lblGuide3.AutoSize = True
        Me.lblGuide3.Location = New System.Drawing.Point(201, 57)
        Me.lblGuide3.Name = "lblGuide3"
        Me.lblGuide3.Size = New System.Drawing.Size(30, 13)
        Me.lblGuide3.TabIndex = 12
        Me.lblGuide3.Text = "Time"
        '
        'lblGuide4
        '
        Me.lblGuide4.AutoSize = True
        Me.lblGuide4.Location = New System.Drawing.Point(201, 85)
        Me.lblGuide4.Name = "lblGuide4"
        Me.lblGuide4.Size = New System.Drawing.Size(54, 13)
        Me.lblGuide4.TabIndex = 12
        Me.lblGuide4.Text = "Questions"
        '
        'lblGuide5
        '
        Me.lblGuide5.AutoSize = True
        Me.lblGuide5.Location = New System.Drawing.Point(9, 142)
        Me.lblGuide5.Name = "lblGuide5"
        Me.lblGuide5.Size = New System.Drawing.Size(39, 13)
        Me.lblGuide5.TabIndex = 12
        Me.lblGuide5.Text = "Keys 1"
        '
        'lblGuide6
        '
        Me.lblGuide6.AutoSize = True
        Me.lblGuide6.Location = New System.Drawing.Point(9, 171)
        Me.lblGuide6.Name = "lblGuide6"
        Me.lblGuide6.Size = New System.Drawing.Size(39, 13)
        Me.lblGuide6.TabIndex = 12
        Me.lblGuide6.Text = "Keys 2"
        '
        'lblGuide7
        '
        Me.lblGuide7.AutoSize = True
        Me.lblGuide7.Location = New System.Drawing.Point(9, 201)
        Me.lblGuide7.Name = "lblGuide7"
        Me.lblGuide7.Size = New System.Drawing.Size(22, 13)
        Me.lblGuide7.TabIndex = 12
        Me.lblGuide7.Text = "BG"
        '
        'lblGuide8
        '
        Me.lblGuide8.AutoSize = True
        Me.lblGuide8.Location = New System.Drawing.Point(134, 201)
        Me.lblGuide8.Name = "lblGuide8"
        Me.lblGuide8.Size = New System.Drawing.Size(28, 13)
        Me.lblGuide8.TabIndex = 12
        Me.lblGuide8.Text = "Text"
        '
        'lblGuide9
        '
        Me.lblGuide9.AutoSize = True
        Me.lblGuide9.Location = New System.Drawing.Point(256, 201)
        Me.lblGuide9.Name = "lblGuide9"
        Me.lblGuide9.Size = New System.Drawing.Size(41, 13)
        Me.lblGuide9.TabIndex = 12
        Me.lblGuide9.Text = "Correct"
        '
        'lblGuide10
        '
        Me.lblGuide10.AutoSize = True
        Me.lblGuide10.Location = New System.Drawing.Point(9, 231)
        Me.lblGuide10.Name = "lblGuide10"
        Me.lblGuide10.Size = New System.Drawing.Size(29, 13)
        Me.lblGuide10.TabIndex = 12
        Me.lblGuide10.Text = "Wait"
        '
        'lblGuide11
        '
        Me.lblGuide11.AutoSize = True
        Me.lblGuide11.Location = New System.Drawing.Point(134, 231)
        Me.lblGuide11.Name = "lblGuide11"
        Me.lblGuide11.Size = New System.Drawing.Size(39, 13)
        Me.lblGuide11.TabIndex = 12
        Me.lblGuide11.Text = "Wrong"
        '
        'tmrError
        '
        Me.tmrError.Interval = 2500
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 304)
        Me.Controls.Add(Me.lblGuide11)
        Me.Controls.Add(Me.lblGuide10)
        Me.Controls.Add(Me.lblGuide9)
        Me.Controls.Add(Me.lblGuide8)
        Me.Controls.Add(Me.lblGuide7)
        Me.Controls.Add(Me.lblGuide6)
        Me.Controls.Add(Me.lblGuide5)
        Me.Controls.Add(Me.lblGuide4)
        Me.Controls.Add(Me.lblGuide3)
        Me.Controls.Add(Me.lblGuide2)
        Me.Controls.Add(Me.lblGuide1)
        Me.Controls.Add(Me.btnKeys2Reset)
        Me.Controls.Add(Me.btnKeys1Reset)
        Me.Controls.Add(Me.btnPlayerReset)
        Me.Controls.Add(Me.btnQsReset)
        Me.Controls.Add(Me.btnColorReset)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.btnKeys20)
        Me.Controls.Add(Me.btnKeys24)
        Me.Controls.Add(Me.btnKeys21)
        Me.Controls.Add(Me.btnKeys23)
        Me.Controls.Add(Me.btnKeys22)
        Me.Controls.Add(Me.btnKeys10)
        Me.Controls.Add(Me.btnKeys14)
        Me.Controls.Add(Me.btnKeys13)
        Me.Controls.Add(Me.btnKeys12)
        Me.Controls.Add(Me.btnKeys11)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWindow)
        Me.Controls.Add(Me.imgFindProg)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Splash"
        Me.Text = "Splash"
        Me.TopMost = True
        CType(Me.imgFindProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgFindProg As System.Windows.Forms.PictureBox
    Friend WithEvents lblWindow As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents recBG As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recWrong As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recWait As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recRight As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFG As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents clrDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnKeys11 As System.Windows.Forms.Button
    Friend WithEvents btnKeys12 As System.Windows.Forms.Button
    Friend WithEvents btnKeys13 As System.Windows.Forms.Button
    Friend WithEvents btnKeys14 As System.Windows.Forms.Button
    Friend WithEvents btnKeys10 As System.Windows.Forms.Button
    Friend WithEvents btnKeys21 As System.Windows.Forms.Button
    Friend WithEvents btnKeys22 As System.Windows.Forms.Button
    Friend WithEvents btnKeys23 As System.Windows.Forms.Button
    Friend WithEvents btnKeys24 As System.Windows.Forms.Button
    Friend WithEvents btnKeys20 As System.Windows.Forms.Button
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents btnColorReset As System.Windows.Forms.Button
    Friend WithEvents btnQsReset As System.Windows.Forms.Button
    Friend WithEvents btnPlayerReset As System.Windows.Forms.Button
    Friend WithEvents btnKeys1Reset As System.Windows.Forms.Button
    Friend WithEvents btnKeys2Reset As System.Windows.Forms.Button
    Friend WithEvents lblGuide1 As System.Windows.Forms.Label
    Friend WithEvents lblGuide2 As System.Windows.Forms.Label
    Friend WithEvents lblGuide3 As System.Windows.Forms.Label
    Friend WithEvents lblGuide4 As System.Windows.Forms.Label
    Friend WithEvents lblGuide5 As System.Windows.Forms.Label
    Friend WithEvents lblGuide6 As System.Windows.Forms.Label
    Friend WithEvents lblGuide7 As System.Windows.Forms.Label
    Friend WithEvents lblGuide8 As System.Windows.Forms.Label
    Friend WithEvents lblGuide9 As System.Windows.Forms.Label
    Friend WithEvents lblGuide10 As System.Windows.Forms.Label
    Friend WithEvents lblGuide11 As System.Windows.Forms.Label
    Friend WithEvents tmrError As System.Windows.Forms.Timer
End Class
