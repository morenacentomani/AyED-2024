using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Centomani_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, num = 0;


            Console.Write("Filas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = num;
                    num++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i,j] + "\t");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
