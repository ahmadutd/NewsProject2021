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

namespace AllNewsCms.Web.Pages.Photos
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Photos Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPhotoPagination _photoPagination;

        public IndexModel(IUnitOfWork unitOfWork,IPhotoPagination photoPagination)
        {
            _unitOfWork = unitOfWork;
            _photoPagination = photoPagination;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 20;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }
        public List<Photo> Photos { get; set; }
        public void OnGet(int?id)
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            Photos = _photoPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
            Count = _photoPagination.GetCount();
        }
    }
}