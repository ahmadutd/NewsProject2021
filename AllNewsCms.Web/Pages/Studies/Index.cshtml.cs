using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.Studies
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Studies Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudiesPagination _studiesPagination;

        public IndexModel(IUnitOfWork unitOfWork,IStudiesPagination studiesPagination)
        {
            _unitOfWork = unitOfWork;
            _studiesPagination = studiesPagination;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 100;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        public List<Domain.Studies> Studies { get; set; }
        public void OnGet()
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            Studies =_studiesPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
            Count = _studiesPagination.GetCount();
        }
    }
}