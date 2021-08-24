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
    public class StatementController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatementController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }
        public IActionResult Index(int? page = 1)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var getStatmenet = _unitOfWork.statementRepo.GetStatements(true,null,currentLanguage.Name);
            var StatementViewModel = new PageinationViewModel<Statement>(getStatmenet, page);
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(StatementViewModel);


        }
        public IActionResult View(int id)
        {
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            return View(_unitOfWork.statementRepo.Get(x=>x.Id==id));
        }
    }
}
