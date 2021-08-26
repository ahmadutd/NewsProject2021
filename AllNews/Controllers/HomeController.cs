using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNews.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public object IFormatProvider { get; private set; }

        public HomeController(IUnitOfWork unitOfWork, ILogger<HomeController> logger ,IConfiguration configuration)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }



        public IActionResult Index()
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            var dataLast10News = _unitOfWork.newsRepo.GetLastNews(true,10,currentLanguage.Name);
            var dataLast4Papers =_unitOfWork.paperRepo.GetPapers(true,8,currentLanguage.Name);
            var dataLast4Company = _unitOfWork.companyRepo.Last4Company(true, 4, currentLanguage.Name);
            var dataTop4Photo = _unitOfWork.photoRepo.GetPhotos(true,4,currentLanguage.Name);
            var dataTopPhoto = _unitOfWork.photoRepo.GetAll().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            var dataTop10Video = _unitOfWork.videoRepo.GetVideos(true,10,currentLanguage.Name).Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
           
          

            var dataLast4WorldNews = _unitOfWork.newsRepo.GetWorldNews(true,4,currentLanguage.Name);
            var dataLast10WorldNews = _unitOfWork.newsRepo.GetWorldNews(true,10,currentLanguage.Name);
            var dataLast4ArabicNews = _unitOfWork.newsRepo.GetArabicNews(true,4, currentLanguage.Name);
            var dataLast10ArabicNews = _unitOfWork.newsRepo.GetArabicNews(true,10, currentLanguage.Name);
            var dataLast2SportsNews = _unitOfWork.newsRepo.GetSportsNews(true,2,currentLanguage.Name);
            var dataLast4Studies = _unitOfWork.studiesRepo.GetStudies(true,10,currentLanguage.Name);

            var homeViewModel = new HomeViewModel
            {
                Last4WorldNews = dataLast4WorldNews,
                Last4ArabicNews = dataLast4ArabicNews,
                Last2SportsNews = dataLast2SportsNews,
                Last10News = dataLast10News,
                Last4Papers = dataLast4Papers,
                Last4Company = dataLast4Company,
                Top4Photo = dataTop4Photo,
                TopPhoto = dataTopPhoto,
                GetLast8Videos = dataTop10Video,
                Last10WorldNews = dataLast10WorldNews,
                Last10ArabicNews = dataLast10ArabicNews,
                GetLast4Studies = dataLast4Studies,


            };

            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");

            return View(homeViewModel);
        }
        

        public IActionResult Search()
        {
            var form = HttpContext.Request.Form;

            var PostTypeCheackBoxResult = form["cheak[]"];
            var searchnewsform = form["search"];
            var categoryidsselect = form["categoryids"];
            var dateTime = form["MadeDate"];

            SearchViewModel SearchDataModle = new SearchViewModel();

            var currentLanguage = CultureInfo.CurrentCulture;


            if (!String.IsNullOrEmpty(dateTime))
            {

                IFormatProvider formatProvider = null;
                switch(currentLanguage.Name.ToLower())
                {
                    case "fa-ir":
                        formatProvider = new CultureInfo("fa-IR").DateTimeFormat;
                        break;
                    case "ar-sa":
                        formatProvider = new CultureInfo("ar-SA").DateTimeFormat;
                        break;
                    case "en-uk":
                        formatProvider = new CultureInfo("en-UK").DateTimeFormat;
                        break;

                }

                

                if(categoryidsselect == "---" && PostTypeCheackBoxResult.Count() < 1)
                {
                    DateTime date = DateTime.ParseExact(dateTime, @"yyyy-MM-dd",
                    CultureInfo.InvariantCulture);

                    if (searchnewsform.Any(x => x.Count() >  1))
                    {
                        var newsByContentDate = _unitOfWork.newsRepo.Find(
                          x=>
                          x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                          x.SiteLanguage.LangTitle == currentLanguage.Name &&
                          x.Title.Contains(searchnewsform) ||
                          x.FirstDescription.Contains(searchnewsform) ||
                          x.SecondDescription.Contains(searchnewsform) ||
                          x.NewsTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                          x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();

                          SearchDataModle.newsSearchData = newsByContentDate;

                        var paperByContentDate = _unitOfWork.paperRepo.Find(
                          x =>
                          x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                          x.SiteLanguage.LangTitle == currentLanguage.Name &&
                          x.Title.Contains(searchnewsform) ||
                          x.Description.Contains(searchnewsform) ||
                          x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();

                        SearchDataModle.paperSearchData = paperByContentDate;

                        var photoByContentDate = _unitOfWork.photoRepo.Find(
                          x =>
                          x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                          x.SiteLanguage.LangTitle == currentLanguage.Name &&
                          x.Title.Contains(searchnewsform) ||
                          x.Description.Contains(searchnewsform) ||
                          x.PhotoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                          x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();

                        SearchDataModle.photoSearchData = photoByContentDate;

                        var videoByContentDate = _unitOfWork.videoRepo.Find(
                          x =>
                          x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                          x.SiteLanguage.LangTitle == currentLanguage.Name &&
                          x.Title.Contains(searchnewsform) ||
                          x.Description.Contains(searchnewsform) ||
                          x.VideoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                          x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();

                        SearchDataModle.videoSearchData = videoByContentDate;

                        var audioByContentDate = _unitOfWork.audioRepo.Find(
                          x =>
                          x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                          x.SiteLanguage.LangTitle == currentLanguage.Name &&
                          x.Title.Contains(searchnewsform) ||
                          x.Description.Contains(searchnewsform) ||
                          x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();

                        SearchDataModle.audioSearchData = audioByContentDate;
                    }
                    else
                    {
                        var newsDate = _unitOfWork.newsRepo.Find(
                            x =>
                            x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                            x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                            SearchDataModle.newsSearchData = newsDate;

                        var paperDate = _unitOfWork.paperRepo.Find(
                           x =>
                           x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                           x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                        SearchDataModle.paperSearchData = paperDate;

                        var photoDate = _unitOfWork.photoRepo.Find(
                           x =>
                           x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                           x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                           SearchDataModle.photoSearchData = photoDate;

                        var videoDate = _unitOfWork.videoRepo.Find(
                           x =>
                           x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                           x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                        SearchDataModle.videoSearchData = videoDate;

                        var audioDate = _unitOfWork.audioRepo.Find(
                          x =>
                          x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                          x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                        SearchDataModle.audioSearchData = audioDate;

                    }

                }
                        
                 

            }

            if (categoryidsselect !="---") 
            {
                
                if (dateTime.Any(x => x.Count() > 0))
                {
                    DateTime date = DateTime.ParseExact(dateTime, @"yyyy-MM-dd",
                    CultureInfo.InvariantCulture);
                    if (searchnewsform.Any(x => x.Count() < 1))
                    {

                        var newsbydatefilter = _unitOfWork.newsRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name
                        ).OrderByDescending(x => x.UpdatedDate)
                        .Where(x => x.CategoryId.ToString() == categoryidsselect);
                        SearchDataModle.newsSearchData = newsbydatefilter;

                        var paperbyfilter = _unitOfWork.paperRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name
                        ).OrderByDescending(x => x.UpdatedDate)
                        .Where(x => x.CategoryId.ToString() == categoryidsselect);
                        SearchDataModle.paperSearchData = paperbyfilter;
                    }

                    else
                    {

                        var newsbycontentfilter = _unitOfWork.newsRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.FirstDescription.Contains(searchnewsform) ||
                        x.NewsTag.Any(x => x.Tag.Name.Contains(searchnewsform))
                        ).OrderByDescending(x => x.UpdatedDate)
                        .Where(x => x.CategoryId.ToString() == categoryidsselect);
                        SearchDataModle.newsSearchData = newsbycontentfilter;


                        var paperssbycontentfilter = _unitOfWork.paperRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.Description.Contains(searchnewsform)
                        ).OrderByDescending(x => x.UpdatedDate)
                        .Where(x => x.CategoryId.ToString() == categoryidsselect);
                        SearchDataModle.paperSearchData = paperssbycontentfilter;
                    }
                }
                else
                {
                    if (searchnewsform.Any(x => x.Count() > 1))
                    {

                        var newsbycontentfilter = _unitOfWork.newsRepo.Find(
                        x =>
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.FirstDescription.Contains(searchnewsform) ||
                        x.NewsTag.Any(x => x.Tag.Name.Contains(searchnewsform))
                        ).OrderByDescending(x => x.UpdatedDate)
                        .Where(x => x.CategoryId.ToString() == categoryidsselect);
                        SearchDataModle.newsSearchData = newsbycontentfilter;


                        var paperssbycontentfilter = _unitOfWork.paperRepo.Find(
                        x =>
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.Description.Contains(searchnewsform)
                        ).OrderByDescending(x => x.UpdatedDate)
                        .Where(x => x.CategoryId.ToString() == categoryidsselect);
                        SearchDataModle.paperSearchData = paperssbycontentfilter;
                    }

                    
                }
                   
            }    

            if (PostTypeCheackBoxResult.Any(val => val == "photos"))
            {
    
                if(dateTime.Any(x=>x.Count() > 0))
                {
                    DateTime date = DateTime.ParseExact(dateTime, @"yyyy-MM-dd",
                   CultureInfo.InvariantCulture);
                    if (searchnewsform.Any(x => x.Count() < 1))
                    {
                        var photoDate = _unitOfWork.photoRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                        SearchDataModle.photoSearchData = photoDate;
                    }
                    else
                    {
                        var dataContentphoto = _unitOfWork.photoRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.Description.Contains(searchnewsform) ||
                        x.PhotoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                        x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();
                        SearchDataModle.photoSearchData = dataContentphoto;
                    }
                }

                if (searchnewsform.Any(x => x.Count() > 1))
                {
                    var dataphoto = _unitOfWork.photoRepo.Find(
                  x =>
                  x.Title.Contains(searchnewsform) ||
                  x.Description.Contains(searchnewsform) ||
                  x.PhotoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                  x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();
                    SearchDataModle.photoSearchData = dataphoto;
                }
                //else
                //{
                //    var dataPhoto = _unitOfWork.photoRepo.GetPhotos(true, null, currentLanguage.Name);
                //    SearchDataModle.photoSearchData = dataPhoto;
                //}


            }
            if (PostTypeCheackBoxResult.Any(val => val == "videos"))
            {
                if (dateTime.Any(x => x.Count() > 0))
                {
                    DateTime date = DateTime.ParseExact(dateTime, @"yyyy-MM-dd",
                   CultureInfo.InvariantCulture);
                    if (searchnewsform.Any(x => x.Count() < 1))
                    {
                        var videoDate = _unitOfWork.videoRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                        SearchDataModle.videoSearchData = videoDate;
                    }
                    else
                    {
                        var dataContentvideo = _unitOfWork.videoRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.Description.Contains(searchnewsform) ||
                        x.VideoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                        x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();
                        SearchDataModle.videoSearchData = dataContentvideo;
                    }
                }

                if (searchnewsform.Any(x => x.Count() > 1))
                {
                    var datavideo = _unitOfWork.videoRepo.Find(
                  x =>
                  x.Title.Contains(searchnewsform) ||
                  x.Description.Contains(searchnewsform) ||
                  x.VideoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                  x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();
                    SearchDataModle.videoSearchData = datavideo;
                }
                //else
                //{
                //    var dataVideo = _unitOfWork.videoRepo.GetVideos(true, null, currentLanguage.Name);
                //    SearchDataModle.videoSearchData = dataVideo;
                //}


            }
            if (PostTypeCheackBoxResult.Any(val => val == "audios"))
            {

                if (dateTime.Any(x => x.Count() > 0))
                {
                    DateTime date = DateTime.ParseExact(dateTime, @"yyyy-MM-dd",
                   CultureInfo.InvariantCulture);
                    if (searchnewsform.Any(x => x.Count() < 1))
                    {
                        var audioDate = _unitOfWork.audioRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name).AsQueryable();
                        SearchDataModle.audioSearchData = audioDate;
                    }
                    else
                    {
                        var dataContentaudio = _unitOfWork.audioRepo.Find(
                        x =>
                        x.UpdatedDate >= date && x.UpdatedDate < date.AddHours(24) &&
                        x.SiteLanguage.LangTitle == currentLanguage.Name &&
                        x.Title.Contains(searchnewsform) ||
                        x.Description.Contains(searchnewsform) ||
                        x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();
                        SearchDataModle.audioSearchData = dataContentaudio;
                    }
                }

                if (searchnewsform.Any(x => x.Count() > 1))
                {
                    var dataaudio = _unitOfWork.audioRepo.Find(
                  x =>
                  x.Title.Contains(searchnewsform) ||
                  x.Description.Contains(searchnewsform) ||
                  x.SiteLanguage.LangTitle.Contains(searchnewsform)).AsQueryable();
                    SearchDataModle.audioSearchData = dataaudio;
                }
                //else
                //{
                //    var dataAudio = _unitOfWork.audioRepo.GetAudios(true, null, currentLanguage.Name);
                //    SearchDataModle.audioSearchData = dataAudio;
                //}


            }


            if (categoryidsselect.Any(x => x.Contains("---") && PostTypeCheackBoxResult.Count() < 1))
            {
                if (searchnewsform.Any(x => x.Count() > 0)) 
                {
                    var newsData = _unitOfWork.newsRepo.Find(
                      x =>

                      x.Title.Contains(searchnewsform) ||
                      x.FirstDescription.Contains(searchnewsform) ||
                      x.SecondDescription.Contains(searchnewsform) ||
                      x.NewsTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                      x.SiteLanguage.LangTitle.Contains(searchnewsform)

                      ).AsQueryable();

                    SearchDataModle.newsSearchData = newsData;


                    var paperData = _unitOfWork.paperRepo.Find(
                    x =>
                    x.Title.Contains(searchnewsform) ||
                    x.Description.Contains(searchnewsform) ||
                    x.SiteLanguage.LangTitle.Contains(searchnewsform)
                    ).AsQueryable();


                    SearchDataModle.paperSearchData = paperData;


                    var photoData = _unitOfWork.photoRepo.Find(
                    x =>
                    x.Title.Contains(searchnewsform) ||
                    x.Description.Contains(searchnewsform) ||
                    x.PhotoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                    x.SiteLanguage.LangTitle.Contains(searchnewsform)
                    ).AsQueryable();


                    SearchDataModle.photoSearchData = photoData;



                    var videoData = _unitOfWork.videoRepo.Find(
                    x =>
                    x.Title.Contains(searchnewsform) ||
                    x.Description.Contains(searchnewsform) ||
                    x.VideoTag.Any(x => x.Tag.Name.Contains(searchnewsform)) ||
                    x.SiteLanguage.LangTitle.Contains(searchnewsform)
                    ).AsQueryable();


                    SearchDataModle.videoSearchData = videoData;


                    var audioData = _unitOfWork.audioRepo.Find(
                    x =>
                    x.Title.Contains(searchnewsform) ||
                    x.Description.Contains(searchnewsform) ||
                    x.SiteLanguage.LangTitle.Contains(searchnewsform)
                    ).AsQueryable();


                    SearchDataModle.audioSearchData = audioData;
                }
               

            }


            ViewBag.SearchDate = dateTime;
            ViewBag.SearchContent = searchnewsform;
            ViewBag.SearchResult = SearchDataModle;
            ViewBag.ShareURL = Configuration.GetSection("AppConst").GetValue<string>("ShareLink");
            ViewBag.AdminURL = Configuration.GetSection("AppConst").GetValue<string>("AdminWebsiteURL");
            return View(SearchDataModle);
            

        }

        public ContentResult CurrentTime()
        {
            return Content(DateTime.Now.ToString("dddd d MMMM yyyy"));
        }
       
        public PartialViewResult CategorySearch()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataCategory = _unitOfWork.catageryRepo.GetAll().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            return PartialView(dataCategory);
        }


        public PartialViewResult MoveText()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var dataMoveText = _unitOfWork.movetextRepo.GetMoveText(true, 8, currentLanguage.Name).ToList();
            return PartialView(dataMoveText);
        }

        public PartialViewResult Social()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var datasocial = _unitOfWork.socialManagmentRepo.Get(x => x.Id == 10);
            return PartialView(datasocial);
        }
        public PartialViewResult Socialmd()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var datasocial = _unitOfWork.socialManagmentRepo.Get(x => x.Id == 10);
            return PartialView(datasocial);
        }
        public PartialViewResult Socialfooter()
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var datasocial = _unitOfWork.socialManagmentRepo.Get(x => x.Id == 10);
            return PartialView(datasocial);
        }
        public PartialViewResult LanguageData()
        {
            var languageList = _unitOfWork.langRepo.GetAll().ToList();
            return PartialView(languageList);
        }
        public PartialViewResult LanguageDataRes()
        {
            var languageList = _unitOfWork.langRepo.GetAll().ToList();
            return PartialView(languageList);
        }

        public IActionResult SetLanguage(string id)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(id)),
                new CookieOptions()
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                }


                );

            return RedirectToAction(nameof(Index));
        }
    }
}
