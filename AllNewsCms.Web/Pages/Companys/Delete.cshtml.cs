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

namespace AllNewsCms.Web.Pages.Companys
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Organisations Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
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
        public IActionResult OnPost()
        {
            try
            {
                if (Companys != null)
                {
                    var companyfectFromDb = _unitofwork.companyRepo.Get(x => x.Id == Companys.Id);
                    if (companyfectFromDb != null)
                        _unitofwork.companyRepo.Delete(companyfectFromDb);
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