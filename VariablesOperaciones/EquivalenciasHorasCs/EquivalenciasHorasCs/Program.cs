using System;

namespace EquivalenciasHorasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double segundos, minutos, horas, dias;

            const ushort Valorsegundos = 3600;
            const byte ValorMinutos = 60;
            const byte ValorDias = 24;

            Console.Write("Ingrese la cantidad de horas a calcular: ");
            horas = Convert.ToUInt32(Console.ReadLine());
            minutos = horas * ValorMinutos;
            segundos = horas * Valorsegundos;
            dias = horas / ValorDias;
            Console.Write("Cantidad de minutos: ");
            Console.WriteLine(minutos);

            Console.Write("Cantidad de segundos: ");
            Console.WriteLine(segundos);

            Console.Write("Cantidad de dias: ");
            Console.WriteLine(dias);
        }
    }
}
