using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IStatementRepository:IRepository<Statement>
    {
        IEnumerable<Statement> GetStatements(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
