Imports System

Module Program
    Sub Main(args As String())
        Const Pie, metros, Totalpul, yardas As Integer
        Const pulgadas As Integer = 12
        Const yarda As Integer = 3
        Const UNApulgada As Double = 2.54
        Const UNmetro As Integer = 100
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
