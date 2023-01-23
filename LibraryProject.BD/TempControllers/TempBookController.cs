


using LibraryProject.Data.Models.Entities;

namespace LibraryProject.BL.TempControllers
{
    public class TempBookController
    {
        public void AddBook(Book book)
        {
            TempDb.Add(book);
        }
        public List<Book> GetAll()
        {
            return TempDb.Books;
        }
    }
}
