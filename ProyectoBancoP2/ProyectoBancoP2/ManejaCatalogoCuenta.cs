using System;
namespace ProyectoBancoP2
{
    public class ManejaCatalogoCuenta
    {
        TipoCuenta[] catalogo;

        public ManejaCatalogoCuenta()
        {
            catalogo = new TipoCuenta[10];
            agregaBase();
        }

        private void agregaBase()
        {
            catalogo[0] = new TipoCuenta("DIGITAL",10000,"PRIVILEGIOS BASICOS. NO INCLUYE TARJETA FISICA");
            catalogo[1] = new TipoCuenta("BASICA",4000,"REQUIERE SALDO MINIMO");
            catalogo[2] = new TipoCuenta("NOMINA",0,"DEPOSITOS DE NOMINA");
        }

        public string imprimir()
        {
            string str = "";
            foreach (TipoCuenta item in catalogo)
            {
                if (item!=null)
                {
                    str = item+"\n";
                }
            }
            return str;
        }
    }
}
