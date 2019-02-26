using System;
using System.Text.RegularExpressions;

namespace ProyectoBancoP2
{
    public class NegociosBanco
    {

        ManejaCuentas manejaCuenta;
        ManejaMovimiento manejaMovimientos;
        ManejaCliente manejaCliente;
        ManejaCatalogoCuenta manejaCatalogoCuenta;

        public NegociosBanco()
        {
            this.manejaCuenta = new ManejaCuentas();
            this.manejaMovimientos = new ManejaMovimiento(manejaCuenta);
            this.manejaCliente = new ManejaCliente(manejaCuenta);
            this.manejaCatalogoCuenta = new ManejaCatalogoCuenta();
        }

        public void menu()
        {

            int key = 0;

            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- MOVIMIENTOS\n2.- CLIENTES\n3.- CUENTAS CLIENTES\n4.- CUENTAS BANCO\n0.- SALIR");
                key = Validaciones.leerInt();
                switch (key)
                {
                    case 1:
                        break;
                    case 2:
                        menuClientes();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }

        public void menuMovimientos()
        {

            int key = 0;

            do
            {
                Console.WriteLine("\n----- MOVIMIENTOS -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- REALIZAR MOVIMIENTO\n2.- BUSCAR MOVIMIENTOS\n0.- SALIR");
                key = Validaciones.leerInt();
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

        public void menuClientes()
        {

            int key = 0;

            do
            {
                Console.WriteLine("\n----- CLIENTES -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- AGREGAR CLIENTE\n2.- BUSCAR CLIENTE\n0.- SALIR");
                key = Validaciones.leerInt();
                switch (key)
                {
                    case 1:
                        // Falta validar cliente repetido  
                        string Nombre, Domicilio, Ciudad, Telefono;
                        Console.WriteLine("- AGREGA CLIENTE-");
                        Console.WriteLine("INGRESE EL NOMBRE");
                        Nombre = Validaciones.leerString();
                        Console.WriteLine("INGRESE EL DOMICILIO");
                        Domicilio = Validaciones.leerString();
                        Console.WriteLine("INGRESE LA CIUDAD");
                        Ciudad = Validaciones.leerString();
                        do
                        {
                            Console.WriteLine("INGRESE EL TELEFONO");
                            Telefono = Validaciones.leerString();
                        } while (!Validaciones.validaTelefono(Telefono));
                        manejaCliente.agrega(Nombre, Domicilio, Ciudad, Telefono);
                        Console.WriteLine("CLIENTE AGREGADO");
                        break;
                    case 2:
                        int Clave;
                        Console.WriteLine("- BUSCAR CLIENTE -");
                        do
                        {
                            Console.WriteLine("INGRESE LA CLAVE DEL CLIENTE");
                            Clave = Validaciones.leerInt();
                        } while (manejaCliente.existe(Clave));
                        Console.WriteLine(manejaCliente.consulta(Clave));
                        break;
                    default:
                        break;
                }
            } while (key != 0);

        }

        public void menuCuentas()
        {

            int key;
            do
            {
                Console.WriteLine("\n----- CUENTAS CLIENTES-----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- APERTURAR CUENTA\n2.- CERRAR CUENTA\n0.- SALIR");
                key = Validaciones.leerInt();
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

        public void menuCuentasBanco(ManejaCatalogoCuenta manejaCatalogoCuenta)
        {

            int key;
            do
            {
                Console.WriteLine("\n----- CUENTAS BANCO -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- CREAR CUENTA\n2.- BUSCAR CUENTA\n3.- ELIMINAR CUENTA\n4.- IMPRIMIR\n0.- SALIR");
                key = Validaciones.leerInt();
                switch (key)
                {
                    case 1:
                        string Nombre, Descripcion;
                        double MontoMinimo;
                        Console.WriteLine("- AGREGA CUENTA BANCO -");
                        Console.WriteLine("INGRESE EL NOMBRE");
                        Nombre = Validaciones.leerString();
                        do
                        {
                            Console.WriteLine("INGRESE EL MONTO MINIMO");
                            MontoMinimo = Validaciones.leerDouble();
                        } while (MontoMinimo<0);
                        Console.WriteLine("INGRESE LA DESCRIPCION");
                        Descripcion = Validaciones.leerString();
                        manejaCatalogoCuenta.agrega(Nombre, MontoMinimo, Descripcion);
                        break;
                    case 2:
                        string NombreB;
                        Console.WriteLine("- BUSCAR CUENTA -");
                        do
                        {
                            Console.WriteLine("INGRESE EL NOMBRE");
                            NombreB = Validaciones.leerString();
                        } while (manejaCatalogoCuenta.consulta(NombreB)==null);
                        Console.WriteLine(manejaCatalogoCuenta.consulta(NombreB));
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine(manejaCatalogoCuenta);
                        break;
                    default:
                        break;
                }
            } while (key != 0);

        }
    }
}
