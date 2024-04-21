using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Centomani_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;
            string cont2;
            Console.WriteLine("Contraseña porfavor");
            cont = Console.ReadLine();
            Console.WriteLine("corfima la contraseña");
            cont2 = Console.ReadLine();

            if (cont == cont2)
            {
                Console.WriteLine("las contraseña son iguales");
            }
            else
            {
                Console.WriteLine("contraseña incorrecta");
            }
            Console.ReadKey();


        }
    }
}
