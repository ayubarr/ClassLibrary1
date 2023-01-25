using LibraryProject.BL.Controllers.Implementations;
using LibraryProject.BL.Controllers.Interfaces;
using LibraryProject.CMD;
using LibraryProject.Data.Models.Entities;
using LibraryProject.Data.Models.Enums;

IBookController bookController = new TempBookController();

Console.WriteLine("Hello, World!");

Book book = GetBookFromConsole();

bookController.AddBook(book);

List<Book> bookList = bookController.GetAll();

Console.ReadKey();

static Book GetBookFromConsole()
{
    #region Get book data
    string bookName = ConsoleReader<string>.Read("book name");
    string shortDesc = ConsoleReader<string>.Read("short description");
    DateTime releasedDate = ConsoleReader<DateTime>
        .Read($"Release date in format {ConsoleConstants.DatePattern}");
    Language lang = ConsoleReader<Language>.Read("languege number");
    Genre genre = ConsoleReader<Genre>.Read("Genre number");
    int countofAvaible = ConsoleReader<int>.Read("books count");
    #endregion

    #region Create new book
    Book book = new Book()
    {
        Name = bookName,
        ShortDesc = shortDesc,
        Released = releasedDate,
        Languages = lang,
        Genres = genre,
        CountAvailable = countofAvaible,
    };
    #endregion


    return book;
}