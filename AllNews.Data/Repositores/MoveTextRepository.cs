using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AllNews.Data.Repositores
{
    public class MoveTextRepository : Repository<MoveText>, IMoveTextRepository
    {
        public MoveTextRepository(AllNewsDbContext context) : base(context)
        {

        }

        public IEnumerable<MoveText> GetMoveText(bool sortDesc = true, int? countItem = null, string culture = null)
        {
            if (countItem != null)
            {
                if (sortDesc)


                    return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).Take((int)countItem).ToList();
            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).ToList();
        }

    }
}
