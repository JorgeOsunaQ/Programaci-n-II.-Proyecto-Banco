﻿using System;
namespace ProyectoBancoP2
{
    public class Movimiento
    {

        private string Tipo;
        private double Importe;
        private int ClaveCuenta;
        private string NombreDepositador;

        public Movimiento(string Tipo, int ClaveCuenta, double Importe, string NombreDepositador)
        {
            this.Tipo = Tipo;
            this.ClaveCuenta = ClaveCuenta;
            this.Importe = Importe;
            this.NombreDepositador = NombreDepositador;
        }

        public string pTipo
        {
            get
            {
                return Tipo;
            }
            set
            {
                Tipo = value;
            }
        }

        public double pImporte
        {
            get
            {
                return Importe;
            }
            set
            {
                Importe = value;
            }
        }

        public string pNombreDepositador
        {
            get
            {
                return NombreDepositador;
            }
            set
            {
                NombreDepositador = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("\nTIPO: {0}\nIMPORTE: {1}\nDEPOSITADOR: {2}", Tipo, Importe, NombreDepositador);
            return str;
        }
    }
}