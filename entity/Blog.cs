using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public int TagId { get; set; }
        public string Description { get; set; }
        public bool IApproved { get; set; }
    }
}