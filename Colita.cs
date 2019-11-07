using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaYPila.Clases
{
    class Colita
    {
        private CNodo primero = new CNodo();
        private CNodo ultimo = new CNodo();

        public Colita()
        {
            primero = null;
        }

        public void IngresarCola()
        {
            CNodo nuevo = new CNodo();
            Console.WriteLine("Ingrese un número");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            Console.WriteLine("\nIngresado correctamente");
        }
        public void RecorrerCola()
        {
            CNodo actual = new CNodo();
            actual = primero;
            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("La cola esta vacía");
                Console.ReadKey();
            }
        }
    }
}
