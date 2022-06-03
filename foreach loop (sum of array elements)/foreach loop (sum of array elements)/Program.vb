Module Program
    Sub Sum(ByVal arr() As Integer)
        Dim sum As Integer = 0
        Dim i As Integer
        For Each i In arr
            sum += arr(i)
        Next
        Console.WriteLine("The sum is: {0}", sum)
    End Sub

    Sub Main()
        Dim array(5) As Integer
        Dim i As Integer

        Console.WriteLine("Enter elements of array: ")

        For i = 0 To 4
            array(i) = Int(Console.ReadLine())
        Next

        Sum(array)
        Console.ReadKey()
    End Sub
End Module