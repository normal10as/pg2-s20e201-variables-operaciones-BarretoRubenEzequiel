Imports System

Module Program
    Sub Main(args As String())
        Dim descrip As String
        Dim costo, unidad As Integer
        Const factorC As Double = 3.5
        Const Costof As Integer = 10700

        Console.Write("Ingrese la el nombre del Art�culo a fabricar: ")
        descrip = Console.ReadLine()

        Console.Write("Ingrese el n�mero de Art�culos a fabricar: ")
        unidad = Console.ReadLine()

        costo = (unidad * factorC) + Costof



        Console.WriteLine("El art�culo Ingresado es " & descrip & " y se fabricar�n " & unidad & " unidades")
        Console.WriteLine("El costo ser� de: $" & costo)
    End Sub
End Module
