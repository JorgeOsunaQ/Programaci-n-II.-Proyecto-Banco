using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoBancoP2
{
    class Cliente
    {
        private static int count=0;
        private int clave;
        private string nombre;
        private string domicilio;
        private string ciudad;
        private string telefono;

        public Cliente(int clave, string nom, string dom, string ci, string tel)
        {
            count++;
            this.clave = count;
            this.nombre = nom;
            this.domicilio = dom;
            this.ciudad = ci;
            this.telefono = tel;
        }

        public int pClave {
            get => clave;
        }
        public string pNombre {
            get => nombre;
            set => nombre = value;
        }
        public string pDomicilio {
            get => domicilio;
            set => domicilio = value;
        }
        public string pCiudad {
            get => ciudad;
            set => ciudad = value;
        }
        public string pTelefono {
            get => telefono;
            set => telefono = value;
        }

        public override string ToString()
        {
            string res = String.Format("Nombre: {0,-5}\n Clave: {1,-3}\n Ciudad de residencia: {2,-3}, Domicilio: {3,-5}\n " +
                "Teléfono: {4,-5}",pNombre,pClave,pCiudad,pDomicilio,pTelefono);

            return res;
        }
    }
}
