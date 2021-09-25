Public Class Form1
    Dim StudentMark As Integer = 0
    Dim MaxMark As Integer = 0
    Dim Percent As Integer = 0

    Private Sub BTNCalculate_Click(sender As Object, e As EventArgs) Handles BTNCalculate.Click

        StudentMark = TBStudentMark.Text
        MaxMark = TBMaxMark.Text

        Percent = StudentMark / MaxMark * 100

        If Percent >= 80 Then
            TBGrade.Text = "Grade A"
        ElseIf Percent >= 70 Then
            TBGrade.Text = "Grade B"
        ElseIf Percent >= 60 Then
            TBGrade.Text = "Grade U"
        End If
    End Sub
End Class
