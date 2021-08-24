using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllNews.Domain
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string LangName { get; set; }
        [Required]
        public string LangTitle { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<MoveText> MoveText { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
        public virtual ICollection<Video> Video { get; set; }
        public virtual ICollection<Audio> Audio { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<Paper> Paper { get; set; }
        public virtual ICollection<Statement> Statement { get; set; }
        public virtual ICollection<Studies> Studies { get; set; }
        public virtual ICollection<Category> Category { get; set; }



    }
}
