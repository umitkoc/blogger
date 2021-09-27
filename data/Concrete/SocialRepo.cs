using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class SocialRepo : ISocialRepo
    {

        private readonly BlogContext context;
        public SocialRepo(BlogContext _context)
        {
            context = _context;
        }


        public void Delete(Social entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Social> GetAll()
        {
            return context.Set<Social>().ToList();
        }

        public Social GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Social entity)
        {
            throw new System.NotImplementedException();
        }
    }
}