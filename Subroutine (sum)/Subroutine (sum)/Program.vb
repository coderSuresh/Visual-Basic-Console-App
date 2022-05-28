Module program
    Sub Sum(ByVal a As Integer, ByVal b As Integer)
        Console.WriteLine("The sum is " & a + b)
    End Sub

    Sub Main()
        Dim a, b As Integer

        Console.WriteLine("Enter two integers: ")
        a = Int(Console.ReadLine())
        b = Int(Console.ReadLine())

        Sum(a, b)

        Console.ReadKey()
    End Sub

End Module