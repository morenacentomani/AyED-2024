using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Centomani_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;

            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora sus ingresos:");
            ingresos = int.Parse(Console.ReadLine());

            if (edad >= 19 && ingresos >= 100000)
            {
                Console.WriteLine("Cumple con los requisitos.");
            }
            else
            {
                Console.WriteLine("No cumple con los requisitos.");
            }

            

            Console.ReadKey();
        }
    }
}
