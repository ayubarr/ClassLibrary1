using ClassLibrary1.Data.Models.Enums;
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
                    Console.WriteLine("An error while getting  value recived. Pleacse enter data again");
                }
            }
            return default(T);
     


        }
        public static T ReadData(string fieldName)
        {
            if (typeof(string) == typeof(T))
            {
                string stringValue = ConsoleHelper.GetStringFromConsole(fieldName);
                object objectValue = (object)stringValue;
                T value = (T)objectValue;

                return value;

                //return (T)(object)ConsoleHelper.GetStringFromConsole(fieldName);
            }
            if (typeof(int) == typeof(T))
            {
                int intValue = ConsoleHelper.GetIntFromConsole(fieldName);
                object objectValue = (object)intValue;
                T value = (T)objectValue;

                return value;

                //return (T)(object)ConsoleHelper.GetIntFromConsole(fieldName);
            }
            if(typeof(DateTime) == typeof(T))
            {
                DateTime dateTimeValue = ConsoleHelper.GetDataTimeFromConsole(fieldName);
                object objectValue = (object)dateTimeValue;
                T value = (T)objectValue;

                return value;

               // return (T)(object)ConsoleHelper.GetDataTimeFromConsole(fieldName);
            }
            if(typeof(Languege) == typeof(T))
            {
                Languege languegeValue = ConsoleHelper.GetEnumNumber(fieldName);
                object objectValue = (object)languegeValue;
                T value = (T)objectValue;

                return value;

              // return (T)(object)ConsoleHelper.GetLanguegeFromConsole(fieldName);
            }
            return default(T);
        }
    }
}
