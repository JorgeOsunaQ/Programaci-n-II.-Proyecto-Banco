using System;
namespace ProyectoBancoP2
{
    public class NegociosMovimientos
    {

        public void menu()
        {

            int key = 0;

            do
            {
                Console.WriteLine("\n----- MOVIMIENTOS -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- REALIZAR MOVIMIENTO\n2.- BUSCAR MOVIMIENTOS\n0.- SALIR");
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

    }
}
