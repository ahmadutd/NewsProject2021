using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AllNews.Data;
using AllNews.Domain;
using AllNews.Data.Interfaces;

namespace AllNews.App
{
    public class NewsService:INewsService
    {
        private readonly INewsRepository _newrepo;
        public NewsService(INewsRepository newrepo)
        {
            _newrepo = newrepo; 
        }
        public IEnumerable<News> GetNews()
        {
            return _newrepo.GetAll();
        }
        public int CreatNews(News news)
        {
            return _newrepo.Add(news);


        }

        public int DeleteNews(int newsId)
        {
            var news = _newrepo.Get(x => x.Id == newsId);
            int result = 0;
            if(news!=null)
            {
                result = _newrepo.Delete(news);
            }
            return result;
        }

        

        public int UpdateNews(News news)
        {
            return _newrepo.Update(news);
        }

       
    }
}
