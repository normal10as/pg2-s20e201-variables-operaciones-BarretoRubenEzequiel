using System;

namespace EquivalenciasHorasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double segundos, minutos, horas, dias;

            ushort Valorsegundos = 3600;
            byte ValorMinutos = 60;
            byte ValorDias = 24;

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
