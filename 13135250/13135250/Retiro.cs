using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Retiro
    {
        public Teclado Teclado{ get; set; }
        private Pantalla Pantalla { get; set; }
        private DispensadorEfectivo DispensadorEfectivo { get; set; }
        public ATM ATM { get; set; }
        private BaseDeDatos BaseDeDatos { get; set; }
        public Retiro()
        {
        }

        private Retiro (DispensadorEfectivo dispensadorRetiro)
        {
            DispensadorEfectivo = dispensadorRetiro;
        }

        private Retiro(Teclado teclado, Pantalla pantalla, DispensadorEfectivo dispensadorEfectivo, ATM aTM, BaseDeDatos baseDatos)
        {
            Teclado = teclado;
            Pantalla = pantalla;
            DispensadorEfectivo = dispensadorEfectivo;
            ATM = aTM;
            BaseDeDatos = baseDatos;
        }
    }

    

}
