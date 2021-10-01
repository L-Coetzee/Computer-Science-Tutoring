Imports System

Module Program
    Sub Main()
        Dim Multiply As Integer = 0
        Dim PowerTo As Integer = 0
        Dim Answer As Integer = 0

        Console.WriteLine("Input number to Multiply")
        Multiply = Console.ReadLine

        Console.WriteLine("Input Power")
        PowerTo = Console.ReadLine

        Answer = (Multiply ^ PowerTo)
        Console.WriteLine(Answer)

        Console.ReadKey()
    End Sub

End Module
