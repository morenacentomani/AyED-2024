using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Centomani_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la cantidad de elementos: ");
            int[] loselementos = new int[int.Parse(Console.ReadLine())];

            int valorminimo = 0, objeto;

            Console.Write("Ingrese el valor mínimo: ");
            valorminimo = int.Parse(Console.ReadLine());

            for(int i = 0;i < loselementos.Count(); i++)
            {
                Console.Write("Ingrese el elemento " + i + ": ");
                objeto = int.Parse(Console.ReadLine());
                loselementos[i] = objeto;
            }
            
            for (int j = 0; j < loselementos.Count(); j++)
            {
                objeto = loselementos[j];
                if (loselementos[j] > valorminimo)
                {
                    Console.WriteLine(objeto);
                }
            }
            
            Console.ReadKey();
        }
    }
}
