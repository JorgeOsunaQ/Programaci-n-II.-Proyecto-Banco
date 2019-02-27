using System;
namespace ProyectoBancoP2
{
    public class NegociosMovimientos
    {
        ManejaMovimiento manejadoraM;
        ManejaCliente manejadoraCli;
        ManejaCuentas manejadoraCu;
        ManejaCatalogoCuenta manejadoraTipoC;

        public NegociosMovimientos(ManejaMovimiento manejaM,ManejaCliente manejaCli,ManejaCuentas manejaCu, ManejaCatalogoCuenta manejaTipo)
        {
            this.manejadoraM = manejaM;
            this.manejadoraCli = manejaCli;
            this.manejadoraCu = manejaCu;
            this.manejadoraTipoC = manejaTipo;
            Menu();
        }

        public void Menu()
        {
            int key = 0;

            do
            {
                if (manejadoraCu.Size() == 0)
                {
                    Console.WriteLine("\nNO SE TIENE REGISTRO DE NINGUNA CUENTA EN EL SISTEMA.");
                    return;
                }

                Console.WriteLine("\n----- MOVIMIENTOS -----");
                Console.WriteLine("INGRESE UNA OPCION");
                Console.WriteLine("1.- REALIZAR MOVIMIENTO\n2.- BUSCAR MOVIMIENTOS\n0.- SALIR");
                key = Validaciones.LeerInt();
                switch (key)
                {
                    case 1:
                        int keyM=0;
                        do
                        {
                            Console.WriteLine("\nINGRESE EL TIPO DE MOVIMIENTO QUE DESEA ");
                            Console.WriteLine("1.-DEPOSITO\n2.-RETIRO\n0.-SALIR");
                            keyM = Validaciones.LeerInt();

                            switch (keyM)
                            {
                                case 1:
                                    RealizarDeposito();
                                    break;
                                case 2:
                                    RealizarRetiro();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("\nOPCIÓN NO DISPONIBLE.");
                                    break;
                            }

                        } while (keyM!=0);
                        break;
                    case 2:
                        ConsultaMovimientos();
                        break;
                    default:
                        Console.WriteLine("\nOPCIÓN NO DISPONIBLE.");
                        break;
                }
            } while (key != 0);

        }

        public void RealizarDeposito()
        {
            int claveC;
            double cant;
            string nom;
            Cuenta temp;

            Console.WriteLine("\n- DEPOSITAR-");
            do
            {
                Console.WriteLine("\nINGRESE LA CLAVE DE LA CUENTA A LA CUÁL DESEA REALIZAR EL DEPOSITO.");
                claveC = Validaciones.LeerInt();

                temp = manejadoraCu.BuscarCuenta(claveC);

                if (temp==null)
                {
                    Console.WriteLine("NO EXISTE UNA CUENTA ASOCIADA A LA CLAVE QUE PROPORCIONÓ. INTENTELO NUEVAMENTE.");
                }

            } while (temp==null);

            do
            {
                Console.WriteLine("INGRESE LA CANTIDAD A DEPOSITAR EN LA CUENTA.");
                cant = Validaciones.LeerDouble();

                if (cant < 0)
                {
                    Console.WriteLine("NO SE PUEDE DEPOSITAR UNA CANTIDAD MENOR O IGUAL A 0 EN UNA CUENTA.");
                }

            } while (cant<=0);

            Console.WriteLine("\nINGRESE EL NOMBRE DEL DEPOSITANTE.");
            nom = Validaciones.LeerString();

            if (manejadoraM.Deposito(cant, claveC, nom))
            {
                Console.WriteLine("DEPOSITO REALIZADO CON ÉXITO.");
            }
        }

        public void RealizarRetiro()
        {
            int claveC;
            double cant;
            string nom;
            Cuenta temp;

            Console.WriteLine("\n- RETIRAR-");
            do
            {
                Console.WriteLine("\nINGRESE LA CLAVE DE LA CUENTA DE LA CUÁL DESEA REALIZAR EL RETIRO.");
                claveC = Validaciones.LeerInt();

                temp = manejadoraCu.BuscarCuenta(claveC);

                if (temp == null)
                {
                    Console.WriteLine("NO EXISTE UNA CUENTA ASOCIADA A LA CLAVE QUE PROPORCIONÓ. INTENTELO NUEVAMENTE.");
                }

            } while (temp == null);

            do
            {
                Console.WriteLine("\nINGRESE EL NOMBRE DE LA PERSONA QUE REALIZA EL RETIRO.");
                nom = Validaciones.LeerString();

                if (manejadoraCli.KeyCliente(nom.ToUpper()) != temp.pClaveCliente)
                {
                    Console.WriteLine("EL NOMBRE DEL CLIENTE NO COINCIDE CON EL PROPIETARIO DE LA CUENTA.");
                }

            } while (manejadoraCli.KeyCliente(nom.ToUpper()) != temp.pClaveCliente);

            do
            {
                if (temp.pSaldo.Equals(manejadoraTipoC.consulta(temp.pNombre).pMontoMinimo))
                {
                    Console.WriteLine("EL SALDO DE LA CUENTA ES IGUAL AL MONTO MINIMO DE LA MISMA. NO PUEDE REALIZAR NINGUN RETIRO.");
                    return;
                }

                Console.WriteLine("INGRESE LA CANTIDAD A RETIRAR DE LA CUENTA.");
                cant = Validaciones.LeerDouble();

                if (cant < 0)
                {
                    Console.WriteLine("NO SE PUEDE DEPOSITAR UNA CANTIDAD MENOR O IGUAL A 0 EN UNA CUENTA.");
                }

                if (temp.pSaldo - cant < manejadoraTipoC.consulta(temp.pNombre).pMontoMinimo)
                {
                    Console.WriteLine("LA CANTIDAD A RETIRAR SOBREPASA EL MONTO MINIMO DE LA CUENTA.");
                }
            } while (cant <= 0 || temp.pSaldo-cant<manejadoraTipoC.consulta(temp.pNombre).pMontoMinimo);

            if (manejadoraM.Retiro(cant,claveC,nom))
            {
                Console.WriteLine("\nRETIRO REALIZADO CON ÉXITO.");
            }
        }

        public void ConsultaMovimientos()
        {
            int claveC;
            Cuenta temp;

            Console.WriteLine("\n- CONSULTAR MOVIMIENTOS-");
            do
            {
                Console.WriteLine("\nINGRESE LA CLAVE DE LA CUENTA DE LA CUÁL DESEA OBTENER INFORMACIÓN.");
                claveC = Validaciones.LeerInt();

                temp = manejadoraCu.BuscarCuenta(claveC);

                if (temp == null)
                {
                    Console.WriteLine("NO EXISTE UNA CUENTA ASOCIADA A LA CLAVE QUE PROPORCIONÓ. INTENTELO NUEVAMENTE.");
                }

            } while (temp == null);

            Console.WriteLine("\n-INFORMACIÓN DEL CLIENTE-.");
            Console.WriteLine(manejadoraCli.Consulta(temp.pClaveCliente));

            Console.WriteLine("\n-INFORMACIÓN DE LA CUENTA-.");
            Console.WriteLine(temp);

            Console.WriteLine("\nMOVIMIENTOS REALIZADOS DENTRO DE LA CUENTA.");
            Console.WriteLine(manejadoraM.ImprimirPorCuenta(claveC));
        }

    }
}
