using LibraryProject.Data.Models.Entities;
using LibraryProject.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryProject.Data
{
    public static class TempDb
    {
        public static void Seed()
        {
            if (TempTable<Book>.Items.Any() || TempTable<Author>.Items.Any())
                return;

            TempTable<Book>.Items.Add(new Book()
            {
                Name = "White fang",
                ShortDesc = "Cool book",
                Released = DateTime.Now,
                Languages = Language.Russian,
                Genres = Genre.Fury,
                CountAvailable = 100,
            });
            TempTable<Book>.Items.Add(new Book()
            {
                Name = "Apendi",
                ShortDesc = "Funny book",
                Released = DateTime.Now,
                Languages = Language.Kyrgyz,
                Genres = Genre.Yaoi,
                CountAvailable = 50,

            });
            TempTable<Author>.Items.Add(new Author()
            {
                FirstName = "Jack",
                LastName = "London",
                Popularity = 50,
            });
        }
    }
}
