using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Entities
{
    public class Author : Entity
    {
        public Author(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Books = new List<Book>();
        }

        protected Author() { }

        public string Name { get; private set; }
        public ICollection<Book> Books { get; private set; }

        public void AddBook(Book book) 
        {
            Books.Add(book);
        }
    }
}
