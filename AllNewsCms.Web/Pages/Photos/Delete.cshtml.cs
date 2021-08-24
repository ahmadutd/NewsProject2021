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

namespace AllNewsCms.Web.Pages.Photos
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Photos Page Delete")]
    public class DeleteModel : PageModel
    {
        

        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Photo Photos { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var photosId = Convert.ToInt32(id);
                var fechphotosfromDb = this.Photos = _unitofwork.photoRepo.Get(x => x.Id == photosId);
                if (fechphotosfromDb != null)
                    this.Photos = fechphotosfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (Photos != null)
                {
                    var photosfectFromDb = _unitofwork.photoRepo.Get(x => x.Id == Photos.Id);
                    if (photosfectFromDb != null)
                        _unitofwork.photoRepo.Delete(photosfectFromDb);
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