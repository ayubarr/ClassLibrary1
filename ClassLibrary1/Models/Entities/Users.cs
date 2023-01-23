using LibraryProject.Data.Models.Common;

namespace LibraryProject.Data.Models.Entities
{
    public class Users : Person
    {

        public List<Book> books { get; set; }
    }
}
