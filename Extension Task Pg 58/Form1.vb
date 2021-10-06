Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBOutputMultiples.Hide()
    End Sub

    Private Sub BTNPrime_Click(sender As Object, e As EventArgs) Handles BTNPrime.Click
        LBOutputMultiples.Items.Clear()
        'Declare and initialise the modulus variables
        'Declared locally so reset to zero if user runs code multiple times
        Dim Modulus As Integer = 0
        Dim ModCount As Integer = 0
        Dim NumberIn As Integer = 0

        NumberIn = TBInput.Text

        For i = 2 To NumberIn - 1
            Modulus = NumberIn Mod i
            If Modulus = 0 Then
                ModCount = ModCount + 1
            End If
        Next

        If ModCount = 0 Then
            TBOutput.Text = "This is a PRIME number"
        Else
            For i = 1 To NumberIn - 1
                If (NumberIn Mod i) = 0 Then
                    LBOutputMultiples.Items.Add(i)
                End If
            Next
            LBOutputMultiples.Show()
            TBOutput.Text = "This is NOT a PRIME number"
        End If
    End Sub
End Class
