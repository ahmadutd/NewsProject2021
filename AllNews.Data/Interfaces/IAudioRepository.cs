using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IAudioRepository:IRepository<Audio>
    {

        IEnumerable<Audio> GetAudios(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
