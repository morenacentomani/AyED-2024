using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Centomani_VectorRandomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad de espacios para el vector: ");
            int[] losnumeros = new int[int.Parse(Console.ReadLine())];

            Random rango = new Random();

            for (int i = 0; i < losnumeros.Count(); i++)
            {
                losnumeros[i] = rango.Next(1, 50);
            }

            Console.WriteLine("--------Menú--------");
            Console.WriteLine(" ");
            Console.WriteLine("1) Ver los números del Array.");
            Console.WriteLine("2) Encontrar un número en el Array.");
            Console.WriteLine("3) Ordenar el Array.");
            Console.WriteLine("4) Chau.");
            string forma;
            bool fin = true;
            int opcion, numero;
            

            while(fin == true)
            {
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
            {
                case 1:
                    Console.WriteLine("Números que contiene tu vector: ");
                    for (int j = 0; j < losnumeros.Count(); j++)
                    {
                        Console.WriteLine(j + ") " + losnumeros[j]);
                    }
                    break;
                case 2:
                    Console.Write("¿Qué número desea buscar? ");
                    numero = int.Parse(Console.ReadLine());
                    for (int j = 0; j < losnumeros.Count(); j++)
                    {
                        if (numero == losnumeros[j])
                        {
                            Console.WriteLine("El número se encuentra en la posición: " + j);
                        }
                        else
                        {
                            Console.WriteLine("Su número no se encuentra en el vector.");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("¿Cómo desea ordenar el vector? ");
                    Console.WriteLine("a. Forma ascendente ");
                    Console.WriteLine("b. Forma descendente ");
                    forma = Console.ReadLine();
                    int varaux = 0;
                    if (forma == "a")
                    {
                        for (int j = 0; j < losnumeros.Count(); j++)
                        {
                            for (int k = 0; k < losnumeros.Count(); k++)
                            {
                                if (losnumeros[k] > losnumeros[j])
                                {
                                    varaux = losnumeros[k];
                                    losnumeros[k] = losnumeros[j];
                                    losnumeros[j] = varaux;
                                }
                            }
                        }
                        Console.WriteLine("Forma ascendente:");
                        for (int i = 0; i < losnumeros.Count(); i++)
                        {
                            Console.WriteLine(i + ") " + losnumeros[i]);
                        }
                    }
                    if (forma == "b")
                    {
                        for (int j = 0; j < losnumeros.Count(); j++)
                        {
                            for (int k = 0; k < losnumeros.Count(); k++)
                            {
                                if (losnumeros[k] < losnumeros[j])
                                {
                                    varaux = losnumeros[k];
                                    losnumeros[k] = losnumeros[j];
                                    losnumeros[j] = varaux;
                                }
                            }
                        }
                        Console.WriteLine("Forma descendente:");
                        for (int i = 0; i < losnumeros.Count(); i++)
                        {
                            Console.WriteLine(i + ") " + losnumeros[i]);
                        }
                    }
                    break;
                    case 4:
                        Console.WriteLine("Bye.");
                        fin = false;
                        break;
            }
                
            }

            Console.ReadKey();
        }
    }
}
