Imports System

Module Program

    Sub Main()
        Dim StudentMark As Integer = 0
        Dim MaxMark As Integer = 0
        Dim Percent As Integer = 0

        Console.WriteLine("Input STUDENT Mark")
        StudentMark = Console.ReadLine
        Console.WriteLine("Input MAX Mark")
        MaxMark = Console.ReadLine

        Percent = StudentMark / MaxMark * 100

        If Percent >= 80 Then
            Console.WriteLine("Grade A")
        Else
            If Percent >= 70 Then
                Console.WriteLine("Grade B")
            Else
                If Percent >= 60 Then
                    Console.WriteLine("Grade C")
                Else
                    Console.WriteLine("Grade U")
                End If
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
