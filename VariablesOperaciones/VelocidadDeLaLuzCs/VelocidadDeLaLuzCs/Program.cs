using System;

namespace VelocidadDeLaLuzCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong segundos, R;
            ulong distancia = 300000;

            Console.Write("Ingrese el valor del tiempo en segundos: ");
            segundos = Convert.ToUInt64(Console.ReadLine());

            R = distancia * segundos;
            Console.WriteLine("La distancia recorrida en " + segundos + " segundos es de: " + R + " kilómetros");
        }
    }
}
