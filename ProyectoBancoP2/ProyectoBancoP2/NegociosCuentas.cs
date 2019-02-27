using System;
namespace ProyectoBancoP2
{
    public class NegociosCuentas
    {

        public void menuCuentas()
        {

            int key;
            do
            {
                Console.WriteLine("\n----- CUENTAS CLIENTES-----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- APERTURAR CUENTA\n2.- CERRAR CUENTA\n0.- SALIR");
                key = Validaciones.LeerInt();
                switch (key)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }

        public void Apertura()
        {
            //int claveCuenta, int claveCliente,double saldoInicial,string tipoCuenta

        }

    }
}
