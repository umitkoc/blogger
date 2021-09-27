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
      

        public void Delete(Tag entity)
        {
            tag.Delete(entity);
        }

        public ICollection<Tag> GetAll()
        {
          return tag.GetAll();
        }

        public Tag GetById(int id)
        {
            return tag.GetById(id);
        }

        public void Update(Tag entity)
        {
            tag.Update(entity);
        }
    }
}