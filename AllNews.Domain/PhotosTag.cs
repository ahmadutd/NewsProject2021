using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllNews.Domain
{
    public class PhotosTag
    {
        [Key]
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public int TagId { get; set; }

        public virtual Photo Photos { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
