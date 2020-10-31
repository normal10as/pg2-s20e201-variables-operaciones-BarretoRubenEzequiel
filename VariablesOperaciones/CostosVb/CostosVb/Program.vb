Imports System

Module Program
    Sub Main(args As String())
        Dim descrip As String
        Dim costo, unidad As Integer
        Const factorC As Double = 3.5
        Const Costof As Integer = 10700

        Console.Write("Ingrese la el nombre del ArtÍculo a fabricar: ")
        descrip = Console.ReadLine()

        Console.Write("Ingrese el número de Artículos a fabricar: ")
        unidad = Console.ReadLine()

        costo = (unidad * factorC) + Costof



        Console.WriteLine("El artículo Ingresado es " & descrip & " y se fabricarán " & unidad & " unidades")
        Console.WriteLine("El costo será de: $" & costo)
    End Sub
End Module
