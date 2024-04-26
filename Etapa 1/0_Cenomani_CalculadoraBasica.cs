using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Centomani_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numuno, numdos;

            Console.WriteLine("Ingrese un número:");
            numuno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            numdos = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma : " + (numuno + numdos));
            Console.WriteLine("La resta : " + (numuno - numdos));
            Console.WriteLine("La multi : " + (numuno * numdos));
            Console.WriteLine("La división : " + (numuno / numdos));
            Console.WriteLine("Y el resto es : " + (numuno % numdos));

            Console.ReadKey();
        }
    }
}
