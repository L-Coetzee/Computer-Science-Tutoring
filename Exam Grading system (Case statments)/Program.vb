Imports System

Module Program
    Sub Main()
        'Decleration of variables
        'NOTE - although Percent is possible to be 
        'calculated as a decimal. It has been declared
        'as an integer to round the calculated value
        'to a whole numnber
        Dim StudentMark As Integer = 0
        Dim MaxMark As Integer = 0
        Dim Percent As Integer = 0

        Console.WriteLine("Input STUDENT Mark")
        StudentMark = Console.ReadLine
        Console.WriteLine("Input MAX Mark")
        MaxMark = Console.ReadLine

        Percent = StudentMark / MaxMark * 100

        Select Case Percent
            Case Is >= 80
                Console.WriteLine("Grade A")
            Case Is >= 70
                Console.WriteLine("Grade B")
            Case Is >= 60
                Console.WriteLine("Grade C")
            Case Else
                Console.WriteLine("Grade U")
        End Select

        Console.ReadKey()

    End Sub
End Module
