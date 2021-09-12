using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain = AllNews.Domain;
namespace AllNewsCms.Web.Pages.News
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("News Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INewsPagination _newsPagination;

        public IndexModel(IUnitOfWork unitOfWork,INewsPagination newsPagination)
        {
            _unitOfWork = unitOfWork;
            _newsPagination = newsPagination;

        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 100;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }



        [BindProperty]
        public List<Domain.News> News { get; set; }

        public  List<Category> Category { get; set; }


        public void OnGet(int? id=null)
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            Category = _unitOfWork.catageryRepo.GetAllCateNews().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            if (id !=null)
            {
                News = _unitOfWork.newsRepo.GetLastNews().Where(x => (id == null || x.CategoryId == id)).ToList();
            }
            else
            {
                News = _newsPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
            }

            Count = _newsPagination.GetCount();

            //News = _unitOfWork.newsRepo.GetLastNews().Where(x => (id == null || x.CategoryId == id) && x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
        }
      
    }
}