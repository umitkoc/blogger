
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly BlogContext context;
        public AuthorRepo(BlogContext _context)
        {
            context = _context;
        }

        public Author Get()
        {
            return context.Set<Author>().FirstOrDefault();
        }

        public void Update(Author author)
        {
            context.Set<Author>().Update(author);
            context.SaveChanges();
        }
    }
}