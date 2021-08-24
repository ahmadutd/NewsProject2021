using System.ComponentModel.DataAnnotations;

namespace AllNews.Domain
{
    public class NewsTag
    {
        [Key]
        public int Id { get; set; }
        public int NewsId { get; set; }
        public int TagId { get; set; }

        public virtual News News { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
