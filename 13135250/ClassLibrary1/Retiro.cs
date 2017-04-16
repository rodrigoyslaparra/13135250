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

        public Retiro()
        {
        }

        private Retiro (DispensadorEfectivo dispensadorRetiro)
        {
            DispensadorEfectivo = dispensadorRetiro;
        }

        private Retiro(Pantalla pantalla)
        {
            Pantalla = pantalla;
        }

        public Retiro(Teclado teclado)
        {
            Teclado = teclado;
        }
    }

    

}
