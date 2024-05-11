using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Centomani_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántas vueltas dió el rayo?");
            int[] lasvueltas = new int[int.Parse(Console.ReadLine())];

            int tiempo = 0;

            for (int i = 0; i < lasvueltas.Count(); i++)
            {
                Console.Write("En la vuelta " + i + " hizo:");
                tiempo = int.Parse(Console.ReadLine());
                lasvueltas[i] = tiempo;

            }
            tiempo = 0;
            for (int j = 0; j < lasvueltas.Count(); j++)
            {
                tiempo = lasvueltas[j] + tiempo;
            }
            Console.WriteLine("El promedio del tiempo de las vueltas es: " + tiempo / lasvueltas.Count());

            tiempo = lasvueltas[0];
            for (int k = 1; k < lasvueltas.Count(); k++)
            {
                if (tiempo > lasvueltas[k])
                {
                    tiempo = lasvueltas[k];
                }
            }
            Console.WriteLine("El mejor tiempo es: " + tiempo);

            Console.ReadKey();
        }
    }
    }

