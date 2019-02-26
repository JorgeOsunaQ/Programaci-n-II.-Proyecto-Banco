using System;
using System.Collections.Generic;

namespace ProyectoBancoP2
{
    public class ManejaMovimiento
    {

       private List<Movimiento> movimientos;
       private ManejaCuentas manejaC;

        public ManejaMovimiento(ManejaCuentas manejadora)
        {
            this.movimientos = new List<Movimiento>();
            this.manejaC = manejadora;
        }

        // agrega (deposito o retiro), consulta por cuenta

        public bool Agrega(string Tipo, int ClaveCuenta, double Importe, string NombreDepositador)
        {
            bool flag = false;
            movimientos.Add(new Movimiento(Tipo, ClaveCuenta, Importe, NombreDepositador));
            flag = true;

            return flag;
        }

        public bool Deposito(double cant, int claveC)
        {
            bool flag = false;

            if (manejaC.BuscarCuenta(claveC)!=null)
            {
                manejaC.BuscarCuenta(claveC).pSaldo += cant;
                flag = true;
            }

            return flag;
        }

        public String ImprimirPorCuenta(int claveC)
        {
            string res = "";

            foreach (Movimiento data in movimientos)
            {
                if (data.pClaveCuenta == claveC)
                    res += data.ToString();
            }

            return res;
        }

    }
}
