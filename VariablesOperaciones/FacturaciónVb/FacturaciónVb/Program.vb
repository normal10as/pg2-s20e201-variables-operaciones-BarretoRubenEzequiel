Imports System

Module Program
    Sub Main(args As String())
        Dim articulo As String
        Dim costo, impuesto, total As Double
        Dim utilidad As Integer = 150
        Dim iva As Integer = 21

        Console.Write("Ingrese el nombre del artículo: ")
        articulo = Console.ReadLine()
        Console.Write("Ingrese el costo del artículo: ")
        costo = Console.ReadLine()

        utilidad = (costo * 150) / 100
        impuesto = (costo * 21) / 100
        total = costo + utilidad + impuesto

        Console.WriteLine("El valor de utilidad de " & articulo & " es de: $" & utilidad)
        Console.WriteLine("El valor de impueto  de " & articulo & " es de: $" & impuesto)
        Console.WriteLine("El valor de venta  de " & articulo & " es de: $" & total)
        Console.Read()
    End Sub
End Module
