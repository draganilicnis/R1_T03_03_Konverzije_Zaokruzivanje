Module VBModule
    Sub Main()
        Console.WriteLine(0.1 + 0.2)            ' 0.3 
        Console.WriteLine(0.3 / 0.1)            ' 3
        Console.WriteLine(0.1 + 0.2 - 0.3)      ' 5.55111512312578E-17
        Console.WriteLine(3 - 0.3 / 0.1)        ' 4.44089209850063E-16
        Console.WriteLine(9007199254740993.0)   ' 9.00719925474099E+15
        Console.WriteLine(007199254740993.0 - 9007199254740992.0)   ' -9E+15
        Console.WriteLine(0.1 / 10 + 0.2 / 10 - 0.3 / 10)           ' 0
    End Sub
End Module
