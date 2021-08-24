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
    public class WorldNewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public WorldNewsController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataWorldNews = _unitOfWork.newsRepo.GetWorldNews(true,null, currentLanguage.Name);
            var worldNewsViewModel = new PageinationViewModel<News>(dataWorldNews,page);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(worldNewsViewModel);
        }
    }
}
