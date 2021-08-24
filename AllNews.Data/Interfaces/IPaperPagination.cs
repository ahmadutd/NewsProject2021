using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IPaperPagination
    {
        List<Paper> GetPaginationResult(int currentPage, int PageSize = 20);

        int GetCount();


    }
}
