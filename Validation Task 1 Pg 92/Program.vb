Imports System

Module Program
    Sub Main()
        LogIn()
    End Sub

    Sub LogIn()
        While Attempts <= 1
            Console.WriteLine("Input Username")
            UserName = Console.ReadLine
            Console.WriteLine("Input Password")
            Password = Console.ReadLine

            If Validate(UserName, Password) Then
                Console.WriteLine("Welcome")
                Exit While
            Else
                Console.WriteLine("Password or Username is incorrect")
                Attempts = Attempts + 1
            End If
        End While
        If Attempts = 2 Then
            Console.Write("Locked Out")
        End If
    End Sub
    Dim UserName As Integer = 0
    Dim Attempts As Integer = 0
    Dim Password As String = ""

    Function Validate(ByVal User As Integer, Pass As String)
        If User > 1000 And User < 1500 Then
            If Pass.Length > 5 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Module
