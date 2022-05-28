Module Program
    Function Sum(ByVal a As Integer, ByVal b As Integer)
        Return a + b
    End Function
    Sub Main()
        Dim x, y As Integer

        Console.WriteLine("Enter two numbers: ")
        x = Int(Console.ReadLine())
        y = Int(Console.ReadLine())

        Console.WriteLine("The sum is " & Sum(x, y))

        Console.ReadKey()
    End Sub
End Module