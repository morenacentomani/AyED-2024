using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Centomani_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho_base;
            int altura;

            Console.WriteLine("Ingrese la base de su rectángulo:");
            ancho_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura de su rectángulo:");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Su perímetro es : " + ((ancho_base*2) + (altura*2)));
            Console.WriteLine("Su área es : " + (ancho_base * altura));
            Console.WriteLine("Su diagonal es : " + (Math.Sqrt((ancho_base * ancho_base)+(altura * altura))));

            Console.ReadKey();
         }
    }
}
