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

namespace AllNewsCms.Web.Pages.About_Us
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("About US Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }
        public About AboutUs { get; set; }
        public void OnGet(int? id)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            AboutUs = _unitOfWork.aboutRepo.Get(x =>x.SiteLanguage.LangTitle == currentLanguage.Name);
        }
    }
}
