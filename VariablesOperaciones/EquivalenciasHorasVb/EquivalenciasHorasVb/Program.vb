Imports System

Module Program
    Sub Main(args As String())
        Dim horas As Integer
        Dim minutos As Integer
        Dim segundos As Integer
        Dim dias As Single
        Dim Valorsegundos As Integer
        Dim ValorMinutos As Integer
        Dim ValorDias As Integer
        Valorsegundos = 3600
        ValorMinutos = 60
        ValorDias = 24

        Console.Write("Ingrese la cantidad de horas a calcular: ")
        horas = Console.ReadLine()
        minutos = horas * ValorMinutos
        segundos = horas * Valorsegundos
        dias = horas / ValorDias
        Console.Write("Cantidad de minutos: ")
        Console.WriteLine(minutos)

        Console.Write("Cantidad de segundos: ")
        Console.WriteLine(segundos)

        Console.Write("Cantidad de dias: ")
        Console.WriteLine(dias)
    End Sub
End Module
