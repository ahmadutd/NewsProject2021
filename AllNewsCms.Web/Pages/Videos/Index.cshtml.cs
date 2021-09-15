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

namespace AllNewsCms.Web.Pages.Videos
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Videos Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVideoPagination _videopagination;

        public IndexModel(IUnitOfWork unitOfWork,IVideoPagination videopagination)
        {
            _unitOfWork = unitOfWork;
            _videopagination = videopagination;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 100;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        public List<Video> Videos { get; set; }
        public void OnGet(int ? id)
        {

            Videos = _videopagination.GetPaginationResult(CurrentPage, PageSize).ToList();
            Count = _videopagination.GetCount();
        }
    }
}