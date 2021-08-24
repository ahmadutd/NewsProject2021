using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllNews.Domain
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<News> CreatedNews { get; set; }
        public virtual ICollection<News> UpdatedNews { get; set; }

        public virtual ICollection<Company> CreatedCompany { get; set; }
        public virtual ICollection<Company> UpdatedCompany { get; set; }

        public virtual ICollection<Paper> CreatedPapers { get; set; }
        public virtual ICollection<Paper> UpdatedPapers { get; set; }

        public virtual ICollection<Statement> CreatedStatement { get; set; }
        public virtual ICollection<Statement> UpdatedStatement { get; set; }

        public virtual ICollection<Studies> CreatedStudies { get; set; }
        public virtual ICollection<Studies> UpdatedStudies { get; set; }

        public virtual ICollection<Photo> CreatedPhoto { get; set; }
        public virtual ICollection<Photo> UpdatedPhoto { get; set; }

        public virtual ICollection<Video> CreatedVideo { get; set; }
        public virtual ICollection<Video> UpdatedVideo { get; set; }

        public virtual ICollection<Audio> CreatedAudios { get; set; }
        public virtual ICollection<Audio> UpdatedAudios { get; set; }


    }
}
