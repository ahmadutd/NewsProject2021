using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IPaperRepository : IRepository<Paper>
    {
        IEnumerable<Paper> GetPapers(bool sortDesc = true, int? countItem = null, string culture = null);
        IEnumerable<Paper> GetAllPapers(bool sortDesc = true, int? countItem = null, string culture = null);
        IEnumerable<Paper> GetArabicPapers(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
