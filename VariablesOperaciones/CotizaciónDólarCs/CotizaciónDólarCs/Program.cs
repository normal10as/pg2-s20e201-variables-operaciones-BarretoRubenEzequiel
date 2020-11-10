using System;

namespace CotizaciónDólarCs
{
    class Program
    {
        static void Main(string[] args)
        {
            uint dolar;
            double pesos;
            byte vDolar;

            Console.Write("Ingrese la cantidad de Dolares a comprar: $");
            dolar = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Ingrese el tipo de cambio en Pesos: $");
            vDolar = Convert.ToByte(Console.ReadLine());

            pesos = dolar * vDolar;

            Console.WriteLine("Usted deberá pagar un total de $" + pesos + " Pesos por la cantidad de $" + dolar + " Dolares ingresados.");
        }
    }
}
