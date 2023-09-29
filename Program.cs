using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Tarea2_PrograII
{
    internal class Program
    {
        static void Main(string[] args)
        {// Un vendedor ofrece su producto de la siguiente manera: Si le compran 10 productos o menos,
         // el precio por producto es de $20. Si le compran más de 10 artículos, el precio es de $15 por artículo.
         // Realice un algoritmo y diagrama de flujo que con solo proporcionarle la cantidad de
         // artículos dé como resultado el precio y el total.
            Console.WriteLine("Bienvemido al sistema");
            Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
            byte cant = byte.Parse(Console.ReadLine());
            int precio = 0;
            if (cant <= 10)
            {
                sbyte art1 = 20;
                precio = cant * art1;
                Console.WriteLine($"Precio por artículo: {art1}");
            }
            else
            {
                sbyte art2 = 15;
                precio = cant*art2;
                Console.WriteLine($"Precio por artículo: {art2}");
            }
            Console.WriteLine($"Total a pagar: {precio}");
            Console.ReadLine();

        }
    }
}
