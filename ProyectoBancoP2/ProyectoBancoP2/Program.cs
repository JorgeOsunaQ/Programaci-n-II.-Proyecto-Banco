using System;

namespace ProyectoBancoP2
{
    // preguntar modificar, tipos cuenta


    class Program
    {

        public static void Main()
        {
            //Pruebalo
            while (true)
            {
                Console.WriteLine("Ingrese número de télefono");
                string tel = Console.ReadLine();
                Console.WriteLine(Validaciones.ValidaTelefono(tel));
                Console.ReadKey();
            }
        }
    }
}
