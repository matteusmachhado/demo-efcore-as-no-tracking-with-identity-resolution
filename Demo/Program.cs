using Demo.Data;
using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //Setup();
            //SearchTracking();
            //SearchAsNoTracking();
            //SearchAsNoTrackingWithIdentityResolution();
            
            Console.ReadKey();
        }

        static void SearchTracking()
        {
            using (var context = new DemoContext())
            {
                var books = context.Books
                    .Include(x => x.Author)
                    .ToList();
            }
        }
        static void SearchAsNoTracking()
        {
            using (var context = new DemoContext())
            {
                var books = context.Books
                    .Include(x => x.Author)
                    .AsNoTracking()
                    .ToList();
            }
        }

        static void SearchAsNoTrackingWithIdentityResolution()
        {
            using (var context = new DemoContext())
            {
                var books = context.Books
                    .Include(x => x.Author)
                    .AsNoTrackingWithIdentityResolution()
                    .ToList();
            }
        }

        static void Setup()
        {
            using (var context = new DemoContext())
            {
                var gender1 = new Gender("Ficção científica");
                var gender2 = new Gender("Fantasia");

                var author1 = new Author("Christopher Nolan");

                foreach (var index in Enumerable.Range(1, 100))
                {
                    var book = new Book($"Livro {index}");
                    book.AddGender(gender1);

                    author1.AddBook(book);
                }

                var author2 = new Author("J. K. Rowling");

                foreach (var index in Enumerable.Range(1, 100))
                {
                    var book = new Book($"Livro {index}");
                    book.AddGender(gender2);

                    author2.AddBook(book);
                }

                context.Authors.Add(author1);
                context.Authors.Add(author2);

                context.SaveChanges();
            }
        }
    }
}
