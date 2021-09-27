using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string TagName { get; set; }
        public bool IApproved { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}