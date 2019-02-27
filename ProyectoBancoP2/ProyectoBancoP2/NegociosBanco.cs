﻿using System;
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
                        break;
                    case 2:
                        NegociosClientes negociosClientes = new NegociosClientes(manejaCliente);
                        break;
                    case 3:
                        break;
                    case 4:
                        NegociosCuentasBanco negociosCuentasBanco = new NegociosCuentasBanco(manejaCatalogoCuenta);
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }
    }
}
