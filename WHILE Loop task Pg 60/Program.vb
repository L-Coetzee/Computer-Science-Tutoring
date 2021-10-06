Imports System

Module Program
    Sub Main()
        Dim Num1 As Integer = 0
        Dim Num2 As Integer = 0
        Dim SubNum As Integer = 0

        'Obtain and store first value form usr
        Console.WriteLine("Insert number 1")
        Num1 = Console.ReadLine
        'Obtain and store second value form usr
        Console.WriteLine("Insert number 2")
        Num2 = Console.ReadLine

        Do While Num1 >= Num2
            'Record number of iterations in loop
            Num1 = Num1 - Num2
            SubNum = SubNum + 1
        Loop

        'Some usefull info:
        '& (concatenation) can be used to join strings and/or variables to create a longer string.
        Console.WriteLine("A Quotient B =  " & SubNum)
        Console.WriteLine("A Modulus B = " & Num1)
        Console.ReadKey()

    End Sub
End Module
