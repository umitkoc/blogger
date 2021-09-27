using System.Collections.Generic;
using business.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class AboutViewComponent:ViewComponent
    {

        IAboutService _about;
        public AboutViewComponent(IAboutService repo)
        {
            _about=repo;
        }
        public IViewComponentResult Invoke(){

            ICollection<About> about=_about.GetAll();


            return View(about);
        }
    }
}