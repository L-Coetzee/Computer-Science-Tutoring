Public Class Form1
    'Declare Globale variables
    Dim Radius As Decimal = 0
    Dim Circumference As Decimal = 0
    Const Pi As Decimal = 3.141592654

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNArea.Click
        'Local variable
        Dim Area As Decimal = 0

        'placing values from the textbox into variables
        Radius = TBRadius.Text

        'calculate area and store in variable
        Area = (Pi * (Radius * Radius))

        TBArea.Text = Area

    End Sub

    Private Sub BTNCircumference_Click(sender As Object, e As EventArgs) Handles BTNCircumference.Click
        Dim Circumference As Decimal = 0

        Radius = TBRadius.Text

        Circumference = 2 * Pi * Radius

        TBCircumference.Text = Circumference
    End Sub


End Class
