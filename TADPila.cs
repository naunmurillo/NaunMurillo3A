using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaYPila.Clases
{
    class TADPila
    {
        public void tadPila()
        {
            Stack pila = new Stack();
            int control = 0, opcion;
            string op;

            while (control == 0)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("--  PILA: MENU DE OPERACIONES --");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("- 1) Apilar elemento           -");
                Console.WriteLine("- 2) Desapilar elemento        -");
                Console.WriteLine("- 3) Mostrar elemento superior -");
                Console.WriteLine("- 4) Salir                     -");
                Console.WriteLine("--------------------------------");
                op = Console.ReadLine();
                opcion = Convert.ToInt32(op);

                if (opcion==1)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    pila.OpApilar(int.Parse(Console.ReadLine()));
                    Console.Clear();
                }
                else if (opcion==2)
                {
                    Console.WriteLine(pila.OpDesapilar());
                    Console.Clear();
                }
                else if (opcion==3)
                {
                    Console.WriteLine(pila.OpCima());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(opcion==4)
                {
                    Console.Clear();
                    control = 1;
                    Console.WriteLine("Finalizado, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPCION INVALIDA. Digite una opcion correcta para ejecutar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
