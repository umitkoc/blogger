using System.Collections.Generic;
using business.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;
using uiweb.models;

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
            var _blogs=blogService.GetAll();
            
            return View(_blogs);
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