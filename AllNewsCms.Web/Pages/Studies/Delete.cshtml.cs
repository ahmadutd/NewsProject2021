using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.Studies
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Studies Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
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
        public IActionResult OnPost()
        {
            try
            {
                if (Studies != null)
                {
                    var studiesfectFromDb = _unitofwork.studiesRepo.Get(x => x.Id == Studies.Id);
                    if (studiesfectFromDb != null)
                        _unitofwork.studiesRepo.Delete(studiesfectFromDb);
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