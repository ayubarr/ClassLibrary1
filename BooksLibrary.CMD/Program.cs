using ClassLibrary1.Data.Models.Entities;
using ClassLibrary1.Data.Models.Enums;
using LibraryProject.CMD;


Console.WriteLine("Hello, World!");
Console.WriteLine("Let\'s create a book!");

Languege lang = ConsoleReader<Languege>.Read("languege number");

DateTime releasedDate = ConsoleReader<DateTime>
    .Read($"Release date in format {ConsoleConstants.DatePattern}");

string bookName = ConsoleReader<string>.Read("book name");
string shortDesc = ConsoleReader<string>.Read("short description");

int countofAvaible = ConsoleReader<int>.Read("books count");
int publishingYear = ConsoleReader<int>.Read("publishing year");
Book book = new Book();
Console.ReadKey();
