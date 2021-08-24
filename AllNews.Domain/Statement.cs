using AllNews.Domain.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class Statement:BaseEntity<int>
    {
        public Statement():base()
        {

        }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Image { get; set; }
        [Display(Name = "ImageFromDb")]
        public string ImageCoverPath { get; set; }
        [NotMappedAttribute]
        public IFormFile ImageFile { get; set; }

        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }
    }
}
