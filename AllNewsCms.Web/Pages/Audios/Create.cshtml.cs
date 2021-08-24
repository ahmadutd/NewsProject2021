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

namespace AllNewsCms.Web.Pages.Audios
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Audios Page Create.")]
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
        public Audio Audios { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var audioId = Convert.ToInt32(id);
                var fechaudiofromDb = this.Audios = _unitofwork.audioRepo.Get(x => x.Id == audioId);
                if (fechaudiofromDb != null)
                    this.Audios = fechaudiofromDb;
            }
        }
        public async Task<IActionResult> OnPost()
        {
            if (Audios.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Audios.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                Audios.CreatedBy = Audios.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.audioRepo.Add(Audios);
                var file = Audios.File;
                if (file != null)
                {
                    var ext = Path.GetExtension(file.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Audios\\Voices\\{fileName}";

                    Audios.AudioCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Audios.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                var Imgfile = Audios.ImageFile;
                if (Imgfile != null)
                {
                    var ext = Path.GetExtension(Imgfile.FileName);

                    var fileName = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Audios\\Images\\{fileName}";

                    Audios.ImageCoverPath = fileName;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Audios.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }



            }
            else
            {
                var audioForDb = _unitofwork.audioRepo.Get(x => x.Id == Audios.Id);
                audioForDb.Title = Audios.Title;
                audioForDb.Description = Audios.Description;              
                audioForDb.Image = Audios.Image;
                audioForDb.UpdatedDate = Audios.UpdatedDate;
                audioForDb.File = Audios.File;
                if (audioForDb.File != null)
                {
                    var ext = Path.GetExtension(audioForDb.File.FileName);

                    audioForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Audios\\Voices\\{audioForDb.ImageCoverPath}";

                    Audios.ImageCoverPath = audioForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Audios.File.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }
                audioForDb.ImageFile = Audios.ImageFile;
                if (audioForDb.ImageFile != null)
                {
                    var ext = Path.GetExtension(audioForDb.ImageFile.FileName);

                    audioForDb.ImageCoverPath = Guid.NewGuid().ToString("N").Substring(0, 10) + ext;

                    var filePath = $"{_environment.WebRootPath}\\Upload\\Audios\\Images\\{audioForDb.ImageCoverPath}";

                    Audios.ImageCoverPath = audioForDb.ImageCoverPath;

                    if (_unitofwork.Commit() > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Audios.ImageFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                            System.IO.File.WriteAllBytes(filePath, memoryStream.ToArray());

                        }
                    }

                }


                audioForDb.UpdatedBy = Audios.UpdatedBy = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                _unitofwork.audioRepo.Update(audioForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}