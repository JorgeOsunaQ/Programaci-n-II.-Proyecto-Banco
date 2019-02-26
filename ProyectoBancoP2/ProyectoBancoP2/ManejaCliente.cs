using System;
using System.Collections.Generic;

namespace ProyectoBancoP2
{
    public class ManejaCliente
    {

        ManejaCuenta manejaCuenta;

        Dictionary<int, Cliente> clientes;
        int countClave = 1;

        public ManejaCliente(ManejaCuenta manejaCuenta)
        {
            clientes = new Dictionary<int, Cliente>();
            this.manejaCuenta = manejaCuenta;
        }

        public void agrega(string Nombre, string Domicilio, string Ciudad, string Telefono)
        {
            clientes.Add(countClave, new Cliente(Nombre, Domicilio, Ciudad, Telefono));
            countClave++;
        }

        public bool existe(int key)
        {
           return clientes.ContainsKey(key);
        }

        public void elimina(int key)
        {
            clientes.Remove(key);
        }

        public string consulta(int key)
        {
            string str="";
            foreach (var item in clientes.Keys)
            {
                if (item==key)
                {
                    str = item.ToString();
                    break;
                }
            }
            return str;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in clientes.Keys)
            {
                str = item.ToString() + "\n";
            }
            return str;
        }

    }
}
