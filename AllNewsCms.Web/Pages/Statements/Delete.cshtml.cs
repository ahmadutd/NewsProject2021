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

namespace AllNewsCms.Web.Pages.Statements
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Statements Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Statement Statements { get; set; }
        public void OnGet(int?id)
        {
            if (id != null)
            {
                var statementId = Convert.ToInt32(id);
                var fechstatementfromDb = this.Statements = _unitofwork.statementRepo.Get(x => x.Id == statementId);
                if (fechstatementfromDb != null)
                    this.Statements = fechstatementfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (Statements != null)
                {
                    var statementfectFromDb = _unitofwork.statementRepo.Get(x => x.Id == Statements.Id);
                    if (statementfectFromDb != null)
                        _unitofwork.statementRepo.Delete(statementfectFromDb);
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