using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class TagService : ITagService
    {
        ITagRepo tag;
        public TagService(ITagRepo repo)
        {
            tag=repo;
        }
        public void Delete(int id)
        {
            tag.Delete(id);
        }

        public ICollection<Tag> GetAll()
        {
          return tag.GetAll();
        }

        public Tag getById(int id)
        {
            return tag.getById(id);
        }

        public void Update(Tag entity)
        {
            tag.Update(entity);
        }
    }
}