using System.Collections.Generic;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class SocialViewComponent:ViewComponent
    {
        ISocialRepo _social;
        public SocialViewComponent(ISocialRepo repo)
        {
            _social = repo;
        }


        public IViewComponentResult Invoke(){
            ICollection<Social> social=_social.GetAll();


            return View(social);
        }
    }
}