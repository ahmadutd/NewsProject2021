using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNews.ViewModel
{
    public class PartialViewModel
    {
        public IEnumerable<Audio> GetAllAudioFiles { get; set; }
        public IEnumerable<Studies> GetAllBooks{ get; set; }
        public IEnumerable<Statement> GetAllStatement{ get; set; }
        public IEnumerable<Company> GetAllCompany{ get; set; }
        public IEnumerable<Photo> GetAllPhotos{ get; set; }
        public IEnumerable<Video> GetAllVideos{ get; set; }
        public IEnumerable<Paper> GetAllPapers { get; set; }
        public IEnumerable<Paper> GetLastPapers { get; set; }
        public IEnumerable<Paper> GetArabicPapers { get; set; }
        public IEnumerable<News> GetArabicNews { get; set; }
        public IEnumerable<News> GetWorldNews { get; set; }
        public IEnumerable<News> GetSportsNews { get; set; }
    


    }
}
