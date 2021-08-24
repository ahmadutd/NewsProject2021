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
    public class LastNewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LastNewsController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataLastNews = _unitOfWork.newsRepo.GetLastNews().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            var LastNewsViewModel = new PageinationViewModel<News>(dataLastNews, page);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(LastNewsViewModel);
        }
    }
}
