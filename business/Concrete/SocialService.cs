using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class SocialService : ISocialService
    {
        ISocialRepo social;
        public SocialService(ISocialRepo repo)
        {
            social = repo;
        }
        public void Delete(int id)
        {
            social.Delete(id);
        }

        public ICollection<Social> GetAll()
        {
           return social.GetAll();
        }

        public Social getById(int id)
        {
           return social.getById(id);
        }

        public void Update(Social entity)
        {
          social.Update(entity);
        }
    }
}