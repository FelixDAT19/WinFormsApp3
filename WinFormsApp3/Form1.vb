Public Class Form1
    Dim tal1 As Integer
    Dim tal2 As Integer
    Dim MultiText As String
    Dim CompareResult As Integer
    Dim ResultInput As Integer
    Dim StreakCounter As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        tal1 = Int((10 * Rnd()) + 1)
        tal2 = Int((10 * Rnd()) + 1)
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

        Else
            Result.BackColor = Color.Red

            StreakCounter = 0

            Streak.Text = "streak: " & CStr(StreakCounter)

        End If
        InputBox.Text = ""
    End Sub

End Class
