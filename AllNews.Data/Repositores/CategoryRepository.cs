using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(AllNewsDbContext context) : base(context)
        {

        }

        public IEnumerable<Category> GetAllCateNews()
        {
            return GetAll().OrderBy(x=>x.Id).Take(9).ToList();
        }

        public IEnumerable<Category> GetAllCatePapers()
        {
            return GetAll().OrderByDescending(x => x.Id).Take(6).ToList();
        }
    }
}
