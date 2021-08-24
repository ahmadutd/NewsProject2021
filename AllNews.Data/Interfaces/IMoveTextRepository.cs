using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IMoveTextRepository:IRepository<MoveText>
    {
        IEnumerable<MoveText> GetLast8MoveText();
    }
}
