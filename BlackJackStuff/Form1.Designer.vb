<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PlayersCards = New System.Windows.Forms.Label()
        Me.PlayersScore = New System.Windows.Forms.Label()
        Me.DealersCards = New System.Windows.Forms.Label()
        Me.DealersScore = New System.Windows.Forms.Label()
        Me.BtnStay = New System.Windows.Forms.Button()
        Me.BtnHit = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.WinLose = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PlayersCards
        '
        Me.PlayersCards.AutoSize = True
        Me.PlayersCards.Location = New System.Drawing.Point(24, 24)
        Me.PlayersCards.Name = "PlayersCards"
        Me.PlayersCards.Size = New System.Drawing.Size(76, 13)
        Me.PlayersCards.TabIndex = 0
        Me.PlayersCards.Text = "Player's Cards:"
        '
        'PlayersScore
        '
        Me.PlayersScore.AutoSize = True
        Me.PlayersScore.Location = New System.Drawing.Point(24, 47)
        Me.PlayersScore.Name = "PlayersScore"
        Me.PlayersScore.Size = New System.Drawing.Size(77, 13)
        Me.PlayersScore.TabIndex = 1
        Me.PlayersScore.Text = "Player's Score:"
        '
        'DealersCards
        '
        Me.DealersCards.AutoSize = True
        Me.DealersCards.Location = New System.Drawing.Point(24, 73)
        Me.DealersCards.Name = "DealersCards"
        Me.DealersCards.Size = New System.Drawing.Size(78, 13)
        Me.DealersCards.TabIndex = 2
        Me.DealersCards.Text = "Dealer's Cards:"
        '
        'DealersScore
        '
        Me.DealersScore.AutoSize = True
        Me.DealersScore.Location = New System.Drawing.Point(24, 97)
        Me.DealersScore.Name = "DealersScore"
        Me.DealersScore.Size = New System.Drawing.Size(79, 13)
        Me.DealersScore.TabIndex = 2
        Me.DealersScore.Text = "Dealer's Score:"
        '
        'BtnStay
        '
        Me.BtnStay.Location = New System.Drawing.Point(81, 202)
        Me.BtnStay.Name = "BtnStay"
        Me.BtnStay.Size = New System.Drawing.Size(48, 43)
        Me.BtnStay.TabIndex = 3
        Me.BtnStay.Text = "Stay"
        Me.BtnStay.UseVisualStyleBackColor = True
        '
        'BtnHit
        '
        Me.BtnHit.Location = New System.Drawing.Point(27, 202)
        Me.BtnHit.Name = "BtnHit"
        Me.BtnHit.Size = New System.Drawing.Size(48, 43)
        Me.BtnHit.TabIndex = 3
        Me.BtnHit.Text = "Hit"
        Me.BtnHit.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(135, 202)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(48, 43)
        Me.BtnNew.TabIndex = 3
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(189, 202)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(48, 43)
        Me.BtnQuit.TabIndex = 3
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'WinLose
        '
        Me.WinLose.AutoSize = True
        Me.WinLose.Location = New System.Drawing.Point(103, 153)
        Me.WinLose.Name = "WinLose"
        Me.WinLose.Size = New System.Drawing.Size(0, 13)
        Me.WinLose.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.WinLose)
        Me.Controls.Add(Me.BtnHit)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnStay)
        Me.Controls.Add(Me.DealersScore)
        Me.Controls.Add(Me.DealersCards)
        Me.Controls.Add(Me.PlayersScore)
        Me.Controls.Add(Me.PlayersCards)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayersCards As System.Windows.Forms.Label
    Friend WithEvents PlayersScore As System.Windows.Forms.Label
    Friend WithEvents DealersCards As System.Windows.Forms.Label
    Friend WithEvents DealersScore As System.Windows.Forms.Label
    Friend WithEvents BtnStay As System.Windows.Forms.Button
    Friend WithEvents BtnHit As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents WinLose As System.Windows.Forms.Label

End Class
