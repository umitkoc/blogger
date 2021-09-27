using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Social
    {
        [Key]
        public int SocialId { get; set; }
        public string SocialName { get; set; }
        public string SocialUrl { get; set; }
        public string IconName { get; set; }
        public bool IApproved { get; set; }
    }
}