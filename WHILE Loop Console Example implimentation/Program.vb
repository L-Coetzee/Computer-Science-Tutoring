Imports System

Module Module1
    Sub Main()
        Dim Multiply As Integer = 0

        'Obtain the input value from the user and place in the variable
        Console.WriteLine("Insert Number")
        Multiply = Console.ReadLine

        'Declare and initialise local variable
        'Initialised to 1 to avoid performaing 0 x Input Number
        Dim Counter As Integer = 1

        'Start the while loop - with the condition to loop while counter <= 10
        Do While Counter <= 10
            Console.WriteLine(Multiply * Counter)

            'Increment counter
            'Omit this line and see what happens
            '          it will create an infinite loop because Counter will always be < 10
            Counter = Counter + 1
        Loop
    End Sub
End Module
