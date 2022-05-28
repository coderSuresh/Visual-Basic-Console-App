Module program
    Sub main()
        'main subroutine (similar to 'void main()' in C)
        'subroutine is similar to a function except it doesn't return anything
        Dim a, b, c As Integer
        Console.WriteLine("Enter any three numbers: ")
        a = Int(Console.ReadLine())
        b = Int(Console.ReadLine())
        c = Int(Console.ReadLine())

        If a > b And a > c Then
            Console.WriteLine("Greatest number = " & a)
            'here & is used to concatinate String with integer
            '+ operator can also be used to concatinate but only when both are string
        ElseIf b > c And b > a Then
            Console.WriteLine("Greatest number = " & b)
        Else
            Console.WriteLine("Greatest number = " & c)
        End If

        Console.ReadKey() 'used to hold the output (similar to 'getch()' in C)

    End Sub
End Module