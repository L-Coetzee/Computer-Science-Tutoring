Imports System

Module Program
    Sub Main()

        Dim Number, NrMultiples As Integer
        Console.WriteLine("Number")
        Number = Console.ReadLine
        Console.WriteLine("Number Of Multiples")
        NrMultiples = Console.ReadLine

        Call Multiply(Number, NrMultiples)
    End Sub
    Sub Multiply(ByVal Number As Integer, ByVal MultipleINT As Integer)
        For i = 1 To MultipleINT
            Console.WriteLine(Number * i)
        Next
    End Sub
End Module
