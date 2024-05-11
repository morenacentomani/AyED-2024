using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Centomani_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos invitados van a venir?");
            int[] losinvitados = new int[int.Parse(Console.ReadLine())];

            int comida = 0;
            
            for (int i = 0; i < losinvitados.Count(); i++)
            {
                Console.Write("El invitado " + i + " come: ");
                comida = int.Parse(Console.ReadLine());

                while (comida > 100 || comida < 1)
                {
                    Console.WriteLine("error");
                    Console.Write("El invitado " + i + " come: ");
                    comida = int.Parse(Console.ReadLine());
                }

                if (comida <= 100 && comida >= 1)
                {

                    losinvitados[i] = comida;

                }

            }
            comida = 0;
            for (int j = 0; j < losinvitados.Count(); j++)
            {
                comida = losinvitados[j] + comida;

            }
            Console.WriteLine("Este es el promedio: " + (comida / losinvitados.Count()));

            Console.ReadKey();
        }
    }
}
