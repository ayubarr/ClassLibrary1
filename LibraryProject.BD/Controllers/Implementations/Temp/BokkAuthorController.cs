using LibraryProject.BL.Controllers.Interfaces;
using LibraryProject.Data.Models.Entities;

namespace LibraryProject.BL.Controllers.Implementations.Temp
{
    public class BookAuthorController : IBookAuthorController
    {
        private readonly IDBilable<Book> _bookController;
        private readonly IDBilable<Author> _authorController;
        public BookAuthorController(IDBilable<Book> bookController, IDBilable<Author> authorController)
        {
            _bookController = bookController;
            _authorController = authorController;
        }
        public void Link(List<Book> books, List<Author> author)
        {

        }
    }
}
