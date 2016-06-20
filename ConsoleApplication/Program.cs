using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new BooksModel())
            {
                var book = new Book
                {
                    Name = "Hamlet",
                    Author = new Author { Name = "William Shakespeare" }
                };

                db.Books.Add(book);
                db.SaveChanges();
            }
        }
    }
}