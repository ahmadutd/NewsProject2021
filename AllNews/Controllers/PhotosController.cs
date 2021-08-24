using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Data.Repositores;
using AllNews.Domain;
using AllNews.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AllNews.Controllers
{
    public class PhotosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PhotosController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var photos = _unitOfWork.photoRepo.GetPhotos(true,null,currentLanguage.Name);
            var PhotosViewModel = new PageinationViewModel<Photo>(photos, page);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(PhotosViewModel);


        }
        
        public IActionResult PhotoView(int id)
        {
            var photo = _unitOfWork.photoRepo.Get(x => x.Id == id);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(photo);
            
        }
    
    }
}
