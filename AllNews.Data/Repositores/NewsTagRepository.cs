using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class NewsTagRepository:Repository<NewsTag>,INewsTagRepository
    {
        public NewsTagRepository(AllNewsDbContext context):base(context)
        {

        }
    }
}
