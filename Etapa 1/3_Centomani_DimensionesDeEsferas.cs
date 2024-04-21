using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_centomani_Dimensionesdeesfera
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
           
            Console.WriteLine("Inicie el radio de su esfera:");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("Su superficie es : " + (4 *3.14 * radio* radio));
            Console.WriteLine("Su volumen es : " + ((4 * 3.14)/3 * radio* radio * radio));

            Console.ReadKey();

        }
    }
}
