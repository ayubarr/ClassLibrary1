using ClassLibrary1.Data.Models.Common;

namespace ClassLibrary1.Data.Models.Entities
{
    public class Users : Person
    {

        public List<Book> books { get; set; }
    }
}
