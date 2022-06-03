Module Program
    Function Fact(ByVal n As Integer) As Integer
        If n < 2 Then
            Return 1
        Else
            Return n * Fact(n - 1)
        End If
    End Function
    Sub Main()
        Dim n, factorial As Integer

        Console.WriteLine("Enter an Integer: ")
        n = Int(Console.ReadLine())

        factorial = Fact(n)

        Console.WriteLine("The factorial of " & n & " is " & factorial)
        Console.ReadKey()

    End Sub
End Module