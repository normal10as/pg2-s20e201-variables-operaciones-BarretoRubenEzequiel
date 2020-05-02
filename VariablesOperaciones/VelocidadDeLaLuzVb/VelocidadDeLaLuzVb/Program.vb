Imports System

Module Program
    Sub Main(args As String())
        Dim segundos, R As Integer
        Dim distancia As ULong = 300000

        Console.Write("Ingrese el valor del tiempo en segundos: ")
        segundos = Console.ReadLine()

        R = distancia * segundos
        Console.WriteLine("La distancia recorrida en " & segundos & " segundos es de: " & R & " kilómetros")
    End Sub
End Module
