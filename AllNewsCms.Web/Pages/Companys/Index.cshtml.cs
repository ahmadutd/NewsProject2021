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

namespace AllNewsCms.Web.Pages.Companys
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Organisations Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Company> Companys { get; set; }
        public void OnGet()
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            Companys = _unitOfWork.companyRepo.GetAllCompany()
            .Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
        }
    }
}