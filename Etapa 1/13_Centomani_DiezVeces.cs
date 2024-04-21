using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_centomani_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador = 0;

            Console.WriteLine("Escriba una palabra:");
            palabra = Console.ReadLine();

            while (contador < 10)
            {
                Console.WriteLine(palabra);
                contador++;
            }

            Console.ReadKey();
        }
    }
}
