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
            int opc = 0;
            int cont = 0;
            int mp = 20; // límite pj
            string[,] pers = new string[mp, 5]; 
            // almacena los pj

            while (opc != 6)
            {
                MostrarMenu(cont, mp);
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
                EjecutarOpcion(opc, ref cont, mp, ref pers);
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }

        static void MostrarMenu(int cont, int mp)
        {
            Console.WriteLine("Menú - ¡Bienvenido a Dibuaventuras!");
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("Personajes Registrados: " + cont + "/" + mp + "\n");
            Console.WriteLine("1- Nuevo personaje");
            Console.WriteLine("2- Consultar personaje");
            Console.WriteLine("3- Modificar personaje");
            Console.WriteLine("4- Eliminar personaje");
            Console.WriteLine("5- Mostrar a todos los personajes.");
            Console.WriteLine("6- Salir del programa.");
            Console.Write("______________________________________________________________________________");
            Console.WriteLine();
            Console.Write("Ingrese la operación que desea realizar: ");
        }

        static void EjecutarOpcion(int opc, ref int cont, int mp, ref string[,] pers)
        {
            switch (opc)
            {
                case 1:
                    NuevoPersonaje(ref cont, mp, ref pers);
                    break;
                case 2:
                    ConsultarPersonaje(ref cont, ref pers);
                    break;
                case 3:
                    ModificarPersonaje(ref cont, mp, ref pers);
                    break;
                case 4:
                    EliminarPersonaje(ref cont, mp, ref pers);
                    break;
                case 5:
                    MostrarTodosPersonajes(ref cont, ref pers);
                    break;
                case 9:
                    Console.WriteLine("bye");
                    break;
                default:
                    Console.WriteLine("Coloque una opción válida.");
                    break;
            }
        }


        static void NuevoPersonaje(ref int cont, int mp, ref string[,] pers)
        {
            if (cont == mp)
            {
                Console.WriteLine("Su lista de personajes está llena.");
                Console.ReadLine();
                return;
            }
            string nom, serie;
            int fue, def, heroe;

            Console.Write("Nombre del personaje: ");
            nom = Console.ReadLine();
            Console.Write("Serie que pertenece el personaje: ");
            serie = Console.ReadLine();
            Console.Write("Fuerza del personaje: ");
            fue = int.Parse(Console.ReadLine());
            Console.Write("Defensa del personaje: ");
            def = int.Parse(Console.ReadLine());
            Console.Write("¿Es un héroe? 1 = Si 2 = No: ");
            heroe = int.Parse(Console.ReadLine());

            while (heroe != 1 && heroe != 2)
            {
                Console.WriteLine("Número inválido, ingrese uno correcto (1 para sí, 2 para no):");
                heroe = int.Parse(Console.ReadLine());
            }

            pers[cont, 0] = nom;
            pers[cont, 1] = serie;
            pers[cont, 2] = fue.ToString();
            pers[cont, 3] = def.ToString();
            pers[cont, 4] = heroe.ToString();
            cont++;
            Console.WriteLine(nom + " fue agregado con éxito.");
            Console.Clear();
            Console.ReadKey();
        }


        static void ConsultarPersonaje(ref int cont, ref string[,] pers)
        {
            if (cont == 0)
            {
                Console.WriteLine("No se encontraron personajes registrados.");
            }
            else
            {
                Console.WriteLine("Seleccione un personaje por su número:");
                for (int i = 0; i < cont; i++)
                {
                    Console.WriteLine((i + 1) + pers[i, 0]);
                }
                int selec;

                Console.Write("Ingrese el número del personaje que desea consultar: ");
                selec = int.Parse(Console.ReadLine()) - 1;
                if (selec >= 0 && selec < cont)
                {
                    Console.WriteLine("Nombre: " + pers[selec, 0]);
                    Console.WriteLine("Serie: " + pers[selec, 1]);
                    Console.WriteLine("Fuerza: " + pers[selec, 2]);
                    Console.WriteLine("Defensa: " + pers[selec, 3]);
                    Console.WriteLine("Héroe: " + pers[selec, 4]);
                }
                else
                {
                    Console.WriteLine("Su número no válido.");
                }
            }

            Console.ReadKey();
        }


        static void ModificarPersonaje(ref int cont, int mp, ref string[,] pers)
        {
            string nombre;
            Console.Write("Ingrese el nombre del personaje que quiere modificar: ");
            nombre = Console.ReadLine();

            bool enc = false;
            for (int i = 0; i < cont; i++)
            {
                if (pers[i, 0] == nombre)
                {
                    Console.WriteLine("---Datos actuales del personaje---");
                    Console.WriteLine("Fuerza: " + pers[i, 2]);
                    Console.WriteLine("Defensa: " + pers[i, 3]);

                    int fue1, def1;
                    Console.Write("Actualice la fuerza: ");
                    fue1 = int.Parse(Console.ReadLine());
                    Console.Write("Actualice la defensa: ");
                    def1 = int.Parse(Console.ReadLine());

                    pers[i, 2] = fue1.ToString();
                    pers[i, 3] = def1.ToString();

                    Console.WriteLine("Su personaje fue modificado.");
                    enc = true;
                    break;
                }
            }

            if (!enc)
            {
                Console.WriteLine("No pudimos encontrar a ese personaje.");
            }
            Console.ReadKey();
        }


        static void EliminarPersonaje(ref int cont, int mp, ref string[,] pers)
        {
            string nomb;
            Console.Write("Coloquque el nombre del personaje que desea eliminar: ");
            nomb = Console.ReadLine();

            bool enco = false;
            for (int i = 0; i < cont; i++)
            {
                if (pers[i, 0] == nomb)
                {

                    for (int j = i; j < cont - 1; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            pers[j, k] = pers[j + 1, k];
                        }
                    }


                    for (int k = 0; k < 5; k++)
                    {
                        pers[cont - 1, k] = null;
                    }

                    cont--;
                    Console.WriteLine("¡Personaje eliminado con éxito!");
                    enco = true;
                    break;
                }
            }

            if (!enco)
            {
                Console.WriteLine("No se encontró a ese personaje.");
            }

            Console.ReadKey();
        }


        static void MostrarTodosPersonajes(ref int cont, ref string[,] pers)
        {
            if (cont == 0)
            {
                Console.WriteLine("No registraste a ningún personaje.");
            }
            else
            {

                for (int i = 0; i < cont - 1; i++)
                {
                    for (int j = i + 1; j < cont; j++)
                    {
                        if (string.Compare(pers[i, 0], pers[j, 0]) > 0)
                        {
                            string temp;
                            for (int k = 0; k < 5; k++)
                            {
                                temp = pers[i, k];
                                pers[i, k] = pers[j, k];
                                pers[j, k] = temp;
                            }
                        }
                    }
                }

                Console.WriteLine("-----Lista de personajes-----");
                for (int i = 0; i < cont; i++)
                {
                    Console.WriteLine(pers[i, 0] + " - " + pers[i, 1] + " - Fuerza: " + pers[i, 2] + " - Defensa: " + pers[i, 3] + " - Héroe: " + pers[i, 4]);

                }
            }

            Console.ReadKey();
        }
    }
}