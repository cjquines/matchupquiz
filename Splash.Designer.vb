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
        CType(Me.imgFindProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFindProg
        '
        Me.imgFindProg.Cursor = System.Windows.Forms.Cursors.Cross
        Me.imgFindProg.Image = Global.matchupquiz.My.Resources.Resources.findprog
        Me.imgFindProg.Location = New System.Drawing.Point(12, 12)
        Me.imgFindProg.Name = "imgFindProg"
        Me.imgFindProg.Size = New System.Drawing.Size(152, 153)
        Me.imgFindProg.TabIndex = 0
        Me.imgFindProg.TabStop = False
        '
        'lblWindow
        '
        Me.lblWindow.AutoSize = True
        Me.lblWindow.Location = New System.Drawing.Point(9, 179)
        Me.lblWindow.Name = "lblWindow"
        Me.lblWindow.Size = New System.Drawing.Size(39, 13)
        Me.lblWindow.TabIndex = 1
        Me.lblWindow.Text = "Label1"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 226)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Button1"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recWrong, Me.recWait, Me.recRight, Me.recFG, Me.recBG})
        Me.ShapeContainer1.Size = New System.Drawing.Size(523, 316)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'recWrong
        '
        Me.recWrong.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recWrong.Location = New System.Drawing.Point(365, 152)
        Me.recWrong.Name = "recWrong"
        Me.recWrong.Size = New System.Drawing.Size(75, 23)
        '
        'recWait
        '
        Me.recWait.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recWait.Location = New System.Drawing.Point(366, 117)
        Me.recWait.Name = "recWait"
        Me.recWait.Size = New System.Drawing.Size(75, 23)
        '
        'recRight
        '
        Me.recRight.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recRight.Location = New System.Drawing.Point(354, 78)
        Me.recRight.Name = "recRight"
        Me.recRight.Size = New System.Drawing.Size(75, 23)
        '
        'recFG
        '
        Me.recFG.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFG.Location = New System.Drawing.Point(361, 44)
        Me.recFG.Name = "recFG"
        Me.recFG.Size = New System.Drawing.Size(75, 23)
        '
        'recBG
        '
        Me.recBG.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBG.Location = New System.Drawing.Point(357, 12)
        Me.recBG.Name = "recBG"
        Me.recBG.Size = New System.Drawing.Size(75, 23)
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(232, 179)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 4
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(365, 190)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 5
        '
        'btnKeys11
        '
        Me.btnKeys11.Location = New System.Drawing.Point(195, 242)
        Me.btnKeys11.Name = "btnKeys11"
        Me.btnKeys11.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys11.TabIndex = 6
        Me.btnKeys11.Text = "Button1"
        Me.btnKeys11.UseVisualStyleBackColor = True
        '
        'btnKeys12
        '
        Me.btnKeys12.Location = New System.Drawing.Point(276, 242)
        Me.btnKeys12.Name = "btnKeys12"
        Me.btnKeys12.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys12.TabIndex = 6
        Me.btnKeys12.Text = "Button1"
        Me.btnKeys12.UseVisualStyleBackColor = True
        '
        'btnKeys13
        '
        Me.btnKeys13.Location = New System.Drawing.Point(354, 242)
        Me.btnKeys13.Name = "btnKeys13"
        Me.btnKeys13.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys13.TabIndex = 6
        Me.btnKeys13.Text = "Button1"
        Me.btnKeys13.UseVisualStyleBackColor = True
        '
        'btnKeys14
        '
        Me.btnKeys14.Location = New System.Drawing.Point(435, 242)
        Me.btnKeys14.Name = "btnKeys14"
        Me.btnKeys14.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys14.TabIndex = 6
        Me.btnKeys14.Text = "Button1"
        Me.btnKeys14.UseVisualStyleBackColor = True
        '
        'btnKeys10
        '
        Me.btnKeys10.Location = New System.Drawing.Point(114, 242)
        Me.btnKeys10.Name = "btnKeys10"
        Me.btnKeys10.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys10.TabIndex = 6
        Me.btnKeys10.Text = "Button1"
        Me.btnKeys10.UseVisualStyleBackColor = True
        '
        'btnKeys21
        '
        Me.btnKeys21.Location = New System.Drawing.Point(195, 271)
        Me.btnKeys21.Name = "btnKeys21"
        Me.btnKeys21.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys21.TabIndex = 6
        Me.btnKeys21.Text = "Button1"
        Me.btnKeys21.UseVisualStyleBackColor = True
        '
        'btnKeys22
        '
        Me.btnKeys22.Location = New System.Drawing.Point(276, 271)
        Me.btnKeys22.Name = "btnKeys22"
        Me.btnKeys22.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys22.TabIndex = 6
        Me.btnKeys22.Text = "Button1"
        Me.btnKeys22.UseVisualStyleBackColor = True
        '
        'btnKeys23
        '
        Me.btnKeys23.Location = New System.Drawing.Point(354, 271)
        Me.btnKeys23.Name = "btnKeys23"
        Me.btnKeys23.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys23.TabIndex = 6
        Me.btnKeys23.Text = "Button1"
        Me.btnKeys23.UseVisualStyleBackColor = True
        '
        'btnKeys24
        '
        Me.btnKeys24.Location = New System.Drawing.Point(435, 271)
        Me.btnKeys24.Name = "btnKeys24"
        Me.btnKeys24.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys24.TabIndex = 6
        Me.btnKeys24.Text = "Button1"
        Me.btnKeys24.UseVisualStyleBackColor = True
        '
        'btnKeys20
        '
        Me.btnKeys20.Location = New System.Drawing.Point(114, 271)
        Me.btnKeys20.Name = "btnKeys20"
        Me.btnKeys20.Size = New System.Drawing.Size(75, 23)
        Me.btnKeys20.TabIndex = 6
        Me.btnKeys20.Text = "Button1"
        Me.btnKeys20.UseVisualStyleBackColor = True
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(232, 206)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer1.TabIndex = 7
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(357, 216)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer2.TabIndex = 8
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 316)
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
End Class
