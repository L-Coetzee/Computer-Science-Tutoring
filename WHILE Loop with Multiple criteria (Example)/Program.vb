Imports System

Module Program
    Sub Main()
        Dim Num As Integer = 0
        Dim Modulus As Integer = 0
        Dim Prime As Boolean = True

        'Obtain and store input from user
        Console.WriteLine("Insert Number to Test")
        Num = Console.ReadLine

        'Declare counter to use with the While loop
        'Initialise to 2 to avoid using 1 as a divisor
        Dim Counter As Integer = 2

        'Start the While loop with two conditions
        'The AND connecting operator means BOTH conditions must be True to iterate
        Do While Counter < Num - 1 And Prime = True
            Modulus = Num Mod Counter

            'If statement changes Prime to False if modulus = 0
            'This will cause the loop conditions to be Fals at next itiration and stop loop
            If Modulus = 0 Then
                Prime = False
            End If
            'Counter incrimented to loop through all integer values between 1 nd num -1
            Counter = Counter + 1
        Loop

        'Once loop complete
        'If statement outputs appropriate message bsed on state of Prime Boolean
        If Prime = True Then
            Console.WriteLine("PRIME number")
        Else
            Console.WriteLine("NOT a PRIME number")
        End If
        Console.ReadKey()
    End Sub
End Module
