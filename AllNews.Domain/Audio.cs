using AllNews.Domain.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class Audio:BaseEntity<int>
    {

        public Audio():base()
        {

        }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    
        public string Image { get; set; }

        [Display(Name = "ImageFromDb")]
        public string ImageCoverPath { get; set; }

        [NotMappedAttribute]
        public IFormFile ImageFile { get; set; }
        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }

        [Display(Name = "AudioFile")]
        public string AudioCoverPath { get; set; }

        [NotMappedAttribute]
        public IFormFile File { get; set; }


    }
}
