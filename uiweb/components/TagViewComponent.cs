using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.components
{
    public class TagViewComponent:ViewComponent
    {
        ITagService tagRepo;
        public TagViewComponent(ITagService tag)
        {
            tagRepo=tag;
        }
        public IViewComponentResult Invoke(){
            ICollection<Tag> _tag=tagRepo.GetAll();
            return View(_tag);
        }
    }
}