Imports System

Module Program
    Sub Main(args As String())
        Dim super, ancho, lado, longitud, obs, precio As ULong
        Dim final As ULong
        Console.Write("Ingrese el valor del metro cuadrado: $")
        precio = Console.ReadLine()

        Console.Write("Ingrese la dimensión del terreno (1=Cuadrado/2=rectángulo): ")
        obs = Console.ReadLine()
        If obs = 1 Then
            Console.Write("Ingrese el LADO del terreno: ")
            lado = Console.ReadLine()
            super = lado * lado
        Else
            Console.Write("Ingrese el ANCHO del terreno: ")
            ancho = Console.ReadLine()
            Console.Write("Ingrese la LONGITUD del terreno: ")
            longitud = Console.ReadLine()
            super = ancho * longitud
        End If
        final = precio * super

        Console.WriteLine("La superficie de su terreno es de " & super & " metros cuadrados")
        Console.WriteLine("El precio a pagar este terreno es de $" & final)

        Console.ReadKey()
    End Sub
End Module
