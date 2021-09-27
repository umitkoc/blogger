using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class SocialViewComponent:ViewComponent
    {
        ISocialService _social;
        public SocialViewComponent(ISocialService repo)
        {
            _social = repo;
        }


        public IViewComponentResult Invoke(){
            ICollection<Social> social=_social.GetAll();


            return View(social);
        }
    }
}