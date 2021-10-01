Imports System

Module Program
    Sub main()
        Dim Multiply As Integer = 0
        Dim Power As Integer = 0

        Console.WriteLine("Input Number To Multiply")
        Multiply = Console.ReadLine

        Console.WriteLine("Input Number Of Multiples")
        Power = Console.ReadLine

        For i = 1 To Power
            Console.WriteLine(Multiply * i)
        Next

        Console.ReadKey()

    End Sub


End Module
