using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllNews.Domain
{
    public class VideoTag
    {
        [Key]
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int TagId { get; set; }

        public virtual Video Videos { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
