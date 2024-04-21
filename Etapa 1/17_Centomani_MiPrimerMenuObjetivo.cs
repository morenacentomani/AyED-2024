using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Centomani_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opciones, numuno, numdos, edad, ingresos, num;
            bool opc = true;

            Console.WriteLine("¡BIENVENIDO USUARIO!");
            Console.WriteLine("");
            Console.WriteLine("1. CALCULADORA");
            Console.WriteLine("2. BECA");
            Console.WriteLine("3. TABLA DE MULTIPLICAR");
            Console.WriteLine("4. BYE BYE");

            while(opc == true)
            {
                opciones = int.Parse(Console.ReadLine());
                if (opciones == 1)
                {
                    Console.Clear();

                    Console.WriteLine("¡BIENVENIDO USUARIO!");
                    Console.WriteLine("");
                    Console.WriteLine("1. CALCULADORA");
                    Console.WriteLine("2. BECA");
                    Console.WriteLine("3. TABLA DE MULTIPLICAR");
                    Console.WriteLine("4. BYE BYE");

                    Console.WriteLine("Ingrese un número:");
                    numuno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro número:");
                    numdos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Suma : " + (numuno + numdos));
                    Console.WriteLine("Resta : " + (numuno - numdos));
                    Console.WriteLine("Multi : " + (numuno * numdos));
                    Console.WriteLine("División : " + (numuno / numdos));
                    Console.WriteLine("Resto de la división : " + (numuno % numdos));
                }
//--------------------------------------------------------------------------------------------------------------------
                if (opciones == 2)
                {
                    Console.Clear();

                    Console.WriteLine("¡BIENVENIDO USUARIO!");
                    Console.WriteLine("");
                    Console.WriteLine("1. CALCULADORA");
                    Console.WriteLine("2. BECA");
                    Console.WriteLine("3. TABLA DE MULTIPLICAR");
                    Console.WriteLine("4. BYE BYE");

                    Console.WriteLine("Ingrese su edad:");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora sus ingresos:");
                    ingresos = int.Parse(Console.ReadLine());

                    if (edad >= 19 && ingresos >= 100000)
                    {
                        Console.WriteLine("Cumple con los requisitos.");
                    }
                    else
                    {
                        Console.WriteLine("No cumple con los requisitos.");
                    }
                    
                }
//--------------------------------------------------------------------------------------------------------------------
                if (opciones == 3)
                    {
                    Console.Clear();

                    Console.WriteLine("¡BIENVENIDO USUARIO!");
                    Console.WriteLine("");
                    Console.WriteLine("1. CALCULADORA");
                    Console.WriteLine("2. BECA");
                    Console.WriteLine("3. TABLA DE MULTIPLICAR");
                    Console.WriteLine("4. BYE BYE");

                    Console.WriteLine("Ingrese un número:");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine(num + "x1" + "=" + (num * 1));
                        Console.WriteLine(num + "x2" + "=" + (num * 2));
                        Console.WriteLine(num + "x3" + "=" + (num * 3));
                        Console.WriteLine(num + "x4" + "=" + (num * 4));
                        Console.WriteLine(num + "x5" + "=" + (num * 5));
                        Console.WriteLine(num + "x6" + "=" + (num * 6));
                        Console.WriteLine(num + "x7" + "=" + (num * 7));
                        Console.WriteLine(num + "x8" + "=" + (num * 8));
                        Console.WriteLine(num + "x9" + "=" + (num * 9));
                        Console.WriteLine(num + "x10" + "=" + (num * 10));
                    }
//--------------------------------------------------------------------------------------------------------------------
               if (opciones == 4)
                {
                    Console.Clear();

                    Console.WriteLine("¡BIENVENIDO USUARIO!");
                    Console.WriteLine("");
                    Console.WriteLine("1. CALCULADORA");
                    Console.WriteLine("2. BECA");
                    Console.WriteLine("3. TABLA DE MULTIPLICAR");
                    Console.WriteLine("4. BYE BYE");

                    opc = false;
                    Console.WriteLine("Bye Bye");
                }
            }

            Console.ReadKey();
        }
    }
}
