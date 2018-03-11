using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> myBook = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDay = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = input[4];
                book.Price = double.Parse(input[5]);

                myBook.Add(book);

            }

            DateTime finalDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library myLibrary = new Library();
            myLibrary.Books = myBook;

            foreach (var book in myLibrary.Books.Where(x =>x.ReleaseDay>finalDate).OrderBy(x=>x.ReleaseDay).ThenBy(x=>x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDay.ToString("dd.MM.yyyy")}");
            }


        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDay { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public List<Book> Books { get; set; }
        public string Name { get; set; }
    }
}
