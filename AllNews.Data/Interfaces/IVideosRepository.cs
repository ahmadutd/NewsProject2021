using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IVideosRepository:IRepository<Video>
    {
        IEnumerable<Video> GetVideos(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
