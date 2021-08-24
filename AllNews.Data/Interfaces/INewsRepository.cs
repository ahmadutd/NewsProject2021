using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface INewsRepository:IRepository<News>
    {
        IEnumerable<News> GetLastNews(bool sortDesc = true, int? countItem = null, string culture = null);
        IEnumerable<News> GetSportsNews(bool sortDesc = true, int? countItem = null, string culture = null);
        IEnumerable<News> GetWorldNews(bool sortDesc = true, int? countItem = null, string culture = null);
        IEnumerable<News> GetArabicNews(bool sortDesc= true, int? countItem = null, string culture = null);


    }
}
