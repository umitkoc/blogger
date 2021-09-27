using System.Collections.Generic;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class TagViewComponent:ViewComponent
    {
        ITagRepo tagRepo;
        public TagViewComponent(ITagRepo tag)
        {
            tagRepo=tag;
        }
        public IViewComponentResult Invoke(){
            ICollection<Tag> _tag=tagRepo.GetAll();
            return View(_tag);
        }
    }
}