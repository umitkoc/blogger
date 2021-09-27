using business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class AuthorViewComponent:ViewComponent
    {
        IAuthorService _author;
        public AuthorViewComponent(IAuthorService repo)
        {
            _author = repo;
        }


        public IViewComponentResult Invoke(){
            var author=_author.Get();
            return View(author);
        }
    }
}