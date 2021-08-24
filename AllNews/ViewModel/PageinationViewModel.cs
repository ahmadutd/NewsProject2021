using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNews.ViewModel
{
    public class PageinationViewModel<T> where T:class
    {
       
        private IEnumerable<T> tList;
        private int? page;
        private int? pageSize;
        private int count;
        public PageinationViewModel(IEnumerable<T> TList, int? page = 1, int? pageSize = 40)
        {
           
            this.page = page;
            this.pageSize = pageSize;
            this.count = TList.Count();
            tList = TList.Skip((int)(((CurrentPage - 1) * PageSize))).Take((int)pageSize);

        }
        public IEnumerable<T> PaginatedList => tList;

        public int CurrentPage { 
            get {
                return (int)this.page;
            } 
        }
        public double PageSize { 
            get {
                return (double)this.pageSize;
            }
        }
        public int TotalPage => ((int)Math.Ceiling(count / PageSize));
    }
}
