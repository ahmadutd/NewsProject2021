using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class TagRepository:Repository<Tag>,ITagRepository
    {
        public TagRepository(AllNewsDbContext context):base(context)
        {

        }
    }
}
