using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class AppRoleUserRepository:Repository<AppRoleUser>,IAppRoleUserRepository
    {
        
        public AppRoleUserRepository(AllNewsDbContext context):base(context)
        {
           
        }

        
        
    }
}
