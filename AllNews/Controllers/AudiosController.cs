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
    public class AudiosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AudiosController(IUnitOfWork unitOfWork,IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataAudios = _unitOfWork.audioRepo.GetAudios(true,null,currentLanguage.Name);
            var LastNewsViewModel = new PageinationViewModel<Audio>(dataAudios, page);

            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(LastNewsViewModel);
        }
        public IActionResult AudioPart(int id)
        {
            var audio = _unitOfWork.audioRepo.Get(x => x.Id == id);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(audio);
            
        }
    }
}
