using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Pantalla
    {
        public int NumRetiCos { get; private set; } // NumRetiCos = cantidad de retiros que se van a mostrar

        public Pantalla(int numRetiCos)
        {
            NumRetiCos = numRetiCos;
        }

        public Pantalla()
        {
        }
    }
}
