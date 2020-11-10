using System;

namespace GradosFahrenheitCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong grados;
            const double Kelvin = 273.15;
            double R;

            Console.Write("Ingrese los grados en °C: ");
            grados = Convert.ToUInt16(Console.ReadLine());

            R = grados + Kelvin;

            Console.Write(grados);
            Console.Write("°C equivalen a ");
            Console.Write(R);
            Console.WriteLine("K");
        }
    }
}
