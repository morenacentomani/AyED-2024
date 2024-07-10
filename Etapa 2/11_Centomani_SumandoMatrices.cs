using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Centomani_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Definí el rango de filas y columnas de tu matriz (solo un número): ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[n, n];
            int[,] matriz2 = new int[n, n];
            int[,] matriz3 = new int[n, n];

            Random rango = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz1[i, j] = rango.Next(1, 10);
                    matriz2[i, j] = rango.Next(1, 10);
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz 1");
            Console.WriteLine("-------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");

            Console.WriteLine("Matriz 2");
            Console.WriteLine("-------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");

            Console.WriteLine("Matrices sumadas");
            Console.WriteLine("-------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
