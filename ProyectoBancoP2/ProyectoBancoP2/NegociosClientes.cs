using System;
namespace ProyectoBancoP2
{
    public class NegociosClientes
    {

        ManejaCliente manejaCliente;

        public NegociosClientes(ManejaCliente manejaCliente)
        {
            this.manejaCliente=manejaCliente;
            Menu();
        }

        public void Menu()
        {
            int key = 0;
            do
            {
                Console.WriteLine("\n----- CLIENTES -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- AGREGAR CLIENTE\n2.- BUSCAR CLIENTE\n3.- IMPRIMIR\n0.- SALIR");
                key = Validaciones.LeerInt();
                switch (key)
                {
                    case 1:
                        // Falta validar cliente repetido  
                        Agregar();
                        Console.WriteLine("\nCLIENTE AGREGADO");
                        break;
                    case 2:
                        if (manejaCliente.Count() > 0) { Buscar(); }
                        else { Console.WriteLine("NO HAY CLIENTES AGREGADOS."); }
                        break;
                    case 3:
                        Imprimir();
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }

        // AGREGA CLIENTES
        public void Agregar()
        {
            string Nombre, Domicilio, Ciudad, Telefono;
            Console.WriteLine("\n- AGREGA CLIENTE-");
            Console.WriteLine("\nINGRESE EL NOMBRE");
            Nombre = Validaciones.LeerString();
            Console.WriteLine("\nINGRESE EL DOMICILIO");
            Domicilio = Validaciones.LeerString();
            Console.WriteLine("\nINGRESE LA CIUDAD");
            Ciudad = Validaciones.LeerString();
            do
            {
                Console.WriteLine("\nINGRESE EL TELEFONO");
                Telefono = Validaciones.LeerString();
            } while (!Validaciones.ValidaTelefono(Telefono));
            manejaCliente.Agrega(Nombre, Domicilio, Ciudad, Telefono);
        }

        // BUSCA UN CLIENTE
        public void Buscar()
        {
            int Clave;
            Console.WriteLine("- BUSCAR CLIENTE -");
            do
            {
                Console.WriteLine("INGRESE LA CLAVE DEL CLIENTE");
                Clave = Validaciones.LeerInt();
            } while (!manejaCliente.Existe(Clave));
            Console.WriteLine(manejaCliente.Consulta(Clave));
        }

        public void Imprimir()
        {
            if (manejaCliente.Count() > 0)
            {
                Console.WriteLine(manejaCliente);
                Console.WriteLine("SE TIENE UN TOTAL DE " + manejaCliente.Count() + " CLIENTES REGISTRADOS");
            }
            else { Console.WriteLine("NO HAY CLIENTES AGREGADOS."); }
        }
    }
}
