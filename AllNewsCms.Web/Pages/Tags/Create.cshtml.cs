using System;
using System.Collections.Generic;
using System.Globalization;
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
    [SecurePage("Tags Page Create")]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public CreateModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Tag Tags { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var tagId = Convert.ToInt32(id);
                var fechtagfromDb = this.Tags = _unitofwork.tagRepo.Get(x => x.Id == tagId);
                if (fechtagfromDb != null)
                    this.Tags = fechtagfromDb;
            }
        }
        public IActionResult OnPost()
        {
            if (Tags.Id == 0)
            {
                var PageCulture = CultureInfo.CurrentCulture;
                Tags.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == PageCulture.Name).Id;
                _unitofwork.tagRepo.Add(Tags);
            }
            else
            {
                var tagForDb = _unitofwork.tagRepo.Get(x => x.Id == Tags.Id);
                tagForDb.Name = Tags.Name;
                _unitofwork.tagRepo.Update(tagForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}