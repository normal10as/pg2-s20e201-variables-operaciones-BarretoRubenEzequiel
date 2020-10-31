Imports System

Module Program
    Sub Main(args As String())
        Const a As Integer = 1
        Const b As Integer = 5
        Const c As Integer = 2
        Dim r As Integer

        r = ((b * b) - (4 * a * c)) / (2 * a)

        Console.WriteLine("Resultado de la x: " & r)
    End Sub
End Module
