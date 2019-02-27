using System;
namespace ProyectoBancoP2
{
    public class NegociosCuentas
    {
        ManejaCuentas manejadoraC;
        ManejaCliente manejadoraCli;
        ManejaCatalogoCuenta manejaTipoC;

        public NegociosCuentas(ManejaCuentas manejaCu,ManejaCliente manejaCli,ManejaCatalogoCuenta manejadoraCatalogo)
        {
            this.manejadoraC = manejaCu;
            this.manejadoraCli = manejaCli;
            this.manejaTipoC = manejadoraCatalogo;
            Menu();
        }

        public void Menu()
        {

            int key;
            do
            {
                Console.WriteLine("\n----- CUENTAS CLIENTES-----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- APERTURAR CUENTA\n2.- CERRAR CUENTA\n0.- SALIR");
                key = Validaciones.LeerInt();
                switch (key)
                {
                    case 1:
                        Apertura();
                        break;
                    case 2:
                        CerrarCuenta();
                        break;
                    default:
                        Console.WriteLine("\nOPCIÓN NO DISPONIBLE.");
                        break;
                }
            } while (key != 0);
        }

        public void Apertura()
        {
            if (manejadoraCli.Count() == 0)
            {
                Console.WriteLine("\nNO SE TIENE REGISTRO DE NINGÚN CLIENTE EN EL SISTEMA.");
                return;
            }
            int claveCliente, clave;
            string tipoCuenta;
            double saldoI;
            TipoCuenta temp = null;

            Console.WriteLine("\n- APERTURAR CUENTA-");
            do
            {
                Console.WriteLine("\nINGRESE LA CLAVE DEL CLIENTE A LA QUE QUIERE ASOCIAR LA CUENTA.");
                claveCliente = Validaciones.LeerInt();

                if (manejadoraCli.Existe(claveCliente) == false)
                {
                    Console.WriteLine("NO EXISTE EL CLIENTE AL QUE DESEA ASOCIAR A LA CUENTA.");
                }

            } while (manejadoraCli.Existe(claveCliente) == false || claveCliente<0);

            do {
                Console.WriteLine("\nINGRESE LA CLAVE QUE DESEA ASIGNARLE A LA CUENTA BANCARIA.");
                clave = Validaciones.LeerInt();

                if (manejadoraC.BuscarCuenta(clave) != null)
                {
                    Console.WriteLine("YA SE HA ASOCIADO A UNA CUENTA CON LA CLAVE PROPORCIONADA.");
                }
            } while (manejadoraC.BuscarCuenta(clave) != null);

            Console.WriteLine(manejaTipoC);

            do {
                Console.WriteLine("INGRESE EL TIPO DE CUENTA QUE DESEA AGREGAR.");
                tipoCuenta = Validaciones.LeerString();

                temp = manejaTipoC.consulta(tipoCuenta.ToUpper());

                if ((temp) == null)
                {
                    Console.WriteLine("ESTE TIPO DE CUENTA ES INEXISTENTE.");
                    return;
                }
            } while ((temp) == null);

            do
            {
                Console.WriteLine("\nINGRESE UN SALDO INICIAL PARA APERTURAR LA CUENTA.");
                saldoI = Validaciones.LeerDouble();

                if (saldoI < temp.pMontoMinimo)
                {
                    Console.WriteLine("EL SALDO MINIMO PARA ESTA TIPO DE CUENTA ES DE {0,-2:C}", temp.pMontoMinimo);
                }
            } while (saldoI < temp.pMontoMinimo);

            if(manejadoraC.Agrega(clave, claveCliente, saldoI, tipoCuenta)){
                Console.WriteLine("\nCUENTA APERTURADA CON EXITO");
            }
        }

        public void CerrarCuenta()
        {
            int clave;
            string nomCliente;

            if (manejadoraC.Size() == 0)
            {
                Console.WriteLine("\nNO SE TIENE REGISTRO DE NINGUNA CUENTA EN EL SISTEMA.");
                return;
            }

            Console.WriteLine("\n- CERRAR CUENTA-");
            do{
                Console.WriteLine("\nINGRESE LA CLAVE DE LA CUENTA QUE DESEA CERRAR");
                clave = Validaciones.LeerInt();

            
                if (manejadoraC.BuscarCuenta(clave) == null)
                {
                    Console.WriteLine("NO EXISTE LA CUENTA QUE DESEA CERRAR.");
                }
            } while (manejadoraC.BuscarCuenta(clave) == null);

            Console.WriteLine("\nINGRESE EL NOMBRE DEL CLIENTE A QUIÉN LE PERTENECE LA CUENTA.");
            nomCliente = Validaciones.LeerString();

            if (manejadoraCli.KeyCliente(nomCliente) == -1)
            {
                Console.WriteLine("NO EXISTE NINGÚN CLIENTE REGISTRADO CON ESE NOMBRE.");
                return;
            }

            if (manejadoraC.BuscarCuenta(clave).pClaveCliente != manejadoraCli.KeyCliente(nomCliente))
            {
                Console.WriteLine("EL NOMBRE DEL CLIENTE NO COINCIDE CON EL QUE ESTÁ ASOCIADO A LA CUENTA.");
                return;
            }

            manejadoraC.EliminarCuenta(clave);
            Console.WriteLine("LA CUENTA DE CLAVE {0,-2:D4} HA SIDO ELIMINADA DEL SISTEMA.",clave);
        }
    }
}
