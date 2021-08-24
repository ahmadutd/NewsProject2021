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

namespace AllNewsCms.Web.Pages.Videos
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Videos Page Create")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Video Videos { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var videosId = Convert.ToInt32(id);
                var fechvideosfromDb = this.Videos = _unitofwork.videoRepo.Get(x => x.Id == videosId);
                if (fechvideosfromDb != null)
                    this.Videos = fechvideosfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (Videos != null)
                {
                    var videosfectFromDb = _unitofwork.videoRepo.Get(x => x.Id == Videos.Id);
                    if (videosfectFromDb != null)
                        _unitofwork.videoRepo.Delete(videosfectFromDb);
                    _unitofwork.Commit();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToPage("Index");

        }
}   }