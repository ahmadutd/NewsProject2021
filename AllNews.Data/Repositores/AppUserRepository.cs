using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class AppUserRepository:Repository<AppUser>,IAppUserRepository
    {
        public AppUserRepository(AllNewsDbContext context):base(context)
        {

        }
    }
}
