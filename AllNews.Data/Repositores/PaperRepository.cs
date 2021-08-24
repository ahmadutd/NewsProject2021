using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class PaperRepository:Repository<Paper>,IPaperRepository
    {
        public PaperRepository(AllNewsDbContext context):base(context)
        {

        }

        public IEnumerable<Paper> GetPapers(bool sortDesc = true, int? countItem = null, string culture = null)
        {
            if (countItem != null)
            {
                if (sortDesc)


                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).ToList();
        }

        public IEnumerable<Paper> GetAllPapers(bool sortDesc = true, int? countItem = null, string culture = null)
        {
            if(countItem !=null)
            {
                if(sortDesc)
                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 12 || x.CategoryId == 13 || x.CategoryId == 14).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
            }
            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 12 || x.CategoryId == 13 || x.CategoryId == 14).OrderByDescending(x => x.UpdatedDate).ToList();
        }

        public IEnumerable<Paper> GetArabicPapers(bool sortDesc = true, int? countItem = null, string culture = null)
        {
            if (countItem != null)
            {
                if (sortDesc)
                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 15 || x.CategoryId == 16 || x.CategoryId == 17).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
            }
            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).Where(x => x.CategoryId == 15 || x.CategoryId == 16 || x.CategoryId == 17).OrderByDescending(x => x.UpdatedDate).ToList();
        }

    }
}
