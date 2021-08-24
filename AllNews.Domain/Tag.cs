using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllNews.Domain
{
    public class Tag:BaseEntity<int>
    {
        public Tag():base()
        {

        }
        [Required]
        public string Name { get; set; }



        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }

        public virtual ICollection<NewsTag> NewsTag { get; set; }
        public virtual ICollection<VideoTag> VideoTag { get; set; }
        public virtual ICollection<PhotosTag> PhotoTag { get; set; }

    }
}
