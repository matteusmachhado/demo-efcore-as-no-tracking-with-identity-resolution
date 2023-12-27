using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Entities
{
    public class Book : Entity
    {
        public Book(string name) 
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        protected Book() { }

        public string Name {  get; private set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        public void AddGender(Gender gender)
        {
            Gender = gender;
        }
    }
}
