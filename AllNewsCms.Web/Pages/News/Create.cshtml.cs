using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain = AllNews.Domain;


namespace AllNewsCms.Web.Pages.News
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("News Page Create")]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _environment;

        public CreateModel(IUnitOfWork unitofwork,UserManager<AppUser> userManager, IHostingEnvironment environment)
        {
            _unitofwork = unitofwork;
            _userManager = userManager;
            _environment = environment;
        }
        [BindProperty]
        public Domain.News News { get; set; }

        public List<SelectListItem> CategoryList = new List<SelectListItem>();
        public void OnGet(int? id)
        {

            var currentLanguage = CultureInfo.CurrentCulture;
            var categorylist = _unitofwork.catageryRepo.GetAllCateNews().Where(x=>x.SiteLanguage.LangTitle== currentLanguage.Name).ToList();
            CategoryList = categorylist.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()

            }).ToList();

            
            if (id != null)
            {
                var newsId = Convert.ToInt32(id);
                var fechnewsfromDb = this.News = _unitofwork.newsRepo.Get(x => x.Id == newsId);
                if (fechnewsfromDb != null)
                    this.News = fechnewsfromDb;
            }
        }



        public async Task<IActionResult> OnPost()
        {
            
           
                if (News.Id == 0)
                {
                      
                    var pageCulture = CultureInfo.CurrentCulture;
                    News.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                    News.CreatedBy = News.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                     _unitofwork.newsRepo.Add(News);

                    var file = News.File;
                    var videofile = News.VideoFile;
                    var videoImg = News.ImgFile;
                    if (file !=null )
                         {
                            var ext = Path.GetExtension(file.FileName);
                       
                            var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;
                        
                            var filePath = $"{_environment.WebRootPath}\\Upload\\News\\Images\\{fileName}";
                        
                             News.ImageCoverPath = fileName;
                                                  
                            if (_unitofwork.Commit() > 0)
                            {
                                using (var memoryStream = new MemoryStream())
                                {
                                    if (file.Length < 3000000)
                                    {
                                        News.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                        System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());
                                    }

                                }
                             }

                         }
                         if(videofile !=null)
                         {
                            var videoext = Path.GetExtension(videofile.FileName);
                            var fileVideoName = Guid.NewGuid().ToString("N").Substring(0, 10) + videoext;
                            var fileVideoPath = $"{_environment.WebRootPath}\\Upload\\News\\Videos\\{fileVideoName}";
                            News.VideoCoverPath = fileVideoName;
                            if (_unitofwork.Commit() > 0)
                            {
                                using (var memoryStream = new MemoryStream())
                                {
                                    if (videofile != null)
                                    {
                                        News.VideoFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                        System.IO.File.WriteAllBytes(fileVideoPath, memoryStream.ToArray());
                                    }
                                }

                            }
                        
                     
                         }
                    if (videoImg != null)
                    {
                        var videoext = Path.GetExtension(videofile.FileName);
                        var fileVideoName = Guid.NewGuid().ToString("N").Substring(0, 10) + videoext;
                        var fileVideoPath = $"{_environment.WebRootPath}\\Upload\\News\\VideoImg\\{fileVideoName}";
                        News.VideoImg = fileVideoName;
                        if (_unitofwork.Commit() > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                if (videofile != null)
                                {
                                    News.ImgFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                    System.IO.File.WriteAllBytes(fileVideoPath, memoryStream.ToArray());
                                }
                            }

                        }


                    }
    
                }
                else
                {

                    var newsForDb = _unitofwork.newsRepo.Get(x => x.Id == News.Id);
                    newsForDb.Title = News.Title;
                    newsForDb.FirstImage = News.FirstImage;
                    newsForDb.FirstDescription = News.FirstDescription;
                    newsForDb.FirstDescriptionFirstParagraph = News.FirstDescriptionFirstParagraph;
                    newsForDb.SecondImage = News.SecondImage;
                    newsForDb.SecondDescription = News.SecondDescription;
                    newsForDb.SecondDescriptionFirstParagraph = News.SecondDescriptionFirstParagraph;

                    newsForDb.Video = News.Video;
                    newsForDb.HotCheack = News.HotCheack;
                    newsForDb.File= News.File;
                    if (newsForDb.File != null)
                    {
                        var ext = Path.GetExtension(newsForDb.File.FileName);

                        newsForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                        var filePath = $"{_environment.WebRootPath}\\Upload\\News\\Images\\{newsForDb.ImageCoverPath}";

                        News.ImageCoverPath = newsForDb.ImageCoverPath;

                        if (_unitofwork.Commit() > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                if (newsForDb.File.Length < 3000000)
                                {
                                    News.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                    System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());
                                }

                            }
                        }

                    }
                    newsForDb.VideoFile= News.VideoFile;
                     if(newsForDb.VideoFile != null)
                     {
                        var videoext = Path.GetExtension(newsForDb.VideoFile.FileName);
                        newsForDb.VideoCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + videoext;
                        var fileVideoPath = $"{_environment.WebRootPath}\\Upload\\News\\Videos\\{newsForDb.VideoCoverPath}";
                        News.VideoCoverPath = newsForDb.VideoCoverPath;
                        if (_unitofwork.Commit() > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                if (newsForDb.VideoFile != null)
                                {
                                    News.VideoFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                    System.IO.File.WriteAllBytes(fileVideoPath, memoryStream.ToArray());
                                }
                            }

                        }
                        
                     
                     }
                    newsForDb.ImgFile = News.ImgFile;
                     if (newsForDb.ImgFile != null)
                     {
                        var ext = Path.GetExtension(newsForDb.ImgFile.FileName);
                        newsForDb.VideoImg = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;
                        var fileVideoPath = $"{_environment.WebRootPath}\\Upload\\News\\VideoImg\\{newsForDb.VideoImg}";
                        News.VideoImg = newsForDb.VideoImg;
                        if (_unitofwork.Commit() > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                if (newsForDb.VideoFile != null)
                                {
                                    News.ImgFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                    System.IO.File.WriteAllBytes(fileVideoPath, memoryStream.ToArray());
                                }
                            }

                        }


                     }

                         newsForDb.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                     if (newsForDb.UpToCheack=News.UpToCheack == true)
                            newsForDb.UpdatedDate = News.UpdatedDate;

                    _unitofwork.newsRepo.Update(newsForDb);
                }
                _unitofwork.Commit();
                _unitofwork.Dispose();
            
            return RedirectToPage("Index");
        }
        
    }
}