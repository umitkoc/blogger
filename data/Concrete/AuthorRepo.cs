using System.Collections.Generic;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class AuthorRepo : IAuthorRepo
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Author getById(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Author> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new System.NotImplementedException();
        }
    }
}