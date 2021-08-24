using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AllNews.Data.Repositores
{
    public class NewsRepository:Repository<News>,INewsRepository
    {
        public NewsRepository(AllNewsDbContext context) : base(context)
        {
            
        }



        public IEnumerable<News> GetLastNews(bool sortDesc = true, int? countItem = null, string culture = null)
        {

            if (countItem != null)
            {
                if (sortDesc)

                    
                return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).ToList();


        }

       
        public IEnumerable<News> GetSportsNews(bool sortDesc = true, int? countItem = null, string culture = null/*int  countOfNews = 4*/)
        {
            if (countItem != null)
            {
                if (sortDesc)

                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 9 || x.CategoryId == 10 || x.CategoryId == 11).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();

            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 9 || x.CategoryId == 10 || x.CategoryId == 11).OrderByDescending(x => x.UpdatedDate).ToList();

        }

        public IEnumerable<News> GetArabicNews(bool sortDesc = true,int ? countItem = null, string culture = null/*int  countOfNews = 4*/)
        {
            if(countItem !=null)
            {
                if(sortDesc)

                    return  Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 6 || x.CategoryId == 7 || x.CategoryId == 8).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
                        
            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 6 || x.CategoryId == 7 || x.CategoryId == 8).OrderByDescending(x => x.UpdatedDate).ToList();
            
        }
        public IEnumerable<News> GetWorldNews(bool sortDesc = true, int? countItem = null, string culture = null/*int  countOfNews = 4*/)
        {
            if (countItem != null)
            {
                if (sortDesc)

                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 1 || x.CategoryId == 4 || x.CategoryId == 5).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();

            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 1 || x.CategoryId == 4 || x.CategoryId == 5).OrderByDescending(x => x.UpdatedDate).ToList();

        }

        
    }
}
