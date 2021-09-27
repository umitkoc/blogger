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
        public void Delete(int id)
        {
            blog.Delete(id);
        }

        public ICollection<Blog> GetAll()
        {
          return  blog.GetAll();
        }

        public Blog getById(int id)
        {
          return blog.getById(id);
        }

        public void Update(Blog entity)
        {
            blog.Update(entity);
        }
    }
}