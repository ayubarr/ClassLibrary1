using ClassLibrary1.Data.Models.Common;
using ClassLibrary1.Data.Models.Enums;



namespace ClassLibrary1.Data.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public int CountAvailable { get; set; }
        public bool IsAvailable => CountAvailable > 0;
        public DateTime Released { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> genres { get; set; }
        public List<Languege> langues { get; set; }
    }
}
