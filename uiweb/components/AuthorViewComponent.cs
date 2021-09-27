using data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class AuthorViewComponent:ViewComponent
    {
        IAuthorRepo _author;
        public AuthorViewComponent(IAuthorRepo repo)
        {
            _author = repo;
        }


        public IViewComponentResult Invoke(){
            var author=_author.GetById(0);
            return View(author);
        }
    }
}