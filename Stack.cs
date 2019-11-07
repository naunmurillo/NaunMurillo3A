using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaYPila.Clases
{
    class Stack
    {
        private CNodo ancla;
        private CNodo trabajo;
        public Stack()
        {
            ancla = new CNodo();
            ancla.Siguiente = null;
        }
        public void OpApilar(int pDato)
        {
            CNodo aux = new CNodo();
            aux.Dato = pDato;
            aux.Siguiente = ancla.Siguiente;
            ancla.Siguiente = aux;
        }
        public int OpDesapilar()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        public int OpCima()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }

        public void Cruce()
        {
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                int elm = trabajo.Dato;
                Console.WriteLine("{[0]}", elm);
            }
        }
    }
}
