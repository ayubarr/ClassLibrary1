using LibraryProject.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.BL.Controllers.Interfaces
{
    public interface IBookController
    {
        public void AddBook(Book book);                 // C
        public List<Book> GetAll();                     // R
        public void Update(Book oldBook, Book newBook); // U
        public void delete(Book book);                  // D
    }
}
