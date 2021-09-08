using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Domain
{
    public class About : BaseEntity<int>
    {
        public About():base()
        {

        }

        public string Title { get; set; }
        public string Text { get; set; }


        public int? LangId { get; set; }
        public virtual Language SiteLanguage { get; set; }

    }
}
