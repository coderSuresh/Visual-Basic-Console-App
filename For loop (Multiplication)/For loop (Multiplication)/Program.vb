Module program
    Sub main()
        Dim n, r, i As Integer
        Console.WriteLine("Enter a number and range: ")
        n = Int(Console.ReadLine())
        r = Int(Console.ReadLine())

        For i = 1 To r
            Console.WriteLine(n & "*" & i & "=" & n * i)
        Next

        Console.ReadKey()
    End Sub
End Module