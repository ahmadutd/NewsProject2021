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


namespace AllNewsCms.Web.Pages.Papers
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Papers Page Create")]
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
        public Paper Papers { get; set; }
        public List<SelectListItem> CategoryPapers = new List<SelectListItem>();
        public void OnGet(int? id)
        {
            var currentLanguage = CultureInfo.CurrentCulture;
            var categorypaperlist = _unitofwork.catageryRepo.GetAllCatePapers().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
            CategoryPapers = categorypaperlist.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()

            }).ToList();


            if (id != null)
            {
                var paperId = Convert.ToInt32(id);
                var fechpaperfromDb = this.Papers = _unitofwork.paperRepo.Get(x => x.Id == paperId);
                if (fechpaperfromDb != null)
                    this.Papers = fechpaperfromDb;
            }

        }
        public async Task<IActionResult> OnPost()
        {
            if (Papers.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Papers.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Papers.CreatedBy = Papers.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.paperRepo.Add(Papers);
                var file = Papers.ImageFile;
                var fileDownload =Papers.DownloadFile ;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Papers\\Images\\{fileName}";

                    Papers.ImageCoverPath = fileName;
                    
                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            if (file.Length < 3000000)
                            {
                                Papers.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());
                            }

                        }
                    }

                }
                if (fileDownload != null)
                {
                    var ext = Path.GetExtension(fileDownload.FileName);
                    var fileDlLink = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;
                    var fileDlPath = $"{_environment.WebRootPath}\\Upload\\Papers\\Downloads\\{fileDlLink}";
                    Papers.Download = fileDlLink;
                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            
                            Papers.DownloadFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(fileDlPath, memoryStream.ToArray());
                            
                        }

                    }


                }

            }
            else
            {
                var paperForDb = _unitofwork.paperRepo.Get(x => x.Id == Papers.Id);
                paperForDb.Title = Papers.Title;
                paperForDb.Description = Papers.Description;
                paperForDb.Image = Papers.Image;
                paperForDb.ImageFile = Papers.ImageFile;
                if (paperForDb.ImageFile != null)
                {
                    var ext = Path.GetExtension(paperForDb.ImageFile.FileName);

                    paperForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Papers\\Images\\{paperForDb.ImageCoverPath}";

                    Papers.ImageCoverPath = paperForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            if (paperForDb.ImageFile.Length < 3000000)
                            {
                                Papers.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                                System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());
                            }

                        }
                    }

                }
                paperForDb.DownloadFile = Papers.DownloadFile;
                if (paperForDb.DownloadFile != null)
                {
                    var videoext = Path.GetExtension(paperForDb.DownloadFile.FileName);
                    paperForDb.Download = Guid.NewGuid().ToString("N").Substring(0, 10) + videoext;
                    var fileVideoPath = $"{_environment.WebRootPath}\\Upload\\Papers\\Downloads\\{paperForDb.Download}";
                    Papers.Download = paperForDb.Download;
                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            
                            
                            Papers.DownloadFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(fileVideoPath, memoryStream.ToArray());
                            
                        }

                    }


                }

                paperForDb.UpdatedBy = Papers.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.paperRepo.Update(paperForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}