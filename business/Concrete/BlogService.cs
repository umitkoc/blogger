using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class BlogService : IBlogService
    {
        IBlogRepo blog;
        public BlogService(IBlogRepo repo)
        {
            blog=repo;
        }

        public void Delete(Blog entity)
        {
            blog.Delete(entity);
        }

        public ICollection<Blog> GetAll()
        {
          return  blog.GetAll();
        }

        public Blog GetById(int id)
        {
          return blog.GetById(id);
        }

        public void Update(Blog entity)
        {
            blog.Update(entity);
        }
    }
}