using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class AppRoleRepository:Repository<AppRole>,IAppRoleRepository
    {
        public AppRoleRepository(AllNewsDbContext context) : base(context)
        {

        }
    }
}
