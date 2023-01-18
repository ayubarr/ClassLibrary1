using ClassLibrary1.Data.Models.Common;
namespace ClassLibrary1.Data.Models.Entities
{
    public class Author : Person
    {
        public List<Book> WrittenBooks { get; set; }
        public int Popularity { get; set; }
    }
}
