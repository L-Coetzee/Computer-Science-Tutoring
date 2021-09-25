Public Class Form1

    'Declaring Global variables
    'Doesn't matter if its local or global in this case
    'Only local when using certain variables in a certain subroutine

    Dim FuelType As String = 0
    Dim EngineCapacity As Decimal = 0
    Dim Mileage As Decimal = 0
    Dim Emissions As Decimal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCalculateEmissions.Click

        FuelType = TBInputFuelType.Text
        EngineCapacity = Convert.ToDecimal(TBInputEngineCapacity.Text) 'System.InvalidCastException: 'Conversion from string "3.8" to type 'Integer' is not valid.'
        Mileage = TBInputMileage.Text 'System.FormatException: 'Input string was not in a correct format

        If FuelType = "Petrol" Then
            If EngineCapacity <= 2 Then
                Emissions = (0.208 / 1000) * Mileage

                TBOutputEmissions.Text = Emissions
            Else
                Emissions = (0.296 / 1000) * Mileage

                TBOutputEmissions.Text = Emissions
            End If

        ElseIf EngineCapacity <= 2 Then

            Emissions = (0.176 / 1000) * Mileage

            TBOutputEmissions.Text = Emissions
        Else
            Emissions = (0.236 / 1000) * Mileage


            TBOutputEmissions.Text = Emissions
        End If

    End Sub

End Class
