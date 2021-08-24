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
    public class LibraryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LibraryController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentInfo = CultureInfo.CurrentCulture;
            var Studies = _unitOfWork.studiesRepo.GetStudies(true,null,currentInfo.Name);
            var StudieViewModel = new PageinationViewModel<Studies>(Studies, page);

            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(StudieViewModel);

        }
    }
}
