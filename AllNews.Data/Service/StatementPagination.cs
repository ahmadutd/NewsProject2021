using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AllNews.Data.Service
{
    public class StatementPagination:IStatementPagination
    {
        

        private readonly IUnitOfWork _unitOfWork;

        public StatementPagination(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Statement> GetPaginationResult(int currentPage, int PageSize = 20)
        {
            var data = GetData();
            return data.OrderByDescending(x => x.UpdatedDate).Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();
        }

        public int GetCount()
        {
            var data = GetData();
            return data.Count();
        }

        private List<Statement> GetData()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            return _unitOfWork.statementRepo.GetStatements().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
        }


    }
    
}
