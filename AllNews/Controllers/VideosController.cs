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
    public class VideosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VideosController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {

            var currentLanguage = CultureInfo.CurrentCulture;
            var videos = _unitOfWork.videoRepo.GetVideos(true,null,currentLanguage.Name);
            var VideosViewModel = new PageinationViewModel<Video>(videos, page);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(VideosViewModel);

        }
        public IActionResult VideoPart(int id)
        {
            

            var video = _unitOfWork.videoRepo.Get(x=>x.Id==id);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(video);
        }
    }
}
