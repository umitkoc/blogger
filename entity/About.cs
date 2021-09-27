using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public string IconName { get; set; }
        public bool IApproved { get; set; }
    }
}