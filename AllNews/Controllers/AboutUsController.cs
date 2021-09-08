using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AllNews.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AboutUsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            return View(_unitOfWork.aboutRepo.Get(x=>x.SiteLanguage.LangTitle == currentLanguage.Name));
        }
    }
}
