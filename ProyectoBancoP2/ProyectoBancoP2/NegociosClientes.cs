using System;
namespace ProyectoBancoP2
{
    public class NegociosClientes
    {

        ManejaCliente manejaCliente;
        ManejaCuentas manejaCuentas;

        public NegociosClientes(ManejaCliente manejaCliente, ManejaCuentas manejaCuentas)
        {
            this.manejaCliente=manejaCliente;
            this.manejaCuentas = manejaCuentas;
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
                        Agregar();
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
            if (manejaCliente.KeyCliente(Nombre)!=-1)
            {
                Console.WriteLine("\nEL CLIENTE YA EXISTE");
                return;
            }
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
            Console.WriteLine("\nCLIENTE AGREGADO");
        }

        // BUSCA UN CLIENTE
        public void Buscar()
        {
            string Nombre;
            Console.WriteLine("- BUSCAR CLIENTE -");
            do
            {
                Console.WriteLine("INGRESE EL NOMBRE DEL CLIENTE");
                Nombre = Validaciones.LeerString();
            } while (manejaCliente.KeyCliente(Nombre)==-1);
            int ClaveC = manejaCliente.KeyCliente(Nombre);
            Console.WriteLine("\nDATOS DEL CLIENTE");
            Console.WriteLine(manejaCliente.Consulta(ClaveC));
            Console.WriteLine("\nCUENTAS DEL CLIENTE\n");
            Console.WriteLine(manejaCuentas.ImprimirPorCliente(ClaveC));
        }

        public void Imprimir()
        {
            Console.WriteLine("- CLIENTES -");
            if (manejaCliente.Count() > 0)
            {
                Console.WriteLine(manejaCliente);
                Console.WriteLine("SE TIENE UN TOTAL DE " + manejaCliente.Count() + " CLIENTES REGISTRADOS");
            }
            else { Console.WriteLine("NO HAY CLIENTES AGREGADOS."); }
        }
    }
}
