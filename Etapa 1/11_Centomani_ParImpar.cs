using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Centomani_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;

            Console.WriteLine("Escriba un número entero:");
            entero = int.Parse(Console.ReadLine());

            if (entero % 2 == 0)
            {
                Console.WriteLine("su número es par.");
            }
            else
            {
                Console.WriteLine("su número es impar.");
            }

            Console.ReadKey();
        }
    }
}
