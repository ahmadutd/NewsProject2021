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

namespace AllNewsCms.Web.Pages.Photos
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Photos Page Create")]
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
        public Photo Photos { get; set; }
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
                var photoId = Convert.ToInt32(id);
                var fechphotofromDb = this.Photos = _unitofwork.photoRepo.Get(x => x.Id == photoId);
                if (fechphotofromDb != null)
                    this.Photos = fechphotofromDb;
            }
        }
        public async Task<IActionResult> OnPost()
        {
            if (Photos.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Photos.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Photos.CreatedBy = Photos.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.photoRepo.Add(Photos);
                var file = Photos.ImageFile;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Photos\\{fileName}";

                    Photos.ImageCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Photos.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }


            }
            else
            {
                var photoForDb = _unitofwork.photoRepo.Get(x => x.Id == Photos.Id);
                photoForDb.Title = Photos.Title;
                photoForDb.Description = Photos.Description;
                photoForDb.Image = Photos.Image;
                photoForDb.ImageFile = Photos.ImageFile;
                if (photoForDb.ImageFile != null)
                {
                    var ext = Path.GetExtension(photoForDb.ImageFile.FileName);

                    photoForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Photos\\{photoForDb.ImageCoverPath}";

                    Photos.ImageCoverPath = photoForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Photos.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                photoForDb.UpdatedBy = Photos.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.photoRepo.Update(photoForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}