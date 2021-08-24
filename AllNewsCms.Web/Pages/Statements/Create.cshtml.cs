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

namespace AllNewsCms.Web.Pages.Statements
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Statements Page Create")]
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
        public Statement Statements { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var statementId = Convert.ToInt32(id);
                var fechstatementfromDb = this.Statements = _unitofwork.statementRepo.Get(x => x.Id == statementId);
                if (fechstatementfromDb != null)
                    this.Statements = fechstatementfromDb;
            }
        }
        public async Task<IActionResult> OnPost()
        {
            if (Statements.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Statements.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Statements.CreatedBy = Statements.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.statementRepo.Add(Statements);
                var file = Statements.ImageFile;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Statements\\{fileName}";

                    Statements.ImageCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Statements.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }

            }
            else
            {
                var statementForDb = _unitofwork.statementRepo.Get(x => x.Id == Statements.Id);
                statementForDb.Title = Statements.Title;
                statementForDb.Description = Statements.Description;
                statementForDb.Image = Statements.Image;
                statementForDb.ImageFile = Statements.ImageFile;
                if (statementForDb.ImageFile != null)
                {
                    var ext = Path.GetExtension(statementForDb.ImageFile.FileName);

                    statementForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Statements\\{statementForDb.ImageCoverPath}";

                    Statements.ImageCoverPath = statementForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Statements.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                statementForDb.UpdatedBy = Statements.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;

                _unitofwork.statementRepo.Update(statementForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}