using LibraryProject.Data.Models.Common;
using LibraryProject.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.BL.Controllers.Interfaces
{
    public interface IDBilable<T> where T : BaseEntity
    {
        public void Add(T item);                 // C
        public List<T> GetAll();                     // R
        public void Update(T oldItem, T newItem);    // U
        public void Delete(T item); //D
    }
}
