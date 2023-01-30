Option Compare Text

Imports System

Module SayMyName
    Sub Main()
        'Initiate variable for the person's name
        Dim name As String
        'Asks what the user's name is
        Console.WriteLine("What is you rname?")
        'Sets the user's input to the name variable
        name = Console.ReadLine()
        'Greets the user to the program
        Console.WriteLine($"Hello {name} welcome to this program. Have a wonderful day!")
        'Ends the sub main
    End Sub
    'Ends the module/program
End Module
