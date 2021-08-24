using AllNews.Data.Interfaces;
using AllNews.Domain;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllNews.Data.Service
{
    public class NewsPagination : INewsPagination
    {

        private readonly IUnitOfWork _unitOfWork;

        public NewsPagination(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public  List<News> GetPaginationResult(int currentPage, int PageSize = 20)
        {
            var data = GetData();
            return data.OrderByDescending(x=>x.UpdatedDate).Skip((currentPage - 1) * PageSize).Take(PageSize).ToList();
        }

        public int GetCount()
        {
            var data = GetData();
            return data.Count();
        }

        private List<News> GetData()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            return _unitOfWork.newsRepo.GetLastNews().Where(x=>x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
        }


    }
}
