using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Centomani_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de jugadores: ");
            int[] losjugadores = new int[int.Parse(Console.ReadLine())];

            int puntaje = 0, puntaje1;

            for (int i = 0; i < losjugadores.Count(); i++)
            {
                Console.Write("El punteje del jugador " + i + " es: ");
                puntaje = (int.Parse(Console.ReadLine()));

                losjugadores[i] = puntaje;
            }
            puntaje = losjugadores[0];
            puntaje1 = losjugadores[0];
            for (int j = 0; j < losjugadores.Count(); j++)
            {
                
                if (puntaje < losjugadores[j])
                {
                    puntaje = losjugadores[j];
                }
                if (puntaje1 > losjugadores[j])
                {
                    puntaje1 = losjugadores[j];
                }
                
            }
            Console.WriteLine("El puntaje más alto es el: " + puntaje);
            Console.WriteLine("El puntaje más bajo es el: " + puntaje1);

            Console.ReadKey();
        }
    }
}
