using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class BaseDeDatos
    {
        private List<Cuenta> _Cuentas;
        public List<Cuenta> Cuentas {
            get { return _Cuentas; }
            set { _Cuentas = value; }
        }
        public BaseDeDatos ()
        {
            Cuentas = new List<Cuenta>();
        }

        public BaseDeDatos(int cantCuentas)
        {
            Cuentas = new List<Cuenta>(cantCuentas);
        }

        
    }
}
