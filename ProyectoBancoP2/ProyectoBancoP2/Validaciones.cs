using System;
using System.Text.RegularExpressions;

namespace ProyectoBancoP2
{
    public class Validaciones
    {

        public static int LeerInt()
        {
            int value;
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                value = int.MinValue;
            }
            return value;
        }

        public static double LeerDouble()
        {
            double value;
            try
            {
                value = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                value = int.MinValue;
            }
            return value;
        }

        public static string LeerString()
        {
            string value;
            do
            {
                value = Console.ReadLine();
            } while (string.IsNullOrEmpty(value));
            return value;
        }

        public static bool ValidaTelefono(string value)
        {
            Regex regex = new Regex(@"^((\+[52]{2}(\s|\-)?)?(((\(\d{3}\))|(\d{3}))((\s|\-)?(\d{3}))((\s|\-)?(\d{2})){2}))$");
            Match match = regex.Match(value);
            if (match.Success)
                return true;
            else
                return false;
        }

    }
}
