using System;
namespace ProyectoBancoP2
{
    public class LecturaGenerica
    {
        public LecturaGenerica()
        {
        }

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
    }
}
