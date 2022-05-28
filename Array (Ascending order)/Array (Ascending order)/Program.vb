Module Program
    Sub Ascend()
        Dim a(10), i, j, temp As Integer

        Console.WriteLine("Enter 10 numbers: ")

        For i = 0 To 9
            a(i) = Int(Console.ReadLine())
        Next

        For i = 0 To 9
            For j = i + 1 To 9
                If a(j) < a(i) Then
                    temp = a(i)
                    a(i) = a(j)
                    a(j) = temp
                End If
            Next

        Next

        For i = 0 To 9
            Console.WriteLine(a(i))
        Next

    End Sub

    Sub Main()
        Ascend()
        Console.ReadKey()
    End Sub

End Module