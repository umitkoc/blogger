using System;

namespace uiweb.models
{
    public class BlogModel
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}