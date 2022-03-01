Public Class Form1
    Dim tal1 As Integer
    Dim tal2 As Integer
    Dim MultiText As String
    Dim CompareResult As Integer
    Dim ResultInput As Integer
    Dim StreakCounter As Integer = 0
    Dim CounterHS As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        skrivi()

    End Sub

    Private Sub skrivi()
        Randomize()
        tal1 = Int((12 * Rnd()) + 0)
        tal2 = Int((12 * Rnd()) + 0)
        MultiText = CStr(tal1) & " * " & CStr(tal2) & " ="
        Multiplikation.Text = MultiText
        CompareResult = tal1 * tal2
    End Sub


    Private Sub Multiplikation_Click(sender As Object, e As EventArgs) Handles Multiplikation.Click

    End Sub

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged

    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        ResultInput = InputBox.Text

        If ResultInput = CompareResult Then
            Result.BackColor = Color.Green

            StreakCounter += 1

            Streak.Text = "streak: " & CStr(StreakCounter)

            CounterHS += 1

        Else

            If CounterHS >= numHighscore.Text Then
                numHighscore.Text = CounterHS
            End If

            ResultView.Items.Add(StreakCounter)

            Result.BackColor = Color.Red

            StreakCounter = 0

            Streak.Text = "streak: " & CStr(StreakCounter)


        End If
        InputBox.Text = ""
        skrivi()
    End Sub

    Private Sub ResultView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ResultView.SelectedIndexChanged

    End Sub
End Class
