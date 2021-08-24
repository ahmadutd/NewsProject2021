using AllNews.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.App
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryService _categoryrepo;
        public CategoryService(ICategoryService categoryrepo)
        {
            _categoryrepo = categoryrepo;
        }
    }
}
