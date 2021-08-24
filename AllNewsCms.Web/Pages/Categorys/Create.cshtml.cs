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

namespace AllNewsCms.Web.Pages.Categorys
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Categorys Page Create")]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public CreateModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Category Categorys { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var categoryId = Convert.ToInt32(id);
                var fechcategoryfromDb = this.Categorys = _unitofwork.catageryRepo.Get(x => x.Id == categoryId);
                if (fechcategoryfromDb != null)
                    this.Categorys = fechcategoryfromDb;
            }
        }
        public IActionResult OnPost()
        {
            if (Categorys.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Categorys.LangId = _unitofwork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                _unitofwork.catageryRepo.Add(Categorys);
            }
            else
            {
                var categoryForDb = _unitofwork.catageryRepo.Get(x => x.Id == Categorys.Id);
                categoryForDb.CategoryName = Categorys.CategoryName;
                _unitofwork.catageryRepo.Update(categoryForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}