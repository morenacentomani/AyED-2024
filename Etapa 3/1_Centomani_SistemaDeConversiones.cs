using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Centomani_SistemaDeConversiones
{
    class Program
    {
        static string deciabina(int deci)
        {
            string binario = "";

            while (deci > 0)
            {
                binario = (deci % 2) + binario;
                deci = deci / 2;
            }
            return binario;
        }

        static double binaadeci(string bina)
        {
            double numdeci = 0, basenum = 2, car = bina.Length, resul;

            for (int i = 0; i < bina.Length; i++)
            {
                char detec = bina[i];

                if (detec == '1')
                {
                    resul = Math.Pow(basenum, car - 1);
                    numdeci = numdeci + resul;
                }
                car -= 1;
            }
            return numdeci;

        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el número decimal que quiera pasar a binario: ");
            Console.WriteLine("En binario es: " + deciabina(int.Parse(Console.ReadLine())));
            Console.Write("Ingrese el número binario que quiera pasar a decimal: ");
            Console.WriteLine("En decimal es: " + binaadeci(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}