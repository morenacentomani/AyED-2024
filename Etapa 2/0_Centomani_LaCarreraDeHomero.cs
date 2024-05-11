using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Centomani_LaCarreraDeHomero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de obstáculos que Homero Simpson debe superar : ");
            int[] losobstaculos = new int[int.Parse(Console.ReadLine())];

            string obssup;
            int puntos = 0; 

            for (int i = 0; i < losobstaculos.Count(); i++)
            {

                Console.Write("Obstáculo " + i + " ¿Lo supera?");

                obssup = Console.ReadLine();


                if (obssup == "si")
                {

                    losobstaculos[i] = 10;

                }
                else if (obssup == "no")
                {
                    
                    losobstaculos[i] = -5;
                }

            }
            for (int j = 0; j < losobstaculos.Count(); j++)
            {

                puntos = losobstaculos[j] + puntos;
                Console.WriteLine(puntos);

            }
            Console.ReadKey();
        }
    }
}
