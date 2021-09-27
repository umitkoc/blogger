using System;
using System.Collections.Generic;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace blog.controllers
{
    public class HomeController : Controller
    {
        IBlogRepo blog;

        public HomeController(IBlogRepo repo)
        {
            blog = repo;
        }



        [HttpGet]
        public IActionResult Index()
        {
            ICollection<Blog> _blog = blog.GetAll();

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