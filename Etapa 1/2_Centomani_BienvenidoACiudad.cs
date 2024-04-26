using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Centomani_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, ciudad;

            Console.WriteLine("¿Cómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Qué ciudad?");
            ciudad = Console.ReadLine();

            Console.WriteLine("¡Hola " + nombre + " bienvenido a " + ciudad + " !");

            Console.ReadKey();
        }
    }
}
