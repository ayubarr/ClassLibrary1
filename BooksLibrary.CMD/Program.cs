using LibraryProject.CMD;
using LibraryProject.Data.Models.Entities;
using LibraryProject.Data.Models.Enums;

Console.WriteLine("Hello, World!");
Console.WriteLine("Let\'s create a book!");

Console.ReadKey();

static Book GetBookFromConsole()
{
    #region Get book data
    string bookName = ConsoleReader<string>.Read("book name");
    string shortDesc = ConsoleReader<string>.Read("short description");
    DateTime releasedDate = ConsoleReader<DateTime>
        .Read($"Release date in format {ConsoleConstants.DatePattern}");
    Languege lang = ConsoleReader<Languege>.Read("languege number");
    Genre genre = ConsoleReader<Genre>.Read("Genre number");
    int countofAvaible = ConsoleReader<int>.Read("books count");
    #endregion

    #region Create new book
    Book book = new Book()
    {
        Name = bookName,
        ShortDesc = shortDesc,
        Released = releasedDate,
        Langueges = lang,
        Genres = genre,
        CountAvailable = countofAvaible,
    };
    #endregion


    return book;
}