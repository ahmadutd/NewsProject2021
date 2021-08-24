using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IAudiosPagination
    {
        List<Audio> GetPaginationResult(int currentPage, int PageSize = 20);
        int GetCount();
    }
}
