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
        public void Delete(int id)
        {
            about.Delete(id);
        }

        public ICollection<About> GetAll()
        {
          return about.GetAll();
        }

        public About getById(int id)
        {
            return about.getById(id);
        }

        public void Update(About entity)
        {
            about.Update(entity);
        }
    }
}