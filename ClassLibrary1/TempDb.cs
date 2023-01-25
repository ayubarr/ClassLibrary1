using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Data.Models.Entities;
using LibraryProject.Data.Models.Enums;

namespace LibraryProject.Data
{
    public class TempDb
    {
        public static List<Book> Books { get; set; }
        public static List<Author> Authors { get; set; }

        public static void Init()
        {
            if (Books.Any() || Authors.Any())
                return;

            Books.Add(new Book()
            {
                Name = "White fang",
                ShortDesc = "Cool book",
                Released = DateTime.Now,
                Languages = Languages.Russian,
                Genres = Genre.Furry,
                CountAvailable = 100
            });

            Books.Add(new Book()
            {
                Name = "Apendi",
                ShortDesc = "Funny book",
                Released = DateTime.Now,
                Languages = Language.Kyrgyz,
                Genres = Genre.Yaoi,
                CountAvailable = 50
            });

            Authors.Add(new Author()
            {
                FirstName = "Jack",
                LastName = "London",
                Popularity = 50,
            });
        }
    }
}
