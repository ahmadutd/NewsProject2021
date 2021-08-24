using AllNews.Domain.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class News : BaseEntity<int>
    {
        public News():base()
        {

        }
        [Column(TypeName = "NVARCHAR(150)")]
        [Required]
        public string Title { get; set; }
        public string FirstImage { get; set; }
        [Required]
        public string FirstDescription { get; set; }
        [Display(Name = "FirstParagraph")]
        public string FirstDescriptionFirstParagraph { get; set; }

        public string SecondImage { get; set; }
        public string SecondDescription { get; set; }
        [Display(Name = "SecondeParagraph")]
        public string SecondDescriptionFirstParagraph { get; set; }

        [Display(Name = "ImageFromDb")]
        public string ImageCoverPath { get; set; }
        [Display(Name = "VideoFromDb")]
        public string VideoCoverPath { get; set; }
        public string VideoImg { get; set; }
        [NotMappedAttribute]
        public IFormFile File { get; set; }

        [NotMappedAttribute]
        public IFormFile VideoFile { get; set; }
        [NotMappedAttribute]
        public IFormFile ImgFile { get; set; }

        public string Video { get; set; }

        public bool HotCheack { get; set; }
        public bool UpToCheack { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }


        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }


        public virtual ICollection<NewsTag> NewsTag { get; set; }

    }

}
