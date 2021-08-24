using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNews.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Language> AppLanguages { get; set; }
        public IEnumerable<News> Last10News { get; set; }
        public IEnumerable<News> Last4ArabicNews { get; set; }
        public IEnumerable<News> Last10ArabicNews { get; set; }
        public IEnumerable<News> Last4WorldNews { get; set; }
        public IEnumerable<News> Last10WorldNews { get; set; }
        public IEnumerable<News> Last2SportsNews { get; set; }
        public IEnumerable<Paper> Last4Papers { get; set; }
        public IEnumerable<Company> Last4Company { get; set; }
        public IEnumerable<Photo> Top4Photo { get; set; }
        public IEnumerable<Photo> TopPhoto { get; set; }
        public IEnumerable<Video> GetLast8Videos { get; set; }
        



    }
}
