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
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWindow)
        Me.Controls.Add(Me.imgFindProg)
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
End Class
