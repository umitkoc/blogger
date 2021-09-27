using System.Collections.Generic;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class BlogRepo : IBlogRepo
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Blog getById(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Blog> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new System.NotImplementedException();
        }
    }
}