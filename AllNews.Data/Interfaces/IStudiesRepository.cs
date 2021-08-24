using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IStudiesRepository:IRepository<Studies>
    {

        IEnumerable<Studies> GetStudies(bool sortDesc = true, int? countItem = null, string culture = null);

    }
}
