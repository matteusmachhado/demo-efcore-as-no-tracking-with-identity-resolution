
namespace Demo.Domain.Entities
{
    public class Gender : Entity
    {
        public Gender(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        protected Gender()
        {
            
        }

        public string Name { get; private set; }
        public ICollection<Book> Books { get; private set; }
    }
}
