using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RanuraDeposito
    {
        //aqui se guarda el monto de un deposito con la variable deposito
        //no se usa mucho
        private int _deposito;

        public int deposito
        {
            get { return _deposito; }
            set { _deposito = value; }
        }


        public RanuraDeposito()
        {

        }
        public RanuraDeposito(int CantidadDeposito)
        {
            deposito = CantidadDeposito;
        }
    }
}
