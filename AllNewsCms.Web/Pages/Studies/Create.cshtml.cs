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
using Domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.Studies
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Studies Page Create")]
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
        public Domain.Studies Studies { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var studieId = Convert.ToInt32(id);
                var fechstudiesfromDb = this.Studies = _unitofwork.studiesRepo.Get(x => x.Id == studieId);
                if (fechstudiesfromDb != null)
                    this.Studies = fechstudiesfromDb;
            }
        }
        public async Task<IActionResult> OnPost()
        {
            if (Studies.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Studies.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Studies.CreatedBy = Studies.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.studiesRepo.Add(Studies);

                var file = Studies.ImageFile;
                var fileDownload = Studies.DownloadFile;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Studies\\Images\\{fileName}";

                    Studies.ImageCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Studies.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                if (fileDownload != null)
                {
                    var ext = Path.GetExtension(fileDownload.FileName);
                    var fileDlLink = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;
                    var fileDlPath = $"{_environment.WebRootPath}\\Upload\\Studies\\Downloads\\{fileDlLink}";
                    Studies.DownloadLink = fileDlLink;
                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {

                            Studies.DownloadFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(fileDlPath, memoryStream.ToArray());

                        }

                    }


                }
            }
            else
            {
                var studiesForDb = _unitofwork.studiesRepo.Get(x => x.Id == Studies.Id);
                studiesForDb.Title = Studies.Title;
                studiesForDb.Description = Studies.Description;
                studiesForDb.Image = Studies.Image;
                studiesForDb.DownloadLink = Studies.DownloadLink;
                studiesForDb.ImageFile = Studies.ImageFile;
                if (studiesForDb.ImageFile != null)
                {
                    var ext = Path.GetExtension(studiesForDb.ImageFile.FileName);

                    studiesForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Studies\\Images\\{studiesForDb.ImageCoverPath}";

                    Studies.ImageCoverPath = studiesForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Studies.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                studiesForDb.DownloadFile = Studies.DownloadFile;
                if (studiesForDb.DownloadFile != null)
                {
                    var ext = Path.GetExtension(studiesForDb.DownloadFile.FileName);
                    studiesForDb.DownloadLink = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;
                    var fileVideoPath = $"{_environment.WebRootPath}\\Upload\\Studies\\Downloads\\{studiesForDb.DownloadLink}";
                    Studies.DownloadLink = studiesForDb.DownloadLink;
                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {


                            Studies.DownloadFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(fileVideoPath, memoryStream.ToArray());

                        }

                    }


                }
                studiesForDb.UpdatedBy = Studies.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.studiesRepo.Update(studiesForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}