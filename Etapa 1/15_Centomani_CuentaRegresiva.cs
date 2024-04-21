using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Centomani_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador;

            Console.WriteLine("Ingrese un número entero positivo:");
            numero = int.Parse(Console.ReadLine());
            contador = numero;

            while (contador > 0)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.ReadKey();
        }
    }
}
