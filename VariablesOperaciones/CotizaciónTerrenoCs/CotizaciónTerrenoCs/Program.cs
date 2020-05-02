using System;

namespace CotizaciónTerrenoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong super, ancho, lado, longitud, obs, precio, final;

            Console.Write("Ingrese el valor del metro cuadrado: $");
            precio = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Ingrese la dimensión del terreno (1=Cuadrado/2=rectángulo): ");
            obs = Convert.ToUInt32(Console.ReadLine());
            if (obs == 1)
            {
                Console.Write("Ingrese el LADO del terreno: ");
                lado = Convert.ToUInt32(Console.ReadLine());
                super = (lado) * (lado);
            }
            else
            {
                Console.Write("Ingrese el ANCHO del terreno: ");
                ancho = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Ingrese la LONGITUD del terreno: ");
                longitud = Convert.ToUInt32(Console.ReadLine());
                super = ancho * longitud;

            }

            final = precio * super;

            Console.WriteLine("La superficie de su terreno es de " + super + " metros cuadrados");
            Console.WriteLine("El precio a pagar este terreno es de $" + final);

            Console.ReadKey();
        }
    }
}
