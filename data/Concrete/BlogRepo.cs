
using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class BlogRepo : IBlogRepo
    {
        private  readonly BlogContext context;


        public BlogRepo(BlogContext _context)
        {
            context = _context;
        }
        public void Delete(Blog entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Blog> GetAll()
        {
                return context.Set<Blog>().ToList();
        }

        public Blog GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new System.NotImplementedException();
        }
    }
}