using System;
namespace ProyectoBancoP2
{
    public class Validaciones
    {

        public static int leerInt()
        {
            int value;
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                value = int.MinValue;
            }
            return value;
        }

        public static double leerDouble()
        {
            double value;
            try
            {
                value = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                value = int.MinValue;
            }
            return value;
        }

        public static string leerString()
        {
            string value;
            do
            {
                value = Console.ReadLine();
            } while (string.IsNullOrEmpty(value));
            return value;
        }

        // formato telefono, lectura de datos

    }
}
