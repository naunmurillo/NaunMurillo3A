using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaYPila.Clases
{
    class CNodo
    {
        private int dato;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        private CNodo siguiente = null;
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("{[0]}", dato);
        }
    }
}
