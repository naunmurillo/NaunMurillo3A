using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaYPila.Clases
{
    class TADCola
    {
        public void tadCola()
        {
            Colita cola = new Colita();
            int control = 0, opcion;
            string op;
           
            while (control == 0)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("--  COLA: MENU DE OPERACIONES --");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("- 1) Ingresar elemento         -");
                Console.WriteLine("- 2) Recorrer cola             -");
                Console.WriteLine("- 3) Salir                     -");
                Console.WriteLine("--------------------------------");
                op = Console.ReadLine();
                opcion = Convert.ToInt32(op);

                if (opcion == 1)
                {
                    cola.IngresarCola();
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    cola.RecorrerCola();
                }
                else if (opcion == 3)
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
