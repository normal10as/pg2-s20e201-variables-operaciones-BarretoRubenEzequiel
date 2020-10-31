using System;

namespace EquivalenciasPiesCs
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong Pie, Totalpul, yardas;
            const yte pulgadas = 12;
            const byte yarda = 3;
            const double UNApulgada = 2.54;
            const byte UNmetro = 100;
            double centimetros, metros;
            Console.Write("Ingrese una distancia medida en pies: ");
            Pie = Convert.ToUInt16(Console.ReadLine());

            Totalpul = Pie * pulgadas;
            yardas = Pie * yarda;
            centimetros = Totalpul * UNApulgada;
            metros = centimetros * UNmetro;

            Console.WriteLine("Equivalente en pulgadas: " + Totalpul);
            Console.WriteLine("Equivalente en yardas: " + yardas);
            Console.WriteLine("Equivalente en centímetros: " + centimetros);
            Console.WriteLine("Equivalente en metros: " + metros);

            Console.ReadKey();

        }
    }
}
