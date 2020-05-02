Imports System

Module Program
    Sub Main(args As String())
        Dim radio As Integer
        Dim area As Integer
        Dim Pi As Double = 3.14

        Console.Write("Ingrese el radio de un círculo: ")
        radio = Console.ReadLine()

        area = Pi * (radio * radio)

        Console.Write("El Area del Círculo es de : ")
        Console.Write(area)
        Console.WriteLine(" Unidad de Superficie.")

    End Sub
End Module
