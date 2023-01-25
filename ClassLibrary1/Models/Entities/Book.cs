using LibraryProject.Data.Models.Common;
using LibraryProject.Data.Models.Enums;

namespace LibraryProject.Data.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public int CountAvailable { get; set; }
        public bool IsAvailable => CountAvailable > 0;
        public DateTime Released { get; set; }

        public List<Author> Authors { get; set; }
        public Genre Genres { get; set; }
        public Language Languages { get; set; }
    }
}
