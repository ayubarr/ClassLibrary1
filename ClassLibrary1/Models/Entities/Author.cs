using LibraryProject.Data.Models.Common;

namespace LibraryProject.Data.Models.Entities
{
    public class Author : Person
    {
        public List<Book> WrittenBooks { get; set; }
        public int Popularity { get; set; }
    }
}
