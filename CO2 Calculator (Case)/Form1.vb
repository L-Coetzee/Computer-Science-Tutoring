Public Class Form1
    Dim EngineSize As Decimal = 0
    Dim EngineType As String = ""
    Dim Mileage As Integer = 0
    Dim Emissions As Decimal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCalculate.Click

        EngineSize = Convert.ToDecimal(TBEngineCapacity.Text)
        Mileage = TBMileage.Text
        Emissions = TBEmissions.Tex
        EngineType  = TBEngineType.Text

        Select Case EngineType = "Petrol"

            Case EngineSize <= 2
                Emissions = (0.176 / 1000) * Mileage
                TBEmissions.Text = Emissions
            Case Else
                Emissions = (0.236 / 1000) * Mileage
                TBEmissions.Text = Emissions
        End Select



        Select Case EngineType = "Diesel"
            Case EngineSize <= 2
                Emissions = (0.208 / 1000) * Mileage
                TBEmissions.Text = Emissions
            Case Else
                Emissions = (0.296 / 1000) * Mileage
                TBEmissions.Text = Emissions
        End Select



    End Sub
End Class
