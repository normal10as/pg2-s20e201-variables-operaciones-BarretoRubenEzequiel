Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2
        Dim r As Integer

        r = ((b * b) - (4 * a * c)) / (2 * a)

        Console.WriteLine("Resultado de la x: " & r)
    End Sub
End Module
