using System;
namespace ProyectoBancoP2
{
    public class ManejaCatalogoCuenta
    {

        private TipoCuenta[] catalogo;
        int pos=0;

        public ManejaCatalogoCuenta()
        {
            catalogo = new TipoCuenta[10];
            agregaBase();
        }

        public TipoCuenta[] pTipoCuenta
        {
            get { return catalogo; }
        }

        private void agregaBase()
        {
            agrega("DIGITAL",10000,"PRIVILEGIOS BASICOS. NO INCLUYE TARJETA FISICA");
            agrega("BASICA",4000,"REQUIERE SALDO MINIMO");
            agrega("NOMINA",0,"DEPOSITOS DE NOMINA");
        }

        public void agrega(string Nombre, double MontoMinimo, string Descripcion)
        {
            catalogo[pos] = new TipoCuenta(Nombre, MontoMinimo, Descripcion);
            pos++;
        }

        public int posTipoCuenta(string Nombre)
        {
            int posTC=-1;
            for (int i = 0; i < pos; i++)
            {
                if (catalogo[i]!=null)
                {
                    if (catalogo[i].pNombre.Equals(Nombre))
                    {
                        posTC = i;
                    }
                }
            }
            return posTC;
        }

        public void elimina(string Nombre)
        {
            for (int i = 0; i < pos; i++)
            {
                if (catalogo[i] != null)
                {
                    if (catalogo[i].pNombre.Equals(Nombre))
                    {
                        catalogo[i] = null;
                    }
                }
            }
        }

        public override string ToString()
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
