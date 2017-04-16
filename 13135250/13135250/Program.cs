using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13135250
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cuenta, ope, pin, montRetiro;
            Retiro credit = new Retiro();
            ATM cajero = new ATM();

            cajero.BaseDatos = new BaseDeDatos();
            Cuenta rodrigo1 = new Cuenta(12345, 1234, 5000.0M);
            cajero.BaseDatos.Cuentas.Add(rodrigo1);
            Console.WriteLine("--------Cajero Automatico--------");

            do
            {
                Console.WriteLine("Puede ingresar el numero de la cuenta: ");
                do
                {
                    cuenta = Int32.Parse(Console.ReadLine());
                }
                while (cuenta == null);
                Console.WriteLine("Puede ingresar la contraseña: ");
                do
                {
                    
                        pin = Int32.Parse(Console.ReadLine());
                    } while (pin==null);
                    if (cajero.BaseDatos.AutenticarUsuario(cuenta, pin) == false)
                    {
                        Console.WriteLine("---Incorrecto vuelva intetarlo---");
                        Console.WriteLine("");
                    }
                }
                while (cajero.BaseDatos.AutenticarUsuario(cuenta, pin) == false);
                Console.WriteLine("-----Bienvenido Cliente-----");
                do
                {
                    Console.WriteLine("   Puede Seleccionar una operacion que desee realizar:");
                    Console.WriteLine("");
                    Console.WriteLine(" 1.-  Obtener saldo Disponible ");
                    Console.WriteLine(" 2.-  Obtener saldo Total ");
                    Console.WriteLine(" 3.-  Debitar ");
                    Console.WriteLine(" 4.-  Acreditar ");
                    ope = Int32.Parse(Console.ReadLine());
                }
                while (ope != 4);
                Console.WriteLine(" Puede Ingresar el monto a retirar ");
                montRetiro = Int32.Parse(Console.ReadLine());
                cajero.BaseDatos.Creditar(cuenta, montRetiro);
                Console.WriteLine(" ---RETIRO EXITOSO---");
                Console.WriteLine(" NUEVO SALDO : " + cajero.BaseDatos.ObtenerSaldoDisponible(cuenta).ToString());
                Console.ReadLine();
            
        }
    }
}
