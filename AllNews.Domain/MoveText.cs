using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllNews.Domain
{
    public class MoveText:BaseEntity<int>
    {
        public MoveText():base()
        {

        }
        [Column(TypeName = "NVARCHAR(150)")]
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "NVARCHAR(600)")]
        [Required]

        public string Text { get; set; }


        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }
    }
}
