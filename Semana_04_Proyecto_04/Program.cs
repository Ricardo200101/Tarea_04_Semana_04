using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salario;
using Biblioteca_2; 

namespace Semana_04_Proyecto_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables. 

            var bc = "s";
            var sn = "s";
            int lis;

            do
            {
                // Lista. 

                Console.WriteLine("----------LISTA-----------");
                Console.WriteLine("1. CALCULAR SUELDO");
                Console.WriteLine("2. CREACION DE LISTA");
                Console.WriteLine("--------------------------\n");
                Console.Write("INGRESE LA OPCION QUE DESEA REALIZAR: ");
                lis = Convert.ToInt32(Console.ReadLine());

                // Condision. 

                if (lis == 1)
                {
                    // Inicio del ciclo While. 

                    while (bc == "s")
                    {

                        // Creacion del arreglo. 

                        string[] nombre = new string[1];

                        // Inicio del Array. 

                        for (int i = 0; i < nombre.Length; i++)
                        {
                            // Reconleccion de datos. 

                            Console.Write("\nINGRESAR EL NOMBRE DEL EMPLEADO: ");
                            nombre[i] = Console.ReadLine();
                            Console.WriteLine("--------------------------------------------------------------------------");


                            for (int j = 0; j < nombre.Length; j++)
                            {
                                // Uso de la biblioteca.

                                Formula.lista();
                                Console.WriteLine("NOMBRE DEL EMPLEADO: {0}", nombre[i]);
                                Console.WriteLine("--------------------------------------------------------------------------");
                            }

                        }



                        // Preguntamos al usuario si desea finalizar el programa. 

                        Console.Write("\n¿DESEA REALIZAR EL PROCESO OTRA VEZ S/N?: ");
                        bc = Console.ReadLine();
                    }



                }
                else
                {
                    Biblioteca2.ejemplo2();

                }

                Console.WriteLine("\n--------------------------------------------------------------------------");
                Console.Write("¿DESEA REGREAR AL MENU S/N?: ");
                sn = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------------------------------");

            } while (sn == "s");
            Console.WriteLine("FELIZ DIA!!!");
            Console.ReadKey();
        }
    }
}
