using System;
namespace ProyectoBancoP2
{
    public class NegociosBanco
    {
        public NegociosBanco()
        {
        }

        public void Main()
        {
      
        }

        public void menu()
        {
            int key = 1;

            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- MOVIMIENTOS\n2.- CLIENTES\n3.- CUENTAS\n0.- SALIR");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }

        public void menuMovimiento()
        {

            int key = 0;

            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- REALIZAR MOVIMIENTO\n2.- CONSULTAR\n3.- CUENTAS\n0.- SALIR");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (key != 0);

        }
    }
}
