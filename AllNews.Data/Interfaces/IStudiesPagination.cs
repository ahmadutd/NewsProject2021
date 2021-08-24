using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IStudiesPagination
    {
        List<Studies> GetPaginationResult(int currentPage, int PageSize = 20);
        int GetCount();
    }
}
