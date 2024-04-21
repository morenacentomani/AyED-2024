using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Centomani_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerouno, numerodos;

            Console.WriteLine("Ingrese un número:");
            numerouno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            numerodos = int.Parse(Console.ReadLine());
            
           
            if (numerodos == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("el resultado de su división es : " + (numerouno / numerodos));
            }


            Console.ReadKey();
        }
    }
}
