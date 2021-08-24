using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace AllNews.Domain
{
    public class Photo:BaseEntity<int>
    {
        public Photo():base()
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
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }

        public virtual ICollection<PhotosTag> PhotoTag { get; set; }

    }
}
