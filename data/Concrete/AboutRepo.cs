using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class AboutRepo : IAboutRepo
    {
        private readonly BlogContext context;
        public AboutRepo(BlogContext _context)
        {
            context = _context;
        }

        public void Delete(About entity)
        {
                context.Set<About>().Remove(entity);
                context.SaveChanges();
        }

        public ICollection<About> GetAll()
        {
                return context.Set<About>().ToList();
        }

        public About GetById(int id)
        {
                return context.Set<About>().Find(id);
        }

        public void Update(About entity)
        {
                context.Set<About>().Update(entity);
                context.SaveChanges();
        }
    }


}