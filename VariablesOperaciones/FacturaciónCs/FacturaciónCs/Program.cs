using System;

namespace FacturaciónCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string articulo;
            double impuesto, utilidad, total, costo;
            byte iva = 21;

            Console.Write("Ingrese el nombre del artículo: ");
            articulo = Console.ReadLine();
            Console.Write("Ingrese el costo del artículo: ");
            costo = Convert.ToUInt16(Console.ReadLine());

            utilidad = (costo * 150) / 100;
            impuesto = (costo * iva) / 100;
            total = costo + utilidad + impuesto;

            Console.WriteLine("El valor de utilidad de " + articulo + " es de: $" + utilidad);
            Console.WriteLine("El valor de impueto  de " + articulo + " es de: $" + impuesto);
            Console.WriteLine("El valor de venta  de " + articulo + " es de: $" + total);
            Console.Read();
        }
    }
}
