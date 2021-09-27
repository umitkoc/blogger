using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    
    
    public class AuthorService : IAuthorService
    {
        IAuthorRepo _author;

        public AuthorService(IAuthorRepo repo)
        {
            _author = repo;
        }

        public Author Get()
        {
           return _author.Get();
        }

        public void Update(Author author)
        {
            _author.Update(author);
        }
    }
}