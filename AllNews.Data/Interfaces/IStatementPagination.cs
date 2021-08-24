using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IStatementPagination
    {

        List<Statement> GetPaginationResult(int currentPage, int PageSize = 20);
        int GetCount();
    }
}
