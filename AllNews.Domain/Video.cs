using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace AllNews.Domain
{
    public class Video:BaseEntity<int>
    {
        public Video():base()
        {

        }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoPlay { get; set; }
        public string VideoImage { get; set; }
        [Display(Name = "VideoFromDb")]
        public string VideoCoverPath { get; set; }
        [NotMappedAttribute]
        public IFormFile File { get; set; }
        [NotMappedAttribute]
        public IFormFile ImgFile { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }

        public virtual ICollection<VideoTag> VideoTag { get; set; }
    }
}
