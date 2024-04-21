using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Centomani_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 1;

            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());

            while(cont < num)
            {  
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
                cont++;
            }

            Console.ReadKey();
        }
    }
}
