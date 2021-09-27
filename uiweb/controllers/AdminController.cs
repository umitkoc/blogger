using Microsoft.AspNetCore.Mvc;

namespace blog.controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Forgot()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateTag()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateAuthor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }
        

    }
}