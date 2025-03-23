using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Utils
{
    public class Validations
    {
        public static string ValidateString(string str)
        {
            while (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("El valor ingresado no puede estar vacío. Inténtelo de nuevo.");
                str = Console.ReadLine();
            }
            return str;
        }

        public static DateTime ValidateDate(string dateInput)
        {
            DateTime parsedDate;
            while (string.IsNullOrWhiteSpace(dateInput) || !DateTime.TryParse(dateInput, out parsedDate))
            {
                Console.WriteLine("El valor ingresado no es una fecha válida. Inténtelo de nuevo (Formato: dd/mm/yyyy):");
                dateInput = Console.ReadLine();
            }
            return parsedDate;
        }

        public static string ValidatePhoneNumber(string phoneNumber)
        {
            while (string.IsNullOrWhiteSpace(phoneNumber) || !phoneNumber.All(char.IsDigit) || phoneNumber.Length != 10)
            {
                Console.WriteLine("El número de celular no es válido. Debe contener exactamente 10 dígitos numéricos. Inténtelo de nuevo:");
                phoneNumber = Console.ReadLine();
            }
            return phoneNumber;
        }
        public static int ValidateInt(string str)
        {
            int resultado;
            while (!int.TryParse(str, out resultado) || resultado <= 0)
            {
                Console.WriteLine("El valor ingresado no es un número entero válido. Inténtelo de nuevo.");
                str = Console.ReadLine();
            }
            return resultado;
        }

    }
}
