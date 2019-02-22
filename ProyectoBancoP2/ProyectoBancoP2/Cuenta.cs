using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoBancoP2
{
    class Cuenta
    {

        private int claveCuenta;
        private double saldo;
        private string nombreCuenta;
        private int claveCliente;

        public Cuenta(double saldoInicial,string tipoCuenta,int claveCliente, int claveCuenta)
        {
            this.claveCliente = claveCliente;
            this.claveCuenta = claveCuenta;
            this.nombreCuenta = tipoCuenta;
            this.saldo = saldoInicial;
        }

        public int pClaveCuenta
        {
            get => claveCuenta;
        }
        public double pSaldo
        {
            get => saldo;
            set => saldo = value;
        }
        public string pNombre
        {
            get => nombreCuenta;
            set => nombreCuenta = value;
        }
        public int pClaveCliente
        {
            get => claveCliente;
            set => claveCliente = value;//?
        }

        public override string ToString()
        {
            string res = String.Format("TIPO DE CUENTA: {0,-5}\n CLAVE: {1,-3}\n,CLAVE DEL CLIENTE ASOCIADO: {2,-3}\n " +
                "SALDO ACTUAL: {3,-3:c}",pNombre,pClaveCuenta,pClaveCliente,pSaldo);
            return res;
        }
    }
}
