Imports System

Module Program
    Sub Main(args As String())
        Dim grados As Integer
        Const Kelvin As Double = 273.15
        Dim R As Double

        Console.Write("Ingrese los grados en °C: ")
        grados = Console.ReadLine()

        R = grados + Kelvin

        Console.Write(grados)
        Console.Write("°C equivalen a ")
        Console.Write(R)
        Console.WriteLine("K")
    End Sub
End Module
