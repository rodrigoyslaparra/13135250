using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pantalla
    {
        public int NumRetiCos { get; private set; } // NumRetiCos = cantidad de retiros que se van a mostrar
        private string _Texto;
        public Pantalla(int numRetiCos)
        {
            NumRetiCos = numRetiCos;
        }
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public Pantalla(string texto)
        {
            Texto = texto;
        }
        public Pantalla()
        {
        }
    }
}
