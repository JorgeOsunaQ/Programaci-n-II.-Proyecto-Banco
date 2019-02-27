using System;
namespace ProyectoBancoP2
{
    public class NegociosCuentasBanco
    {

        ManejaCatalogoCuenta manejaCatalogoCuenta;

        public NegociosCuentasBanco(ManejaCatalogoCuenta manejaCatalogoCuenta)
        {
            this.manejaCatalogoCuenta = manejaCatalogoCuenta;
            Menu();
        }

        public void Menu()
        {
            int key;
            do
            {
                Console.WriteLine("\n----- CUENTAS BANCO -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- CREAR CUENTA\n2.- BUSCAR CUENTA\n3.- IMPRIMIR\n0.- SALIR");
                key = Validaciones.LeerInt();
                switch (key)
                {
                    case 1:
                        CrearCuenta();
                        Console.WriteLine("CUENTA CREADA");
                        break;
                    case 2:
                        if (manejaCatalogoCuenta.Count() > 0) { Buscar(); }
                        else { Console.WriteLine("NO HAY CUENTAS CREADAS."); }
                        break;
                    case 3:
                        Imprimir();
                        break;
                    default:
                        break;
                }
            } while (key != 0);

        }

        // CREA TIPO DE CUENTA
        public void CrearCuenta()
        {
            string Nombre, Descripcion;
            double MontoMinimo;
            Console.WriteLine("- AGREGA CUENTA BANCO -");
            Console.WriteLine("INGRESE EL NOMBRE");
            Nombre = Validaciones.LeerString();
            do
            {
                Console.WriteLine("INGRESE EL MONTO MINIMO");
                MontoMinimo = Validaciones.LeerDouble();
            } while (MontoMinimo < 0);
            Console.WriteLine("INGRESE LA DESCRIPCION");
            Descripcion = Validaciones.LeerString();
            manejaCatalogoCuenta.agrega(Nombre, MontoMinimo, Descripcion);
        }

        // BUSCA TIPO CUENTA
        public void Buscar()
        {
            string NombreB;
            Console.WriteLine("- BUSCAR CUENTA -");
            do
            {
                Console.WriteLine("INGRESE EL NOMBRE");
                NombreB = Validaciones.LeerString();
            } while (manejaCatalogoCuenta.consulta(NombreB) == null);
            Console.WriteLine(manejaCatalogoCuenta.consulta(NombreB));
        }

        // IMPRIME LAS CUENTAS
        public void Imprimir()
        {
            if (manejaCatalogoCuenta.Count() > 0)
            {
                Console.WriteLine(manejaCatalogoCuenta);
                Console.WriteLine("SE TIENE UN TOTAL DE " + manejaCatalogoCuenta.Count() + " TIPOS DE CUENTAS");
            }
            else { Console.WriteLine("NO HAY CUENTAS CREADAS."); }
        }
    }
}
