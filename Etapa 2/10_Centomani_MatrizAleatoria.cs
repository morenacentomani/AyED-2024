using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Centomani_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.Write("Filas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            Random rango = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rango.Next(1, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
