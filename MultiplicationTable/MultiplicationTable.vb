'Jessica McArthur
'RCET0265
'Spring 2022
'Multiplication Table
'

Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()
        'Variables declared
        Dim userResponse As String
        Dim size As Integer
        Dim sizeCheck As Boolean = False

        'ask the user for a number
        Console.WriteLine("Please enter the desired table size. ")
        userResponse = Console.ReadLine()

        'user's response is validated as an integer.
        Do Until sizeCheck = True
            Try
                size = CInt(userResponse)
                sizeCheck = True
            Catch ex As Exception
                Console.WriteLine("Please enter a whole number!")
                userResponse = Console.ReadLine()
            End Try
        Loop

        Console.WriteLine("Enjoy Earthling your " & size & " by " & size & " Multiplication Table")

        'table is made to user's requested size.
        For rolodex = 1 To size
            For index = 1 To size
                Console.Write(CStr(index * rolodex).PadLeft(5))

            Next
            Console.WriteLine()
        Next

        'exit considerations are made for the user.
        Console.WriteLine("Please press enter to exit. A bientot!")
        Console.ReadLine()
    End Sub

End Module
