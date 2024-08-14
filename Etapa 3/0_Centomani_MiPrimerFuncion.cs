using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Centomani_MiPrimerFuncion
{
    class Program
    {
        static string saludar(string nom)
        {
            string saludo = ("Hola " + nom);
            return saludo;
        }
        static void Main(string[] args)
        {
            Console.Write(saludar("More"));

            Console.ReadKey();
        }
    }
}
