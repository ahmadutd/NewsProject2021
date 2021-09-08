using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class AboutRepository:Repository<About>,IAboutRepository
    {
        public AboutRepository(AllNewsDbContext contex) : base(contex)
        {

        }
    }
}
