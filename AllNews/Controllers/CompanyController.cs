using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AllNews.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;

        }
        private IConfiguration Configuration { get; }
        public IActionResult Index()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var getallcompany= _unitOfWork.companyRepo.GetAllCompany().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            var data = new ViewModel.PartialViewModel
            {
                GetAllCompany = getallcompany,
            };
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(data);
        }
    }
}
