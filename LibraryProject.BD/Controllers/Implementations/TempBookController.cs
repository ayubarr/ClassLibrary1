using LibraryProject.BL.Controllers.Interfaces;
using LibraryProject.Data;
using LibraryProject.Data.Models.Entities;

namespace LibraryProject.BL.Controllers.Implementations
{
    public class TempBookController : IBookController
    {
        public void AddBook(Book book)
        {
            TempDb.Books.Add(book);
        }
        public List<Book> GetAll()
        {
            return TempDb.Books;
        }
        public void Update(Book oldBook, Book newBook)
        {
            int index = TempDb.Books.IndexOf(oldBook);

            if (index == -1)
            {
                throw new ArgumentException("Book not found");
            }

            TempDb.Books[index] = newBook;
        }

        public void delete(Book book)
        {
            TempDb.Books.Remove(book);
        }
    }
}
