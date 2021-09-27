using System.Collections.Generic;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class AboutViewComponent:ViewComponent
    {

        IAboutRepo _about;
        public AboutViewComponent(IAboutRepo repo)
        {
            _about=repo;
        }
        public IViewComponentResult Invoke(){

            ICollection<About> about=_about.GetAll();


            return View(about);
        }
    }
}