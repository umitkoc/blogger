using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class AuthorService : IAuthorService
    {
       private IAuthorRepo author;


        public AuthorService(IAuthorRepo repo)
        {
            author = repo;
        }
        public void Delete(int id)
        {
            author.Delete(id);
        }

        public ICollection<Author> GetAll()
        {
           return author.GetAll();
        }

        public Author getById(int id)
        {
            return author.getById(id);
        }

        public void Update(Author entity)
        {
            author.Update(entity);
        }
    }
}