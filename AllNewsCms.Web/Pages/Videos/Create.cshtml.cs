using System;
using System.Collections.Generic;
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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AllNewsCms.Web.Pages.Videos
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Videos Page Create")]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _environment;

        public CreateModel(IUnitOfWork unitofwork, UserManager<AppUser> userManager, IHostingEnvironment environment)
        {
            _unitofwork = unitofwork;
            _userManager = userManager;
            _environment = environment;
        }
        [BindProperty]
        public Video Videos { get; set; }
        public List<SelectListItem> CategoryList = new List<SelectListItem>();
        public void OnGet(int? id)
        {
            var categorylist = _unitofwork.catageryRepo.GetAll().ToList();
            CategoryList = categorylist.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()

            }).ToList();

            if (id != null)
            {
                var videoId = Convert.ToInt32(id);
                var fechvideofromDb = this.Videos = _unitofwork.videoRepo.Get(x => x.Id == videoId);
                if (fechvideofromDb != null)
                    this.Videos = fechvideofromDb;
            }

        }
        public async Task<IActionResult> OnPost()
        {
            if (Videos.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Videos.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Videos.CreatedBy = Videos.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.videoRepo.Add(Videos);
                var file = Videos.File;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Videos\\Media\\{fileName}";

                    Videos.VideoCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Videos.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                var imgfile = Videos.ImgFile;
                if (imgfile != null)
                {
                    var ext = Path.GetExtension(imgfile.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Videos\\Img\\{fileName}";

                    Videos.VideoImage = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Videos.ImgFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
            }
            else
            {
                var videoForDb = _unitofwork.videoRepo.Get(x => x.Id == Videos.Id);
                videoForDb.Title = Videos.Title;
                videoForDb.Description = Videos.Description;
                videoForDb.VideoPlay = Videos.VideoPlay;
                videoForDb.VideoImage = Videos.VideoImage;
                videoForDb.File = Videos.File;
                if (videoForDb.File != null)
                {
                    var ext = Path.GetExtension(videoForDb.File.FileName);

                    videoForDb.VideoCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Videos\\Media\\{videoForDb.VideoCoverPath}";

                    Videos.VideoCoverPath = videoForDb.VideoCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Videos.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                videoForDb.ImgFile = Videos.ImgFile;
                if (videoForDb.ImgFile != null)
                {
                    var ext = Path.GetExtension(videoForDb.ImgFile.FileName);

                    videoForDb.VideoImage = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Videos\\Img\\{videoForDb.VideoImage}";

                    Videos.VideoImage = videoForDb.VideoImage;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Videos.ImgFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                videoForDb.UpdatedBy = Videos.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;

                _unitofwork.videoRepo.Update(videoForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}