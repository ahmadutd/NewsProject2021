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

namespace AllNewsCms.Web.Pages.Companys
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Organisations Page Create")]
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
        public Company Companys { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var companyId = Convert.ToInt32(id);
                var fechcompanyfromDb = this.Companys = _unitofwork.companyRepo.Get(x => x.Id == companyId);
                if (fechcompanyfromDb != null)
                    this.Companys = fechcompanyfromDb;
            }

        }
        public async Task<IActionResult> OnPost()
        {
            if (Companys.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Companys.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Companys.CreatedBy = Companys.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.companyRepo.Add(Companys);
                var file = Companys.File;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Organisation\\{fileName}";

                    Companys.ImageCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Companys.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
            }
            else
            {
                var companyForDb = _unitofwork.companyRepo.Get(x => x.Id == Companys.Id);
                companyForDb.Title = Companys.Title;
                companyForDb.Information = Companys.Information;
                companyForDb.Image = Companys.Image;

                companyForDb.File = Companys.File;
                if (companyForDb.File != null)
                {
                    var ext = Path.GetExtension(companyForDb.File.FileName);

                    companyForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Organisation\\{companyForDb.ImageCoverPath}";

                    Companys.ImageCoverPath = companyForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Companys.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                companyForDb.UpdatedBy = Companys.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.companyRepo.Update(companyForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}