Public Class Form1
    'Global variables
    Dim Height1 As Decimal = 0
    Dim Width1 As Decimal = 0
    Dim Depth1 As Decimal = 0
    'Constant to hold ratio between cubic centimtres and cubic litres
    Const Litres As Integer = 1000

    Private Sub BTNCalculateVolume_Click(sender As Object, e As EventArgs) Handles BTNCalculateVolume.Click
        'Local variable for Volume
        Dim Volume As Decimal = 0

        'Placing values for the textbox into variables
        Height1 = TBHeight.Text
        Width1 = TBWidth.Text
        Depth1 = TBDepth.Text

        'Calculate volume and store in local variable
        'Convert to Litres
        Volume = (Height1 * Width1 * Depth1) / Litres

        'Output the value in local variable Volume to the textbox
        TBVolume.Text = Volume

    End Sub
End Class
