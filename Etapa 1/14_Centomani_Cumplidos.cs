using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Centomani_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, cumplidos, contador;
            cumplidos = 0;
            contador = 0;

            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            while (contador < edad)
            {
                cumplidos++;
                Console.WriteLine("Cumpliste : " + cumplidos);
                contador++;
            }

            Console.ReadKey();
        }
    }
}
