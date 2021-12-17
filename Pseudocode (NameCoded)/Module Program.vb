Module Program
    Sub Main()
    End Sub

    'Subroutine to manage passenger accounts, ticket codes/prices and booking id's
    Sub PassengerAccManagement()

        'Initialising variables and arrays to be used in "Task 1"
        Dim H_S() As Decimal = {1.5, 3.0, 4.5, 6.0, 8.0}
        Dim S_E() As Decimal = {5.75, 12.5, 22.25, 34.5, 45.0}
        Dim E_D() As Decimal = {1.5, 3.0, 4.5, 6.0, 8.0}
        Dim Home_Start As String = ""
        Dim Start_End As String = ""
        Dim End_Dest As String = ""
        Dim Accounts(1000) As String
        Dim StartTime As String = ""

        Console.WriteLine("Enter Home Station -> Start Station Code ")
        Home_Start = Console.ReadLine
        Console.WriteLine("Enter Start Station -> End Station Code ")
        Start_End = Console.ReadLine
        Console.WriteLine("Enter End Station -> Destination Code ")
        End_Dest = Console.ReadLine
        Console.WriteLine("Enter Start Time of Journey ")
        StartTime = Console.ReadLine



    End Sub
    Function Booking()
        Dim pID As Integer = 0
        Dim StartT As Integer = 0
        Dim CX As Integer = 0
        Dim MX As Integer = 0
        Dim FX As Integer = 0

        Dim CCode As String = ""
        Dim MCode As String = ""
        Dim FCode As String = ""

        Console.Write("Passenger ID?_")
        pID = Console.ReadLine
        Console.Write("Enter Start Time_")
        StartT = Console.ReadLine

        Dim Bookings()

        Dim oneBooking = {"0", "12:43", "C2", "M3", "F5"}
        Bookings.Append(oneBooking)

        oneBooking = {"3", "9:43", "C3", "M1", "F4"}
        Bookings.Append(oneBooking)

        Dim bID As Integer = 0

        Console.WriteLine("This is booking")
        Console.WriteLine("Passenger ", Bookings(bID)(pID))
        Console.WriteLine("Start Time ", Bookings(bID)(StartT))
        Console.WriteLine(Bookings(bID)(CX))
        Console.WriteLine(Bookings(bID)(MX))
        Console.WriteLine(Bookings(bID)(FX))
    End Function

    Function ValidateAllInputs()

    End Function
End Module