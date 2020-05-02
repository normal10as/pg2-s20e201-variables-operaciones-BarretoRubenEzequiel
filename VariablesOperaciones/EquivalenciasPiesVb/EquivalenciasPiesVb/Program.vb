Imports System

Module Program
    Sub Main(args As String())
        Dim Pie, metros, Totalpul, yardas As Integer
        Dim pulgadas As Integer = 12
        Dim yarda As Integer = 3
        Dim UNApulgada As Double = 2.54
        Dim UNmetro As Integer = 100
        Dim centimetros As Double
        Console.Write("Ingrese una distancia medida en pies: ")
        Pie = Console.ReadLine()

        Totalpul = Pie * pulgadas
        yardas = Pie * yarda
        centimetros = Totalpul * UNApulgada
        metros = centimetros * UNmetro

        Console.WriteLine("Equivalente en pulgadas: " & Totalpul)
        Console.WriteLine("Equivalente en yardas: " & yardas)
        Console.WriteLine("Equivalente en centímetros: " & centimetros)
        Console.WriteLine("Equivalente en metros: " & metros)

        Console.ReadKey()
    End Sub
End Module
