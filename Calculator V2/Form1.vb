Public Class Form1

    Dim Num1 As Decimal = 0 'Declaring variables
    Dim Operation As String = "" 'Using a string to asign operator to program
    Dim Num2 As Decimal = 0 'Declaring variables
    Dim Ans As Decimal = 0 'Declaring variables

    Private Sub BTNEquals_Click(sender As Object, e As EventArgs) Handles BTNEquals.Click

        Num2 = TBInputOutput.Text

        Select Case Operation

            Case Is = "+"
                Ans = Num1 + Num2

            Case Is = "/"
                Ans = Num1 / Num2

            Case Is = "-"
                Ans = Num1 - Num2

            Case Is = "*"
                Ans = Num1 * Num2
            Case Else
                TBInputOutput.Text = "Error has occured!"
        End Select

        TBInputOutput.Clear()

        TBInputOutput.Text = "= " + Decimal.Parse(Ans).ToString()


    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click

        Num1 = TBInputOutput.Text
        Operation = "+"
        TBInputOutput.Clear()
        'TBInputOutput.Text = Num1 + 1 (test code to test that routine works)

        Me.ActiveControl = TBInputOutput

    End Sub

    Private Sub BTNDivide_Click(sender As Object, e As EventArgs) Handles BTNDivide.Click
        Num1 = TBInputOutput.Text
        Operation = "/"
        TBInputOutput.Clear()
        'TBInputOutput.Text = Num1 + 1 (test code to test that routine works)
        Me.ActiveControl = TBInputOutput
    End Sub

    Private Sub BTNSub_Click(sender As Object, e As EventArgs) Handles BTNSub.Click

        Num1 = TBInputOutput.Text
        Operation = "-"
        TBInputOutput.Clear()
        'TBInputOutput.Text = Num1 + 1 (test code to test that routine works)
        Me.ActiveControl = TBInputOutput

    End Sub

    Private Sub BTNMultiply_Click(sender As Object, e As EventArgs) Handles BTNMultiply.Click

        Num1 = TBInputOutput.Text
        Operation = "*"
        TBInputOutput.Clear()
        'TBInputOutput.Text = Num1 + 1 (test code to test that routine works)
        Me.ActiveControl = TBInputOutput

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        TBInputOutput.Clear()
        Me.ActiveControl = TBInputOutput
    End Sub

End Class
