Module Module1

    Sub Main()

        'Dim numbers As Integer() = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
        Dim numbers As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 19, 10}

        Dim i, j, t As Integer
        i = 0
        j = 0
        t = 0

        Dim sorted As Boolean
        sorted = True


        For i = 0 To 8


            sorted = True

            For j = 0 To 8 - i
                If (numbers(j) > numbers(j + 1)) Then
                    t = numbers(j + 1)
                    numbers(j + 1) = numbers(j)
                    numbers(j) = t

                    sorted = False
                End If
            Next

            If sorted = True Then 'that means the array is already sorted
                Exit For
            End If

        Next


        Console.WriteLine(i)

        For i = 0 To 9
            Console.Write(numbers(i) & " ")
        Next

    End Sub

End Module
