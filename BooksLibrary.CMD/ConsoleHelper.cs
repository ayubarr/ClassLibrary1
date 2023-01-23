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
        private static void PrintEnumWithIndexes(Type enumType, int indexDif)
        {
            string[] enumValues = Enum.GetNames(enumType);
            int i = 0;
            foreach (string enumValue in enumValues)
            {
                Console.WriteLine($"{i + indexDif} {enumValue}");
                i++;
            }
        }
        public static int GetEnumNumberFromConsole(string fieldName, Type enumType)
        {
            const int indexDif = 1;
            PrintEnumWithIndexes(enumType, indexDif);

            int number = GetIntFromConsole(fieldName) - indexDif;
            return number;
        }
    }

}
