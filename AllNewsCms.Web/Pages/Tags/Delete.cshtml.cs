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

namespace AllNewsCms.Web.Pages.Tags
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Tags Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Tag Tags { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var tagsId = Convert.ToInt32(id);
                var fechtagsfromDb = this.Tags = _unitofwork.tagRepo.Get(x => x.Id == tagsId);
                if (fechtagsfromDb != null)
                    this.Tags = fechtagsfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (Tags != null)
                {
                    var tagsfectFromDb = _unitofwork.tagRepo.Get(x => x.Id == Tags.Id);
                    if (tagsfectFromDb != null)
                        _unitofwork.tagRepo.Delete(tagsfectFromDb);
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