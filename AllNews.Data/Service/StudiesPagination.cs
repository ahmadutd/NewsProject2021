using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AllNews.Data.Service
{
    public class StudiesPagination:IStudiesPagination
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudiesPagination(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Studies> GetPaginationResult(int currentPage, int PageSize = 20)
        {
            var data = GetData();
            return data.OrderByDescending(x => x.UpdatedDate).Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();
        }


        public int GetCount()
        {
            var data = GetData();
            return data.Count();
        }

        private List<Studies> GetData()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            return _unitOfWork.studiesRepo.GetStudies().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
        }
    }
}
