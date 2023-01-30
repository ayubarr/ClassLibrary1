
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Data.Models.Entities;
using LibraryProject.Data.Models.Enums;

namespace LibraryProject.Data
{
    public class TempTable<T>
    {
         public static List<T> Items = new List<T>();       
    }
}

 