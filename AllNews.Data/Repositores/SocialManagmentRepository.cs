using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class SocialManagmentRepository:Repository<SocialManagment>,ISocialManagmentRepository
    {
        public SocialManagmentRepository(AllNewsDbContext context) : base(context)
        {

        }
    }
}
