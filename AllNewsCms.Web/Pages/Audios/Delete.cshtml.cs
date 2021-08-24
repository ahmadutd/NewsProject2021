using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AllNewsCms.Web.Pages.Audios
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Audios Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Audio Audios { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var audiosId = Convert.ToInt32(id);
                var fechaudiosfromDb = this.Audios = _unitofwork.audioRepo.Get(x => x.Id == audiosId);
                if (fechaudiosfromDb != null)
                    this.Audios = fechaudiosfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (Audios != null)
                {
                    var audiosfectFromDb = _unitofwork.audioRepo.Get(x => x.Id == Audios.Id);
                    if (audiosfectFromDb != null)
                        _unitofwork.audioRepo.Delete(audiosfectFromDb);
                    _unitofwork.Commit();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToPage("Index");

        }
    }
}