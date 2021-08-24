using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AllNews.Data.Interfaces
{
    public interface INewsPagination
    {
        List<News> GetPaginationResult(int currentPage, int PageSize = 20);
        int GetCount();

    }
}
