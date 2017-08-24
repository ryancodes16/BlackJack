Public Class Form1
    Dim Card As Integer
    Dim Player As Integer
    Dim Dealer As Integer
    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
        End
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        BtnNew.Enabled = False
        BtnHit.Enabled = True
        BtnStay.Enabled = True
        Card = Int(10 * Rnd()) + 1
        Player = Card
        PlayersCards.Text = "Player's Cards: " & Player
        Card = Int(10 * Rnd()) + 1
        Player = Player + Card
        PlayersCards.Text = PlayersCards.Text & " " & Card
        PlayersScore.Text = "Player's Score: " & Player
        Card = Int(10 * Rnd()) + 1
        Dealer = Card
        DealersCards.Text = "Dealer's Cards: " & Dealer
        DealersScore.Text = "Dealer's Score: "
        WinLose.Text = " "
    End Sub

    Private Sub BtnStay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStay.Click
        BtnStay.Enabled = False
        BtnHit.Enabled = False
        BtnNew.Enabled = True
        Do While (Dealer < 17)
            Card = Int(10 * Rnd()) + 1
            Dealer = Dealer + Card
            DealersCards.Text = DealersCards.Text & " " & Card
            DealersScore.Text = "Dealer's Score: " & Dealer
        Loop
        If Dealer > 21 Then
            WinLose.Text = "Dealer Bust"
        ElseIf Dealer > Player And Dealer <= 21 Then
            WinLose.Text = "Dealer Win"
        ElseIf Dealer < Player And Player <= 21 Then
            WinLose.Text = "Player Win"
        ElseIf Dealer = Player And Dealer <= 21 Then
            WinLose.Text = "Push"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnHit.Enabled = False
        BtnStay.Enabled = False
        Randomize()
    End Sub

    Private Sub BtnHit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHit.Click
        Card = Int(10 * Rnd()) + 1
        Player = Player + Card
        PlayersCards.Text = PlayersCards.Text & " " & Card
        PlayersScore.Text = "Player's Score: " & Player
        If Player > 21 Then
            WinLose.Text = "Player Bust"
            BtnStay.Enabled = False
            BtnNew.Enabled = True
            BtnHit.Enabled = False
        End If
    End Sub
End Class

