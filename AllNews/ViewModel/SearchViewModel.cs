using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNews.ViewModel
{
    public class SearchViewModel
    {
        public IEnumerable<News> newsSearchData { get; set; }
        public IEnumerable<Photo> photoSearchData { get; set; }
        public IEnumerable<Video> videoSearchData { get; set; }
        public IEnumerable<Audio> audioSearchData { get; set; }
        public IEnumerable<Category> categorySearchData { get; set; }
        public IEnumerable<Paper> paperSearchData { get; set; }
        public IEnumerable<Statement> statementSearchData { get; set; }
        public IEnumerable<Company> companySearchData { get; set; }
        public IEnumerable<Studies> studiesSearchData { get; set; }

    }
}
