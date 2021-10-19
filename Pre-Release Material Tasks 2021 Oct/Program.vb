Imports System

Module Program
    Dim Bookings(1000)
    'Dim UserIDs()
    Dim Accounts(1000) As String 'id:name   
    Dim AccountCounter As Integer = 0
    Dim BookingCounter As Integer = 0
    Dim Journey(1000) As String
    Dim H_S() As Decimal = {1.5, 3.0, 4.5, 6.0, 8.0}
    Dim S_E() As Decimal = {5.75, 12.5, 22.25, 34.5, 45.0}
    Dim E_D() As Decimal = {1.5, 3.0, 4.5, 6.0, 8.0}
    Dim Time(2) As String
    'TODO: do the calculations you have all the things you ne
    Sub Main()
        Dim Proceed As String = "y"
        While Proceed = "y"
            Dim InputChoice As String = ""
            Console.WriteLine("Welcome to Victor.Inc Booking Management. Would you like to Create new account? y or n ")
            InputChoice = Console.ReadLine
            If InputChoice = "n" Then
                Call BookingManagement()
            ElseIf InputChoice = "y" Then
                AccountCreation()
            End If
            Console.WriteLine("Do you want to continue?_ ")
            Proceed = Console.ReadLine
        End While

    End Sub

    'Subroutine to manage passenger accounts, ticket codes/prices and booking id's
    Sub BookingManagement()

        'Initialising variables and arrays to be used in "Task 1"
        Dim PassengerCode As String = ""
        Dim PassengerName As String = ""
        Dim Home_Start As String = ""
        Dim HS As Decimal = 0
        Dim SE As Decimal = 0
        Dim ED As Decimal = 0
        Dim Start_End As String = ""
        Dim End_Dest As String = ""
        Dim StartTime As String = ""
        Dim PID As String = ""
        Dim JourneyTP As Decimal = 0
        Dim DiscountedPrice As Decimal = 0

        'input name/code
        Console.WriteLine("Input Passenger Code_ ")

        PassengerCode = Console.ReadLine
        PID = FindID(PassengerCode).ToString()
        'Validate input to not be -1 us IF STATEMENT
        If PassengerCode <= -1 Then
            Console.WriteLine("Passenger code not valid_ ")
        End If

        'Obtaining Codes form passenger
        ' where did I call it? 105

        Console.WriteLine("Enter Home Station -> Start Station Code_ ")
        Home_Start = Console.ReadLine
        While PricesForH_S(Home_Start) = -1
            Console.WriteLine("Enter A Valid Home Station -> Start Station Code_ ")
            Home_Start = Console.ReadLine
        End While
        HS = PricesForH_S(Home_Start)

        Console.WriteLine("Enter Start Station -> End Station Code_ ")
        Start_End = Console.ReadLine
        While PricesForS_E(Start_End) = -1
            Console.WriteLine("Enter A Valid Start Station -> End Station Code_ ")
            Start_End = Console.ReadLine
        End While
        SE = PricesForS_E(Start_End)

        Console.WriteLine("Enter End Station -> Destination Code_ ")
        End_Dest = Console.ReadLine
        While PricesForE_D(End_Dest) = -1
            Console.WriteLine("Enter End A Valid Station -> Destination Code_ ")
            End_Dest = Console.ReadLine
        End While
        ED = PricesForE_D(End_Dest)

        Console.WriteLine("Enter Start Time of Journey_ ")
        StartTime = Console.ReadLine
        CheckTime(StartTime)

        JourneyTP = HS + SE + ED

        If CalculateDiscount(JourneyTP.ToString, DiscountedPrice.ToString, StartTime) = False Then
            Console.WriteLine("Total Price for Journey W/out discount_$" & JourneyTP)
        ElseIf True Then
            Dim Answer As String = ""
            DiscountedPrice = JourneyTP - (JourneyTP * 0.4)
            Console.WriteLine("Total Price With discount_ $" & DiscountedPrice)

        End If



        CalculateDiscount(JourneyTP, DiscountedPrice, StartTime)

        CheckTime(StartTime)
        Booking(PID, StartTime, Home_Start, Start_End, End_Dest) ' this was actually correct sorry, becuase this will store the string codes I think this should work now just try run it

        'Call Booking(PID, StartTime, HS, SE, ED)' Okay lol 'but all the variables are in the correct place'its catually not correct bc HS SE ED are the verified codes... Ok

        ' yes
        'ive sent you a whatsapp'

        'This Is what it Is outputting

        'fun asdf(int i)// checks i>5 
        'If asdf(6) Then
        '        Input Passenger Code_
        '0
        'Enter Home Station -> Start Station Code_
        'C4
        '        Enter Start Station -> End Station Code_
        'F5
        '        Enter A Valid Start Station -> End Station Code_
        'M2
        '        Enter End Station -> Destination Code_
        'F5
        '        Enter Start Time of Journey_
        '15:50
        'Total Price With discount_ $15, 9
        'Your Booking ID is_ 1
        'Your Booking info is_ , 15: 50,C4,M2       
        'Confirm details? y Or n_

    End Sub
    Function CalculateDiscount(ByVal Price, DiscountPrice, StartTimeS)
        Dim Hours As Integer = -1
        Dim Minutes As Integer = -1
        Int32.TryParse(Time(0), Hours)
        Int32.TryParse(Time(1), Minutes)

        If Hours >= "10" Then
            If Minutes >= "01" Then
                Return True
            End If
        End If
        Return False

    End Function

    Sub AccountCreation()
        Console.WriteLine("Enter Account Name_ ")
        Console.ReadLine()
        Accounts(AccountCounter.ToString) = Console.ReadLine()
        Console.WriteLine("Account Created Succesfully. Your Account Number is_ " & AccountCounter)
        AccountCounter = AccountCounter + 1
    End Sub
    Function CheckTime(ByVal StartT)
        'Time = ["hh","mm"]
        Dim Hours As Integer = -1
        Dim Minutes As Integer = -1

        Time = Split(StartT, ":")
        If Int32.TryParse(Time(0), Hours) = False Then
            Console.WriteLine("Hours not in correct format_ ")
            Return False
        End If
        '        ok.look at this line And tell me what you see wrong
        If Int32.TryParse(Time(1), Minutes) = False Then
            Console.WriteLine("Minutes not in correct format_ ")
            Return False
        End If

        Hours = Time(0)
        Minutes = Time(1)
        If Hours >= 0 And Hours <= 23 Then
            If Minutes >= 0 And Minutes <= 59 Then
                Return True
            End If
        End If
        Return False
    End Function

    'Checking all avialable codes

    Function PricesForH_S(ByVal Code As String)
        Select Case Code
            Case "C1"
                Return H_S(0)
            Case "C2"
                Return H_S(1)
            Case "C3"
                Return H_S(2)
            Case "C4"
                Return H_S(3)
            Case "C5"
                Return H_S(4)
            Case Else
                Return -1
        End Select
    End Function
    Function PricesForS_E(ByVal Code As String)
        Select Case Code
            Case "M1"
                Return S_E(0)
            Case "M2"
                Return S_E(1)
            Case "M3"
                Return S_E(2)
            Case "M4"
                Return S_E(3)
            Case "M5"
                Return S_E(4)
            Case Else
                Return -1
        End Select
    End Function
    Function PricesForE_D(ByVal Code As String)
        Select Case Code
            Case "F1"
                Return E_D(0)
            Case "F2"
                Return E_D(1)
            Case "F3"
                Return E_D(2)
            Case "F4"
                Return E_D(3)
            Case "F5"
                Return E_D(4)
            Case Else
                Return -1
        End Select
    End Function

    'Assigning each "PassengerName" a unique PassengerID

    'Return Accounts(pasengerCode)
    Function FindID(ByVal PassengerCode As String)
        If PassengerCode >= 0 And PassengerCode < 999 Then
            Return Accounts(PassengerCode)
        Else
            Console.WriteLine("Error! Passenger Train Is Full")
            Return -1
            Exit Function
        End If
    End Function

    Sub Booking(ByVal pID As String, StartT As String, CX As String, MX As String, FX As String)


        Dim oneBooking() = {pID, StartT, CX, MX, FX}
        Dim Choice As String = ""
        Dim CCode As String = ""
        Dim MCode As String = ""
        Dim FCode As String = ""
        Dim bID As String = ""
        Dim OutputString As String = ""
        CCode = CX
        MCode = MX
        FCode = FX

        bID = BookingCounter

        'Bookings -> [[0,13:45,C1,M2,F3],[]]
        Bookings(BookingCounter) = oneBooking

        BookingCounter = BookingCounter + 1


        Console.WriteLine("Your booking ID is_ " & BookingCounter)
        OutputString = "Your booking info is_ " & BookingCounter.ToString() & Bookings(bID)(0) & ", " & Bookings(bID)(1) & ", " & Bookings(bID)(2) & ", " & Bookings(bID)(3) & ", " & Bookings(bID)(4)
        Console.WriteLine(OutputString) 'try that?                      Jup just like that lol im running it now... yes it works!                                                                         


        Console.WriteLine("Confirm details? y or n_ ")
        Choice = Console.ReadLine
        If Choice = "n" Then
            Exit Sub
        End If

    End Sub 'It is also outputting two of this            ^ above statement

End Module

'Use System.String.Split:

'Dim source As String = "Tom, John, Jason, Mike"
'Dim stringSeparators() As String = {","}
'Dim result() As String
'result = source.Split(stringSeparators,
'StringSplitOptions.RemoveEmptyEntries)
'Or use Microsoft.VisualBasic.Strings.Split

'Dim source As String = "Tom, John, Jason, Mike"
'Dim result() As String = Split(source, ",")

'13:50 

'Split(source, ":")
'["13","50"]

'so what this does is splits the string "13:50" up into and array that looks like the one about this
'ok so the : Is a break point in the time... its where the the string is split up.
'so like on line 178. the break point is the , so you get an array that looks like ["Tom","John",.,.,.]
'Its just split by commas and breakpoints yeah cool
'Its connecting now
'You were talking about breakpoints 
'Makes sense. That is a good workaround
'I am still trying to connect

'Input Passenger Code_
'0
'Enter Home Station -> Start Station Code_
'c2
'Invalid Code
'Enter Start Station -> End Station Code_
'M2
'Enter End Station -> Destination Code_
'F3
'Enter Start Time Of Journey_
'10:20
'10 20
'10 20 ' i disconnected... Just type out what you wa
' your switches dont catch the error. so you need to loop over it until its stops giving you the wrong input. so return some 
'hting ' tlhat makes ense
' ya so return somthing in the Else that is obvious so you can chatch it with a while loop or something. you can then
'loop until the user puts in a valid code
'make sense?
' yes makes esne
