using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Centomani_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            int[] losproductos = new int[int.Parse(Console.ReadLine())];

            int precio = 0, precio1;

            for (int i = 0; i < losproductos.Count(); i++)
            {
                Console.Write("Ingrese el precio del producto " + i + ": ");
                precio = int.Parse(Console.ReadLine());
                losproductos[i] = precio;
            }
            precio = losproductos[0];
            precio1 = losproductos[0];
            for (int j = 1; j < losproductos.Count(); j++)
            {
                if(precio < losproductos[j])
                {
                    precio = losproductos[j];
                }
                if (precio1 > losproductos[j])
                {
                    precio1 = losproductos[j];
                }
            }
            Console.WriteLine("El precio más alto fue: " + precio);
            Console.WriteLine("El precio más bajo fue: " + precio1);

            Console.ReadKey();
        }
    }
}
