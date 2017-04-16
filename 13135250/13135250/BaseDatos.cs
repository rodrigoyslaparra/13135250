using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BaseDeDatos
    {
        public List<Cuenta> _Cuentas;
        public List<Cuenta> Cuentas {
            get { return _Cuentas; }
            set { _Cuentas = value; }
        }
        public BaseDeDatos ()
        {
            Cuentas = new List<Cuenta>();
        }

        public bool AutenticarUsuario(int numeroCuenta, int pin)
        {

            int max = _Cuentas.Count;
            //_Cuentas.ForEach(if numeroCuenta==_Cuentas.)
            for (int i = 0; i <= max; i++)
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta && _Cuentas[i].Pin == pin)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public BaseDeDatos(int cantCuentas)
        {
            Cuentas = new List<Cuenta>(cantCuentas);
        }
        public decimal ObtenerSaldoDisponible(int numeroCuenta) {
            int max = _Cuentas.Count;
            for (int i=0; i<=max;i++)
            {
                if (_Cuentas[i].NumCuenta == numeroCuenta)
                {
                    return _Cuentas[i].Monto;
                }
                else { return 0.0M; }
                    }return 0.0M;
        }

        public void Debitar(int numeroCuenta,decimal monto) {
            //Codigo solo transsaccion
        }
        public void Creditar(int numeroCuenta, decimal monto)
        {
            //esta transaccion es el retiro de dinero de la cuenta
            int max = _Cuentas.Count;
            for (int i = 0; i < max; i++)
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta)
                {
                    //luego de encontrar la cuenta con ese numero de cuenta le resta el monto
                    _Cuentas[i].Monto -= monto;

                }

            }

        }

    }
}
