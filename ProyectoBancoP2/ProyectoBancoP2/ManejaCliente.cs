﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Agrega(string Nombre, string Domicilio, string Ciudad, string Telefono)
        {
            clientes.Add(countClave, new Cliente(Nombre, Domicilio, Ciudad, Telefono));
            countClave++;
        }

        public int Count()
        {
            return clientes.Count;
        }

        public bool Existe(int key)
        {
           return clientes.ContainsKey(key);
        }

        public Cliente BuscarCliente(string nom)
        {
            Cliente temp=null;
            foreach(KeyValuePair<int, Cliente> data in clientes)
            {
                if (data.Value.pNombre.Equals(nom.ToUpper()))
                {
                    temp = data.Value;
                }
            }
            return temp;
        }

        public string Consulta(int key)
        {
            string str="";
            for (int i = 0; i < clientes.Count; i++)
            {
                var dato = clientes.ElementAt(i);
                Cliente c = dato.Value;
                int keyA = dato.Key;
                if (keyA==key)
                {
                    str = "CLAVE: "+keyA+"\n"+c.ToString();
                }
            }
            return str;
        }

        public override string ToString()
        {
            string str;
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < clientes.Count; i++)
            {
                var dato = clientes.ElementAt(i);
                Cliente c = dato.Value;
                int keyA = dato.Key;
                sb.AppendLine("\nCLAVE: " + keyA + "\n" + c);
            }
            str = sb.ToString();
            return str;
        }
    }
}
