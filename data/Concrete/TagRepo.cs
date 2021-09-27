
using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class TagRepo : ITagRepo
    {

        private readonly BlogContext context;
        public TagRepo(BlogContext _context)
        {
            context = _context;
        }


        public void Delete(Tag entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Tag> GetAll()
        {
            return context.Set<Tag>().ToList();
        }

        public Tag GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Tag entity)
        {
            throw new System.NotImplementedException();
        }
    }
}