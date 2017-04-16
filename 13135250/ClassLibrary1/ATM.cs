using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ATM
    {
        
        private RanuraDeposito _RanuraDeposito;
        private Pantalla _Pantalla;
        private DispensadorEfectivo _DispensadorEfectivo;
        private Teclado _Teclado;

        public Teclado Teclado
        {
            get { return _Teclado; }
            set { _Teclado = value; }
        }

        private RanuraDeposito RanuraDeposito
        {
            get { return _RanuraDeposito; }
            set { _RanuraDeposito = value; }
        }
        private Pantalla Pantalla
        {
            get { return _Pantalla;}
            set { _Pantalla = value; }
        }
        private DispensadorEfectivo DispensadorEfectivo
        {
            get { return _DispensadorEfectivo; }
            set { _DispensadorEfectivo = value; }
        }
       

        public ATM()
            {
            _RanuraDeposito = new RanuraDeposito();
            _Teclado = new Teclado();
            _DispensadorEfectivo = new DispensadorEfectivo();
            _Pantalla = new Pantalla();
        }
    }
}
