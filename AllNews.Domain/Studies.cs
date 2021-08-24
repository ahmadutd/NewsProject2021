using AllNews.Domain.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class Studies:BaseEntity<int>
    {
        public Studies():base()
        {

        }
        [Required]
        public string Title { get; set; }

        public string Image { get; set; }
        [Display(Name = "ImageFromDb")]
        public string ImageCoverPath { get; set; }
        public string DownloadLink { get; set; }
        [NotMappedAttribute]
        public IFormFile ImageFile { get; set; }
        [NotMappedAttribute]
        public IFormFile DownloadFile { get; set; }
        [Required]
        public string Description { get; set; }

        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }
    }
}
