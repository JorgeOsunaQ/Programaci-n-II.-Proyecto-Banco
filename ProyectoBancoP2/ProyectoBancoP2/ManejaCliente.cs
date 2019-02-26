using System;
using System.Collections.Generic;

namespace ProyectoBancoP2
{
    public class ManejaCliente
    {

        Dictionary<int, Cliente> clientes;
        int countClave = 1;

        public ManejaCliente()
        {
            clientes = new Dictionary<int, Cliente>();
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

    }
}
