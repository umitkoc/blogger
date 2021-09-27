using System.Collections.Generic;
using business.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace blog.controllers
{
    public class HomeController : Controller
    {
        IBlogService blogService;

        public HomeController(IBlogService repo)
        {
            blogService = repo;
        }



        [HttpGet]
        public IActionResult Index()
        {
            ICollection<Blog> _blog = blogService.GetAll();

            return View(_blog);
        }
        [HttpGet]
        public IActionResult Blog(int? id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string q)
        {
            return RedirectToAction("index", "home");
        }


    }
}