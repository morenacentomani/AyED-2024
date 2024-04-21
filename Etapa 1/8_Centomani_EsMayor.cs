using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Centomani_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Su edad es menor que 18.");
            }
            else if (edad == 18){
                Console.WriteLine("Su edad es 18.");
            }
            else
            {
                Console.WriteLine("Su edad es mayor que 18.");
            }

            Console.ReadKey();
        }
    }
}
