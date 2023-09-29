using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_ejercicio1_PrograII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer un algoritmo de una tienda que vende camisas, si la persona se lleva una camisa se lo lleva a precio de costo, 

            //si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15 %

            //si la persona se lleva más de 5 el descuento es de 20 %

            //El sistema debe solicitar la cantidad de camisas y el precio de las camisas
            float por1 = 0.15f;
            float por2 = 0.2f;
            float descuento = 0;
            float acum = 0;
            float TotalSinDescuento = 0;
            float TotalConDescuento = 0;

            Console.WriteLine("Cuantas prendas desea ingresar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++) 
            {
                Console.WriteLine("Ingrese el precio de la camisa");
                float precio = float.Parse(Console.ReadLine());
                acum = acum + precio;
            }
            if (cant == 1)
            {
                descuento = 0;
            }
            else if (cant <= 5)
            {
                descuento = acum * por1;
            }
            else
            {
                descuento = acum * por2;
            }
            TotalSinDescuento = acum;
            TotalConDescuento = acum - descuento;
            Console.WriteLine($"Cantidad de camisas registradas: {cant}");
            Console.WriteLine($"Total sin descuento: {TotalSinDescuento}");
            Console.WriteLine($"Total con descuento: {TotalConDescuento}");




            Console.ReadLine();
        }
    }
}
