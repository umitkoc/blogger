using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string   ImageUrl { get; set; }
        public string  Job { get; set; }
        
    }
}