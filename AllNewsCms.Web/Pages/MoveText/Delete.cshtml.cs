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

namespace AllNewsCms.Web.Pages.MoveText
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("MoveText Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Domain.MoveText MoveText { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var movetextId = Convert.ToInt32(id);
                var fechmovetextfromDb = this.MoveText = _unitofwork.movetextRepo.Get(x => x.Id == movetextId);
                if (fechmovetextfromDb != null)
                    this.MoveText = fechmovetextfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (MoveText != null)
                {
                    var movetextfectFromDb = _unitofwork.movetextRepo.Get(x => x.Id == MoveText.Id);
                    if (movetextfectFromDb != null)
                        _unitofwork.movetextRepo.Delete(movetextfectFromDb);
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