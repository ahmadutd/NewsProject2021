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
    public class NewsPageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public NewsPageController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        
        public IActionResult Index(int id)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var lastNews = _unitOfWork.newsRepo.Get(x => x.Id == id);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(lastNews);
        }
    }
}
