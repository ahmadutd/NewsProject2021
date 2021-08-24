using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class LanguageRepository:Repository<Language>, ILanguageRepository
    {
        public LanguageRepository(AllNewsDbContext context):base(context)
        {
                
        }
    }
}
