using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CentomaniValdez
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, tipo;
            int nivel, opc = 0, val = 0, numinv = 0, elecp, numaum, aux;
            string[,] matriz = new string[76, 6];
            Random rng = new Random();
            bool comprob = true, par = true;
            string[] vector = new string[6];

            vector[0] = "FILA";
            vector[1] = "NOMBRE";
            vector[2] = "TIPO";
            vector[3] = "NIVEL";
            vector[4] = "ESTADO";
            vector[5] = "NÚMERO DE INVESTIGADOR";
            

            while (par == true)
            {
                
                Console.WriteLine("-----------------MENÚ POCHIMON-----------------");
                Console.WriteLine(" ");
                Console.WriteLine("1)Registrar un Pochimon.");
                Console.WriteLine("2)Asignar investigador a Pochimon.");
                Console.WriteLine("3)Actualizar nivel de Pochimon.");
                Console.WriteLine("4)Marcar Pochimon como investigado.");
                Console.WriteLine("5)Mostrar información de Pochimons.");
                Console.WriteLine("6)Buscar Pochimons por su tipo.");
                Console.WriteLine("7)Mostrar Pochimons por investigador.");
                Console.WriteLine("8)Mostrar Pochimons Messias.");
                Console.WriteLine("9)Salir.");
                Console.WriteLine(" ");
                opc = int.Parse(Console.ReadLine());
                while (opc < 1 || opc > 9)
                {
                    Console.WriteLine("Coloque una opcion que este en el menú");
                    opc = int.Parse(Console.ReadLine());
                }
                elecp = 0;
                comprob = true;
                numinv = 0;
                switch (opc)
                {


                    case 1:
                        Console.Clear();

                        if (val == 75)
                        {
                            Console.WriteLine("Ya la Pochidex esta llena...");
                            break;
                        }

                        Console.WriteLine("-----------------MENÚ REGISTRO-----------------");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese nombre del Pochimon: ");
                        nom = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el tipo de " + nom);
                        Console.WriteLine("Tipos:");
                        Console.WriteLine("Fuego / Agua / Bicho / Roca / Eléctrico / Lucha / Hada.");
                        Console.WriteLine("(Coloque solo la inicial del tipo).");
                        tipo = (Console.ReadLine()).ToUpper();
                        while (tipo != "F" && tipo != "A" && tipo != "B" && tipo != "R" && tipo != "E" && tipo != "L" && tipo != "H")
                        {
                            Console.WriteLine("Coloque las letras correspondientes para asignar un tipo");
                            tipo = (Console.ReadLine()).ToUpper();
                        }

                        Console.WriteLine(" ");
                        Console.Write("Ingrese el nivel de " + nom + ": ");
                        nivel = int.Parse(Console.ReadLine());
                        while (nivel < 0 || nivel > 100)
                        {
                            Console.WriteLine("INCORRECTO. Un número entre el 1 y el 100");
                            nivel = int.Parse(Console.ReadLine());
                        }
                        matriz[val, 0] = (val + 1).ToString();
                        matriz[val, 1] = nom;
                        if (tipo == "F")
                        {
                            tipo = "FUEGO";
                        }
                        if (tipo == "A")
                        {
                            tipo = "AGUA";
                        }
                        if (tipo == "B")
                        {
                            tipo = "BICHO";
                        }
                        if (tipo == "R")
                        {
                            tipo = "ROCA";
                        }
                        if (tipo == "E")
                        {
                            tipo = "ELECT";
                        }
                        if (tipo == "L")
                        {
                            tipo = "LUCHA";
                        }
                        if (tipo == "H")
                        {
                            tipo = "HADA";
                        }
                        matriz[val, 2] = tipo;
                        matriz[val, 3] = nivel.ToString();
                        matriz[val, 4] = "0";
                        matriz[val, 5] = "000";
                        val++;

                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }


                        Console.WriteLine("-----------------MENÚ ASIGNACION DE INVESTIGADOR-----------------");
                        Console.WriteLine(" ");

                        aux = matriz[0, 1].Length;

                        for(int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }
                        

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write( " "+ vector[i]+ "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            

                            for (int j = 0; j < 6; j++)
                            {
                               Console.Write(" " + matriz[i, j] + "\t" + "|");

                            }
                            Console.WriteLine();
                        }

                        Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                        elecp = int.Parse(Console.ReadLine());
                        while (elecp < 1 || elecp > val)
                        {
                            Console.WriteLine("NO SE A ENCONTRADO ESA FILA");
                            Console.WriteLine("POR FAVOR INGRESE UN NÚMERO DE FILA EXISTENTE");
                            elecp = int.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("Ingrese el código del Investigador: ");
                        numinv = int.Parse(Console.ReadLine());

                        matriz[elecp-1, 4] = "1";
                        matriz[elecp-1, 5] = numinv.ToString();
                        Console.Clear();
                        break;


                    case 3:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ ACTUALIZACIÓN DEL NIVEL-----------------");
                        Console.WriteLine(" ");

                        aux = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            if (i == 2)
                            {
                                i = 3;
                            }
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-------------------------");
                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (j == 2)
                                {
                                    j = 3;
                                }
                                Console.Write(" " + matriz[i, j] + "\t" + "|");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                        elecp = int.Parse(Console.ReadLine());
                        while (elecp < 1 || elecp > val)
                        {
                            Console.WriteLine("NO SE A ENCONTRADO ESA FILA");
                            Console.WriteLine("POR FAVOR INGRESE UN NÚMERO DE FILA EXISTENTE");
                            elecp = int.Parse(Console.ReadLine());

                        }
                        numaum = rng.Next(1, 3);
                        matriz[elecp, 3] = (int.Parse(matriz[(elecp - 1), 3]) + numaum).ToString();
                        Console.WriteLine(matriz[elecp, 1] + " subió de nivel a " + matriz[elecp, 3]);
                        break;


                    case 4:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ MARCAR POCHIMON COMO INVESTIGADO-----------------");
                        Console.WriteLine(" ");
                        aux = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");
                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (matriz[i, 4] == "1")
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");
                        elecp = int.Parse(Console.ReadLine());
                        while (elecp < 1 || elecp > val)
                        {
                            Console.WriteLine("NO SE A ENCONTRADO ESA FILA");
                            Console.WriteLine("POR FAVOR INGRESE UN NÚMERO DE FILA EXISTENTE");
                            elecp = int.Parse(Console.ReadLine());
                        }
                        matriz[elecp, 4] = "2";
                        break;


                    case 5:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ INFORMACIÓN DE POCHIMONS-----------------");
                        Console.WriteLine(" ");

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");
                        aux = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }
                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                    Console.Write(matriz[i, j] + "\t" + "|");
                            }
                            Console.WriteLine();
                            
                        }
                        break;


                    case 6:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ BUSCAR POCHIMONS POR SU TIPO-----------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el tipo de Pochimon que desea buscar: ");
                        Console.WriteLine("(Solo coloque el nombre del tipo)");
                        tipo = (Console.ReadLine()).ToUpper();
                        while (tipo != "FUEGO" && tipo != "AGUA" && tipo != "PLANTA" && tipo != "TIERRA" && tipo != "ELECTRICO" && tipo != "NORMAL" && tipo != "HADA")
                        {
                            Console.WriteLine("Coloque la palabra correspondiente para buscar el tipo");
                            tipo = (Console.ReadLine()).ToUpper();
                        }
                        Console.Clear();
                        aux = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (matriz[i, 2] == tipo)
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;


                    case 7:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ BUSCAR POCHIMONS POR INVESTIGADOR-----------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el código del Investigador: ");
                        numinv = int.Parse(Console.ReadLine());
                        aux = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 3; j++)
                                
                            {
                                if (matriz[i, 3] == numinv.ToString())
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                    comprob = false;
                                    
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Clear();
                        if (comprob == true)
                        {
                            Console.WriteLine("No se a encontrado a ningún Pochimon con ese código.");
                        }
                        
                        break;


                    case 8:
                        Console.Clear();
                        if (val == 0)
                        {
                            Console.WriteLine("No se a encontrado a ningun Pochimon en la Pochidex.");
                            Console.WriteLine("POR FAVOR REGISTRE A UN POCHIMON SI QUIERE ASIGNARLE UN INVESTIGADOR");
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("-----------------MENÚ MOSTRAR POCHIMONS MESSIAS-----------------");
                        Console.WriteLine(" ");
                        aux = matriz[0, 1].Length;

                        for (int i = 1; i < val; i++)
                        {
                            if (aux < matriz[i, 1].Length)
                            {
                                aux = matriz[i, 1].Length;
                            }
                        }
                        for (int i = 0; i < val; i++)
                        {
                            matriz[i, 1] = matriz[i, 1].PadRight(aux);
                            
                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(vector[i] + "\t" + "|");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        for (int i = 0; i < val; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (int.Parse(matriz[i, 3]) >= 30)
                                {
                                    Console.Write(" " + matriz[i, j] + "\t" + "|");
                                    comprob = false;

                                }
                            }
                            Console.WriteLine();
                        }
                        if (comprob == true)
                        {
                            
                            Console.WriteLine("No se a encontrado a ningún Pochimon Messias (ninguno es de nivel 30 o mayor. Que triste).");
                        }
                        break;


                    case 9:
                        par = false;
                        break;
                }
                
            }
            Console.WriteLine("byeeeee.");

            Console.ReadKey();
        }
    }
}
