namespace _05.BookLibrary
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Collections.Generic;
    class BookLibrary
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library lib = new Library("New library");

            //the title, author, publisher, release date, ISBN-number and price. 
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = input[4];
                decimal price = decimal.Parse(input[5]);
                Book book = new Book(title, author, publisher, releaseDate, isbn, price);
                lib.ListOfBooks.Add(book);
            }

            Dictionary<string, List<Book>> listByAuthors = new Dictionary<string, List<Book>>();

            foreach (var book in lib.ListOfBooks)
            {
                if (!listByAuthors.ContainsKey(book.Author))
                {
                    listByAuthors.Add(book.Author,new List<Book>());
                }

                listByAuthors[book.Author].Add(book); 
            }
            var sorted = listByAuthors.Select(b => b.Value.OrderBy(k => k.ReleaseDate).ThenBy(k => k.Title));
            DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var authorEntry in sorted )
            {
                foreach (var book in authorEntry)
                {
                    if (book.ReleaseDate > currentDate)
                    {
                        Console.WriteLine($"{book.Title} -> {book.ReleaseDate}");
                    }
                }
               
            }
                
        }
    }
}
