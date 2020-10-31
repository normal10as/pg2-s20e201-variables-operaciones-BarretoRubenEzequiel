using System;

namespace CostosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string descrip;
            uint unidad;
            const double factorC = 3.5;
            const uint Costof = 10700;
            double costo;
            Console.Write("Ingrese la el nombre del ArtÍculo a fabricar: ");
            descrip = Console.ReadLine();

            Console.Write("Ingrese el número de Artículos a fabricar: ");
            unidad = Convert.ToUInt16(Console.ReadLine());

            costo = (unidad * factorC) + Costof;



            Console.WriteLine("El artículo Ingresado es " + descrip + " y se fabricarán " + unidad + " unidades");
            Console.WriteLine("El costo será de: $" + costo);
        }
    }
}
