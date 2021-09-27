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
      

        public void Delete(Social entity)
        {
             social.Delete(entity);
        }

        public ICollection<Social> GetAll()
        {
           return social.GetAll();
        }

        public Social GetById(int id)
        {
           return social.GetById(id);
        }

        public void Update(Social entity)
        {
          social.Update(entity);
        }
    }
}