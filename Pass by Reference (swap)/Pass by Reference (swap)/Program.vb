Module Program
    Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer

        Console.WriteLine("Before swap:" & vbCrLf & "a = " & a & vbCrLf & "b = " & b)
        'vbCrLf for new line (similar to \n in C)
        temp = a
        a = b
        b = temp

        Console.WriteLine("After swap:" & vbCrLf & "a = " & a & vbCrLf & "b = " & b)

    End Sub
    Public Sub Main()
        Dim a, b As Integer

        Console.WriteLine("Enter value of a and b: ")
        a = Int(Console.ReadLine())
        b = Int(Console.ReadLine())

        Swap(a, b)
        Console.ReadKey()

    End Sub
End Module