using AllNews.Domain.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class Company:BaseEntity<int>
    {
        public Company():base()
        {

        }

        public string Image { get; set; }

        [Display(Name = "ImageFromDb")]
        public string ImageCoverPath { get; set; }
        [NotMappedAttribute]
        public IFormFile File { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Information { get; set; }


        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }
    }
}
