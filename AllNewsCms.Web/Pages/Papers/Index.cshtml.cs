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

namespace AllNewsCms.Web.Pages.Papers
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Papers Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaperPagination _paperpagination;

        public IndexModel(IUnitOfWork unitOfWork,IPaperPagination paperpagination)
        {
            _unitOfWork = unitOfWork;
            _paperpagination = paperpagination;
        }



        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 20;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        public List<Paper> Papers { get; set; }
        public List<Category> CategoryPapers { get; set; }

        public void OnGet(int? id = null)
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            CategoryPapers = _unitOfWork.catageryRepo.GetAllCatePapers().Where(x=>x.SiteLanguage.LangTitle== currentLanguage.Name).ToList();

            if (id != null)
            {
                Papers = _unitOfWork.paperRepo.GetPapers(true, null, currentLanguage.Name).Where(x => (id == null || x.CategoryId == id) && x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            }
            else
            {
                Papers = _paperpagination.GetPaginationResult(CurrentPage, PageSize).ToList();
            }

            Count = _paperpagination.GetCount();

            
        }
    }
}