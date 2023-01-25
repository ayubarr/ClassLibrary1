using LibraryProject.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.CMD
{
    public static class ConsoleReader<T> 
    {
        public static T Read(string fieldName)
        {
            bool  isIncorrectDataEntered = true;

            while(isIncorrectDataEntered)
            {
                try
                {
                    T data = ReadData(fieldName);
                    isIncorrectDataEntered = false;
                    return data;
                }
                catch
                {
                    Console.WriteLine("An error while getting" +
                        " value recived. Pleacse enter data again");
                }
            }
            return default(T);
        }

        public static T ReadData(string fieldName)
        {
            if (typeof(string) == typeof(T))
            {
                return (T)(object)ConsoleHelper.GetStringFromConsole(fieldName);

                //string stringValue = ConsoleHelper.GetStringFromConsole(fieldName);
                //object objectValue = (object)stringValue;
                //T value = (T)objectValue;
                //return value;
            }
            if (typeof(int) == typeof(T))
            {
                return (T)(object)ConsoleHelper.GetIntFromConsole(fieldName);

                //int intValue = ConsoleHelper.GetIntFromConsole(fieldName);
                //object objectValue = (object)intValue;
                //T value = (T)objectValue;
                //return value;
            }
            if (typeof(DateTime) == typeof(T))
            {
                return (T)(object)ConsoleHelper.GetDataTimeFromConsole(fieldName);

                //DateTime dateTimeValue = ConsoleHelper.GetDataTimeFromConsole(fieldName);
                //object objectValue = (object)dateTimeValue;
                //T value = (T)objectValue;
                //return value;
            }
            if (typeof(Language) == typeof(T))
            {
                return (T)(object)GetLanguageFromConsole(fieldName);

                //Languege languegeValue = GetLanguageFromConsole(fieldName);
                //object objectValue = (object)languegeValue;
                //T value = (T)objectValue;
                //return value;
            }
            if (typeof(Genre) == typeof(T))
            {
                return (T)(object)GetGenreFromConsole(fieldName);
                
                //Genre genreValue = GetGenreFromConsole(fieldName);
                //object objectValue = (object)genreValue;
                //T value = (T)objectValue;
                //return value;
            }
            return default(T);
        }

        private static Language GetLanguageFromConsole(string fieldName)
        {
            Language languegeValue = (Language)ConsoleHelper
                .GetEnumNumberFromConsole(fieldName, typeof(Language));

            return languegeValue;
        }
        private static Genre GetGenreFromConsole(string fieldName)
        {
            Genre genreValue = (Genre)ConsoleHelper
                .GetEnumNumberFromConsole(fieldName, typeof(Genre));

            return genreValue;
        }
    }
}
