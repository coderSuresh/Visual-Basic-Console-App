Module Program
    Function Mul(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a * b
    End Function

    Sub Main()
        Dim a, b, ans As Integer
        Console.WriteLine("Enter two integers: ")
        a = Int(Console.ReadLine())
        b = Int(Console.ReadLine())

        ans = Mul(a, b)

        Console.WriteLine("The answer is: " & ans)
        Console.ReadKey()

    End Sub
End Module