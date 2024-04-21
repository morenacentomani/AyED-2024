using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Centomani_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string si;
            bool aaa = true;

            while(aaa == true)
            {
                Console.WriteLine("¿Queres cerrar el programa?");
                si = Console.ReadLine();

                if (si == "SI")
                {
                    aaa = false;
                    Console.WriteLine("Chauuu");
                }
                
            }

            Console.ReadKey();
        }
    }
}
