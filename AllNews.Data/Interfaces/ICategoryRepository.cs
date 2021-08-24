using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface ICategoryRepository:IRepository<Category>
    {
        IEnumerable<Category> GetAllCateNews();
        IEnumerable<Category> GetAllCatePapers();
    }
}
