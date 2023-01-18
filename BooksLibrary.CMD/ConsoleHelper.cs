using ClassLibrary1.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.CMD
{
    public static class ConsoleHelper
    {
        public static string GetStringFromConsole(string fieldName)
        {
            Console.WriteLine($"Please enter {fieldName}");
            string value = Console.ReadLine();
            return value;
        }

        public static int GetIntFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName);
            return int.Parse(value);
        }

        public static DateTime GetDataTimeFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName) ;
            return DateTime.ParseExact(value, ConsoleConstants.DatePattern, null);
        }

        public static Languege GetEnumNumber(string fieldName)
        {
            const int indexDif = 1;
            string[] enumValues = Enum.GetNames(typeof(Languege));
            int i = 0;
            foreach (string enumValue in enumValues) 
            {
                Console.WriteLine($"{i + indexDif} {enumValue}");
                i++;
            }

            int number = GetIntFromConsole(fieldName) - indexDif;

            return (Languege)number;
        }
    }

}
