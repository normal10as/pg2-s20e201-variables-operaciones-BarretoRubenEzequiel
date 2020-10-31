using System;

namespace CuadraticaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte a = 1;
            const byte b = 5;
            const byte c = 2;
            double x;


            x = Convert.ToDouble((b * b) - (4 * a * c)) / (2 * a);

            Console.WriteLine("Resultado de la x: " + x);
        }
    }
}
