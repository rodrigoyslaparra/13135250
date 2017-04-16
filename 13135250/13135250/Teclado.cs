using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teclado
    {
        public int NumRetir { get; private set; }
        private int _NumeroCuenta;
        private int _Pin;


        public Teclado(int numReti)
        {
            NumRetir = numReti;
        }

        public Teclado()
        {
        }

        public int NumeroCuenta
        {
            get { return _NumeroCuenta; }
            set { _NumeroCuenta = value; }
        }

        public int Pin
        {
            get { return _Pin; }
            set { _Pin = value; }
        }

        
        public Teclado(int numeroCuenta, int pin)
        {
            NumeroCuenta = numeroCuenta;
            Pin = pin;

        }
    }
    }
