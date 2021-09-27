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

        public void Delete(Author entity)
        {
            author.Delete(entity);
        }

        public Author Get()
        {
           return author.Get();
        }

        public ICollection<Author> GetAll()
        {
            return author.GetAll();
        }

        public Author GetById(int id)
        {
            return author.GetById(id);
        }

        public void Update(Author entity)
        {
            author.Update(entity);
        }
    }
}