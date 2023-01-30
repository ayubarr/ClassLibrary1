using LibraryProject.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.BL.Controllers.Interfaces
{
    public interface IBookAuthorController
    {
        public void Link(List<Book> books, List<Author> author);
    }
}
