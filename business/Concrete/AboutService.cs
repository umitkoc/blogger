using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class AboutService : IAboutService
    {
        IAboutRepo about;
        public AboutService(IAboutRepo repo)
        {
         about=repo;   
        }

        public void Delete(About entity)
        {
           about.Delete(entity);
        }

        public ICollection<About> GetAll()
        {
          return about.GetAll();
        }

        public About GetById(int id)
        {
            return about.GetById(id);
        }

        public void Update(About entity)
        {
            about.Update(entity);
        }
    }
}