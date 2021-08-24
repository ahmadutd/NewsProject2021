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

namespace AllNewsCms.Web.Pages.Papers
{

    [Authorize(Permissions.NicePermission)]
    [SecurePage("Papers Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Paper Papers { get; set; }
        public void OnGet(int?id)
        {
            if (id != null)
            {
                var paperId = Convert.ToInt32(id);
                var fechpaperfromDb = this.Papers = _unitofwork.paperRepo.Get(x => x.Id == paperId);
                if (fechpaperfromDb != null)
                    this.Papers = fechpaperfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (Papers != null)
                {
                    var paperfectFromDb = _unitofwork.paperRepo.Get(x => x.Id == Papers.Id);
                    if (paperfectFromDb != null)
                        _unitofwork.paperRepo.Delete(paperfectFromDb);
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