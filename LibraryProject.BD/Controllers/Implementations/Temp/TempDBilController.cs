using LibraryProject.BL.Controllers.Interfaces;
using LibraryProject.Data;
using LibraryProject.Data.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LibraryProject.BL.Controllers.Implementations.Temp
{
    public class TempDBilController<T> : IDBilable<T> where T : BaseEntity
    {
        public void Add(T item)
        {
            TempTable<T>.Items.Add(item);
        }

        public void Delete(T item)
        {
            TempTable<T>.Items.Remove(item);

        }

        public List<T> GetAll()
        {
            return TempTable<T>.Items;
        }

        public void Update(T oldItem, T newItem)
        {
            int index = TempTable<T>.Items.IndexOf(oldItem);

            if(index == -1)
            {
                throw new ArgumentException($"{typeof(T).Name} wasn't found");
            }
            TempTable<T>.Items[index] = newItem;
        }
    }
}
