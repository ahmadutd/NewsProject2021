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
    public class SportsNewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SportsNewsController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataSportsNews = _unitOfWork.newsRepo.GetSportsNews(true,null,currentLanguage.Name);
            var SportsNewsViewModel = new PageinationViewModel<News>(dataSportsNews, page);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(SportsNewsViewModel);
        }
    }
}
