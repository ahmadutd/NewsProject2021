using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AllNewsCms.Web.Pages
{
  
    public class IndexModel : PageModel
    {
        
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,IUnitOfWork unitOfWork)
        {

            _logger = logger;
            _unitOfWork = unitOfWork;
      
        }

        public void OnGet()
        {
            
        }

        public PartialViewResult OnGetLanguageData()
        {
            var languageList = _unitOfWork.langRepo.GetAll().ToList();
            return Partial("_PartialLang" ,languageList);
        }
        public PartialViewResult OnGetLanguageDataForLayout()
        {
            var languageList = _unitOfWork.langRepo.GetAll().ToList();
            return Partial("_PartialLang-Layout", languageList);
        }

        public IActionResult OnGetSetLanguage(string id)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(id)),
                new CookieOptions()
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                }


                );

            return Redirect(Request.Headers["referer"].ToString());
        }


        
    }
}
