Module Program
    Function Greatest()
        Dim a(10), i, g As Integer

        Console.WriteLine("Enter 10 numbers: ")

        For i = 0 To 9
            a(i) = Int(Console.ReadLine())
        Next

        g = a(0)

        For i = 1 To 9
            If a(i) > g Then
                g = a(i)
            End If
        Next

        Return g

    End Function

    Sub Main()
        Console.WriteLine(Greatest() & " is the greatest number.")
        Console.ReadKey()
    End Sub

End Module