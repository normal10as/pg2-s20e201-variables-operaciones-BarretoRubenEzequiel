Imports System

Module Program
    Sub Main(args As String())
        Dim dolar As Integer
        Dim pesos As Integer
        Dim vDolar As Integer

        Console.Write("Ingrese la cantidad de Dolares a comprar: $")
        dolar = Console.ReadLine()

        Console.Write("Ingrese el tipo de cambio en Pesos: $")
        vDolar = Console.ReadLine()

        pesos = dolar * vDolar

        Console.Write("Usted deberá pagar un total de $")
        Console.Write(pesos)
        Console.Write(" Pesos por la cantidad de $")
        Console.Write(dolar)
        Console.WriteLine(" Dolares ingresados.")
    End Sub
End Module
