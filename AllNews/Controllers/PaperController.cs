using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNews.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AllNews.Controllers
{
    public class PaperController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaperController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var papers = _unitOfWork.paperRepo.GetPapers(true,null,currentLanguage.Name);
            var PapersViewModel = new PageinationViewModel<Paper>(papers, page);
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(PapersViewModel);
        }
        public IActionResult All(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var allPapers = _unitOfWork.paperRepo.GetAllPapers(true, null, currentLanguage.Name);
            var AllPapersViewModel = new PageinationViewModel<Paper>(allPapers, page);
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(AllPapersViewModel);

            
        }
        public IActionResult Arabic(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var arabicPapers = _unitOfWork.paperRepo.GetArabicPapers(true, null, currentLanguage.Name);
            var ArabicPapersViewModel = new PageinationViewModel<Paper>(arabicPapers, page);
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(ArabicPapersViewModel);


            
        }
    }
}
