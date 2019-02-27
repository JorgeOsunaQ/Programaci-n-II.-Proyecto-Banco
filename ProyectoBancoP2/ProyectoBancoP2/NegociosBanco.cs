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
            this.manejaCliente = new ManejaCliente();
            this.manejaCatalogoCuenta = new ManejaCatalogoCuenta();
            Menu();
        }

        public void Menu()
        {
            int key = 0;
            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- MOVIMIENTOS\n2.- CLIENTES\n3.- CUENTAS CLIENTES\n4.- CUENTAS BANCO\n0.- SALIR");
                key = Validaciones.LeerInt();
                switch (key)
                {
                    case 1:
                        NegociosMovimientos negociosMovimientos = new NegociosMovimientos(manejaMovimientos,manejaCliente,manejaCuenta, manejaCatalogoCuenta);
                        break;
                    case 2:
                        NegociosClientes negociosClientes = new NegociosClientes(manejaCliente, manejaCuenta);
                        break;
                    case 3:
                        NegociosCuentas negociosCuentas = new NegociosCuentas(manejaCuenta, manejaCliente, manejaCatalogoCuenta);
                        break;
                    case 4:
                        NegociosCuentasBanco negociosCuentasBanco = new NegociosCuentasBanco(manejaCatalogoCuenta);
                        break;
                    default:
                        Console.WriteLine("\nOPCIÓN NO DISPONIBLE.");
                        break;
                }
            } while (key != 0);
        }
    }
}
