using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class VideosRepository:Repository<Video>,IVideosRepository
    {
        public VideosRepository(AllNewsDbContext context):base(context)
        {

        }

        public IEnumerable<Video> GetVideos(bool sortDesc = true, int? countItem = null, string culture = null)
        {
            if (countItem != null)
            {
                if (sortDesc)


                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).ToList();
        }

       
    }
}
