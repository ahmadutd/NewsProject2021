using System;
using System.Collections.Generic;
using System.Globalization;
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
    [SecurePage("MoveText Page Create")]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public CreateModel(IUnitOfWork unitofwork)
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
            if (MoveText.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                MoveText.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                _unitofwork.movetextRepo.Add(MoveText);
            }
            else
            {
                var movetextForDb = _unitofwork.movetextRepo.Get(x => x.Id == MoveText.Id);
                movetextForDb.Text = MoveText.Text;
                movetextForDb.Title = MoveText.Title;

                _unitofwork.movetextRepo.Update(movetextForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}