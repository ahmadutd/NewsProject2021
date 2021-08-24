using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class Category:BaseEntity<int>
    {
        public Category() : base()
        {

        }

        [Required]
        [Column(TypeName = "NVarchar(20)")]
        public string CategoryName { get; set; }

        public string RoutName { get; set; }

        public virtual ICollection<News> Newss { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Paper> Paper { get; set; }
        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }
    }
}
