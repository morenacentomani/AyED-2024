using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Centomani_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            string letrauno , letrados , letratres;

            Console.WriteLine("Ingrese la primer letra:");
            letrauno = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda letra:");
            letrados = Console.ReadLine();
            Console.WriteLine("Ingrese la tercer letra:");
            letratres = Console.ReadLine();

            Console.WriteLine("El orden al reves es : " + letratres + letrados + letrauno);

            Console.ReadKey();
        }
    }
}
