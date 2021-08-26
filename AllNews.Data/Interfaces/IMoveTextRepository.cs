using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IMoveTextRepository:IRepository<MoveText>
    {
        IEnumerable<MoveText> GetMoveText(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
