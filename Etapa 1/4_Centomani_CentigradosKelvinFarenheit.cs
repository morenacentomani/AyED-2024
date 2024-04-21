using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Centomani_CentigradosKelvinFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradoscelsius;

            Console.WriteLine("Ingrese los grados celsius:");
            gradoscelsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin : " + (gradoscelsius + 273));
            Console.WriteLine("Farenheit : " + ((gradoscelsius * 18)/10 + 32));

            Console.ReadKey();
        }
    }
}
