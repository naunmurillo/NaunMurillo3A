using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ColaYPila.Clases;

namespace ColaYPila
{
    class Program
    {
        static void Main(string[] args)
        {
            TADPila Pila = new TADPila();
            TADCola Cola = new TADCola();

            int control = 0, opcion;
            string op;


            while (control == 0)
            {
                Console.WriteLine("\t\t---------------------");
                Console.WriteLine("\t\t-  MENU DE OPCIONES -");
                Console.WriteLine("\t\t---------------------");
                Console.WriteLine("\t\t- 1) Ejercicio Pila -");
                Console.WriteLine("\t\t- 2) Ejercicio Cola -");
                Console.WriteLine("\t\t- 3) Salir          -");
                Console.WriteLine("\t\t---------------------");
                Console.WriteLine("");
                Console.WriteLine(" Digite opción a ejecutar: ");
                op = Console.ReadLine();
                opcion = Convert.ToInt32(op);

                if (opcion == 1)
                {
                   Pila.tadPila();
                }
                else if (opcion == 2)
                {
                   Cola.tadCola();
                }
                else if (opcion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Finalizó el programa. Presione una tecla para salir.");
                    Console.ReadKey();
                    control = 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPCION INVALIDA. Porfavor digite una opcion correcta para ejecutar.");

                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}

