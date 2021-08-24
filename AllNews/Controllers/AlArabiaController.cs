using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNews.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AllNews.Controllers
{
    public class AlArabiaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AlArabiaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataArabicNews = _unitOfWork.newsRepo.GetArabicNews(true,null,currentLanguage.Name);
            var arabicNewsViewModel = new PageinationViewModel<News>(dataArabicNews, page);
            return View(arabicNewsViewModel);


            
        }
       
       
    }
}
