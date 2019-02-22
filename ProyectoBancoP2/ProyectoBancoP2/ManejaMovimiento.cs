using System;
using System.Collections.Generic;

namespace ProyectoBancoP2
{
    public class ManejaMovimiento
    {

        List<Movimiento> movimientos;

        public ManejaMovimiento()
        {
            movimientos = new List<Movimiento>();
        }

        // agrega (deposito o retiro), consulta por cuenta

        public void agrega(string Tipo, int ClaveCuenta, double Importe, string NombreDepositador)
        {
            movimientos.Add(new Movimiento(Tipo, ClaveCuenta, Importe, NombreDepositador));
        }
    }
}
